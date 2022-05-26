﻿using ImportData;
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
    public partial class MainPage : Form
    {
        private string account;
        private Poem recommend;
        private HttpClient client;
        public MainPage( string account)
        {
            this.account = account;
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
            client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            GetRecommend();
            InitializeComponent();
            GetStyles();
        }
        public void GetStyles()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.WindowState = FormWindowState.Maximized;
            AbilityPanel.FillColor = Color.FromArgb(100, 255, 255, 255);
            RecPanel.FillColor= Color.FromArgb(100, 255, 255, 255);
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {
            PoemSquare square = new PoemSquare(account, this);
            this.Visible = false;
            square.Show();
        }

        private void GetRecommend()
        {
            string baseUrl = "https://localhost:5001/api/poem/recommend?account=" + account;
            var task= client.GetStringAsync(baseUrl);
            recommend = JsonConvert.DeserializeObject<Poem>(task.Result);
            string s = "";
            
        }
    }
}