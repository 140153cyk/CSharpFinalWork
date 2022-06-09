
using System.Windows.Forms;

namespace GameWinForm
{
    partial class DrawAndGuess
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
            this.textBoxSend = new Sunny.UI.UITextBox();
            this.ColorPicker = new Sunny.UI.UIColorPicker();
            this.textBoxChat = new Sunny.UI.UITextBox();
            this.buttonSend = new Sunny.UI.UIButton();
            this.pictureBoxDrawing = new System.Windows.Forms.PictureBox();
            this.panelWindow = new Sunny.UI.UIPanel();
            this.uiPanelGameWin = new Sunny.UI.UIPanel();
            this.uiPanelDrawAndText = new Sunny.UI.UIPanel();
            this.uiPanelScore = new Sunny.UI.UIPanel();
            this.uiDataGridViewScore = new Sunny.UI.UIDataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerAndScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanelDraw = new Sunny.UI.UIPanel();
            this.uiPanelText = new Sunny.UI.UIPanel();
            this.uiPanelDrawBox = new Sunny.UI.UIPanel();
            this.uiPanelPen = new Sunny.UI.UIPanel();
            this.RadioButtonGroupPen = new Sunny.UI.UIRadioButtonGroup();
            this.uiPanelTitle = new Sunny.UI.UIPanel();
            this.labelPoem = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).BeginInit();
            this.panelWindow.SuspendLayout();
            this.uiPanelGameWin.SuspendLayout();
            this.uiPanelDrawAndText.SuspendLayout();
            this.uiPanelScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerAndScoreBindingSource)).BeginInit();
            this.uiPanelDraw.SuspendLayout();
            this.uiPanelText.SuspendLayout();
            this.uiPanelDrawBox.SuspendLayout();
            this.uiPanelPen.SuspendLayout();
            this.uiPanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSend
            // 
            this.textBoxSend.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.textBoxSend.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.textBoxSend.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.textBoxSend.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.textBoxSend.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.textBoxSend.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.textBoxSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSend.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.textBoxSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxSend.Location = new System.Drawing.Point(397, 50);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSend.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.textBoxSend.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.textBoxSend.ShowText = false;
            this.textBoxSend.Size = new System.Drawing.Size(263, 30);
            this.textBoxSend.Style = Sunny.UI.UIStyle.Orange;
            this.textBoxSend.TabIndex = 6;
            this.textBoxSend.Text = "uiTextBox1";
            this.textBoxSend.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxSend.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ColorPicker
            // 
            this.ColorPicker.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ColorPicker.FillColor = System.Drawing.Color.White;
            this.ColorPicker.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ColorPicker.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ColorPicker.Location = new System.Drawing.Point(15, 20);
            this.ColorPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColorPicker.MinimumSize = new System.Drawing.Size(63, 0);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ColorPicker.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.ColorPicker.Size = new System.Drawing.Size(63, 42);
            this.ColorPicker.Style = Sunny.UI.UIStyle.Orange;
            this.ColorPicker.TabIndex = 8;
            this.ColorPicker.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ColorPicker.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ColorPicker.ValueChanged += new Sunny.UI.UIColorPicker.OnColorChanged(this.ColorChange);
            // 
            // textBoxChat
            // 
            this.textBoxChat.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.textBoxChat.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.textBoxChat.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.textBoxChat.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.textBoxChat.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.textBoxChat.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.textBoxChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxChat.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.textBoxChat.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxChat.Location = new System.Drawing.Point(18, 10);
            this.textBoxChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxChat.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxChat.Multiline = true;
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.textBoxChat.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.textBoxChat.ShowText = false;
            this.textBoxChat.Size = new System.Drawing.Size(371, 113);
            this.textBoxChat.Style = Sunny.UI.UIStyle.Orange;
            this.textBoxChat.TabIndex = 5;
            this.textBoxChat.Text = "uiTextBox1";
            this.textBoxChat.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxChat.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // buttonSend
            // 
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.buttonSend.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.buttonSend.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.buttonSend.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.buttonSend.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.buttonSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonSend.Location = new System.Drawing.Point(396, 88);
            this.buttonSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.buttonSend.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.buttonSend.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.buttonSend.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.buttonSend.Size = new System.Drawing.Size(264, 32);
            this.buttonSend.Style = Sunny.UI.UIStyle.Orange;
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "发   送";
            this.buttonSend.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSend.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // pictureBoxDrawing
            // 
            this.pictureBoxDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDrawing.BackColor = System.Drawing.Color.White;
            this.pictureBoxDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDrawing.Location = new System.Drawing.Point(18, 17);
            this.pictureBoxDrawing.Name = "pictureBoxDrawing";
            this.pictureBoxDrawing.Size = new System.Drawing.Size(642, 366);
            this.pictureBoxDrawing.TabIndex = 9;
            this.pictureBoxDrawing.TabStop = false;
            this.pictureBoxDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseDown);
            this.pictureBoxDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseMove);
            this.pictureBoxDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseUp);
            // 
            // panelWindow
            // 
            this.panelWindow.Controls.Add(this.uiPanelGameWin);
            this.panelWindow.Controls.Add(this.uiPanelTitle);
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.panelWindow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.panelWindow.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.panelWindow.Location = new System.Drawing.Point(0, 0);
            this.panelWindow.Margin = new System.Windows.Forms.Padding(2);
            this.panelWindow.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.panelWindow.Size = new System.Drawing.Size(977, 589);
            this.panelWindow.Style = Sunny.UI.UIStyle.Orange;
            this.panelWindow.TabIndex = 9;
            this.panelWindow.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelWindow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelGameWin
            // 
            this.uiPanelGameWin.Controls.Add(this.uiPanelDrawAndText);
            this.uiPanelGameWin.Controls.Add(this.uiPanelPen);
            this.uiPanelGameWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelGameWin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelGameWin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelGameWin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelGameWin.Location = new System.Drawing.Point(0, 58);
            this.uiPanelGameWin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelGameWin.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelGameWin.Name = "uiPanelGameWin";
            this.uiPanelGameWin.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelGameWin.Size = new System.Drawing.Size(977, 531);
            this.uiPanelGameWin.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelGameWin.TabIndex = 14;
            this.uiPanelGameWin.Text = "游戏界面";
            this.uiPanelGameWin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelGameWin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelDrawAndText
            // 
            this.uiPanelDrawAndText.Controls.Add(this.uiPanelScore);
            this.uiPanelDrawAndText.Controls.Add(this.uiPanelDraw);
            this.uiPanelDrawAndText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelDrawAndText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelDrawAndText.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelDrawAndText.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelDrawAndText.Location = new System.Drawing.Point(95, 0);
            this.uiPanelDrawAndText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelDrawAndText.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelDrawAndText.Name = "uiPanelDrawAndText";
            this.uiPanelDrawAndText.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelDrawAndText.Size = new System.Drawing.Size(882, 531);
            this.uiPanelDrawAndText.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelDrawAndText.TabIndex = 12;
            this.uiPanelDrawAndText.Text = "画和猜";
            this.uiPanelDrawAndText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelDrawAndText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelScore
            // 
            this.uiPanelScore.Controls.Add(this.uiDataGridViewScore);
            this.uiPanelScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelScore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelScore.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelScore.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelScore.Location = new System.Drawing.Point(676, 0);
            this.uiPanelScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelScore.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelScore.Name = "uiPanelScore";
            this.uiPanelScore.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelScore.Size = new System.Drawing.Size(206, 531);
            this.uiPanelScore.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelScore.TabIndex = 1;
            this.uiPanelScore.Text = "得分";
            this.uiPanelScore.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelScore.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDataGridViewScore
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewScore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridViewScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDataGridViewScore.AutoGenerateColumns = false;
            this.uiDataGridViewScore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewScore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridViewScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridViewScore.ColumnHeadersHeight = 50;
            this.uiDataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridViewScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.uiDataGridViewScore.DataSource = this.playerAndScoreBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridViewScore.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridViewScore.EnableHeadersVisualStyles = false;
            this.uiDataGridViewScore.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridViewScore.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(69)))));
            this.uiDataGridViewScore.Location = new System.Drawing.Point(20, 20);
            this.uiDataGridViewScore.Name = "uiDataGridViewScore";
            this.uiDataGridViewScore.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridViewScore.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridViewScore.RowHeadersVisible = false;
            this.uiDataGridViewScore.RowHeadersWidth = 82;
            this.uiDataGridViewScore.RowHeight = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridViewScore.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridViewScore.RowTemplate.Height = 40;
            this.uiDataGridViewScore.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewScore.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiDataGridViewScore.SelectedIndex = -1;
            this.uiDataGridViewScore.Size = new System.Drawing.Size(174, 497);
            this.uiDataGridViewScore.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewScore.Style = Sunny.UI.UIStyle.Orange;
            this.uiDataGridViewScore.TabIndex = 0;
            this.uiDataGridViewScore.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "玩家";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "得分";
            this.scoreDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.Width = 70;
            // 
            // playerAndScoreBindingSource
            // 
            this.playerAndScoreBindingSource.DataSource = typeof(GameWinForm.PlayerAndScore);
            // 
            // uiPanelDraw
            // 
            this.uiPanelDraw.Controls.Add(this.uiPanelText);
            this.uiPanelDraw.Controls.Add(this.uiPanelDrawBox);
            this.uiPanelDraw.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanelDraw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelDraw.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelDraw.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelDraw.Location = new System.Drawing.Point(0, 0);
            this.uiPanelDraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelDraw.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelDraw.Name = "uiPanelDraw";
            this.uiPanelDraw.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelDraw.Size = new System.Drawing.Size(676, 531);
            this.uiPanelDraw.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelDraw.TabIndex = 0;
            this.uiPanelDraw.Text = "画";
            this.uiPanelDraw.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelDraw.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelText
            // 
            this.uiPanelText.Controls.Add(this.textBoxSend);
            this.uiPanelText.Controls.Add(this.textBoxChat);
            this.uiPanelText.Controls.Add(this.buttonSend);
            this.uiPanelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelText.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelText.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelText.Location = new System.Drawing.Point(0, 397);
            this.uiPanelText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelText.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelText.Name = "uiPanelText";
            this.uiPanelText.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelText.Size = new System.Drawing.Size(676, 134);
            this.uiPanelText.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelText.TabIndex = 9;
            this.uiPanelText.Text = null;
            this.uiPanelText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelDrawBox
            // 
            this.uiPanelDrawBox.Controls.Add(this.pictureBoxDrawing);
            this.uiPanelDrawBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelDrawBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelDrawBox.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelDrawBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelDrawBox.Location = new System.Drawing.Point(0, 0);
            this.uiPanelDrawBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelDrawBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelDrawBox.Name = "uiPanelDrawBox";
            this.uiPanelDrawBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelDrawBox.Size = new System.Drawing.Size(676, 397);
            this.uiPanelDrawBox.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelDrawBox.TabIndex = 8;
            this.uiPanelDrawBox.Text = "画画界面";
            this.uiPanelDrawBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelDrawBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelPen
            // 
            this.uiPanelPen.Controls.Add(this.ColorPicker);
            this.uiPanelPen.Controls.Add(this.RadioButtonGroupPen);
            this.uiPanelPen.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanelPen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelPen.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelPen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelPen.Location = new System.Drawing.Point(0, 0);
            this.uiPanelPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelPen.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelPen.Name = "uiPanelPen";
            this.uiPanelPen.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelPen.Size = new System.Drawing.Size(95, 531);
            this.uiPanelPen.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelPen.TabIndex = 11;
            this.uiPanelPen.Text = null;
            this.uiPanelPen.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelPen.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // RadioButtonGroupPen
            // 
            this.RadioButtonGroupPen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.RadioButtonGroupPen.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.RadioButtonGroupPen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.RadioButtonGroupPen.Items.AddRange(new object[] {
            "画笔",
            "橡皮"});
            this.RadioButtonGroupPen.Location = new System.Drawing.Point(8, 72);
            this.RadioButtonGroupPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButtonGroupPen.MinimumSize = new System.Drawing.Size(1, 1);
            this.RadioButtonGroupPen.Name = "RadioButtonGroupPen";
            this.RadioButtonGroupPen.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.RadioButtonGroupPen.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.RadioButtonGroupPen.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.RadioButtonGroupPen.RowInterval = 20;
            this.RadioButtonGroupPen.Size = new System.Drawing.Size(79, 146);
            this.RadioButtonGroupPen.Style = Sunny.UI.UIStyle.Orange;
            this.RadioButtonGroupPen.TabIndex = 10;
            this.RadioButtonGroupPen.Text = null;
            this.RadioButtonGroupPen.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonGroupPen.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.RadioButtonGroupPen.ValueChanged += new Sunny.UI.UIRadioButtonGroup.OnValueChanged(this.PenOrEraser);
            // 
            // uiPanelTitle
            // 
            this.uiPanelTitle.Controls.Add(this.labelPoem);
            this.uiPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelTitle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelTitle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.uiPanelTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelTitle.Name = "uiPanelTitle";
            this.uiPanelTitle.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelTitle.Size = new System.Drawing.Size(977, 58);
            this.uiPanelTitle.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelTitle.TabIndex = 13;
            this.uiPanelTitle.Text = "题目";
            this.uiPanelTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelTitle.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelPoem
            // 
            this.labelPoem.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelPoem.Location = new System.Drawing.Point(318, 9);
            this.labelPoem.Name = "labelPoem";
            this.labelPoem.Size = new System.Drawing.Size(341, 34);
            this.labelPoem.Style = Sunny.UI.UIStyle.Orange;
            this.labelPoem.TabIndex = 12;
            this.labelPoem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPoem.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // DrawAndGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 589);
            this.Controls.Add(this.panelWindow);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(651, 395);
            this.Name = "DrawAndGuess";
            this.Text = "DrawAndGuess";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).EndInit();
            this.panelWindow.ResumeLayout(false);
            this.uiPanelGameWin.ResumeLayout(false);
            this.uiPanelDrawAndText.ResumeLayout(false);
            this.uiPanelScore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerAndScoreBindingSource)).EndInit();
            this.uiPanelDraw.ResumeLayout(false);
            this.uiPanelText.ResumeLayout(false);
            this.uiPanelDrawBox.ResumeLayout(false);
            this.uiPanelPen.ResumeLayout(false);
            this.uiPanelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox textBoxSend;
        private Sunny.UI.UIColorPicker ColorPicker;
        private Sunny.UI.UITextBox textBoxChat;
        private Sunny.UI.UIButton buttonSend;
        private System.Windows.Forms.PictureBox pictureBoxDrawing;
        private Sunny.UI.UIPanel panelWindow;
        private Sunny.UI.UIRadioButtonGroup RadioButtonGroupPen;
        private Sunny.UI.UILabel labelPoem;
        private Sunny.UI.UIPanel uiPanelTitle;
        private Sunny.UI.UIPanel uiPanelGameWin;
        private Sunny.UI.UIPanel uiPanelDrawAndText;
        private Sunny.UI.UIPanel uiPanelScore;
        private Sunny.UI.UIPanel uiPanelDraw;
        private Sunny.UI.UIPanel uiPanelPen;
        private Sunny.UI.UIPanel uiPanelDrawBox;
        private Sunny.UI.UIPanel uiPanelText;
        private Sunny.UI.UIDataGridView uiDataGridViewScore;
        private BindingSource playerAndScoreBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
    }
}