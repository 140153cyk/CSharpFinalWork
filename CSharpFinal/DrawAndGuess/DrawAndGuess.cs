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
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DrawAndGuess
{
    public partial class DrawAndGuess : Form
    {
        Client client;

        public Color PenColor { set; get; } = Color.Black;
        public int SelectPenOrEraser { set; get; } = 0;
        public Bitmap Bitmap { set; get; }
        public Point StartPoint { set; get; }
        public int count { set; get; }
        public ConcurrentQueue<Line> Lines { set; get; } = new ConcurrentQueue<Line>();
        private bool CanMove { set; get; }
        public DrawAndGuess(Client c)
        {
            InitializeComponent();
            ColorPicker.Value = Color.Black;
            RadioButtonGroupPen.SelectedIndex = 0;
            client = c;
            CanMove = false;
            Bitmap = new Bitmap(pictureBoxDrawing.Width,pictureBoxDrawing.Height);
            pictureBoxDrawing.Image = Bitmap;
        }

        public void DrawImage(Color c, Point sp, Point ep)
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
        public void SetPoem(string poem)
        {
            labelPoem.Text = poem;
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {

        }
        private void pictureBoxDrawing_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            CanMove = true;
            StartPoint = new Point(e.X, e.Y);
        }
        private void pictureBoxDrawing_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
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

        private void buttonReady_Click(object sender, EventArgs e)
        {
            client.Prepare();
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
}
