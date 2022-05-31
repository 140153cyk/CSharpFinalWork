using Client;
using Client;
using System.Windows.Forms;

namespace GameWinForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanelWindow = new Sunny.UI.UIPanel();
            this.uiPanelRoom = new Sunny.UI.UIPanel();
            this.uiPanelRoomInfo = new Sunny.UI.UIPanel();
            this.uiDataGridViewRoomInfo = new Sunny.UI.UIDataGridView();
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPlayingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiPanelButtons = new Sunny.UI.UIPanel();
            this.uiPanelEnter = new Sunny.UI.UIPanel();
            this.uiLabelSelectedID = new Sunny.UI.UILabel();
            this.uiButtonEnter = new Sunny.UI.UIButton();
            this.uiTextBoxRoomID = new Sunny.UI.UITextBox();
            this.uiPanelFreshCreate = new Sunny.UI.UIPanel();
            this.uiButtonFresh = new Sunny.UI.UIButton();
            this.uiButtonCreate = new Sunny.UI.UIButton();
            this.uiPanelTitle = new Sunny.UI.UIPanel();
            this.uiLabelGameName = new Sunny.UI.UILabel();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanelWindow.SuspendLayout();
            this.uiPanelRoom.SuspendLayout();
            this.uiPanelRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewRoomInfo)).BeginInit();
            this.uiPanelButtons.SuspendLayout();
            this.uiPanelEnter.SuspendLayout();
            this.uiPanelFreshCreate.SuspendLayout();
            this.uiPanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanelWindow
            // 
            this.uiPanelWindow.Controls.Add(this.uiPanelRoom);
            this.uiPanelWindow.Controls.Add(this.uiPanelTitle);
            this.uiPanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelWindow.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelWindow.Location = new System.Drawing.Point(0, 0);
            this.uiPanelWindow.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanelWindow.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelWindow.Name = "uiPanelWindow";
            this.uiPanelWindow.Size = new System.Drawing.Size(985, 599);
            this.uiPanelWindow.TabIndex = 0;
            this.uiPanelWindow.Text = "uiPanel1";
            this.uiPanelWindow.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelWindow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelRoom
            // 
            this.uiPanelRoom.Controls.Add(this.uiPanelRoomInfo);
            this.uiPanelRoom.Controls.Add(this.uiPanelButtons);
            this.uiPanelRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelRoom.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelRoom.Location = new System.Drawing.Point(0, 71);
            this.uiPanelRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelRoom.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelRoom.Name = "uiPanelRoom";
            this.uiPanelRoom.Size = new System.Drawing.Size(985, 528);
            this.uiPanelRoom.TabIndex = 2;
            this.uiPanelRoom.Text = "uiPanelRoom";
            this.uiPanelRoom.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelRoom.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelRoomInfo
            // 
            this.uiPanelRoomInfo.Controls.Add(this.uiDataGridViewRoomInfo);
            this.uiPanelRoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelRoomInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelRoomInfo.Location = new System.Drawing.Point(0, 0);
            this.uiPanelRoomInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelRoomInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelRoomInfo.Name = "uiPanelRoomInfo";
            this.uiPanelRoomInfo.Size = new System.Drawing.Size(743, 528);
            this.uiPanelRoomInfo.TabIndex = 1;
            this.uiPanelRoomInfo.Text = "uiPanelRoomInfo";
            this.uiPanelRoomInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelRoomInfo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDataGridViewRoomInfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridViewRoomInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridViewRoomInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridViewRoomInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridViewRoomInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridViewRoomInfo.ColumnHeadersHeight = 30;
            this.uiDataGridViewRoomInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridViewRoomInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.isPlayingDataGridViewTextBoxColumn,
            this.CurrentNum,
            this.maxNumDataGridViewTextBoxColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridViewRoomInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridViewRoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridViewRoomInfo.EnableHeadersVisualStyles = false;
            this.uiDataGridViewRoomInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridViewRoomInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.uiDataGridViewRoomInfo.Location = new System.Drawing.Point(0, 0);
            this.uiDataGridViewRoomInfo.Name = "uiDataGridViewRoomInfo";
            this.uiDataGridViewRoomInfo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridViewRoomInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridViewRoomInfo.RowHeadersWidth = 90;
            this.uiDataGridViewRoomInfo.RowHeight = 30;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridViewRoomInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridViewRoomInfo.RowTemplate.Height = 30;
            this.uiDataGridViewRoomInfo.SelectedIndex = -1;
            this.uiDataGridViewRoomInfo.Size = new System.Drawing.Size(743, 528);
            this.uiDataGridViewRoomInfo.TabIndex = 0;
            this.uiDataGridViewRoomInfo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiDataGridViewRoomInfo.SelectIndexChange += new Sunny.UI.UIDataGridView.OnSelectIndexChange(this.IndexSet);
            this.uiDataGridViewRoomInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridViewRoomInfo_CellContentClick);
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "房间号";
            this.roomIdDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            this.roomIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "房间名";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isPlayingDataGridViewTextBoxColumn
            // 
            this.isPlayingDataGridViewTextBoxColumn.DataPropertyName = "IsPlaying";
            this.isPlayingDataGridViewTextBoxColumn.HeaderText = "状态";
            this.isPlayingDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.isPlayingDataGridViewTextBoxColumn.Name = "isPlayingDataGridViewTextBoxColumn";
            this.isPlayingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CurrentNum
            // 
            this.CurrentNum.DataPropertyName = "CurrentNum";
            this.CurrentNum.HeaderText = "当前玩家数";
            this.CurrentNum.MinimumWidth = 150;
            this.CurrentNum.Name = "CurrentNum";
            this.CurrentNum.ReadOnly = true;
            this.CurrentNum.Width = 150;
            // 
            // maxNumDataGridViewTextBoxColumn
            // 
            this.maxNumDataGridViewTextBoxColumn.DataPropertyName = "MaxNum";
            this.maxNumDataGridViewTextBoxColumn.HeaderText = "最大玩家数";
            this.maxNumDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.maxNumDataGridViewTextBoxColumn.Name = "maxNumDataGridViewTextBoxColumn";
            this.maxNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxNumDataGridViewTextBoxColumn.Width = 150;
            // 
            // uiPanelButtons
            // 
            this.uiPanelButtons.Controls.Add(this.uiPanelEnter);
            this.uiPanelButtons.Controls.Add(this.uiPanelFreshCreate);
            this.uiPanelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanelButtons.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelButtons.Location = new System.Drawing.Point(743, 0);
            this.uiPanelButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelButtons.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelButtons.Name = "uiPanelButtons";
            this.uiPanelButtons.Size = new System.Drawing.Size(242, 528);
            this.uiPanelButtons.TabIndex = 0;
            this.uiPanelButtons.Text = "uiPanelButtons";
            this.uiPanelButtons.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelButtons.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelEnter
            // 
            this.uiPanelEnter.Controls.Add(this.uiLabelSelectedID);
            this.uiPanelEnter.Controls.Add(this.uiButtonEnter);
            this.uiPanelEnter.Controls.Add(this.uiTextBoxRoomID);
            this.uiPanelEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelEnter.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelEnter.Location = new System.Drawing.Point(0, 241);
            this.uiPanelEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelEnter.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelEnter.Name = "uiPanelEnter";
            this.uiPanelEnter.Radius = 2;
            this.uiPanelEnter.Size = new System.Drawing.Size(242, 287);
            this.uiPanelEnter.TabIndex = 2;
            this.uiPanelEnter.Text = null;
            this.uiPanelEnter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelEnter.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabelSelectedID
            // 
            this.uiLabelSelectedID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabelSelectedID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabelSelectedID.Location = new System.Drawing.Point(62, 40);
            this.uiLabelSelectedID.Name = "uiLabelSelectedID";
            this.uiLabelSelectedID.Size = new System.Drawing.Size(112, 42);
            this.uiLabelSelectedID.TabIndex = 2;
            this.uiLabelSelectedID.Text = "当前所选ID：";
            this.uiLabelSelectedID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabelSelectedID.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButtonEnter
            // 
            this.uiButtonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonEnter.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButtonEnter.Location = new System.Drawing.Point(66, 146);
            this.uiButtonEnter.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonEnter.Name = "uiButtonEnter";
            this.uiButtonEnter.Size = new System.Drawing.Size(108, 39);
            this.uiButtonEnter.TabIndex = 1;
            this.uiButtonEnter.Text = "加入房间";
            this.uiButtonEnter.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonEnter.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButtonEnter.Click += new System.EventHandler(this.uiButtonEnter_Click);
            // 
            // uiTextBoxRoomID
            // 
            this.uiTextBoxRoomID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTextBoxRoomID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxRoomID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBoxRoomID.Location = new System.Drawing.Point(66, 87);
            this.uiTextBoxRoomID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxRoomID.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxRoomID.Name = "uiTextBoxRoomID";
            this.uiTextBoxRoomID.ShowText = false;
            this.uiTextBoxRoomID.Size = new System.Drawing.Size(108, 34);
            this.uiTextBoxRoomID.TabIndex = 0;
            this.uiTextBoxRoomID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxRoomID.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelFreshCreate
            // 
            this.uiPanelFreshCreate.Controls.Add(this.uiButtonFresh);
            this.uiPanelFreshCreate.Controls.Add(this.uiButtonCreate);
            this.uiPanelFreshCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelFreshCreate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelFreshCreate.Location = new System.Drawing.Point(0, 0);
            this.uiPanelFreshCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelFreshCreate.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelFreshCreate.Name = "uiPanelFreshCreate";
            this.uiPanelFreshCreate.Size = new System.Drawing.Size(242, 241);
            this.uiPanelFreshCreate.TabIndex = 1;
            this.uiPanelFreshCreate.Text = null;
            this.uiPanelFreshCreate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelFreshCreate.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButtonFresh
            // 
            this.uiButtonFresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonFresh.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButtonFresh.Location = new System.Drawing.Point(56, 72);
            this.uiButtonFresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonFresh.Name = "uiButtonFresh";
            this.uiButtonFresh.Size = new System.Drawing.Size(130, 35);
            this.uiButtonFresh.TabIndex = 4;
            this.uiButtonFresh.Text = "刷新列表";
            this.uiButtonFresh.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonFresh.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButtonFresh.Click += new System.EventHandler(this.uiButtonFresh_Click);
            // 
            // uiButtonCreate
            // 
            this.uiButtonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonCreate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButtonCreate.Location = new System.Drawing.Point(56, 132);
            this.uiButtonCreate.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonCreate.Name = "uiButtonCreate";
            this.uiButtonCreate.Size = new System.Drawing.Size(130, 35);
            this.uiButtonCreate.TabIndex = 3;
            this.uiButtonCreate.Text = "创建房间";
            this.uiButtonCreate.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonCreate.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButtonCreate.Click += new System.EventHandler(this.uiButtonCreate_Click);
            // 
            // uiPanelTitle
            // 
            this.uiPanelTitle.Controls.Add(this.uiLabelGameName);
            this.uiPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelTitle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.uiPanelTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelTitle.Name = "uiPanelTitle";
            this.uiPanelTitle.Size = new System.Drawing.Size(985, 71);
            this.uiPanelTitle.TabIndex = 1;
            this.uiPanelTitle.Text = "uiPanel1";
            this.uiPanelTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelTitle.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabelGameName
            // 
            this.uiLabelGameName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabelGameName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabelGameName.Font = new System.Drawing.Font("华文行楷", 40F);
            this.uiLabelGameName.Location = new System.Drawing.Point(266, 9);
            this.uiLabelGameName.Name = "uiLabelGameName";
            this.uiLabelGameName.Size = new System.Drawing.Size(444, 57);
            this.uiLabelGameName.TabIndex = 0;
            this.uiLabelGameName.Text = "飞  花  令";
            this.uiLabelGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabelGameName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(GameWinForm.Room);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(985, 599);
            this.Controls.Add(this.uiPanelWindow);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(782, 453);
            this.Name = "RoomForm";
            this.Text = "飞花令";
            this.uiPanelWindow.ResumeLayout(false);
            this.uiPanelRoom.ResumeLayout(false);
            this.uiPanelRoomInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewRoomInfo)).EndInit();
            this.uiPanelButtons.ResumeLayout(false);
            this.uiPanelEnter.ResumeLayout(false);
            this.uiPanelFreshCreate.ResumeLayout(false);
            this.uiPanelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanelWindow;
        private Sunny.UI.UIPanel uiPanelTitle;
        private Sunny.UI.UILabel uiLabelGameName;
        private Sunny.UI.UIPanel uiPanelRoom;
        private Sunny.UI.UIPanel uiPanelRoomInfo;
        private Sunny.UI.UIPanel uiPanelButtons;
        private Sunny.UI.UIDataGridView uiDataGridViewRoomInfo;
        private BindingSource roomBindingSource;
        private DataGridViewTextBoxColumn playerNumDataGridViewTextBoxColumn;
        private Sunny.UI.UIPanel uiPanelFreshCreate;
        private Sunny.UI.UIPanel uiPanelEnter;
        private Sunny.UI.UILabel uiLabelSelectedID;
        private Sunny.UI.UIButton uiButtonEnter;
        private Sunny.UI.UITextBox uiTextBoxRoomID;
        private Sunny.UI.UIButton uiButtonFresh;
        private Sunny.UI.UIButton uiButtonCreate;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isPlayingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CurrentNum;
        private DataGridViewTextBoxColumn maxNumDataGridViewTextBoxColumn;
    }
}