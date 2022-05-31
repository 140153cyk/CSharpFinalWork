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

namespace tempDetail
{
    public partial class PoemDetail : Form
    {
        private Poem poem;
        private HttpClient client;
        private string account;
        private bool alreadyCollect;
        public PoemDetail(string account,Poem po)
        {
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
          var task=  client.GetStringAsync("https://localhost:5001/api/collect?account=" + account + "&poemId=" + poem.id);
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
                var task = client.DeleteAsync("https://localhost:5001/api/collect?account=" + account + "&poemId=" + poem.id);
                task.Wait();
                JudeCollect();
            }
            else
            {
                var task = client.PostAsync("https://localhost:5001/api/collect?account=" + account + "&poemId=" + poem.id, null);
                task.Wait();
                JudeCollect();
            }

        }
    }
}
