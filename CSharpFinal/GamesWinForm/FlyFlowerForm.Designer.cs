using System.Drawing;
using System.Windows.Forms;

namespace GameWinForm
{
    partial class FlyFlowerForm
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
            this.uiPanelGameWin = new Sunny.UI.UIPanel();
            this.pictureBoxAnswer = new System.Windows.Forms.PictureBox();
            this.panelAnswerWin = new System.Windows.Forms.Panel();
            this.uiLabelAnswerPlayer = new Sunny.UI.UILabel();
            this.uiTextBoxAnswer = new Sunny.UI.UITextBox();
            this.uiButtonSend = new Sunny.UI.UIButton();
            this.uiLabelAnswer = new Sunny.UI.UILabel();
            this.uiPanelPlayers = new Sunny.UI.UIPanel();
            this.uiPanelPlayerBox = new Sunny.UI.UIPanel();
            this.uiDataGridViewPlayers = new Sunny.UI.UIDataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainPlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanelTimer = new Sunny.UI.UIPanel();
            this.uiLabelTimer = new Sunny.UI.UILabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.uiPanelWindow.SuspendLayout();
            this.uiPanelGameWin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).BeginInit();
            this.panelAnswerWin.SuspendLayout();
            this.uiPanelPlayers.SuspendLayout();
            this.uiPanelPlayerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainPlayerBindingSource)).BeginInit();
            this.uiPanelTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelWindow
            // 
            this.uiPanelWindow.Controls.Add(this.uiPanelGameWin);
            this.uiPanelWindow.Controls.Add(this.uiPanelPlayers);
            this.uiPanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelWindow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelWindow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelWindow.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelWindow.Location = new System.Drawing.Point(0, 0);
            this.uiPanelWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiPanelWindow.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiPanelWindow.Name = "uiPanelWindow";
            this.uiPanelWindow.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelWindow.Size = new System.Drawing.Size(1526, 1136);
            this.uiPanelWindow.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelWindow.TabIndex = 0;
            this.uiPanelWindow.Text = null;
            this.uiPanelWindow.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelWindow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelGameWin
            // 
            this.uiPanelGameWin.BackColor = System.Drawing.SystemColors.Control;
            this.uiPanelGameWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPanelGameWin.Controls.Add(this.pictureBoxAnswer);
            this.uiPanelGameWin.Controls.Add(this.panelAnswerWin);
            this.uiPanelGameWin.Controls.Add(this.uiLabelAnswer);
            this.uiPanelGameWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelGameWin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelGameWin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelGameWin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelGameWin.Location = new System.Drawing.Point(0, 0);
            this.uiPanelGameWin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelGameWin.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelGameWin.Name = "uiPanelGameWin";
            this.uiPanelGameWin.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelGameWin.Size = new System.Drawing.Size(1353, 1136);
            this.uiPanelGameWin.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelGameWin.TabIndex = 1;
            this.uiPanelGameWin.Text = null;
            this.uiPanelGameWin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelGameWin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pictureBoxAnswer
            // 
            this.pictureBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAnswer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAnswer.Location = new System.Drawing.Point(249, 310);
            this.pictureBoxAnswer.Name = "pictureBoxAnswer";
            this.pictureBoxAnswer.Size = new System.Drawing.Size(856, 98);
            this.pictureBoxAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAnswer.TabIndex = 2;
            this.pictureBoxAnswer.TabStop = false;
            // 
            // panelAnswerWin
            // 
            this.panelAnswerWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panelAnswerWin.Controls.Add(this.uiLabelAnswerPlayer);
            this.panelAnswerWin.Controls.Add(this.uiTextBoxAnswer);
            this.panelAnswerWin.Controls.Add(this.uiButtonSend);
            this.panelAnswerWin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAnswerWin.Location = new System.Drawing.Point(0, 1016);
            this.panelAnswerWin.Name = "panelAnswerWin";
            this.panelAnswerWin.Size = new System.Drawing.Size(1353, 120);
            this.panelAnswerWin.TabIndex = 1;
            // 
            // uiLabelAnswerPlayer
            // 
            this.uiLabelAnswerPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabelAnswerPlayer.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelAnswerPlayer.Font = new System.Drawing.Font("华文行楷", 20F);
            this.uiLabelAnswerPlayer.Location = new System.Drawing.Point(55, 12);
            this.uiLabelAnswerPlayer.Name = "uiLabelAnswerPlayer";
            this.uiLabelAnswerPlayer.Size = new System.Drawing.Size(1253, 30);
            this.uiLabelAnswerPlayer.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabelAnswerPlayer.TabIndex = 2;
            this.uiLabelAnswerPlayer.Text = "作答人：";
            this.uiLabelAnswerPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabelAnswerPlayer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBoxAnswer
            // 
            this.uiTextBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTextBoxAnswer.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBoxAnswer.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiTextBoxAnswer.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiTextBoxAnswer.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBoxAnswer.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiTextBoxAnswer.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiTextBoxAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxAnswer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiTextBoxAnswer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBoxAnswer.Location = new System.Drawing.Point(145, 56);
            this.uiTextBoxAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxAnswer.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxAnswer.Name = "uiTextBoxAnswer";
            this.uiTextBoxAnswer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBoxAnswer.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBoxAnswer.ShowText = false;
            this.uiTextBoxAnswer.Size = new System.Drawing.Size(1055, 36);
            this.uiTextBoxAnswer.Style = Sunny.UI.UIStyle.Orange;
            this.uiTextBoxAnswer.TabIndex = 1;
            this.uiTextBoxAnswer.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxAnswer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButtonSend
            // 
            this.uiButtonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiButtonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonSend.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonSend.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButtonSend.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonSend.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonSend.Font = new System.Drawing.Font("华文行楷", 20F);
            this.uiButtonSend.Location = new System.Drawing.Point(1234, 56);
            this.uiButtonSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonSend.Name = "uiButtonSend";
            this.uiButtonSend.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonSend.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButtonSend.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonSend.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonSend.Size = new System.Drawing.Size(88, 36);
            this.uiButtonSend.Style = Sunny.UI.UIStyle.Orange;
            this.uiButtonSend.TabIndex = 0;
            this.uiButtonSend.Text = "确 定";
            this.uiButtonSend.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonSend.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButtonSend.Click += new System.EventHandler(this.uiButtonSend_Click);
            // 
            // uiLabelAnswer
            // 
            this.uiLabelAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabelAnswer.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelAnswer.Font = new System.Drawing.Font("华文行楷", 30F);
            this.uiLabelAnswer.Location = new System.Drawing.Point(12, 223);
            this.uiLabelAnswer.Name = "uiLabelAnswer";
            this.uiLabelAnswer.Size = new System.Drawing.Size(1322, 116);
            this.uiLabelAnswer.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabelAnswer.TabIndex = 0;
            this.uiLabelAnswer.Text = "\r\n";
            this.uiLabelAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabelAnswer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelPlayers
            // 
            this.uiPanelPlayers.Controls.Add(this.uiPanelPlayerBox);
            this.uiPanelPlayers.Controls.Add(this.uiPanelTimer);
            this.uiPanelPlayers.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanelPlayers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelPlayers.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelPlayers.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelPlayers.Location = new System.Drawing.Point(1353, 0);
            this.uiPanelPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelPlayers.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelPlayers.Name = "uiPanelPlayers";
            this.uiPanelPlayers.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelPlayers.Size = new System.Drawing.Size(173, 1136);
            this.uiPanelPlayers.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelPlayers.TabIndex = 0;
            this.uiPanelPlayers.Text = "剩余玩家";
            this.uiPanelPlayers.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelPlayers.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelPlayerBox
            // 
            this.uiPanelPlayerBox.Controls.Add(this.uiDataGridViewPlayers);
            this.uiPanelPlayerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelPlayerBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelPlayerBox.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelPlayerBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelPlayerBox.Location = new System.Drawing.Point(0, 123);
            this.uiPanelPlayerBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelPlayerBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelPlayerBox.Name = "uiPanelPlayerBox";
            this.uiPanelPlayerBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelPlayerBox.Size = new System.Drawing.Size(173, 1013);
            this.uiPanelPlayerBox.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelPlayerBox.TabIndex = 1;
            this.uiPanelPlayerBox.Text = null;
            this.uiPanelPlayerBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelPlayerBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDataGridViewPlayers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewPlayers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridViewPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDataGridViewPlayers.AutoGenerateColumns = false;
            this.uiDataGridViewPlayers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridViewPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridViewPlayers.ColumnHeadersHeight = 30;
            this.uiDataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.uiDataGridViewPlayers.DataSource = this.remainPlayerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridViewPlayers.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridViewPlayers.EnableHeadersVisualStyles = false;
            this.uiDataGridViewPlayers.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridViewPlayers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(69)))));
            this.uiDataGridViewPlayers.Location = new System.Drawing.Point(9, 8);
            this.uiDataGridViewPlayers.Name = "uiDataGridViewPlayers";
            this.uiDataGridViewPlayers.ReadOnly = true;
            this.uiDataGridViewPlayers.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridViewPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridViewPlayers.RowHeadersWidth = 40;
            this.uiDataGridViewPlayers.RowHeight = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridViewPlayers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridViewPlayers.RowTemplate.Height = 40;
            this.uiDataGridViewPlayers.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewPlayers.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiDataGridViewPlayers.SelectedIndex = -1;
            this.uiDataGridViewPlayers.Size = new System.Drawing.Size(154, 977);
            this.uiDataGridViewPlayers.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewPlayers.Style = Sunny.UI.UIStyle.Orange;
            this.uiDataGridViewPlayers.TabIndex = 2;
            this.uiDataGridViewPlayers.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "剩余玩家";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remainPlayerBindingSource
            // 
            this.remainPlayerBindingSource.DataSource = typeof(GameWinForm.RemainPlayer);
            // 
            // uiPanelTimer
            // 
            this.uiPanelTimer.Controls.Add(this.uiLabelTimer);
            this.uiPanelTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelTimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelTimer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelTimer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelTimer.Location = new System.Drawing.Point(0, 0);
            this.uiPanelTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelTimer.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelTimer.Name = "uiPanelTimer";
            this.uiPanelTimer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelTimer.Size = new System.Drawing.Size(173, 123);
            this.uiPanelTimer.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelTimer.TabIndex = 0;
            this.uiPanelTimer.Text = null;
            this.uiPanelTimer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelTimer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabelTimer
            // 
            this.uiLabelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabelTimer.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelTimer.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.uiLabelTimer.Location = new System.Drawing.Point(38, 35);
            this.uiLabelTimer.Name = "uiLabelTimer";
            this.uiLabelTimer.Size = new System.Drawing.Size(95, 58);
            this.uiLabelTimer.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabelTimer.TabIndex = 2;
            this.uiLabelTimer.Text = "0:30";
            this.uiLabelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabelTimer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FlyFlowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1526, 1136);
            this.Controls.Add(this.uiPanelWindow);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1552, 1207);
            this.MinimumSize = new System.Drawing.Size(1552, 1207);
            this.Name = "FlyFlowerForm";
            this.Text = "FlyFlowerForm";
            this.Load += new System.EventHandler(this.FlyFlowerForm_Load);
            this.uiPanelWindow.ResumeLayout(false);
            this.uiPanelGameWin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).EndInit();
            this.panelAnswerWin.ResumeLayout(false);
            this.uiPanelPlayers.ResumeLayout(false);
            this.uiPanelPlayerBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainPlayerBindingSource)).EndInit();
            this.uiPanelTimer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanelWindow;
        private Sunny.UI.UIPanel uiPanelPlayers;
        private Sunny.UI.UIPanel uiPanelGameWin;
        private Sunny.UI.UILabel uiLabelTimer;
        private Sunny.UI.UIPanel uiPanelPlayerBox;
        private Sunny.UI.UIPanel uiPanelTimer;
        private Sunny.UI.UILabel uiLabelAnswer;
        private Panel panelAnswerWin;
        private Sunny.UI.UITextBox uiTextBoxAnswer;
        private Sunny.UI.UIButton uiButtonSend;
        private Sunny.UI.UILabel uiLabelAnswerPlayer;
        private Sunny.UI.UIDataGridView uiDataGridViewPlayers;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource remainPlayerBindingSource;
        private Timer timer;
        private PictureBox pictureBoxAnswer;
    }
}