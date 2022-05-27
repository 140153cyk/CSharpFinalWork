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
    public partial class Comments: Form
    {
        public Comments()
        {
            InitializeComponent();
      
        }

    private void uiTextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void uiButton1_Click(object sender, EventArgs e)
    {
      int i=0;  
      if(uiButton1.FillColor == Color.White)
      {
        i++;
        uiButton1.FillColor = Color.Red;
        uiButton1.Text = "赞" + i;
      }
      else
      {
        i--;
        uiButton1.FillColor = Color.White;
        uiButton1.Text = "赞" + i;
      }
    }

    private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
