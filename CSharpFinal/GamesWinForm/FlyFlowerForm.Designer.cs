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
            this.panelAnswerWin = new System.Windows.Forms.Panel();
            this.uiLabelAnswerPlayer = new Sunny.UI.UILabel();
            this.uiTextBoxAnswer = new Sunny.UI.UITextBox();
            this.uiButtonSend = new Sunny.UI.UIButton();
            this.uiLabelAnswer = new Sunny.UI.UILabel();
            this.uiPanelPlayers = new Sunny.UI.UIPanel();
            this.uiPanelPlayerBox = new Sunny.UI.UIPanel();
            this.uiDataGridViewPlayers = new Sunny.UI.UIDataGridView();
            this.uiPanelTimer = new Sunny.UI.UIPanel();
            this.uiLabelTimer = new Sunny.UI.UILabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxAnswer = new System.Windows.Forms.PictureBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainPlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanelWindow.SuspendLayout();
            this.uiPanelGameWin.SuspendLayout();
            this.panelAnswerWin.SuspendLayout();
            this.uiPanelPlayers.SuspendLayout();
            this.uiPanelPlayerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewPlayers)).BeginInit();
            this.uiPanelTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainPlayerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanelWindow
            // 
            this.uiPanelWindow.Controls.Add(this.uiPanelGameWin);
            this.uiPanelWindow.Controls.Add(this.uiPanelPlayers);
            this.uiPanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelWindow.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelWindow.Location = new System.Drawing.Point(0, 0);
            this.uiPanelWindow.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanelWindow.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelWindow.Name = "uiPanelWindow";
            this.uiPanelWindow.Size = new System.Drawing.Size(773, 600);
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
            this.uiPanelGameWin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelGameWin.Location = new System.Drawing.Point(0, 0);
            this.uiPanelGameWin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelGameWin.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelGameWin.Name = "uiPanelGameWin";
            this.uiPanelGameWin.Size = new System.Drawing.Size(600, 600);
            this.uiPanelGameWin.TabIndex = 1;
            this.uiPanelGameWin.Text = null;
            this.uiPanelGameWin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelGameWin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // panelAnswerWin
            // 
            this.panelAnswerWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panelAnswerWin.Controls.Add(this.uiLabelAnswerPlayer);
            this.panelAnswerWin.Controls.Add(this.uiTextBoxAnswer);
            this.panelAnswerWin.Controls.Add(this.uiButtonSend);
            this.panelAnswerWin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAnswerWin.Location = new System.Drawing.Point(0, 480);
            this.panelAnswerWin.Name = "panelAnswerWin";
            this.panelAnswerWin.Size = new System.Drawing.Size(600, 120);
            this.panelAnswerWin.TabIndex = 1;
            // 
            // uiLabelAnswerPlayer
            // 
            this.uiLabelAnswerPlayer.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelAnswerPlayer.Font = new System.Drawing.Font("华文行楷", 20F);
            this.uiLabelAnswerPlayer.Location = new System.Drawing.Point(55, 12);
            this.uiLabelAnswerPlayer.Name = "uiLabelAnswerPlayer";
            this.uiLabelAnswerPlayer.Size = new System.Drawing.Size(500, 30);
            this.uiLabelAnswerPlayer.TabIndex = 2;
            this.uiLabelAnswerPlayer.Text = "作答人：";
            this.uiLabelAnswerPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabelAnswerPlayer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBoxAnswer
            // 
            this.uiTextBoxAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxAnswer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBoxAnswer.Location = new System.Drawing.Point(145, 56);
            this.uiTextBoxAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxAnswer.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxAnswer.Name = "uiTextBoxAnswer";
            this.uiTextBoxAnswer.ShowText = false;
            this.uiTextBoxAnswer.Size = new System.Drawing.Size(302, 36);
            this.uiTextBoxAnswer.TabIndex = 1;
            this.uiTextBoxAnswer.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxAnswer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButtonSend
            // 
            this.uiButtonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonSend.Font = new System.Drawing.Font("华文行楷", 20F);
            this.uiButtonSend.Location = new System.Drawing.Point(481, 56);
            this.uiButtonSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonSend.Name = "uiButtonSend";
            this.uiButtonSend.Size = new System.Drawing.Size(88, 36);
            this.uiButtonSend.TabIndex = 0;
            this.uiButtonSend.Text = "确 定";
            this.uiButtonSend.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonSend.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButtonSend.Click += new System.EventHandler(this.uiButtonSend_Click);
            // 
            // uiLabelAnswer
            // 
            this.uiLabelAnswer.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelAnswer.Font = new System.Drawing.Font("华文行楷", 30F);
            this.uiLabelAnswer.Location = new System.Drawing.Point(12, 223);
            this.uiLabelAnswer.Name = "uiLabelAnswer";
            this.uiLabelAnswer.Size = new System.Drawing.Size(569, 116);
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
            this.uiPanelPlayers.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelPlayers.Location = new System.Drawing.Point(600, 0);
            this.uiPanelPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelPlayers.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelPlayers.Name = "uiPanelPlayers";
            this.uiPanelPlayers.Size = new System.Drawing.Size(173, 600);
            this.uiPanelPlayers.TabIndex = 0;
            this.uiPanelPlayers.Text = "剩余玩家";
            this.uiPanelPlayers.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelPlayers.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelPlayerBox
            // 
            this.uiPanelPlayerBox.Controls.Add(this.uiDataGridViewPlayers);
            this.uiPanelPlayerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelPlayerBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelPlayerBox.Location = new System.Drawing.Point(0, 123);
            this.uiPanelPlayerBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelPlayerBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelPlayerBox.Name = "uiPanelPlayerBox";
            this.uiPanelPlayerBox.Size = new System.Drawing.Size(173, 477);
            this.uiPanelPlayerBox.TabIndex = 1;
            this.uiPanelPlayerBox.Text = null;
            this.uiPanelPlayerBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelPlayerBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDataGridViewPlayers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridViewPlayers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridViewPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDataGridViewPlayers.AutoGenerateColumns = false;
            this.uiDataGridViewPlayers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridViewPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
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
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridViewPlayers.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridViewPlayers.EnableHeadersVisualStyles = false;
            this.uiDataGridViewPlayers.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridViewPlayers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.uiDataGridViewPlayers.Location = new System.Drawing.Point(9, 8);
            this.uiDataGridViewPlayers.Name = "uiDataGridViewPlayers";
            this.uiDataGridViewPlayers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridViewPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridViewPlayers.RowHeadersWidth = 40;
            this.uiDataGridViewPlayers.RowHeight = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridViewPlayers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridViewPlayers.RowTemplate.Height = 40;
            this.uiDataGridViewPlayers.SelectedIndex = -1;
            this.uiDataGridViewPlayers.Size = new System.Drawing.Size(154, 441);
            this.uiDataGridViewPlayers.TabIndex = 2;
            this.uiDataGridViewPlayers.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelTimer
            // 
            this.uiPanelTimer.Controls.Add(this.uiLabelTimer);
            this.uiPanelTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelTimer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelTimer.Location = new System.Drawing.Point(0, 0);
            this.uiPanelTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelTimer.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelTimer.Name = "uiPanelTimer";
            this.uiPanelTimer.Size = new System.Drawing.Size(173, 123);
            this.uiPanelTimer.TabIndex = 0;
            this.uiPanelTimer.Text = "uiPanel1";
            this.uiPanelTimer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelTimer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabelTimer
            // 
            this.uiLabelTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabelTimer.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.uiLabelTimer.Location = new System.Drawing.Point(38, 35);
            this.uiLabelTimer.Name = "uiLabelTimer";
            this.uiLabelTimer.Size = new System.Drawing.Size(95, 58);
            this.uiLabelTimer.TabIndex = 2;
            this.uiLabelTimer.Text = "0:15";
            this.uiLabelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabelTimer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBoxAnswer
            // 
            this.pictureBoxAnswer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAnswer.Location = new System.Drawing.Point(249, 310);
            this.pictureBoxAnswer.Name = "pictureBoxAnswer";
            this.pictureBoxAnswer.Size = new System.Drawing.Size(103, 98);
            this.pictureBoxAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAnswer.TabIndex = 2;
            this.pictureBoxAnswer.TabStop = false;
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
            // FlyFlowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(773, 600);
            this.Controls.Add(this.uiPanelWindow);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(577, 395);
            this.Name = "FlyFlowerForm";
            this.Text = "FlyFlowerForm";
            this.Load += new System.EventHandler(this.FlyFlowerForm_Load);
            this.uiPanelWindow.ResumeLayout(false);
            this.uiPanelGameWin.ResumeLayout(false);
            this.panelAnswerWin.ResumeLayout(false);
            this.uiPanelPlayers.ResumeLayout(false);
            this.uiPanelPlayerBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewPlayers)).EndInit();
            this.uiPanelTimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainPlayerBindingSource)).EndInit();
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