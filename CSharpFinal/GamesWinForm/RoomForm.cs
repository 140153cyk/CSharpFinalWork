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
        public Dictionary<int, string> Rooms;
         //所选择的房间的名称
        public string RoomName { set; get; }
        //所选择的房间的ID
        public int RoomID { set; get; } = 0;

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
                this.uiLabelGameName.Text = "飞花令";
                client = new FlyingFlowerClient(clientName);
            }
            else
            {
                this.uiLabelGameName.Text = "你画我猜";
                client = new DrawAndGuessClient(clientName);
            }
            Rooms = new Dictionary<int, string>();
            //关联 委托 和 创建并展示等待房间的方法 
            OnShowWaitingForm += ShowWaitingRoom;
            OnShowInfoForm += ShowInfoForm;

            //数据绑定
            this.uiTextBoxRoomID.DataBindings.Add("Text", this, "RoomID");


            // 刷新房间列表,s格式为“{房间ID} {房间名} {游玩状态} {当前人数} {最大游玩人数} ”
            client.ShowRooms = (str) =>
            {
                MatchCollection matches = regex.Matches(str);
                for(int i = 0; (5 * i) < matches.Count; i++)
                {
                    Rooms.Add(Int32.Parse(matches[5 * i].Value), matches[5 * i + 1].Value);
                    if(uiDataGridViewRoomInfo.Rows.Count <= i+1) this.uiDataGridViewRoomInfo.AddRow();
                    this.uiDataGridViewRoomInfo.Rows[i].Cells[0].Value = matches[5*i].Value;
                    this.uiDataGridViewRoomInfo.Rows[i].Cells[1].Value = matches[5*i + 1].Value;
                    if (matches[5 * i + 2].Value=="False")
                    {
                        this.uiDataGridViewRoomInfo.Rows[i].Cells[2].Value = "未开始";
                    }
                    else
                    {
                        this.uiDataGridViewRoomInfo.Rows[i].Cells[2].Value = "已开始";
                    }
                    this.uiDataGridViewRoomInfo.Rows[i].Cells[3].Value = matches[5*i + 3].Value;
                    this.uiDataGridViewRoomInfo.Rows[i].Cells[4].Value = matches[5*i + 4].Value;
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
            if (this.uiTextBoxRoomID.Text.Length == 0)
            {
                InfoForm infoForm = new InfoForm("请选择房间");
                infoForm.ShowDialog();
            }
            else
            {
                RoomName = Rooms[RoomID];
                client.JoinRoom(RoomID);
            }

        }
        private void IndexSet(object sender, int index)
        {
            try
            {
                int roomID = Int32.Parse((String)this.uiDataGridViewRoomInfo.Rows[index].Cells[0].Value);
                RoomID = roomID;
                this.uiTextBoxRoomID.Text = RoomID.ToString();
            }
            catch(Exception e) { }
        }

        //创建并展示等待界面的窗口
        public void ShowWaitingRoom(string str)
        {
            this.Invoke(new Action(delegate ()
            {
                WaitingRoom form = new WaitingRoom(client,RoomID,RoomName,Type,str);
                this.Hide();
                form.Show();
                this.Dispose();
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
        public void test()
        {
           
        }

        private void uiDataGridViewRoomInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
