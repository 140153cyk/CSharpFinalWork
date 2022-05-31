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
    public partial class CreateForm : Form
    {
        public Client.Client client;
        public string RoomName { set; get; } = "";
        public int MaxNum { set; get; } = 5;
        public CreateForm(Client.Client client)
        {
            InitializeComponent();
            this.client = client;
            this.uiTextBoxName.DataBindings.Add("Text", this, "RoomName");
            this.uiTextBoxMaxNum.DataBindings.Add("Text", this, "MaxNum");
        }

        private void uiButtonCreate_Click(object sender, EventArgs e)
        {
            if (RoomName == "")
            {
                InfoForm form = new InfoForm("请输入房间名");
                form.ShowDialog();
            }
            else if(MaxNum == 0)
            {
                InfoForm form = new InfoForm("最大玩家数应大于0");
                form.ShowDialog();
            }
            else
            {
                //创建房间，并把房间名返回给RoomForm
                client.CreateRoom(RoomName, MaxNum);
                RoomForm roomForm = (RoomForm)this.Owner;
                roomForm.RoomName = RoomName;
                this.Close();
            }
        }
    }
}
