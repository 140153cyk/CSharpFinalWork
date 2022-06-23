
namespace Basic
{
    partial class MyComments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyComments));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiScrollingText1 = new Sunny.UI.UIScrollingText();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.commentsGridview = new Sunny.UI.UIDataGridView();
            this.Poems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.praseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myCommentsSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.pageText = new Sunny.UI.UIScrollingText();
            this.nextBtn = new Sunny.UI.UIButton();
            this.beforeBtn = new Sunny.UI.UIButton();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCommentsSource)).BeginInit();
            this.uiPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiScrollingText1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(10, 10);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel1.Size = new System.Drawing.Size(726, 89);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiScrollingText1
            // 
            this.uiScrollingText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiScrollingText1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiScrollingText1.Font = new System.Drawing.Font("隶书", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiScrollingText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiScrollingText1.Location = new System.Drawing.Point(0, 0);
            this.uiScrollingText1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiScrollingText1.Name = "uiScrollingText1";
            this.uiScrollingText1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiScrollingText1.Size = new System.Drawing.Size(726, 89);
            this.uiScrollingText1.Style = Sunny.UI.UIStyle.Orange;
            this.uiScrollingText1.TabIndex = 0;
            this.uiScrollingText1.Text = "我 的 诗 评";
            this.uiScrollingText1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.commentsGridview);
            this.uiPanel2.Controls.Add(this.uiPanel4);
            this.uiPanel2.Controls.Add(this.uiPanel3);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(10, 99);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel2.Size = new System.Drawing.Size(726, 341);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // commentsGridview
            // 
            this.commentsGridview.AllowUserToAddRows = false;
            this.commentsGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.commentsGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.commentsGridview.AutoGenerateColumns = false;
            this.commentsGridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.commentsGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.commentsGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentsGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.commentsGridview.ColumnHeadersHeight = 32;
            this.commentsGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.commentsGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Poems,
            this.Detail,
            this.praseDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn});
            this.commentsGridview.DataSource = this.myCommentsSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.commentsGridview.DefaultCellStyle = dataGridViewCellStyle5;
            this.commentsGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentsGridview.EnableHeadersVisualStyles = false;
            this.commentsGridview.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commentsGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(69)))));
            this.commentsGridview.Location = new System.Drawing.Point(222, 0);
            this.commentsGridview.Name = "commentsGridview";
            this.commentsGridview.ReadOnly = true;
            this.commentsGridview.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentsGridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.commentsGridview.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.commentsGridview.RowTemplate.Height = 23;
            this.commentsGridview.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.commentsGridview.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.commentsGridview.SelectedIndex = -1;
            this.commentsGridview.Size = new System.Drawing.Size(504, 290);
            this.commentsGridview.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.commentsGridview.Style = Sunny.UI.UIStyle.Orange;
            this.commentsGridview.TabIndex = 3;
            this.commentsGridview.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.commentsGridview.DoubleClick += new System.EventHandler(this.commentsGridview_DoubleClick);
            // 
            // Poems
            // 
            this.Poems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Poems.DataPropertyName = "Poems";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            this.Poems.DefaultCellStyle = dataGridViewCellStyle3;
            this.Poems.HeaderText = "诗题";
            this.Poems.Name = "Poems";
            this.Poems.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.Detail.DefaultCellStyle = dataGridViewCellStyle4;
            this.Detail.FillWeight = 150F;
            this.Detail.HeaderText = "内容";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Width = 150;
            // 
            // praseDataGridViewTextBoxColumn
            // 
            this.praseDataGridViewTextBoxColumn.DataPropertyName = "Prase";
            this.praseDataGridViewTextBoxColumn.HeaderText = "点赞数";
            this.praseDataGridViewTextBoxColumn.Name = "praseDataGridViewTextBoxColumn";
            this.praseDataGridViewTextBoxColumn.ReadOnly = true;
            this.praseDataGridViewTextBoxColumn.Width = 70;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "发表时间";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDataGridViewTextBoxColumn.Width = 120;
            // 
            // myCommentsSource
            // 
            this.myCommentsSource.DataSource = typeof(Models.Comment);
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.pageText);
            this.uiPanel4.Controls.Add(this.nextBtn);
            this.uiPanel4.Controls.Add(this.beforeBtn);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel4.Location = new System.Drawing.Point(222, 290);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Padding = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.uiPanel4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel4.Size = new System.Drawing.Size(504, 51);
            this.uiPanel4.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel4.TabIndex = 2;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pageText
            // 
            this.pageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageText.Enabled = false;
            this.pageText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.pageText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.pageText.Location = new System.Drawing.Point(180, 10);
            this.pageText.MinimumSize = new System.Drawing.Size(1, 1);
            this.pageText.Name = "pageText";
            this.pageText.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.pageText.Size = new System.Drawing.Size(144, 31);
            this.pageText.Style = Sunny.UI.UIStyle.Orange;
            this.pageText.TabIndex = 2;
            this.pageText.Text = "1";
            this.pageText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // nextBtn
            // 
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.nextBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.nextBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.nextBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.nextBtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.nextBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextBtn.Location = new System.Drawing.Point(324, 10);
            this.nextBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.nextBtn.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.nextBtn.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.nextBtn.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.nextBtn.Size = new System.Drawing.Size(80, 31);
            this.nextBtn.Style = Sunny.UI.UIStyle.Orange;
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "下一页";
            this.nextBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // beforeBtn
            // 
            this.beforeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beforeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.beforeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.beforeBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.beforeBtn.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.beforeBtn.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.beforeBtn.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.beforeBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.beforeBtn.Location = new System.Drawing.Point(100, 10);
            this.beforeBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.beforeBtn.Name = "beforeBtn";
            this.beforeBtn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.beforeBtn.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.beforeBtn.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.beforeBtn.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.beforeBtn.Size = new System.Drawing.Size(80, 31);
            this.beforeBtn.Style = Sunny.UI.UIStyle.Orange;
            this.beforeBtn.TabIndex = 0;
            this.beforeBtn.Text = "上一页";
            this.beforeBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.beforeBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.beforeBtn.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiPanel3
            // 
            this.uiPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uiPanel3.BackgroundImage")));
            this.uiPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiPanel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel3.Location = new System.Drawing.Point(0, 0);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel3.Size = new System.Drawing.Size(222, 341);
            this.uiPanel3.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel3.TabIndex = 0;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // commentBindingSource
            // 
            this.commentBindingSource.DataSource = typeof(Models.Comment);
            // 
            // MyComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Name = "MyComments";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "我的诗评";
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commentsGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCommentsSource)).EndInit();
            this.uiPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIScrollingText uiScrollingText1;
        private Sunny.UI.UIPanel uiPanel2;
        private System.Windows.Forms.BindingSource commentBindingSource;
        private Sunny.UI.UIPanel uiPanel3;
        private System.Windows.Forms.BindingSource myCommentsSource;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIDataGridView commentsGridview;
        private Sunny.UI.UIScrollingText pageText;
        private Sunny.UI.UIButton nextBtn;
        private Sunny.UI.UIButton beforeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn praseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
    }
}