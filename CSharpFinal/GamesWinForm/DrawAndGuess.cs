using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;


namespace GameWinForm
{
    public partial class DrawAndGuess : Form
    {
        DrawAndGuessClient client;
        private BindingList<PlayerAndScore> Players { set; get; }
        //玩家信息
        public string Answer { set; get; } = "";
        private bool isMyTurn = false;
        //答对人数。用于在所有人答对时暂停计时器
        private int countCorrect = 0;
        //时间
        private int Time { set; get; } = 60;
        //画画相关的属性
        private Color PenColor { set; get; } = ColorTranslator.FromHtml("#000000");
        private int SelectPenOrEraser { set; get; } = 0;
        private Bitmap Bitmap { set; get; }
        private Point StartPoint { set; get; }
        private int count { set; get; } = 0;//计数当前画了多少线
        private ConcurrentQueue<Line> Lines { set; get; } = new ConcurrentQueue<Line>();
        private bool CanMove { set; get; }

        protected Regex regex = new Regex(@"[^_]+");


        public DrawAndGuess(DrawAndGuessClient c, List<string> players)
        {
            client = c;
            client.StartReceive();

            //初始化玩家和得分列表
            Players = new BindingList<PlayerAndScore>();
            foreach (string player in players)
            {
                Players.Add(new PlayerAndScore(player,0));
            }

            InitializeComponent();

            //数据绑定
            this.textBoxSend.DataBindings.Add("Text", this, "Answer");
            this.uiDataGridViewScore.DataSource = Players;

            //初始化画画相关部件的值
            ColorPicker.Value = ColorTranslator.FromHtml("#000000");
            RadioButtonGroupPen.SelectedIndex = 0;
            CanMove = false;
            Bitmap = new Bitmap(pictureBoxDrawing.Width, pictureBoxDrawing.Height);
            pictureBoxDrawing.Image = Bitmap;

            client.MyTurn = () =>
            {
                isMyTurn = true;
                if (this.uiLabelPainter.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        this.uiLabelPainter.Text = "画家：你";
                        this.labelPoem.Text = client.currentPoem;
                        this.buttonSend.Enabled = false;
                        InitTurn();
                    }));
                }
                else
                {
                    this.uiLabelPainter.Text = "画家：你";
                    this.labelPoem.Text = client.currentPoem;
                    this.buttonSend.Enabled = false;
                    InitTurn();
                }
            };
            client.NotMyTurn = (str) =>
            {
                isMyTurn = false;
                if (this.uiLabelPainter.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        this.uiLabelPainter.Text = "画家：" + str;
                        this.buttonSend.Enabled = true;
                        this.labelPoem.Text = new StringBuilder(client.currentPoem.Length * 2).Insert(0,"_ ", client.currentPoem.Length).ToString();
                        InitTurn();
                    }));
                }
                else
                {
                    this.uiLabelPainter.Text = "画家：" + str;
                    this.buttonSend.Enabled = true;
                    this.labelPoem.Text = new StringBuilder(client.currentPoem.Length * 2).Insert(0, "_ ", client.currentPoem.Length).ToString();
                    InitTurn();
                }
            };
            client.ShowPaint = (str) =>
            {
                MatchCollection matchCollection = regex.Matches(str);
                for (int i = 0; i < 5; i++)
                {
                    DrawImage(ColorTranslator.FromHtml("#"+matchCollection[5 * i].Value),
                        new Point(Int16.Parse(matchCollection[5 * i + 1].Value), Int16.Parse(matchCollection[5 * i + 2].Value)),
                        new Point(Int16.Parse(matchCollection[5 * i + 3].Value), Int16.Parse(matchCollection[5 * i + 4].Value))
                        );
                }
            };
            client.ShowCorrect = () =>
            {
                //自己答对了
                if (this.labelPoem.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        //显示答案并且按钮不可用
                        //答对之后就不让再发言
                        this.labelPoem.Text = client.currentPoem;
                        this.buttonSend.Enabled = false;
                    }));
                }
                else
                {
                    this.labelPoem.Text = client.currentPoem;
                    this.buttonSend.Enabled = false;
                }
            };
            client.ShowMessage = (str) =>
            {
                if (this.textBoxChat.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        this.textBoxChat.Text += str + "\r\n";
                    }));
                }
                else
                {
                    this.textBoxChat.Text += str + "\r\n";
                }
            };
            client.AddScore = (player, score) =>
            {
                Players.FirstOrDefault((e) => e.Name == player).Score += score;
                countCorrect++;

                if (this.uiDataGridViewScore.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        //刷新得分表；如果所有人答对，暂停计时器
                        this.uiDataGridViewScore.Refresh();
                        if (countCorrect >= Players.Count - 1) this.timer.Stop();
                    }));
                }
                else
                {
                    this.uiDataGridViewScore.Refresh();
                    if (countCorrect >= Players.Count - 1) this.timer.Stop();
                }
            };
            client.GameOver = (winner) =>
            {
                if (this.uiLabelWinner.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        this.uiLabelWinner.Text = "赢家："+winner;
                        this.uiLabelWinner.Visible = true;
                    }));
                }
                else
                {
                    this.uiLabelWinner.Text = "赢家：" + winner;
                    this.uiLabelWinner.Visible = true;
                }
            };
        }

        private void DrawImage(Color c, Point sp, Point ep)
        {
            pictureBoxDrawing.Image = Bitmap;
            if (ColorTranslator.ToHtml(c)=="#FFFFFF")
            {
                using (Graphics graphics = Graphics.FromImage(pictureBoxDrawing.Image))
                {
                    graphics.DrawLine(new Pen(Color.White, 8), sp, ep);
                }
            }
            else
            {
                using (Graphics graphics = Graphics.FromImage(pictureBoxDrawing.Image))
                {
                    graphics.DrawLine(new Pen(c, 2), sp, ep);
                }
            }
        }
        private void InitTurn()
        {
            //清空聊天框
            this.textBoxChat.Text = "";
            //重置计时器
            Time = 60;
            this.uiLabelTime.Text = "1:00";
            this.timer.Start();
            //重置答对人数
            countCorrect = 0;
            //清空画板
            Bitmap.Dispose();
            Bitmap = new Bitmap(pictureBoxDrawing.Width, pictureBoxDrawing.Height);
            pictureBoxDrawing.Image = Bitmap;
            //清空Lines，防止残留
            while (count>0)
            {
                Lines.TryDequeue(out Line line);
                count--;
            }
        }

        //事件
        private void buttonSend_Click(object sender, EventArgs e)
        {
            client.SendMessageToServer(Answer);
        }
        private void pictureBoxDrawing_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            CanMove = true;
            StartPoint = new Point(e.X, e.Y);
        }
        private void pictureBoxDrawing_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (!isMyTurn) return;
            if (CanMove == false) return;
            pictureBoxDrawing.Image = Bitmap;
            Point newPoint = new Point(e.X, e.Y);
            using (Graphics graphics = Graphics.FromImage(pictureBoxDrawing.Image))
            {
                if (SelectPenOrEraser == 1)
                {
                    //橡皮
                    graphics.DrawLine(new Pen(Color.White, 8), StartPoint, newPoint);
                    Lines.Enqueue(new Line(Color.FromArgb(255,255,255,255), StartPoint, newPoint));
                }
                else
                {
                    //笔
                    graphics.DrawLine(new Pen(PenColor, 2), StartPoint, newPoint);
                    Lines.Enqueue(new Line(PenColor, StartPoint, newPoint));
                }
                //graphics.DrawImage(Bitmap, pictureBoxDrawing.Location.X, pictureBoxDrawing.Location.Y, pictureBoxDrawing.Width, pictureBoxDrawing.Height);
            }

            StartPoint = newPoint;
            count++;
            //如果到了5，就发送给其他人
            if (count >= 5)
            {
                count -= 5;
                var task1 = new Task(() =>
                {
                    string image = "";
                    int n = 5;
                    while (n-- > 0)
                    {
                        Line line;
                        Lines.TryDequeue(out line);
                        image += ColorTranslator.ToHtml(line.PenColor).Substring(1) + "_" + line.StartPoint.X + "_" + line.StartPoint.Y + "_" + line.EndPoint.X + "_" + line.EndPoint.Y + "_";
                    }
                    client.SendImage(image);
                });
                task1.Start();
            }
        }
        private void pictureBoxDrawing_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
            this.CanMove = false;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Time--;
            if (Time < 10) this.uiLabelTime.Text = "0:0" + Time;
            else this.uiLabelTime.Text = "0:" + Time;
            if (Time <= 0)
            {
                this.timer.Stop();
                //按钮不可用且显示答案
                this.buttonSend.Enabled = false;
                this.labelPoem.Text = client.currentPoem;
            }
        }
        private void ColorChange(object sender, Color color)
        {
            PenColor = color;
        }
        private void PenOrEraser(object sender, int index, string text)
        {
            SelectPenOrEraser = index;
        }

    }
    public class Line
    {
        public Color PenColor { set; get; }
        public Point StartPoint { set; get; }
        public Point EndPoint { set; get; }
        public Line(Color c, Point sp, Point ep)
        {
            PenColor = c;
            StartPoint = sp;
            EndPoint = ep;
        }
    }
    public class PlayerAndScore
    {
        public string Name { set; get; }
        public int Score { set; get; }
        public PlayerAndScore(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
