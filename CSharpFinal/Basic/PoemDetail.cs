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
    public partial class PoemDetail : Form
    {
        private Poem poem;
        private HttpClient client;
        private string account;
        private bool alreadyCollect;
        private string baseUrl;
        public PoemDetail(string account,Poem po)
        {
            XmlDocument serverDoc = new XmlDocument();
            serverDoc.Load("serverIp.xml");
            XmlNode node = serverDoc.SelectSingleNode("serverIp");
            baseUrl = "https://" + node.InnerText + ":5001/api";
            //this.poem = poem;
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
            client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            /*            var task = client.GetStringAsync("https://localhost:5001/api/poem?author=李白");
                        this.poem = JsonConvert.DeserializeObject<List<Poem>>(task.Result)[0];*/
            this.poem = po;
            this.account = account;

            InitializeComponent();
            JudeCollect();

            
            title.Text = this.poem.title;
            poetText.Text = poem.author;
            poem.paragraphs=poem.paragraphs.OrderBy(p => p.paraNum).ToList();
            StringBuilder sb = new StringBuilder();
            foreach(Models.Paragraph p in poem.paragraphs)
            {
                string[] sentences = p.value.Split(new char[] { '，', '。', '！', '？', '；' });
                foreach(string s in sentences)
                {
                    sb.Append( Environment.NewLine+s);
                }               
            }
            Paragraph.Text = sb.ToString();

            
        }

        public void JudeCollect()
        {
          var task=  client.GetStringAsync(baseUrl+"/collect?account=" + account + "&poemId=" + poem.id);
          alreadyCollect = Boolean.Parse(task.Result);
            if (alreadyCollect)
            {
                collectBtn.Text = "取消收藏";
            }
            else collectBtn.Text = "收藏";
        }

        //用户点击收藏按钮
        private void collectBtn_Click(object sender, EventArgs e)
        {
            if (alreadyCollect)
            {
                var task = client.DeleteAsync(baseUrl+"/collect?account=" + account + "&poemId=" + poem.id);
                task.Wait();
                JudeCollect();
            }
            else
            {
                var task = client.PostAsync(baseUrl+"/collect?account=" + account + "&poemId=" + poem.id, null);
                task.Wait();
                JudeCollect();
            }

        }

    private void commentBtn_Click(object sender, EventArgs e)
    {
       Comments comments= new Comments(account,poem.id);
       comments.Show();
    }

    private void Paragraph_TextChanged(object sender, EventArgs e)
    {

    }

        private void goToPoet(object sender, EventArgs e)
        {
            var task = client.GetStringAsync(baseUrl + "/poet?name=" + poem.author);
            Poet poet = JsonConvert.DeserializeObject<Poet>(task.Result);
            PoetPage poetPage = new PoetPage(poet);
            poetPage.Show();
        }
    }
}
