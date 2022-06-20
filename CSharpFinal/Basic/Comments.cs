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
             baseUrl = "https://" + node.InnerText + ":5001/api/comment";
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
            client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            this.account = account;
            poemId = id;
            getComments(id);
    }

  

    private void uiButton1_Click(object sender, EventArgs e)
    {
      int i=0;  
      if(uiButton1.FillColor == Color.White)
      {
        i++;
        uiButton1.FillColor = Color.Red;
        uiButton1.Text = "赞" + i;
      }
      else
      {
        i--;
        uiButton1.FillColor = Color.White;
        uiButton1.Text = "赞" + i;
      }
    }

    public void getComments(int id)
    {
      var task = client.GetStringAsync(baseUrl+"?poemId=" + id);
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
        var task = client.PostAsync(baseUrl, data);
        getComments(poemId);
      }
      getComments(poemId);
    }

    private void commentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      
    }

    private void uiButton3_Click(object sender, EventArgs e)
    {
      Comment comment = (Comment)commentBindingSource.Current;
      Replys replys = new Replys(account, comment.Id, comment.UserAccount,poemId);
      replys.Show();
    }
  }
}
