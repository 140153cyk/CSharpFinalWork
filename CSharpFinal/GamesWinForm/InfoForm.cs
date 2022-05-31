using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWinForm
{
    public partial class InfoForm : Form
    {
        public InfoForm(string info)
        {
            InitializeComponent();
            this.uiLabelInfo.Text = info;
        }
    }
}
