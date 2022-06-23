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
    
    public partial class MyComments : Form
    {
        public string account { get; set; }
        public HttpClient client { get; set; }
        public string baseUrl { get; set; }

        public int page { get; set; } = 1;
        public MyComments(string account)
        {

            this.account = account;
            InitializeComponent();
            pageText.Text = ""+ page;
            XmlDocument serverDoc = new XmlDocument();
            serverDoc.Load("serverIp.xml");
            XmlNode node = serverDoc.SelectSingleNode("serverIp");
            baseUrl = "https://" + node.InnerText + ":5001/api";

            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
            client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            getPageComments(1);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            getPageComments(page - 1);
            pageText.Text = "" + page;
        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            getPageComments(page + 1);
            pageText.Text = "" + page;

        }
        public void getPageComments(int pageNum)
        {
            page = pageNum;
            var task = client.GetStringAsync(baseUrl + "/comment?account=" + account + "&skip=" + (page - 1) * 6 + "&take=6");
            myCommentsSource.DataSource = JsonConvert.DeserializeObject<List<Comment>>(task.Result);
            commentsGridview.DataSource = null;
            commentsGridview.DataSource = myCommentsSource;
            judgeBtnState();
        }
        public void judgeBtnState()
        {
            if (page > 1) beforeBtn.Enabled = true;
            else beforeBtn.Enabled = false;
            if (myCommentsSource.Count == 6) nextBtn.Enabled = true;
            else nextBtn.Enabled = false;
        }

        private void commentsGridview_DoubleClick(object sender, EventArgs e)
        {
            Comment current = (Comment)myCommentsSource.Current;
            Replys replys = new Replys(account, current);
            replys.Show();
        }
    }
}
