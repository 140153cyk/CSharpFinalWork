using ImportData;
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
    public partial class RegisterPage : Form
    {
        private string baseUrl;
        public RegisterPage()
        {
            XmlDocument serverDoc = new XmlDocument();
            serverDoc.Load("../../../serverIp.xml");
            XmlNode node = serverDoc.SelectSingleNode("serverIp");
            baseUrl = "https://" + node.InnerText + ":5001/api";
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string account = AccountText.Text;
            string password = PasswordText.Text;
            string confirm = ConfrimPas.Text;
            if (password != confirm)
            {
                MessageBox.Show("两次输入密码不同", "注册失败", MessageBoxButtons.OK);
                return;
            }
            

            string url = baseUrl+"/userinfo";
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
            HttpClient client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            UserInfo info = new UserInfo(account, password);
            HttpContent content = new StringContent(JsonConvert.SerializeObject(info),Encoding.UTF8,"application/json");
            var task = client.PostAsync(url, content);
            task.Wait();

            HttpResponseMessage m=task.Result;
            if(m.ReasonPhrase=="Bad Request")
            {
                MessageBox.Show("已存在相同账号", "注册失败", MessageBoxButtons.OK);
                return;
            }else this.Close();
        }
    }
}
