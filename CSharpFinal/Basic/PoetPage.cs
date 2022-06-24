using Models;
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
using System.Windows.Forms;

namespace Basic
{
    public partial class PoetPage : Form
    {
        public Poet poet { get; set; }
        public PoetPage(Poet poet)
        {
            this.poet = poet;
            InitializeComponent();
            nameText.Text = poet.name;
            introText.Text = poet.introduction;
            IMGPanel.BackgroundImage = GetPictureImage(poet.IMGPath);
        }
        public static Image GetPictureImage(string Url)
        {
            WebRequest webreq = WebRequest.Create(Url);
            WebResponse webres = webreq.GetResponse();
            using (Stream stream = webres.GetResponseStream())
            {
                return System.Drawing.Image.FromStream(stream);
            }
        }
    }
}
