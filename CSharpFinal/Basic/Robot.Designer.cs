namespace Basic
{
  partial class Robot
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
            this.SuspendLayout();
            // 
            // Robot
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Robot";
            this.Load += new System.EventHandler(this.Robot_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private Sunny.UI.UILabel uiLabel1;
    private Sunny.UI.UIButton uiButton1;
    private Sunny.UI.UITextBox uiTextBox1;
    private Sunny.UI.UITextBox uiTextBox2;
  }
}