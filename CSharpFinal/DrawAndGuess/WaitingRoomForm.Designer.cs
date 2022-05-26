
namespace DrawAndGuess
{
    partial class WaitingRoomForm
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
            this.buttonReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReady
            // 
            this.buttonReady.Location = new System.Drawing.Point(808, 410);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(175, 76);
            this.buttonReady.TabIndex = 0;
            this.buttonReady.Text = "准备";
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // WaitingRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 608);
            this.Controls.Add(this.buttonReady);
            this.Name = "WaitingRoomForm";
            this.Text = "WaitingRoomForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReady;
    }
}