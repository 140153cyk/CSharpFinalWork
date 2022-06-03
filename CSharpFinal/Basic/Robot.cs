using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Basic
{

  public partial class Robot : Form
  {
    public class Newslists
    {
      public string List { get; set; }
    }
    public class Content
    {
      public int Code { get; set; }
      public string Msg { get; set; }
      public List<Newslists> Newslist { get; set; }
    }
    public Robot()
    {
      InitializeComponent();
      //this.BackgroundImage = Image.FromFile("D:\\loginView\\500.jpg");
      this.Size = new System.Drawing.Size(1000, 600);
      uiTextBox2.Multiline = true;
      uiTextBox2.AutoSize = false;
      uiTextBox2.Height = 200;
   
    }
    public static string HttpGet(string word)
    {
      //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
      Encoding encoding = Encoding.UTF8;
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.tianapi.com/cangtoushi/index?key=c4eba90cfbb5608049513494bba1eb22&word=" + word);
      request.Method = "GET";
      request.Accept = "text/html, application/xhtml+xml, */*";
      request.ContentType = "application/json";

      HttpWebResponse response = (HttpWebResponse)request.GetResponse();
      using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
      {
        return reader.ReadToEnd();
      }
    }
 
    private void uiLabel1_Click(object sender, EventArgs e)
    {
    }
   

  

    private void Robot_Load(object sender, EventArgs e)
    {

    }

    private void uiTextBox2_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void uiButton1_Click(object sender, EventArgs e)
    {
      var ss = HttpGet(uiTextBox1.Text);
      JavaScriptSerializer js = new JavaScriptSerializer();
      var model = js.Deserialize<Content>(ss);
      foreach (var temp in model.Newslist)
      {

        //MessageBox.Show(temp.List);
        uiTextBox2.AppendText(temp.List + Environment.NewLine);

      }
    }
  }
}

