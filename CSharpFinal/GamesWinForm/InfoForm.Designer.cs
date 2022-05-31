using System.Drawing;

namespace GameWinForm
{
    partial class InfoForm
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
            this.uiLabelInfo = new Sunny.UI.UILabel();
            this.uiPanelWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelWindow
            // 
            this.uiPanelWindow.Controls.Add(this.uiLabelInfo);
            this.uiPanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelWindow.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelWindow.Location = new System.Drawing.Point(0, 0);
            this.uiPanelWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uiPanelWindow.Name = "uiPanelWindow";
            this.uiPanelWindow.Size = new System.Drawing.Size(284, 161);
            this.uiPanelWindow.TabIndex = 0;
            this.uiPanelWindow.Text = null;
            this.uiPanelWindow.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelWindow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabelInfo
            // 
            this.uiLabelInfo.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabelInfo.Location = new System.Drawing.Point(24, 50);
            this.uiLabelInfo.Name = "uiLabelInfo";
            this.uiLabelInfo.Size = new System.Drawing.Size(239, 70);
            this.uiLabelInfo.TabIndex = 0;
            this.uiLabelInfo.Text = "请输入房间名";
            this.uiLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabelInfo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.uiPanelWindow);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(300, 200);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.uiPanelWindow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanelWindow;
        private Sunny.UI.UILabel uiLabelInfo;
    }
}