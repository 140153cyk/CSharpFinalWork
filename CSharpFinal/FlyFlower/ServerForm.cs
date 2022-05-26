using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyFlower
{
    public partial class ServerForm : Form
    {
        Server server;
        public ServerForm()
        {
            InitializeComponent();
            server = new Server();
            server.showMessage += (content) =>
            {
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    rtbMessage.AppendText(content + "\n");
                })); 
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server.showMessage("加载服务器");
            RoomForm roomForm = new RoomForm("bob");
            roomForm.Show();
        }
    }
}
