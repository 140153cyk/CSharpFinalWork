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
        public MyComments(string account)
        {

            this.account = account;
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

            var task = client.GetStringAsync(baseUrl + "/comment?account=" + account+"&skip=0&take=4");
            myCommentsSource.DataSource= JsonConvert.DeserializeObject<List<Comment>>(task.Result);
            commentsGridview.DataSource = null;
            commentsGridview.DataSource = myCommentsSource;
        }
    }
}
