using GameWinForm;
using ImportData;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Basic
{
    public partial class MainPage : Form
    {
        private string account;
        private Poem recommend;
        private HttpClient client;
        private string baseUrl;
        public MainPage( string account)
        {
            XmlDocument serverDoc = new XmlDocument();
            serverDoc.Load("serverIp.xml");
            XmlNode node = serverDoc.SelectSingleNode("serverIp");
           baseUrl = "https://" + node.InnerText + ":5001/api";

            this.account = account;
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
            client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            InitializeComponent();
            GetRecommend();

            GetStyles();
        }
        public void GetStyles()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.WindowState = FormWindowState.Maximized;
            AbilityPanel.FillColor = Color.FromArgb(100, 255, 255, 255);
            RecPanel.FillColor= Color.FromArgb(100, 255, 255, 255);
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {
            PoemSquare square = new PoemSquare(account);
            square.FormClosing += (x, y) => this.Visible = true;
            this.Visible = false;
            square.Show();
        }

        private void GetRecommend()
        {
            string url = baseUrl+"/reccommend/" + account;
            var task= client.GetStringAsync(url);
            recommend = JsonConvert.DeserializeObject<Poem>(task.Result);
            reccomendText.Text = recommend.title;
        }

        private void uiPanel3_Click(object sender, EventArgs e)
        {
            
            RoomForm flyForm = new RoomForm(account, 0);
            flyForm.FormClosing += (x, y) => this.Visible = true;
            flyForm.Show();
            this.Visible = false;

        }

        private void uiPanel4_Click(object sender, EventArgs e)
        {
           RoomForm guessRoom = new RoomForm(account,1);
            guessRoom.FormClosing += (x, y) => this.Visible = true;
            guessRoom.Show();
            this.Visible = false;
        }

        private void uipanel2_Click(object sender, EventArgs e)
        {
            Robot robot = new Robot();
            robot.FormClosing += (x, y) => this.Visible = true;
            robot.Show();
            this.Visible = false;
        }

        private void openReccommend(object sender, EventArgs e)
        {
            Finished finished = new Finished(account,recommend.id);
            HttpContent content = new StringContent(JsonConvert.SerializeObject(finished),Encoding.UTF8,"application/json");
            client.PostAsync(baseUrl + "/finished", content);
            PoemDetail detail = new PoemDetail(account,recommend);
            detail.Show();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            CollectsPage collects = new CollectsPage(account);
            collects.Show();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            MyComments myComments = new MyComments(account);
            myComments.Show();
        }
    }
}
