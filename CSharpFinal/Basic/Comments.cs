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
  public partial class Comments : Form
  {
    public Comments()
    {
      InitializeComponent();
    }

    private void uiButton1_Click(object sender, EventArgs e)
    {
      int i = 0;//数据库中拿数据
        if(uiButton1.FillColor== Color.LightSteelBlue)
      {
        i++;
        uiButton1.FillColor = Color.Red;
        uiButton1.Text = "赞" + i;
      }
      else
      {
        i--;
        uiButton1.FillColor= Color.LightSteelBlue;
        uiButton1.Text = "赞" + i;
      }
    }

    private void uiButton2_Click(object sender, EventArgs e)
    {

    }
  }
}
