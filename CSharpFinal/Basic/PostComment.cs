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
namespace Basic
{
  public partial class PostComment : Form
  {
    private HttpClient client;
    private string account;
    private int id;
    public class newComment
    {

      public string Account { get; set; }
      public int poemId { get; set; }
      public newComment(string account, int poemId)
      {

        this.Account = account;
        this.poemId = poemId;
      }
      public override string ToString()

      {

        return $" {Account}:{poemId}";

      }
    }
    public PostComment(string account,int poemId)
    {
      InitializeComponent();
      HttpClientHandler handler = new HttpClientHandler();
      handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
      client = new HttpClient(handler);
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
      this.account = account;
      id = poemId;
    }

   

    private void uiButton1_Click_1(object sender, EventArgs e)
    {
      var myComment = new newComment(account, id);
      var json = JsonConvert.SerializeObject(myComment);
      HttpContent data = new StringContent(json);
      data.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
      var task = client.PostAsync("https://localhost:5001/api/comment", data);
    }
  }
}
