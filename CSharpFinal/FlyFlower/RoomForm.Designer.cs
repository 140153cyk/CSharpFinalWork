namespace FlyFlower
{
    partial class RoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.btnCreateRooms = new Sunny.UI.UIButton();
            this.btnRefreshRooms = new Sunny.UI.UIButton();
            this.btnJoinRoom = new Sunny.UI.UIButton();
            this.lbRooms = new Sunny.UI.UIListBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // btnCreateRooms
            // 
            this.btnCreateRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateRooms.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreateRooms.Location = new System.Drawing.Point(820, 1);
            this.btnCreateRooms.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCreateRooms.Name = "btnCreateRooms";
            this.btnCreateRooms.Size = new System.Drawing.Size(100, 35);
            this.btnCreateRooms.TabIndex = 0;
            this.btnCreateRooms.Text = "新建房间";
            this.btnCreateRooms.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreateRooms.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCreateRooms.Click += new System.EventHandler(this.btnCreateRooms_Click);
            // 
            // btnRefreshRooms
            // 
            this.btnRefreshRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshRooms.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefreshRooms.Location = new System.Drawing.Point(820, 83);
            this.btnRefreshRooms.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefreshRooms.Name = "btnRefreshRooms";
            this.btnRefreshRooms.Size = new System.Drawing.Size(100, 35);
            this.btnRefreshRooms.TabIndex = 1;
            this.btnRefreshRooms.Text = "刷新列表";
            this.btnRefreshRooms.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefreshRooms.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnRefreshRooms.Click += new System.EventHandler(this.btnRefreshRooms_Click);
            // 
            // btnJoinRoom
            // 
            this.btnJoinRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJoinRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJoinRoom.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJoinRoom.Location = new System.Drawing.Point(820, 42);
            this.btnJoinRoom.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnJoinRoom.Name = "btnJoinRoom";
            this.btnJoinRoom.Size = new System.Drawing.Size(100, 35);
            this.btnJoinRoom.TabIndex = 2;
            this.btnJoinRoom.Text = "加入房间";
            this.btnJoinRoom.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJoinRoom.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnJoinRoom.Click += new System.EventHandler(this.btnJoinRoom_Click);
            // 
            // lbRooms
            // 
            this.lbRooms.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRooms.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lbRooms.ItemSelectForeColor = System.Drawing.Color.White;
            this.lbRooms.Location = new System.Drawing.Point(2, 42);
            this.lbRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbRooms.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbRooms.Name = "lbRooms";
            this.lbRooms.Padding = new System.Windows.Forms.Padding(2);
            this.lbRooms.ShowText = false;
            this.lbRooms.Size = new System.Drawing.Size(811, 523);
            this.lbRooms.TabIndex = 3;
            this.lbRooms.Text = "uiListBox1";
            this.lbRooms.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(2, 1);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(811, 45);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "房间ID 房间名字 游玩状态 当前玩家数量 最大玩家数量";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(923, 565);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.lbRooms);
            this.Controls.Add(this.btnJoinRoom);
            this.Controls.Add(this.btnRefreshRooms);
            this.Controls.Add(this.btnCreateRooms);
            this.Name = "RoomForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btnCreateRooms;
        private Sunny.UI.UIButton btnRefreshRooms;
        private Sunny.UI.UIButton btnJoinRoom;
        private Sunny.UI.UIListBox lbRooms;
        private Sunny.UI.UILabel uiLabel1;
    }
}