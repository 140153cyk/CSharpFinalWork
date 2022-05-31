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
            this.uiPanelWindow = new Sunny.UI.UIPanel();
            this.uiPanelGameWin = new Sunny.UI.UIPanel();
            this.panelAnswerWin = new System.Windows.Forms.Panel();
            this.uiLabelPlayerAnswer = new Sunny.UI.UILabel();
            this.uiTextBoxAnswer = new Sunny.UI.UITextBox();
            this.uiButtonSend = new Sunny.UI.UIButton();
            this.uiLabelAnswer = new Sunny.UI.UILabel();
            this.uiPanelPlayers = new Sunny.UI.UIPanel();
            this.uiPanelPlayerBox = new Sunny.UI.UIPanel();
            this.uiLabelPlayerRemain = new Sunny.UI.UILabel();
            this.uiTextBoxPlayersRemain = new Sunny.UI.UITextBox();
            this.uiPanelTimer = new Sunny.UI.UIPanel();
            this.uiLabelTimer = new Sunny.UI.UILabel();
            this.uiPanelWindow.SuspendLayout();
            this.uiPanelGameWin.SuspendLayout();
            this.panelAnswerWin.SuspendLayout();
            this.uiPanelPlayers.SuspendLayout();
            this.uiPanelPlayerBox.SuspendLayout();
            this.uiPanelTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelWindow
            // 
            this.uiPanelWindow.Controls.Add(this.uiPanelGameWin);
            this.uiPanelWindow.Controls.Add(this.uiPanelPlayers);
            this.uiPanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelWindow.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelWindow.Location = new System.Drawing.Point(0, 0);
            this.uiPanelWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.panelAnswerWin.Controls.Add(this.uiLabelPlayerAnswer);
            this.panelAnswerWin.Controls.Add(this.uiTextBoxAnswer);
            this.panelAnswerWin.Controls.Add(this.uiButtonSend);
            this.panelAnswerWin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAnswerWin.Location = new System.Drawing.Point(0, 480);
            this.panelAnswerWin.Name = "panelAnswerWin";
            this.panelAnswerWin.Size = new System.Drawing.Size(600, 120);
            this.panelAnswerWin.TabIndex = 1;
            // 
            // uiLabelPlayerAnswer
            // 
            this.uiLabelPlayerAnswer.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelPlayerAnswer.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabelPlayerAnswer.Location = new System.Drawing.Point(55, 12);
            this.uiLabelPlayerAnswer.Name = "uiLabelPlayerAnswer";
            this.uiLabelPlayerAnswer.Size = new System.Drawing.Size(500, 30);
            this.uiLabelPlayerAnswer.TabIndex = 2;
            this.uiLabelPlayerAnswer.Text = "作答人：";
            this.uiLabelPlayerAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabelPlayerAnswer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            this.uiButtonSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButtonSend.Location = new System.Drawing.Point(481, 56);
            this.uiButtonSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonSend.Name = "uiButtonSend";
            this.uiButtonSend.Size = new System.Drawing.Size(88, 36);
            this.uiButtonSend.TabIndex = 0;
            this.uiButtonSend.Text = "确 定";
            this.uiButtonSend.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonSend.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabelAnswer
            // 
            this.uiLabelAnswer.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelAnswer.Font = new System.Drawing.Font("华文行楷", 20F);
            this.uiLabelAnswer.Location = new System.Drawing.Point(111, 341);
            this.uiLabelAnswer.Name = "uiLabelAnswer";
            this.uiLabelAnswer.Size = new System.Drawing.Size(345, 54);
            this.uiLabelAnswer.TabIndex = 0;
            this.uiLabelAnswer.Text = "将进酒，杯莫停";
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
            this.uiPanelPlayerBox.Controls.Add(this.uiLabelPlayerRemain);
            this.uiPanelPlayerBox.Controls.Add(this.uiTextBoxPlayersRemain);
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
            // uiLabelPlayerRemain
            // 
            this.uiLabelPlayerRemain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabelPlayerRemain.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabelPlayerRemain.Location = new System.Drawing.Point(18, 5);
            this.uiLabelPlayerRemain.Name = "uiLabelPlayerRemain";
            this.uiLabelPlayerRemain.Size = new System.Drawing.Size(125, 49);
            this.uiLabelPlayerRemain.TabIndex = 1;
            this.uiLabelPlayerRemain.Text = "剩余玩家：";
            this.uiLabelPlayerRemain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabelPlayerRemain.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBoxPlayersRemain
            // 
            this.uiTextBoxPlayersRemain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiTextBoxPlayersRemain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxPlayersRemain.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBoxPlayersRemain.Location = new System.Drawing.Point(22, 54);
            this.uiTextBoxPlayersRemain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxPlayersRemain.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxPlayersRemain.Multiline = true;
            this.uiTextBoxPlayersRemain.Name = "uiTextBoxPlayersRemain";
            this.uiTextBoxPlayersRemain.ShowText = false;
            this.uiTextBoxPlayersRemain.Size = new System.Drawing.Size(137, 323);
            this.uiTextBoxPlayersRemain.TabIndex = 0;
            this.uiTextBoxPlayersRemain.Text = "uiTextBox1";
            this.uiTextBoxPlayersRemain.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxPlayersRemain.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            this.uiLabelTimer.Text = "0:30";
            this.uiLabelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabelTimer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FlyFlowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(773, 600);
            this.Controls.Add(this.uiPanelWindow);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MinimumSize = new System.Drawing.Size(577, 395);
            this.Name = "FlyFlowerForm";
            this.Text = "FlyFlowerForm";
            this.uiPanelWindow.ResumeLayout(false);
            this.uiPanelGameWin.ResumeLayout(false);
            this.panelAnswerWin.ResumeLayout(false);
            this.uiPanelPlayers.ResumeLayout(false);
            this.uiPanelPlayerBox.ResumeLayout(false);
            this.uiPanelTimer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanelWindow;
        private Sunny.UI.UIPanel uiPanelPlayers;
        private Sunny.UI.UIPanel uiPanelGameWin;
        private Sunny.UI.UITextBox uiTextBoxPlayersRemain;
        private Sunny.UI.UILabel uiLabelTimer;
        private Sunny.UI.UILabel uiLabelPlayerRemain;
        private Sunny.UI.UIPanel uiPanelPlayerBox;
        private Sunny.UI.UIPanel uiPanelTimer;
        private Sunny.UI.UILabel uiLabelAnswer;
        private Panel panelAnswerWin;
        private Sunny.UI.UITextBox uiTextBoxAnswer;
        private Sunny.UI.UIButton uiButtonSend;
        private Sunny.UI.UILabel uiLabelPlayerAnswer;
    }
}