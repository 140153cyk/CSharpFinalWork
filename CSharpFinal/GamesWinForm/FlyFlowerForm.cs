using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;

namespace GameWinForm
{
    public partial class FlyFlowerForm : Form
    {
        FlyingFlowerClient client;
        public string KeyWord { set; get; } = "月";
        public FlyFlowerForm(FlyingFlowerClient c)
        {
            client = c;
            c.StartReceive();

            InitializeComponent();

            while (client.KeyWord == "") { }
            KeyWord = client.KeyWord;
            setImage();
        }
        private void setImage()
        {
            switch (KeyWord)
            {
                case "月":
                    //this.uiPanelGameWin.BackgroundImage = global::GameWinForm.Properties.Resources.Moon;
                    this.uiLabelAnswer.ForeColor = Color.White;
                    this.uiLabelPlayerAnswer.ForeColor = Color.White;
                    break;
                case "酒":
                    //this.uiPanelGameWin.BackgroundImage = global::GameWinForm.Properties.Resources.Wine;
                    break;
                case "花":

                    break;
                case "风":

                    break;
                case "春":

                    break;
                case "夏":

                    break;
                case "秋":

                    break;
                case "冬":

                    break;
                case "夜":

                    break;
                case "叶":

                    break;
                default:
                    break;
            }
        }
    }
}
