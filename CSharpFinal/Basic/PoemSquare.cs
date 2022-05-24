using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic
{
    public partial class PoemSquare : Form
    {
        private string account;
        public PoemSquare(string account,MainPage main)
        {
            this.account = account;
            this.FormClosing += (x, y) =>
            {
                main.Visible = true;
            };
           
            InitializeComponent();
        }
        
    }
}
