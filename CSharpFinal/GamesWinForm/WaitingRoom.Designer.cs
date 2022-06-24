using System.Windows.Forms;

namespace GameWinForm
{
    partial class WaitingRoom
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
            this.uiPanelInfo = new Sunny.UI.UIPanel();
            this.uiPanelPlayer = new Sunny.UI.UIPanel();
            this.uiDataGridViewPlayers = new Sunny.UI.UIDataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanelButton = new Sunny.UI.UIPanel();
            this.uiButtonReady = new Sunny.UI.UIButton();
            this.uiPanelName = new Sunny.UI.UIPanel();
            this.uiLabelName = new Sunny.UI.UILabel();
            this.uiPanelWindow.SuspendLayout();
            this.uiPanelInfo.SuspendLayout();
            this.uiPanelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.uiPanelButton.SuspendLayout();
            this.uiPanelName.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelWindow
            // 
            this.uiPanelWindow.Controls.Add(this.uiPanelInfo);
            this.uiPanelWindow.Controls.Add(this.uiPanelName);
            this.uiPanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelWindow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelWindow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelWindow.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelWindow.Location = new System.Drawing.Point(0, 0);
            this.uiPanelWindow.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanelWindow.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelWindow.Name = "uiPanelWindow";
            this.uiPanelWindow.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelWindow.Size = new System.Drawing.Size(461, 494);
            this.uiPanelWindow.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelWindow.TabIndex = 0;
            this.uiPanelWindow.Text = "uiPanel1";
            this.uiPanelWindow.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelWindow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelInfo
            // 
            this.uiPanelInfo.Controls.Add(this.uiPanelPlayer);
            this.uiPanelInfo.Controls.Add(this.uiPanelButton);
            this.uiPanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelInfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelInfo.Location = new System.Drawing.Point(0, 69);
            this.uiPanelInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelInfo.Name = "uiPanelInfo";
            this.uiPanelInfo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelInfo.Size = new System.Drawing.Size(461, 425);
            this.uiPanelInfo.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelInfo.TabIndex = 1;
            this.uiPanelInfo.Text = "uiPanel1";
            this.uiPanelInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelInfo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelPlayer
            // 
            this.uiPanelPlayer.Controls.Add(this.uiDataGridViewPlayers);
            this.uiPanelPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelPlayer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelPlayer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelPlayer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelPlayer.Location = new System.Drawing.Point(0, 0);
            this.uiPanelPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelPlayer.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelPlayer.Name = "uiPanelPlayer";
            this.uiPanelPlayer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelPlayer.Size = new System.Drawing.Size(294, 425);
            this.uiPanelPlayer.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelPlayer.TabIndex = 1;
            this.uiPanelPlayer.Text = "玩家";
            this.uiPanelPlayer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelPlayer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDataGridViewPlayers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewPlayers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.nameDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.uiDataGridViewPlayers.DataSource = this.playerBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridViewPlayers.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridViewPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridViewPlayers.EnableHeadersVisualStyles = false;
            this.uiDataGridViewPlayers.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridViewPlayers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(69)))));
            this.uiDataGridViewPlayers.Location = new System.Drawing.Point(0, 0);
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
            this.uiDataGridViewPlayers.Size = new System.Drawing.Size(294, 425);
            this.uiDataGridViewPlayers.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiDataGridViewPlayers.Style = Sunny.UI.UIStyle.Orange;
            this.uiDataGridViewPlayers.TabIndex = 0;
            this.uiDataGridViewPlayers.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "玩家名";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "是否准备";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(GameWinForm.Player);
            // 
            // uiPanelButton
            // 
            this.uiPanelButton.Controls.Add(this.uiButtonReady);
            this.uiPanelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelButton.Location = new System.Drawing.Point(294, 0);
            this.uiPanelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelButton.Name = "uiPanelButton";
            this.uiPanelButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelButton.Size = new System.Drawing.Size(167, 425);
            this.uiPanelButton.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelButton.TabIndex = 0;
            this.uiPanelButton.Text = "准备";
            this.uiPanelButton.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButtonReady
            // 
            this.uiButtonReady.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiButtonReady.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonReady.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonReady.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonReady.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButtonReady.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonReady.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonReady.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButtonReady.Location = new System.Drawing.Point(27, 183);
            this.uiButtonReady.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonReady.Name = "uiButtonReady";
            this.uiButtonReady.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonReady.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButtonReady.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonReady.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonReady.Size = new System.Drawing.Size(109, 46);
            this.uiButtonReady.Style = Sunny.UI.UIStyle.Orange;
            this.uiButtonReady.TabIndex = 0;
            this.uiButtonReady.Text = "准  备";
            this.uiButtonReady.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonReady.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButtonReady.Click += new System.EventHandler(this.uiButtonReady_Click);
            // 
            // uiPanelName
            // 
            this.uiPanelName.Controls.Add(this.uiLabelName);
            this.uiPanelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelName.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelName.Location = new System.Drawing.Point(0, 0);
            this.uiPanelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelName.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelName.Name = "uiPanelName";
            this.uiPanelName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelName.Size = new System.Drawing.Size(461, 69);
            this.uiPanelName.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelName.TabIndex = 0;
            this.uiPanelName.Text = null;
            this.uiPanelName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabelName
            // 
            this.uiLabelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabelName.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabelName.Location = new System.Drawing.Point(49, 18);
            this.uiLabelName.Name = "uiLabelName";
            this.uiLabelName.Size = new System.Drawing.Size(350, 37);
            this.uiLabelName.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabelName.TabIndex = 0;
            this.uiLabelName.Text = "房间名";
            this.uiLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabelName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // WaitingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 494);
            this.Controls.Add(this.uiPanelWindow);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(477, 533);
            this.MinimumSize = new System.Drawing.Size(477, 533);
            this.Name = "WaitingRoom";
            this.Text = "WaitingRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quit);
            this.uiPanelWindow.ResumeLayout(false);
            this.uiPanelInfo.ResumeLayout(false);
            this.uiPanelPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.uiPanelButton.ResumeLayout(false);
            this.uiPanelName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanelWindow;
        private Sunny.UI.UIPanel uiPanelInfo;
        private Sunny.UI.UIPanel uiPanelPlayer;
        private Sunny.UI.UIPanel uiPanelButton;
        private Sunny.UI.UIPanel uiPanelName;
        private Sunny.UI.UIDataGridView uiDataGridViewPlayers;
        private BindingSource playerBindingSource;
        private Sunny.UI.UIButton uiButtonReady;
        private Sunny.UI.UILabel uiLabelName;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
    }
}