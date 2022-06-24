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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanelWindow = new Sunny.UI.UIPanel();
            this.uiPanelRoom = new Sunny.UI.UIPanel();
            this.uiPanelRoomInfo = new Sunny.UI.UIPanel();
            this.uiDataGridViewRoomInfo = new Sunny.UI.UIDataGridView();
            this.uiPanelButtons = new Sunny.UI.UIPanel();
            this.uiPanelEnter = new Sunny.UI.UIPanel();
            this.uiButtonEnter = new Sunny.UI.UIButton();
            this.uiPanelFreshCreate = new Sunny.UI.UIPanel();
            this.uiButtonFresh = new Sunny.UI.UIButton();
            this.uiButtonCreate = new Sunny.UI.UIButton();
            this.uiPanelTitle = new Sunny.UI.UIPanel();
            this.uiLabelGameName = new Sunny.UI.UILabel();
            this.CurrentPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiLabelRoomID = new Sunny.UI.UILabel();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanelWindow.SuspendLayout();
            this.uiPanelRoom.SuspendLayout();
            this.uiPanelRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewRoomInfo)).BeginInit();
            this.uiPanelButtons.SuspendLayout();
            this.uiPanelEnter.SuspendLayout();
            this.uiPanelFreshCreate.SuspendLayout();
            this.uiPanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanelWindow
            // 
            this.uiPanelWindow.Controls.Add(this.uiPanelRoom);
            this.uiPanelWindow.Controls.Add(this.uiPanelTitle);
            this.uiPanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelWindow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelWindow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelWindow.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelWindow.Location = new System.Drawing.Point(0, 0);
            this.uiPanelWindow.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanelWindow.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelWindow.Name = "uiPanelWindow";
            this.uiPanelWindow.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelWindow.Size = new System.Drawing.Size(985, 599);
            this.uiPanelWindow.Style = Sunny.UI.UIStyle.Orange;
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
            this.uiPanelRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelRoom.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelRoom.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelRoom.Location = new System.Drawing.Point(0, 71);
            this.uiPanelRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelRoom.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelRoom.Name = "uiPanelRoom";
            this.uiPanelRoom.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelRoom.Size = new System.Drawing.Size(985, 528);
            this.uiPanelRoom.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelRoom.TabIndex = 2;
            this.uiPanelRoom.Text = "uiPanelRoom";
            this.uiPanelRoom.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelRoom.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelRoomInfo
            // 
            this.uiPanelRoomInfo.Controls.Add(this.uiDataGridViewRoomInfo);
            this.uiPanelRoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelRoomInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelRoomInfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelRoomInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelRoomInfo.Location = new System.Drawing.Point(0, 0);
            this.uiPanelRoomInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelRoomInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelRoomInfo.Name = "uiPanelRoomInfo";
            this.uiPanelRoomInfo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelRoomInfo.Size = new System.Drawing.Size(743, 528);
            this.uiPanelRoomInfo.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelRoomInfo.TabIndex = 1;
            this.uiPanelRoomInfo.Text = "uiPanelRoomInfo";
            this.uiPanelRoomInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelRoomInfo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDataGridViewRoomInfo
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewRoomInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.uiDataGridViewRoomInfo.AutoGenerateColumns = false;
            this.uiDataGridViewRoomInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewRoomInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridViewRoomInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.uiDataGridViewRoomInfo.ColumnHeadersHeight = 30;
            this.uiDataGridViewRoomInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridViewRoomInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.CurrentPlayer,
            this.MaxPlayer});
            this.uiDataGridViewRoomInfo.DataSource = this.roomInfoBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridViewRoomInfo.DefaultCellStyle = dataGridViewCellStyle18;
            this.uiDataGridViewRoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridViewRoomInfo.EnableHeadersVisualStyles = false;
            this.uiDataGridViewRoomInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridViewRoomInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(69)))));
            this.uiDataGridViewRoomInfo.Location = new System.Drawing.Point(0, 0);
            this.uiDataGridViewRoomInfo.Name = "uiDataGridViewRoomInfo";
            this.uiDataGridViewRoomInfo.ReadOnly = true;
            this.uiDataGridViewRoomInfo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridViewRoomInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.uiDataGridViewRoomInfo.RowHeadersWidth = 90;
            this.uiDataGridViewRoomInfo.RowHeight = 30;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridViewRoomInfo.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.uiDataGridViewRoomInfo.RowTemplate.Height = 30;
            this.uiDataGridViewRoomInfo.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewRoomInfo.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiDataGridViewRoomInfo.SelectedIndex = -1;
            this.uiDataGridViewRoomInfo.Size = new System.Drawing.Size(743, 528);
            this.uiDataGridViewRoomInfo.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewRoomInfo.Style = Sunny.UI.UIStyle.Orange;
            this.uiDataGridViewRoomInfo.TabIndex = 0;
            this.uiDataGridViewRoomInfo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiDataGridViewRoomInfo.SelectIndexChange += new Sunny.UI.UIDataGridView.OnSelectIndexChange(this.IndexSet);
            // 
            // uiPanelButtons
            // 
            this.uiPanelButtons.Controls.Add(this.uiPanelEnter);
            this.uiPanelButtons.Controls.Add(this.uiPanelFreshCreate);
            this.uiPanelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanelButtons.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelButtons.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelButtons.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelButtons.Location = new System.Drawing.Point(743, 0);
            this.uiPanelButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelButtons.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelButtons.Name = "uiPanelButtons";
            this.uiPanelButtons.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelButtons.Size = new System.Drawing.Size(242, 528);
            this.uiPanelButtons.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelButtons.TabIndex = 0;
            this.uiPanelButtons.Text = "uiPanelButtons";
            this.uiPanelButtons.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelButtons.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelEnter
            // 
            this.uiPanelEnter.Controls.Add(this.uiLabelRoomID);
            this.uiPanelEnter.Controls.Add(this.uiButtonEnter);
            this.uiPanelEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelEnter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelEnter.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelEnter.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelEnter.Location = new System.Drawing.Point(0, 241);
            this.uiPanelEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelEnter.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelEnter.Name = "uiPanelEnter";
            this.uiPanelEnter.Radius = 2;
            this.uiPanelEnter.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelEnter.Size = new System.Drawing.Size(242, 287);
            this.uiPanelEnter.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelEnter.TabIndex = 2;
            this.uiPanelEnter.Text = null;
            this.uiPanelEnter.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelEnter.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButtonEnter
            // 
            this.uiButtonEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiButtonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonEnter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonEnter.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonEnter.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButtonEnter.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonEnter.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonEnter.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButtonEnter.Location = new System.Drawing.Point(66, 146);
            this.uiButtonEnter.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonEnter.Name = "uiButtonEnter";
            this.uiButtonEnter.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonEnter.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButtonEnter.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonEnter.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonEnter.Size = new System.Drawing.Size(108, 39);
            this.uiButtonEnter.Style = Sunny.UI.UIStyle.Orange;
            this.uiButtonEnter.TabIndex = 1;
            this.uiButtonEnter.Text = "加入房间";
            this.uiButtonEnter.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonEnter.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButtonEnter.Click += new System.EventHandler(this.uiButtonEnter_Click);
            // 
            // uiPanelFreshCreate
            // 
            this.uiPanelFreshCreate.Controls.Add(this.uiButtonFresh);
            this.uiPanelFreshCreate.Controls.Add(this.uiButtonCreate);
            this.uiPanelFreshCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelFreshCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelFreshCreate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelFreshCreate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelFreshCreate.Location = new System.Drawing.Point(0, 0);
            this.uiPanelFreshCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelFreshCreate.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelFreshCreate.Name = "uiPanelFreshCreate";
            this.uiPanelFreshCreate.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelFreshCreate.Size = new System.Drawing.Size(242, 241);
            this.uiPanelFreshCreate.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelFreshCreate.TabIndex = 1;
            this.uiPanelFreshCreate.Text = null;
            this.uiPanelFreshCreate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelFreshCreate.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButtonFresh
            // 
            this.uiButtonFresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiButtonFresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonFresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonFresh.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonFresh.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButtonFresh.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonFresh.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonFresh.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButtonFresh.Location = new System.Drawing.Point(56, 72);
            this.uiButtonFresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonFresh.Name = "uiButtonFresh";
            this.uiButtonFresh.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonFresh.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButtonFresh.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonFresh.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonFresh.Size = new System.Drawing.Size(130, 35);
            this.uiButtonFresh.Style = Sunny.UI.UIStyle.Orange;
            this.uiButtonFresh.TabIndex = 4;
            this.uiButtonFresh.Text = "刷新列表";
            this.uiButtonFresh.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonFresh.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButtonFresh.Click += new System.EventHandler(this.uiButtonFresh_Click);
            // 
            // uiButtonCreate
            // 
            this.uiButtonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiButtonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonCreate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonCreate.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButtonCreate.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonCreate.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonCreate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButtonCreate.Location = new System.Drawing.Point(56, 132);
            this.uiButtonCreate.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonCreate.Name = "uiButtonCreate";
            this.uiButtonCreate.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonCreate.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButtonCreate.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonCreate.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonCreate.Size = new System.Drawing.Size(130, 35);
            this.uiButtonCreate.Style = Sunny.UI.UIStyle.Orange;
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
            this.uiPanelTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelTitle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelTitle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.uiPanelTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelTitle.Name = "uiPanelTitle";
            this.uiPanelTitle.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelTitle.Size = new System.Drawing.Size(985, 71);
            this.uiPanelTitle.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelTitle.TabIndex = 1;
            this.uiPanelTitle.Text = null;
            this.uiPanelTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelTitle.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabelGameName
            // 
            this.uiLabelGameName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabelGameName.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelGameName.Font = new System.Drawing.Font("华文行楷", 40F);
            this.uiLabelGameName.Location = new System.Drawing.Point(266, 9);
            this.uiLabelGameName.Name = "uiLabelGameName";
            this.uiLabelGameName.Size = new System.Drawing.Size(444, 57);
            this.uiLabelGameName.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabelGameName.TabIndex = 0;
            this.uiLabelGameName.Text = "飞  花  令";
            this.uiLabelGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabelGameName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // CurrentPlayer
            // 
            this.CurrentPlayer.DataPropertyName = "CurrentPlayer";
            this.CurrentPlayer.HeaderText = "当前人数";
            this.CurrentPlayer.MinimumWidth = 100;
            this.CurrentPlayer.Name = "CurrentPlayer";
            this.CurrentPlayer.ReadOnly = true;
            // 
            // MaxPlayer
            // 
            this.MaxPlayer.DataPropertyName = "MaxPlayer";
            this.MaxPlayer.HeaderText = "最大人数";
            this.MaxPlayer.MinimumWidth = 100;
            this.MaxPlayer.Name = "MaxPlayer";
            this.MaxPlayer.ReadOnly = true;
            // 
            // uiLabelRoomID
            // 
            this.uiLabelRoomID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabelRoomID.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelRoomID.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabelRoomID.Location = new System.Drawing.Point(62, 92);
            this.uiLabelRoomID.Name = "uiLabelRoomID";
            this.uiLabelRoomID.Size = new System.Drawing.Size(153, 27);
            this.uiLabelRoomID.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabelRoomID.TabIndex = 3;
            this.uiLabelRoomID.Text = "ID: 无";
            this.uiLabelRoomID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabelRoomID.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "房间号";
            this.roomIDDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "房间状态";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomInfoBindingSource
            // 
            this.roomInfoBindingSource.DataSource = typeof(GameWinForm.RoomInfo);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(985, 599);
            this.Controls.Add(this.uiPanelWindow);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1001, 638);
            this.MinimumSize = new System.Drawing.Size(1001, 638);
            this.Name = "RoomForm";
            this.Text = "  ";
            this.uiPanelWindow.ResumeLayout(false);
            this.uiPanelRoom.ResumeLayout(false);
            this.uiPanelRoomInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewRoomInfo)).EndInit();
            this.uiPanelButtons.ResumeLayout(false);
            this.uiPanelEnter.ResumeLayout(false);
            this.uiPanelFreshCreate.ResumeLayout(false);
            this.uiPanelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomInfoBindingSource)).EndInit();
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
        private DataGridViewTextBoxColumn playerNumDataGridViewTextBoxColumn;
        private Sunny.UI.UIPanel uiPanelFreshCreate;
        private Sunny.UI.UIPanel uiPanelEnter;
        private Sunny.UI.UIButton uiButtonEnter;
        private Sunny.UI.UIButton uiButtonFresh;
        private Sunny.UI.UIButton uiButtonCreate;
        private DataGridViewTextBoxColumn currentPlayerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxPlayerDataGridViewTextBoxColumn;
        private BindingSource roomInfoBindingSource;
        private DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CurrentPlayer;
        private DataGridViewTextBoxColumn MaxPlayer;
        private Sunny.UI.UILabel uiLabelRoomID;
    }
}