namespace GameWinForm
{
    partial class CreateForm
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
            this.uiLabelMaxNum = new Sunny.UI.UILabel();
            this.uiLabelName = new Sunny.UI.UILabel();
            this.uiTextBoxMaxNum = new Sunny.UI.UITextBox();
            this.uiTextBoxName = new Sunny.UI.UITextBox();
            this.uiPanelButton = new Sunny.UI.UIPanel();
            this.uiButtonCreate = new Sunny.UI.UIButton();
            this.uiPanelWindow.SuspendLayout();
            this.uiPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelWindow
            // 
            this.uiPanelWindow.Controls.Add(this.uiLabelMaxNum);
            this.uiPanelWindow.Controls.Add(this.uiLabelName);
            this.uiPanelWindow.Controls.Add(this.uiTextBoxMaxNum);
            this.uiPanelWindow.Controls.Add(this.uiTextBoxName);
            this.uiPanelWindow.Controls.Add(this.uiPanelButton);
            this.uiPanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelWindow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelWindow.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelWindow.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelWindow.Location = new System.Drawing.Point(0, 0);
            this.uiPanelWindow.Margin = new System.Windows.Forms.Padding(2);
            this.uiPanelWindow.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelWindow.Name = "uiPanelWindow";
            this.uiPanelWindow.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelWindow.Size = new System.Drawing.Size(307, 342);
            this.uiPanelWindow.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelWindow.TabIndex = 0;
            this.uiPanelWindow.Text = null;
            this.uiPanelWindow.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelWindow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabelMaxNum
            // 
            this.uiLabelMaxNum.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelMaxNum.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabelMaxNum.Location = new System.Drawing.Point(46, 116);
            this.uiLabelMaxNum.Name = "uiLabelMaxNum";
            this.uiLabelMaxNum.Size = new System.Drawing.Size(135, 44);
            this.uiLabelMaxNum.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabelMaxNum.TabIndex = 4;
            this.uiLabelMaxNum.Text = "最大玩家数:";
            this.uiLabelMaxNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabelMaxNum.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabelName
            // 
            this.uiLabelName.BackColor = System.Drawing.Color.Transparent;
            this.uiLabelName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabelName.Location = new System.Drawing.Point(46, 23);
            this.uiLabelName.Name = "uiLabelName";
            this.uiLabelName.Size = new System.Drawing.Size(94, 45);
            this.uiLabelName.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabelName.TabIndex = 3;
            this.uiLabelName.Text = "房间名:";
            this.uiLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabelName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBoxMaxNum
            // 
            this.uiTextBoxMaxNum.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBoxMaxNum.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiTextBoxMaxNum.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiTextBoxMaxNum.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBoxMaxNum.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiTextBoxMaxNum.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiTextBoxMaxNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxMaxNum.DoubleValue = 5D;
            this.uiTextBoxMaxNum.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiTextBoxMaxNum.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBoxMaxNum.IntValue = 5;
            this.uiTextBoxMaxNum.Location = new System.Drawing.Point(50, 165);
            this.uiTextBoxMaxNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxMaxNum.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxMaxNum.Name = "uiTextBoxMaxNum";
            this.uiTextBoxMaxNum.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBoxMaxNum.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBoxMaxNum.ShowText = false;
            this.uiTextBoxMaxNum.Size = new System.Drawing.Size(205, 40);
            this.uiTextBoxMaxNum.Style = Sunny.UI.UIStyle.Orange;
            this.uiTextBoxMaxNum.TabIndex = 2;
            this.uiTextBoxMaxNum.Text = "5";
            this.uiTextBoxMaxNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxMaxNum.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBoxName
            // 
            this.uiTextBoxName.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBoxName.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiTextBoxName.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiTextBoxName.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBoxName.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiTextBoxName.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiTextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxName.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiTextBoxName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBoxName.Location = new System.Drawing.Point(50, 73);
            this.uiTextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxName.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxName.Name = "uiTextBoxName";
            this.uiTextBoxName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBoxName.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBoxName.ShowText = false;
            this.uiTextBoxName.Size = new System.Drawing.Size(205, 38);
            this.uiTextBoxName.Style = Sunny.UI.UIStyle.Orange;
            this.uiTextBoxName.TabIndex = 1;
            this.uiTextBoxName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBoxName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanelButton
            // 
            this.uiPanelButton.Controls.Add(this.uiButtonCreate);
            this.uiPanelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanelButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelButton.Location = new System.Drawing.Point(0, 236);
            this.uiPanelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelButton.Name = "uiPanelButton";
            this.uiPanelButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanelButton.Size = new System.Drawing.Size(307, 106);
            this.uiPanelButton.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanelButton.TabIndex = 0;
            this.uiPanelButton.Text = null;
            this.uiPanelButton.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanelButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButtonCreate
            // 
            this.uiButtonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonCreate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonCreate.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButtonCreate.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonCreate.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonCreate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButtonCreate.Location = new System.Drawing.Point(50, 32);
            this.uiButtonCreate.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonCreate.Name = "uiButtonCreate";
            this.uiButtonCreate.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButtonCreate.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButtonCreate.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonCreate.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButtonCreate.Size = new System.Drawing.Size(205, 43);
            this.uiButtonCreate.Style = Sunny.UI.UIStyle.Orange;
            this.uiButtonCreate.TabIndex = 0;
            this.uiButtonCreate.Text = "创建房间";
            this.uiButtonCreate.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButtonCreate.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButtonCreate.Click += new System.EventHandler(this.uiButtonCreate_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 342);
            this.Controls.Add(this.uiPanelWindow);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "CreateForm";
            this.Text = "创建房间";
            this.uiPanelWindow.ResumeLayout(false);
            this.uiPanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanelWindow;
        private Sunny.UI.UILabel uiLabelName;
        private Sunny.UI.UITextBox uiTextBoxMaxNum;
        private Sunny.UI.UITextBox uiTextBoxName;
        private Sunny.UI.UIPanel uiPanelButton;
        private Sunny.UI.UILabel uiLabelMaxNum;
        private Sunny.UI.UIButton uiButtonCreate;
    }
}