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
    public partial class CollectsPage : Form
    {
        private string account;
        private HttpClient client;
        private string baseUrl;
        public CollectsPage(string account)
        {
            XmlDocument serverDoc = new XmlDocument();
            serverDoc.Load("../../../serverIp.xml");
            XmlNode node = serverDoc.SelectSingleNode("serverIp");
            baseUrl = "https://" + node.InnerText + ":5001/api";

            this.account = account;
            InitializeComponent();
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
            client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            GetCollects();

        }

        private void goToCollectDetail(object sender, DataGridViewCellEventArgs e)
        {
            Poem collectPoem = (Poem)poemBindingSource.Current;
            PoemDetail detail = new PoemDetail(account, collectPoem);
            detail.FormClosing +=(x,y)=> GetCollects();
            detail.Show();
        }

        public void GetCollects()
        {
            var task = client.GetStringAsync(baseUrl+"/collect/" + account);
            poemBindingSource.DataSource =
                JsonConvert.DeserializeObject<List<Poem>>(task.Result);
            collectsGridView.DataSource = poemBindingSource;
            Console.WriteLine(task.Result);
        }
    }
}
