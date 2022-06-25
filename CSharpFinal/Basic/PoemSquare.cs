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
    public partial class PoemSquare : Form
    {
        private string account;
        private HttpClient client;
        private string baseUrl;
        public PoemSquare(string account)
        {
            this.account = account;
            XmlDocument serverDoc = new XmlDocument();
            serverDoc.Load("serverIp.xml");
            XmlNode node = serverDoc.SelectSingleNode("serverIp");
            baseUrl = "https://" + node.InnerText + ":5001/api";
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
            client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            InitializeComponent();
            searchTypeBox.SelectedIndex = 0;
            uiPanel3.RectColor = Color.Transparent;
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            pageNum.Text = "1";
            search(sender, e);
            if (searchBindingSource.Count == 4) nextBtn.Enabled = true;
            beforeBtn.Enabled = false;
        }

        private void search(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(baseUrl);
            sb.Append("/poem");
            string args = searchArgBox.Text;
            switch (searchTypeBox.SelectedIndex)
            {
                case 0:sb.Append("?title=" + args);break;
                case 1:sb.Append("?author=" + args);break;
                case 2:sb.Append("?content=" + args);break;
                default:break;
            }
            int page = Int32.Parse(pageNum.Text);
            sb.Append("&skip=" + (page - 1) * 4);
            sb.Append("&take=4");

            var task= client.GetStringAsync(sb.ToString());
            searchBindingSource.DataSource=
                JsonConvert.DeserializeObject<List<Poem>>(task.Result);
            searchGridView.DataSource = searchBindingSource;

        }

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            int page = Int32.Parse(pageNum.Text);
            pageNum.Text = page - 1 + "";
            search(sender, e);
            if (searchBindingSource.Count == 4) nextBtn.Enabled = true;
            else nextBtn.Enabled = false;
            if (page-1 > 1) beforeBtn.Enabled = true;
            else beforeBtn.Enabled = false;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int page = Int32.Parse(pageNum.Text);
            pageNum.Text = page + 1 + "";
            search(sender, e);
            if (searchBindingSource.Count == 4) nextBtn.Enabled = true;
            else nextBtn.Enabled = false;
            if (page + 1 > 1) beforeBtn.Enabled = true;
            else beforeBtn.Enabled = false;
        }

        private void searchGridView_CellDoubleClick(object sender, EventArgs e)
        {
            Poem searchPoem = (Poem)searchBindingSource.Current;
            PoemDetail detail = new PoemDetail(account, searchPoem);
            detail.Show();
        }
    }
}
