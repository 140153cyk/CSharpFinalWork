using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Basic
{
  public partial class Replys : Form
  {
    private HttpClient client;
    private string account;
    private int commentId;
    private int poemId;
    private string name;
   
    public Replys(string account,int Id,string name,int poemId)
    {
      InitializeComponent();
      HttpClientHandler handler = new HttpClientHandler();
      handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
      client = new HttpClient(handler);
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
      this.account = account;
      commentId = Id;
      this.poemId = poemId;
      this.name = name;
      HttpGet();
      uiLabel1.Text = account + "的回复";
    }
    public void HttpGet()
    {
      Comment a = new Comment();
      var task = client.GetStringAsync("https://localhost:5001/api/comment?poemId=" + poemId);
      var model =
          JsonConvert.DeserializeObject<List<Comment>>(task.Result);
      var query = from s1 in model
                  where commentId == s1.Id
                  select s1;
      foreach (var comment in query)
      {
        a = comment;
      }
      replyBindingSource.DataSource = a.Replys;
      uiDataGridView1.DataSource = replyBindingSource;
    }
    private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      
    }

  }
}
