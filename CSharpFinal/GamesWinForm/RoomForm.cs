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
using Client;
using System.Threading;

namespace GameWinForm
{
    //房间选择界面
    public partial class RoomForm : Form
    {
        public Client.Client client;

        //Type==0是飞花令，Type==1是你画我猜，在进入房间选择界面时传入
        public int Type { get; set; } = 0;
        //房间列表，从客户端获得，用于显示
        public Dictionary<int, RoomInfo> Rooms;
        //所选择或创建的房间的名称
        //创建房间，则从CreateForm返回房间名称，在进入WaitingRoom时传入WaitingRoom
        //选择房间，则在点击“进入房间”按钮时，从Dictionary中获得，并在进入WaitingRoom时传入WaitingRoom
        public string RoomName { set; get; }
        //所选择的房间的ID
        public int RoomID { set; get; } = -1;

        //创建并展示等待房间的委托
        public static Action<string> OnShowWaitingForm;
        public static Action<string> OnShowInfoForm;

        protected Regex regex = new Regex(@"\w+");


        public RoomForm(string clientName, int type)
        {

            //初始化
            InitializeComponent();
            Type = type;
            if (Type== 0)
            {
                this.uiLabelGameName.Text = "飞  花  令";
                client = new FlyingFlowerClient(clientName);
            }
            else
            {
                this.uiLabelGameName.Text = "你 画 我 猜";
                client = new DrawAndGuessClient(clientName);
            }
            Rooms = new Dictionary<int, RoomInfo>();
            //关联 委托 和 创建并展示等待房间的方法 
            OnShowWaitingForm += ShowWaitingRoom;
            OnShowInfoForm += ShowInfoForm;


            // 刷新房间列表,s格式为“{房间ID} {房间名} {游玩状态} {当前人数} {最大游玩人数} ”
            client.ShowRooms = (str) =>
            {
                MatchCollection matches = regex.Matches(str);
                for(int i = 0; (5 * i) < matches.Count; i++)
                {
                    //更新Dictionary
                    Rooms[Int32.Parse(matches[5 * i].Value)] = new RoomInfo(Int32.Parse(matches[5 * i].Value),
                       matches[5 * i + 1].Value,matches[5 * i + 2].Value,
                       Int32.Parse(matches[5 * i + 3].Value),Int32.Parse(matches[5 * i + 4].Value));

                    this.uiDataGridViewRoomInfo.DataSource = Rooms.Values.ToList<RoomInfo>();
                }
            };
            client.CreateFormAndShowPlayerState = (str) =>
            {
                OnShowWaitingForm(str);
            };
            //***
            client.ShowWarning = (s) =>
            {
                MessageBox.Show(s);
            };
        }

        private void form_Show(object sender, EventArgs e)
        {
            //client.RefreshAllRooms();
        }
        private void uiButtonCreate_Click(object sender, EventArgs e)
        {
            CreateForm form = new CreateForm(client);
            form.ShowDialog(this);
        }
        private void uiButtonFresh_Click(object sender, EventArgs e)
        {
            client.RefreshAllRooms();
        }
        private void uiButtonEnter_Click(object sender, EventArgs e)
        {
            if (RoomID == -1)
            {
                InfoForm infoForm = new InfoForm("请选择房间");
                infoForm.ShowDialog();
            }
            else
            {
                RoomName = Rooms[RoomID].Name;
                client.JoinRoom(RoomID);
            }

        }
        private void IndexSet(object sender, int index)
        {
            try
            {
                this.uiLabelRoomID.Text = "ID: " + this.uiDataGridViewRoomInfo.Rows[index].Cells[0].Value.ToString();
                RoomID = (int)this.uiDataGridViewRoomInfo.Rows[index].Cells[0].Value;
            }
            catch(Exception e) { }
        }

        //创建并展示等待界面的窗口
        public void ShowWaitingRoom(string str)
        {
            this.Invoke(new Action(delegate ()
            {
                WaitingRoom form = new WaitingRoom(client,RoomID,RoomName,Type,str,this);
                this.Hide();
                form.Show();
                form.FormClosing += (x,y)=>this.Show();
            }));
        }
        public void ShowInfoForm(string str)
        {
            this.Invoke(new Action(delegate ()
            {
                InfoForm form = new InfoForm(str);
                this.Hide();
                form.ShowDialog();
                this.Dispose();
            }));
        }

    }

    public class RoomInfo
    {
        public int RoomID { get; set; }

        public string Name { get; set; }
        public string State { set; get; }
        public int CurrentPlayer { set; get; }
        public int MaxPlayer { set; get; }
        public RoomInfo(int roomID, string name, string state, int currentPlayer, int maxPlayer)
        {
            RoomID = roomID;
            Name = name;
            if (state == "False")
            {
                State = "未开始";
            }
            else
            {
                State = "已开始";
            }
            CurrentPlayer = currentPlayer;
            MaxPlayer = maxPlayer;
        }
    }
}
