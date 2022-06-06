using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;

namespace GameWinForm
{
    public partial class FlyFlowerForm : Form
    {
        FlyingFlowerClient client;
        public BindingList<RemainPlayer> PlayersRemain { set; get; }
        public string KeyWord { set; get; } = "月";
        public string Answer { set; get; }
        public int Time { set; get; } = 15;
        public FlyFlowerForm(FlyingFlowerClient c, List<string> players)
        {
            client = c;
            client.StartReceive();

            PlayersRemain = new BindingList<RemainPlayer>();
            foreach(string player in players)
            {
                PlayersRemain.Add(new RemainPlayer(player));
            }

            InitializeComponent();
            //设置界面初始状态
            //按钮只有在自己的回合可以使用
            this.uiButtonSend.Enabled = false;
            //数据绑定
            this.uiTextBoxAnswer.DataBindings.Add("Text", this, "Answer");
            this.uiDataGridViewPlayers.DataSource = PlayersRemain;

            //接收关键字，并且设置游戏背景
            while (client.KeyWord == "") { }
            KeyWord = client.KeyWord;
            setImage();

            //轮到自己
            client.MyTurn = () =>
            {
                //设置作答人，设置按钮可以使用，设置开始计时，设置“对错图片”不可见，清空上一轮的答案
                if (this.uiLabelAnswerPlayer.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        this.uiLabelAnswerPlayer.Text = "作答人：你";
                        this.uiButtonSend.Enabled = true;
                        this.timer.Start();
                        this.pictureBoxAnswer.Enabled = false;
                        this.uiLabelAnswer.Text = "";
                    }));
                }
                else
                {
                    this.uiLabelAnswerPlayer.Text = "作答人：你";
                    this.uiButtonSend.Enabled = true;
                    this.timer.Start();
                    this.pictureBoxAnswer.Enabled = false;
                    this.uiLabelAnswer.Text = "";
                }
            };
            //不是自己的回合
            client.NotMyTurn = (str) =>
            {
                //设置作答人，设置按钮不可使用，设置开始计时，设置“对错图片”不可见，清空上轮答案
                if (this.uiLabelAnswerPlayer.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        this.uiLabelAnswerPlayer.Text = "作答人：" + str;
                        this.uiButtonSend.Enabled = false;
                        this.timer.Start();
                        this.pictureBoxAnswer.Enabled = false;
                        this.uiLabelAnswer.Text = "";
                    }));
                }
                else
                {
                    this.uiLabelAnswerPlayer.Text = "作答人：" + str;
                    this.uiButtonSend.Enabled = false;
                    this.timer.Start();
                    this.pictureBoxAnswer.Enabled = false;
                    this.uiLabelAnswer.Text = "";
                }
            };
            //淘汰str
            client.KnockOutPlayer = (str) =>
            {
                PlayersRemain.Remove(PlayersRemain.FirstOrDefault(Name => Name.Equals(str)));
                this.uiDataGridViewPlayers.Refresh();
                if (PlayersRemain.Count > 1) return;
                //如果剩下的玩家只剩一个：
                if (this.uiLabelAnswer.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        this.uiLabelAnswer.Text = PlayersRemain.FirstOrDefault().Name + " 胜利";
                    }));
                }
                else
                {
                    this.uiLabelAnswer.Text = PlayersRemain.FirstOrDefault().Name + " 胜利";
                }
            };
            //展示回答
            client.ShowAnswer = (str) =>
            {
                Regex regex = new Regex(@"\w+");
                Match match = regex.Match(str);
                match.NextMatch();
                match.NextMatch();
                if (this.uiLabelAnswer.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        this.uiLabelAnswer.Text = match.Value;
                    }));
                }
                else
                {
                    this.uiLabelAnswer.Text = match.Value;
                }
            };
            //回答正确，展示勾的图片
            client.AnswerRight = (str) =>
            {
                if (this.pictureBoxAnswer.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        this.pictureBoxAnswer.Enabled = true;
                        this.pictureBoxAnswer.Image = global::GamesWinForm.Properties.Resources.correct;
                    }));
                }
                else
                {
                    this.pictureBoxAnswer.Enabled = true;
                    this.pictureBoxAnswer.Image = global::GamesWinForm.Properties.Resources.correct;
                }
            };
            //回答错误，展示叉的图片
            client.AnswerWrong = (str) =>
            {
                if (this.pictureBoxAnswer.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        this.pictureBoxAnswer.Enabled = true;
                        this.pictureBoxAnswer.Image = global::GamesWinForm.Properties.Resources.wrong;
                    }));
                }
                else
                {
                    this.pictureBoxAnswer.Enabled = true;
                    this.pictureBoxAnswer.Image = global::GamesWinForm.Properties.Resources.wrong;
                }
            };
        }
        private void setImage()
        {
            switch (KeyWord)
            {
                case "月":
                    this.uiPanelGameWin.BackgroundImage = global::GamesWinForm.Properties.Resources.Moon;
                    this.uiLabelAnswer.ForeColor = Color.White;
                    this.uiLabelAnswerPlayer.ForeColor = Color.White;
                    break;
                case "酒":
                    this.uiPanelGameWin.BackgroundImage = global::GamesWinForm.Properties.Resources.Wine;
                    break;
                case "花":
                    this.uiPanelGameWin.BackgroundImage = global::GamesWinForm.Properties.Resources.Flower;
                    break;
                case "风":
                    this.uiPanelGameWin.BackgroundImage = global::GamesWinForm.Properties.Resources.Wind;
                    break;
                case "春":
                    this.uiPanelGameWin.BackgroundImage = global::GamesWinForm.Properties.Resources.Spring;
                    break;
                case "秋":
                    this.uiPanelGameWin.BackgroundImage = global::GamesWinForm.Properties.Resources.Autumn;
                    break;
                case "冬":
                    this.uiPanelGameWin.BackgroundImage = global::GamesWinForm.Properties.Resources.Winter;
                    this.uiLabelAnswer.ForeColor = Color.Black;
                    this.uiLabelAnswerPlayer.ForeColor= Color.Black;
                    break;
                case "夜":
                    this.uiPanelGameWin.BackgroundImage = global::GamesWinForm.Properties.Resources.Night;
                    this.uiLabelAnswer.ForeColor = Color.White;
                    this.uiLabelAnswerPlayer.ForeColor = Color.White;
                    break;
                case "叶":
                    this.uiPanelGameWin.BackgroundImage = global::GamesWinForm.Properties.Resources.Leaf;
                    break;
                default:
                    break;
            }
        }

        private void uiButtonSend_Click(object sender, EventArgs e)
        {
            if (Answer == "") return;
            //按钮只能用一次。
            this.uiButtonSend.Enabled = false;
            client.SendMessageToServer(Answer);
            Answer = "";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Time--;
            if(Time < 10) this.uiLabelTimer.Text = "0:0" + Time;
            else this.uiLabelTimer.Text = "0:" + Time;
            if (Time <= 0)
            {
                this.timer.Stop();
                this.uiButtonSend.Enabled = false;
                this.uiButtonSend.PerformClick();
            }
        }

        private void FlyFlowerForm_Load(object sender, EventArgs e)
        {
            this.pictureBoxAnswer.Parent = this.uiPanelGameWin;
        }
    }

    public class RemainPlayer
    {
        public string Name { set; get; }
        public RemainPlayer(string name)
        {
            Name = name;
        }

    }
}
