namespace DrawAndGuess
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
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rtbRoomList = new System.Windows.Forms.RichTextBox();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.btnEnterRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(1070, 664);
            this.btnCreateRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(112, 37);
            this.btnCreateRoom.TabIndex = 0;
            this.btnCreateRoom.Text = "新建房间";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(780, 19);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 37);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新房间";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // rtbRoomList
            // 
            this.rtbRoomList.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbRoomList.Location = new System.Drawing.Point(0, 0);
            this.rtbRoomList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbRoomList.Name = "rtbRoomList";
            this.rtbRoomList.Size = new System.Drawing.Size(769, 720);
            this.rtbRoomList.TabIndex = 2;
            this.rtbRoomList.Text = "";
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.Location = new System.Drawing.Point(798, 666);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(249, 35);
            this.textBoxRoomName.TabIndex = 3;
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(798, 603);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(249, 35);
            this.textBoxRoomID.TabIndex = 5;
            // 
            // btnEnterRoom
            // 
            this.btnEnterRoom.Location = new System.Drawing.Point(1070, 601);
            this.btnEnterRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnterRoom.Name = "btnEnterRoom";
            this.btnEnterRoom.Size = new System.Drawing.Size(112, 37);
            this.btnEnterRoom.TabIndex = 4;
            this.btnEnterRoom.Text = "进入房间";
            this.btnEnterRoom.UseVisualStyleBackColor = true;
            this.btnEnterRoom.Click += new System.EventHandler(this.btnEnterRoom_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.textBoxRoomID);
            this.Controls.Add(this.btnEnterRoom);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.rtbRoomList);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCreateRoom);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoomForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RichTextBox rtbRoomList;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.Button btnEnterRoom;
    }
}