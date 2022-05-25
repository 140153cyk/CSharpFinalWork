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
    public partial class RoomForm : Form
    {
        Client client;
        public RoomForm()
        {
            InitializeComponent();
            client = new Client("Bob");
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
            client.CreateRoom("棋牌室", 20);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            client.RefreshAllRooms();
        }
    }
}
