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
    public partial class RoomForm : Form
    {
        Client client;
        public string RoomName { set; get; }
        public int RoomID { set; get; }
        public RoomForm(string name)
        {
            InitializeComponent();
            textBoxRoomName.DataBindings.Add("Text", this, "RoomName");
            textBoxRoomID.DataBindings.Add("Text", this, "RoomID");
            client = new Client(name);
            client.showMessage += (content) =>
            {
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    rtbRoomList.Clear();
                    rtbRoomList.AppendText(content + "\n");
                }));
            };
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            client.CreateRoom(RoomName, 20);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            client.RefreshAllRooms();
        }

        private void btnEnterRoom_Click(object sender, EventArgs e)
        {
            if (client.JoinRoom(RoomID))
            {
                client.dagForm = new DrawAndGuess(client);
                client.dagForm.Show();
                this.Visible=false;
            }
        }
    }
}
