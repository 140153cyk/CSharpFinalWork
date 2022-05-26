using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FlyFlower
{
    public partial class RoomForm : Form
    {
        Client client;
        private Regex regex = new Regex(@"\w+");
        public RoomForm(String name)
        {
            InitializeComponent();
            client = new Client(name);
            client.ShowRooms += (AllRooms) =>
            {
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    lbRooms.Items.Clear();
                    Regex newLineRegex = new Regex(@"[^\n]+");
                    Match match = newLineRegex.Match(AllRooms);
                    while (match.Success)
                    {
                        lbRooms.Items.Add(match.Value);
                        match = match.NextMatch();
                    }
                }));
            };


        }

        private void btnRefreshRooms_Click(object sender, EventArgs e)
        {
            client.RefreshAllRooms();
        }

        private void btnCreateRooms_Click(object sender, EventArgs e)
        {
            RoomDetailsForm roomDetailsForm = new RoomDetailsForm();
            if(roomDetailsForm.ShowDialog() == DialogResult.OK)
            {
                client.CreateRoom(roomDetailsForm.roomName.Trim(),roomDetailsForm.maxMem);
            }
            this.Visible = false;
            FlyingFlower f = new FlyingFlower();
            f.Show();
        }

        private void btnJoinRoom_Click(object sender, EventArgs e)
        {
            if(lbRooms.SelectedItems != null)
            {
                Match match = regex.Match(lbRooms.SelectedItem.ToString());
                int roomId = Int32.Parse(match.Value);
                client.JoinRoom(roomId);
            }
        }
    }
}
