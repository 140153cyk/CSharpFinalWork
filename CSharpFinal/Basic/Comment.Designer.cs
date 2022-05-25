namespace Basic
{
  partial class Comment
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.userInfo = new Sunny.UI.UILabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.praseBtn = new Sunny.UI.UIButton();
            this.commentBtn = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(30, 24);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "诗词分享";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // userInfo
            // 
            this.userInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userInfo.Location = new System.Drawing.Point(65, 110);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(100, 23);
            this.userInfo.TabIndex = 1;
            this.userInfo.Text = "用户1";
            this.userInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userInfo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(235, 110);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(221, 29);
            this.uiTextBox1.TabIndex = 2;
            this.uiTextBox1.Text = "uiTextBox1";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // praseBtn
            // 
            this.praseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.praseBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.praseBtn.Location = new System.Drawing.Point(247, 275);
            this.praseBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.praseBtn.Name = "praseBtn";
            this.praseBtn.Radius = 25;
            this.praseBtn.RectColor = System.Drawing.Color.White;
            this.praseBtn.Size = new System.Drawing.Size(50, 35);
            this.praseBtn.Style = Sunny.UI.UIStyle.Custom;
            this.praseBtn.TabIndex = 3;
            this.praseBtn.Text = "赞";
            this.praseBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.praseBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // commentBtn
            // 
            this.commentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commentBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commentBtn.Location = new System.Drawing.Point(346, 275);
            this.commentBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.commentBtn.Name = "commentBtn";
            this.commentBtn.Radius = 25;
            this.commentBtn.RectColor = System.Drawing.Color.White;
            this.commentBtn.RectPressColor = System.Drawing.Color.White;
            this.commentBtn.Size = new System.Drawing.Size(50, 35);
            this.commentBtn.Style = Sunny.UI.UIStyle.Custom;
            this.commentBtn.TabIndex = 4;
            this.commentBtn.Text = "评论";
            this.commentBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commentBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.commentBtn.Click += new System.EventHandler(this.commentBtn_Click);
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.commentBtn);
            this.Controls.Add(this.praseBtn);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.uiLabel1);
            this.Name = "Comment";
            this.Text = "Comment";
            this.ResumeLayout(false);

    }

    #endregion

    private Sunny.UI.UILabel uiLabel1;
    private Sunny.UI.UILabel userInfo;
    private Sunny.UI.UITextBox uiTextBox1;
    private Sunny.UI.UIButton praseBtn;
    private Sunny.UI.UIButton commentBtn;
  }
}