using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawAndGuess
{
    public partial class ServerForm : Form
    {
        Server server;
        public string ClientName { set; get; }
        public ServerForm()
        {
            InitializeComponent();
            textBoxName.DataBindings.Add("Text", this, "ClientName");
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
            RoomForm roomForm = new RoomForm(ClientName);
            roomForm.Show();
        }
    }
}
