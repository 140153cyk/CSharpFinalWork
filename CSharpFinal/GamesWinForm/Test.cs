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
    public partial class Test : Form
    {
        public string Name { set; get; } = "";
        public Test()
        {
            InitializeComponent();
            this.uiTextBox1.DataBindings.Add("Text", this, "Name");
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            RoomForm form = new RoomForm(Name, 1);
            form.Show();
        }
    }
}
