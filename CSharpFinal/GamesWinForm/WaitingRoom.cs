using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;

namespace GameWinForm
{
    public partial class WaitingRoom : Form
    {
        public BindingList<Player> PlayerList = new BindingList<Player>();
        public Client.Client client;
        public int RoomID { set; get; }
        public string RoomName { set; get; }
        public int Type { set; get; }
        public int PlayerReadyNum { set; get; } = 0;

        protected Regex regex = new Regex(@"\w+");


        public WaitingRoom(Client.Client c, int roomID, string roomName, int type, string message)
        {
            client = c;
            c.StartReceive();

            InitializeComponent();
            RoomID = roomID;
            RoomName = roomName;
            Type = type;

            this.uiLabelName.Text = RoomName;

            if (message != "")
            {
                MatchCollection matches = regex.Matches(message);
                for (int i = 0; 2 * i < matches.Count; i++)
                {
                    if (matches[i + 1].Value == "已准备") PlayerReadyNum++;
                    PlayerList.Add(new Player(matches[i].Value, matches[i + 1].Value));
                }
            }
            client.PlayerGetIn = (str) =>
            {
                PlayerList.Add(new Player(str, "未准备"));
                this.Invoke(new Action(delegate ()
                {
                    this.uiDataGridViewPlayers.DataSource = PlayerList;
                }));
            };
            client.PlayerGetReady = (str) =>
            {
                PlayerList.FirstOrDefault((player) => player.Name == str).State = "已准备";
                PlayerReadyNum++;
                this.Invoke(new Action(delegate ()
                {
                    this.uiDataGridViewPlayers.Refresh();
                    if (PlayerReadyNum >= PlayerList.Count)
                    {
                        FlyFlowerForm form = new FlyFlowerForm((FlyingFlowerClient)client);
                        this.Hide();
                        form.ShowDialog();
                        this.Dispose();
                    }
                }));
                
            };

        }

        private void uiButtonReady_Click(object sender, EventArgs e)
        {
            client.GetReady();
            this.uiButtonReady.Enabled = false;
        }
    }
    public class Player
    {
        public string Name { get; set; }
        public string State { get; set; }

        public Player(string name, string state)
        {
            Name = name;
            State = state;
        }
    }
}
