
namespace Basic
{
    partial class PoemDetail
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoemDetail));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.commentBtn = new Sunny.UI.UIButton();
            this.collectBtn = new Sunny.UI.UIButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.Paragraph = new Sunny.UI.UITextBox();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.title = new Sunny.UI.UIScrollingText();
            this.uiPanel5 = new Sunny.UI.UIPanel();
            this.poetText = new Sunny.UI.UIScrollingText();
            this.uiScrollingText1 = new Sunny.UI.UIScrollingText();
            this.poemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanel1.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.uiPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.commentBtn);
            this.uiPanel1.Controls.Add(this.collectBtn);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(10, 298);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Padding = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel1.Size = new System.Drawing.Size(536, 82);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // commentBtn
            // 
            this.commentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commentBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.commentBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.commentBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.commentBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.commentBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.commentBtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.commentBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commentBtn.Location = new System.Drawing.Point(361, 15);
            this.commentBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.commentBtn.Name = "commentBtn";
            this.commentBtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.commentBtn.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.commentBtn.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.commentBtn.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.commentBtn.Size = new System.Drawing.Size(150, 52);
            this.commentBtn.Style = Sunny.UI.UIStyle.Orange;
            this.commentBtn.TabIndex = 2;
            this.commentBtn.Text = "评论";
            this.commentBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commentBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.commentBtn.Click += new System.EventHandler(this.commentBtn_Click);
            // 
            // collectBtn
            // 
            this.collectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collectBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.collectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.collectBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.collectBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.collectBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.collectBtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.collectBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.collectBtn.Location = new System.Drawing.Point(25, 15);
            this.collectBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.collectBtn.Name = "collectBtn";
            this.collectBtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.collectBtn.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.collectBtn.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.collectBtn.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.collectBtn.Size = new System.Drawing.Size(150, 52);
            this.collectBtn.Style = Sunny.UI.UIStyle.Orange;
            this.collectBtn.TabIndex = 1;
            this.collectBtn.Text = "收藏";
            this.collectBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.collectBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.collectBtn.Click += new System.EventHandler(this.collectBtn_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiPanel2.BackgroundImage")));
            this.uiPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(392, 10);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel2.Size = new System.Drawing.Size(154, 288);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.Paragraph);
            this.uiPanel3.Controls.Add(this.uiPanel4);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel3.Location = new System.Drawing.Point(10, 10);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.uiPanel3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel3.Size = new System.Drawing.Size(382, 288);
            this.uiPanel3.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel3.TabIndex = 3;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Paragraph
            // 
            this.Paragraph.AutoSize = true;
            this.Paragraph.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Paragraph.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.Paragraph.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.Paragraph.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Paragraph.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.Paragraph.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.Paragraph.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Paragraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Paragraph.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.Paragraph.Font = new System.Drawing.Font("隶书", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Paragraph.Location = new System.Drawing.Point(10, 83);
            this.Paragraph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Paragraph.MinimumSize = new System.Drawing.Size(1, 16);
            this.Paragraph.Multiline = true;
            this.Paragraph.Name = "Paragraph";
            this.Paragraph.ReadOnly = true;
            this.Paragraph.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Paragraph.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Paragraph.ShowScrollBar = true;
            this.Paragraph.ShowText = false;
            this.Paragraph.Size = new System.Drawing.Size(362, 195);
            this.Paragraph.Style = Sunny.UI.UIStyle.Orange;
            this.Paragraph.TabIndex = 3;
            this.Paragraph.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Paragraph.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.title);
            this.uiPanel4.Controls.Add(this.uiPanel5);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel4.Location = new System.Drawing.Point(10, 10);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.uiPanel4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel4.Size = new System.Drawing.Size(362, 73);
            this.uiPanel4.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel4.TabIndex = 2;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.title.Font = new System.Drawing.Font("隶书", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.title.Location = new System.Drawing.Point(10, 10);
            this.title.MinimumSize = new System.Drawing.Size(1, 1);
            this.title.Name = "title";
            this.title.Radius = 1;
            this.title.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.title.Size = new System.Drawing.Size(342, 27);
            this.title.Style = Sunny.UI.UIStyle.Orange;
            this.title.TabIndex = 2;
            this.title.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel5
            // 
            this.uiPanel5.Controls.Add(this.poetText);
            this.uiPanel5.Controls.Add(this.uiScrollingText1);
            this.uiPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel5.Location = new System.Drawing.Point(10, 37);
            this.uiPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel5.Name = "uiPanel5";
            this.uiPanel5.Padding = new System.Windows.Forms.Padding(5);
            this.uiPanel5.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel5.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel5.Size = new System.Drawing.Size(342, 26);
            this.uiPanel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel5.TabIndex = 1;
            this.uiPanel5.Text = null;
            this.uiPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // poetText
            // 
            this.poetText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poetText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.poetText.Font = new System.Drawing.Font("隶书", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.poetText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.poetText.Location = new System.Drawing.Point(5, 5);
            this.poetText.MinimumSize = new System.Drawing.Size(1, 1);
            this.poetText.Name = "poetText";
            this.poetText.Radius = 1;
            this.poetText.RectColor = System.Drawing.Color.Transparent;
            this.poetText.Size = new System.Drawing.Size(182, 16);
            this.poetText.Style = Sunny.UI.UIStyle.Custom;
            this.poetText.TabIndex = 1;
            this.poetText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiScrollingText1
            // 
            this.uiScrollingText1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiScrollingText1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiScrollingText1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiScrollingText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiScrollingText1.Location = new System.Drawing.Point(187, 5);
            this.uiScrollingText1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiScrollingText1.Name = "uiScrollingText1";
            this.uiScrollingText1.Radius = 1;
            this.uiScrollingText1.RectColor = System.Drawing.Color.Transparent;
            this.uiScrollingText1.Size = new System.Drawing.Size(150, 16);
            this.uiScrollingText1.Style = Sunny.UI.UIStyle.Custom;
            this.uiScrollingText1.TabIndex = 0;
            this.uiScrollingText1.Text = "查看诗人详情";
            this.uiScrollingText1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // poemBindingSource
            // 
            this.poemBindingSource.DataSource = typeof(Models.Poem);
            // 
            // PoemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 390);
            this.Controls.Add(this.uiPanel3);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PoemDetail";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Text = "诗词详情";
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.uiPanel3.PerformLayout();
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIButton commentBtn;
        private Sunny.UI.UIButton collectBtn;
        private System.Windows.Forms.BindingSource poemBindingSource;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UITextBox Paragraph;
        private Sunny.UI.UIScrollingText title;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIScrollingText poetText;
        private Sunny.UI.UIScrollingText uiScrollingText1;
    }
}

