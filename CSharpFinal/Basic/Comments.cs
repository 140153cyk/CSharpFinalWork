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
using System.Drawing;
using System.Xml;

namespace Basic
{
    public partial class Comments: Form
    {
          private Poem poem;
          private HttpClient client;
          private string account;
          private int poemId;
         private string baseUrl;
          private bool alreadyPrase;
    public class newComment
    {

      public string userAccount { get; set; }
      public int poemId { get; set; }
      public string Detail { get; set; }
      public DateTime created { get; set; }
      public newComment(string account, int poemId, string detail)
      {

        this.userAccount = account;
        this.poemId = poemId;
        this.Detail = detail;
        this.created = DateTime.Now;
      }
      public override string ToString()

      {

        return $" {userAccount}:{poemId}:{created}:{Detail}";

      }
   
    }
    public Comments(string account,int id)
        {
            InitializeComponent();
            XmlDocument serverDoc = new XmlDocument();
            serverDoc.Load("serverIp.xml");
            XmlNode node = serverDoc.SelectSingleNode("serverIp");
             baseUrl = "https://" + node.InnerText + ":5001/api";
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
            client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            this.account = account;
            poemId = id;
            getComments(id);
    }
    public void JudePrase()
    {
      Comment comment = (Comment)commentBindingSource.Current;
      var task1 = client.GetStringAsync(baseUrl + "/commentprase?account=" + account + "&Id=" + comment.Id);
      alreadyPrase = Boolean.Parse(task1.Result);
      //MessageBox.Show(""+alreadyPrase);
      if (alreadyPrase)
      {
        uiButton1.Text = "已赞";
      }
      else uiButton1.Text = "赞";
    }
   
    private void uiButton1_Click(object sender, EventArgs e)
    {
      if(uiButton1.Text == "已赞")
      {
        Comment comment=(Comment)commentBindingSource.Current;
        var task1 = client.DeleteAsync(baseUrl + "/commentprase?account=" + account + "&Id=" + comment.Id);
        comment.Prase = comment.Prase - 1;
        var json = JsonConvert.SerializeObject(comment);
        //MessageBox.Show(json);
        HttpContent data = new StringContent(json);
        data.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        var task2 = client.PutAsync(baseUrl+ "/comment/"+comment.Id, data);
        System.Threading.Thread.Sleep(100);
        getComments(poemId);
        JudePrase();
      }
      else
      {
        Comment comment = (Comment)commentBindingSource.Current;
        var task1 = client.PostAsync(baseUrl + "/commentprase?account=" + account + "&commentId=" + comment.Id, null);
        comment.Prase = comment.Prase + 1;
        var json = JsonConvert.SerializeObject(comment);
        //MessageBox.Show(json);
        HttpContent data = new StringContent(json);
        data.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        var task2 = client.PutAsync(baseUrl + "/comment/" + comment.Id, data);
        System.Threading.Thread.Sleep(100);
        getComments(poemId);
        JudePrase();
      }
    }

    public void getComments(int id)
    {
      var task = client.GetStringAsync(baseUrl+"/comment?poemId=" + id);
      commentBindingSource.DataSource =
          JsonConvert.DeserializeObject<List<Comment>>(task.Result);
      commentGridView.DataSource = commentBindingSource;
      //MessageBox.Show(task.Result);
    }
    private void Comments_Load(object sender, EventArgs e)
    {
      
    }

    private void uiButton2_Click(object sender, EventArgs e)
    {
      if (uiTextBox1.Text == "")
      {
        MessageBox.Show("评论不能为空！");
      }
      else
      {
            var myComment = new newComment(account, poemId, uiTextBox1.Text);
            var json = JsonConvert.SerializeObject(myComment);
            HttpContent data = new StringContent(json);
            data.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var task = client.PostAsync(baseUrl + "/comment", data);
            System.Threading.Thread.Sleep(100);
            getComments(poemId);
            uiTextBox1.Text = "";
      }
      
    }

    private void commentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      JudePrase();
    }
 
    private void uiButton3_Click(object sender, EventArgs e)
    {
      Comment comment = (Comment)commentBindingSource.Current;
      Replys replys = new Replys(account, comment);
      replys.Show();
    }
  }
}
