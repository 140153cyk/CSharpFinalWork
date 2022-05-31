
namespace DrawAndGuess
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
            this.textBoxSend = new Sunny.UI.UITextBox();
            this.ColorPicker = new Sunny.UI.UIColorPicker();
            this.textBoxChat = new Sunny.UI.UITextBox();
            this.buttonSend = new Sunny.UI.UIButton();
            this.pictureBoxDrawing = new System.Windows.Forms.PictureBox();
            this.panelWindow = new Sunny.UI.UIPanel();
            this.labelPoem = new Sunny.UI.UILabel();
            this.buttonReady = new Sunny.UI.UIButton();
            this.RadioButtonGroupPen = new Sunny.UI.UIRadioButtonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).BeginInit();
            this.panelWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSend
            // 
            this.textBoxSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSend.Location = new System.Drawing.Point(874, 480);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSend.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.ShowText = false;
            this.textBoxSend.Size = new System.Drawing.Size(173, 40);
            this.textBoxSend.TabIndex = 6;
            this.textBoxSend.Text = "uiTextBox1";
            this.textBoxSend.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxSend.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ColorPicker
            // 
            this.ColorPicker.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ColorPicker.FillColor = System.Drawing.Color.White;
            this.ColorPicker.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColorPicker.Location = new System.Drawing.Point(25, 70);
            this.ColorPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColorPicker.MinimumSize = new System.Drawing.Size(63, 0);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ColorPicker.Size = new System.Drawing.Size(63, 42);
            this.ColorPicker.TabIndex = 8;
            this.ColorPicker.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ColorPicker.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ColorPicker.ValueChanged += new Sunny.UI.UIColorPicker.OnColorChanged(this.ColorChange);
            // 
            // textBoxChat
            // 
            this.textBoxChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxChat.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxChat.Location = new System.Drawing.Point(874, 68);
            this.textBoxChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxChat.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBoxChat.Multiline = true;
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.ShowText = false;
            this.textBoxChat.Size = new System.Drawing.Size(267, 402);
            this.textBoxChat.TabIndex = 5;
            this.textBoxChat.Text = "uiTextBox1";
            this.textBoxChat.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxChat.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // buttonSend
            // 
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSend.Location = new System.Drawing.Point(1054, 480);
            this.buttonSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(87, 40);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "发送";
            this.buttonSend.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSend.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // pictureBoxDrawing
            // 
            this.pictureBoxDrawing.BackColor = System.Drawing.Color.White;
            this.pictureBoxDrawing.Location = new System.Drawing.Point(106, 68);
            this.pictureBoxDrawing.Name = "pictureBoxDrawing";
            this.pictureBoxDrawing.Size = new System.Drawing.Size(752, 452);
            this.pictureBoxDrawing.TabIndex = 9;
            this.pictureBoxDrawing.TabStop = false;
            this.pictureBoxDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseDown);
            this.pictureBoxDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseMove);
            this.pictureBoxDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseUp);
            // 
            // panelWindow
            // 
            this.panelWindow.Controls.Add(this.labelPoem);
            this.panelWindow.Controls.Add(this.buttonReady);
            this.panelWindow.Controls.Add(this.RadioButtonGroupPen);
            this.panelWindow.Controls.Add(this.pictureBoxDrawing);
            this.panelWindow.Controls.Add(this.textBoxChat);
            this.panelWindow.Controls.Add(this.buttonSend);
            this.panelWindow.Controls.Add(this.ColorPicker);
            this.panelWindow.Controls.Add(this.textBoxSend);
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelWindow.Location = new System.Drawing.Point(0, 0);
            this.panelWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelWindow.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Size = new System.Drawing.Size(2564, 1559);
            this.panelWindow.TabIndex = 9;
            this.panelWindow.Text = "uiPanel1";
            this.panelWindow.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelWindow.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // labelPoem
            // 
            this.labelPoem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPoem.Location = new System.Drawing.Point(301, 24);
            this.labelPoem.Name = "labelPoem";
            this.labelPoem.Size = new System.Drawing.Size(367, 25);
            this.labelPoem.TabIndex = 12;
            this.labelPoem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPoem.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // buttonReady
            // 
            this.buttonReady.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReady.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReady.Location = new System.Drawing.Point(1147, 480);
            this.buttonReady.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(86, 40);
            this.buttonReady.TabIndex = 11;
            this.buttonReady.Text = "准备";
            this.buttonReady.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReady.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // RadioButtonGroupPen
            // 
            this.RadioButtonGroupPen.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.RadioButtonGroupPen.Items.AddRange(new object[] {
            "画笔",
            "橡皮"});
            this.RadioButtonGroupPen.Location = new System.Drawing.Point(13, 131);
            this.RadioButtonGroupPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButtonGroupPen.MinimumSize = new System.Drawing.Size(1, 1);
            this.RadioButtonGroupPen.Name = "RadioButtonGroupPen";
            this.RadioButtonGroupPen.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.RadioButtonGroupPen.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.RadioButtonGroupPen.Size = new System.Drawing.Size(86, 109);
            this.RadioButtonGroupPen.TabIndex = 10;
            this.RadioButtonGroupPen.Text = null;
            this.RadioButtonGroupPen.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonGroupPen.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.RadioButtonGroupPen.ValueChanged += new Sunny.UI.UIRadioButtonGroup.OnValueChanged(this.PenOrEraser);
            // 
            // DrawAndGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1559);
            this.Controls.Add(this.panelWindow);
            this.MinimumSize = new System.Drawing.Size(2558, 1518);
            this.Name = "DrawAndGuess";
            this.Text = "DrawAndGuess";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).EndInit();
            this.panelWindow.ResumeLayout(false);
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
        private Sunny.UI.UIButton buttonReady;
        private Sunny.UI.UILabel labelPoem;
    }
}