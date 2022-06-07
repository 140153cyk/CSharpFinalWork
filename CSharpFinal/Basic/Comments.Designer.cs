namespace Basic
{
  partial class Comments
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
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.commentGridView = new Sunny.UI.UIDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.praseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.SystemColors.Control;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(237, 391);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 25;
            this.uiButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButton1.Size = new System.Drawing.Size(75, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 2;
            this.uiButton1.Text = "赞";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(901, 391);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 25;
            this.uiButton2.Size = new System.Drawing.Size(75, 35);
            this.uiButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton2.TabIndex = 3;
            this.uiButton2.Text = "评论";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiTextBox1);
            this.uiPanel1.Controls.Add(this.uiButton3);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.commentGridView);
            this.uiPanel1.Controls.Add(this.uiButton2);
            this.uiPanel1.Controls.Add(this.uiButton1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1482, 753);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBox1.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiTextBox1.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiTextBox1.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBox1.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiTextBox1.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(837, 115);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Multiline = true;
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBox1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTextBox1.ShowScrollBar = true;
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(208, 212);
            this.uiTextBox1.Style = Sunny.UI.UIStyle.Orange;
            this.uiTextBox1.TabIndex = 7;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.uiTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(360, 391);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Radius = 25;
            this.uiButton3.Size = new System.Drawing.Size(100, 35);
            this.uiButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton3.TabIndex = 6;
            this.uiButton3.Text = "查看回复";
            this.uiButton3.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.White;
            this.uiLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(0, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(1482, 75);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Orange;
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "妙 语 诗 评";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // commentGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.commentGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.commentGridView.AutoGenerateColumns = false;
            this.commentGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.commentGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.commentGridView.ColumnHeadersHeight = 32;
            this.commentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.commentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userAccountDataGridViewTextBoxColumn,
            this.detailDataGridViewTextBoxColumn,
            this.poemIdDataGridViewTextBoxColumn,
            this.poemsDataGridViewTextBoxColumn,
            this.praseDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn});
            this.commentGridView.DataSource = this.commentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.commentGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.commentGridView.EnableHeadersVisualStyles = false;
            this.commentGridView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commentGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(69)))));
            this.commentGridView.Location = new System.Drawing.Point(3, 78);
            this.commentGridView.Name = "commentGridView";
            this.commentGridView.ReadOnly = true;
            this.commentGridView.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.commentGridView.RowHeadersWidth = 51;
            this.commentGridView.RowHeight = 27;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.commentGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.commentGridView.RowTemplate.Height = 27;
            this.commentGridView.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.commentGridView.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.commentGridView.SelectedIndex = -1;
            this.commentGridView.Size = new System.Drawing.Size(803, 307);
            this.commentGridView.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.commentGridView.Style = Sunny.UI.UIStyle.Orange;
            this.commentGridView.TabIndex = 4;
            this.commentGridView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.commentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commentGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // userAccountDataGridViewTextBoxColumn
            // 
            this.userAccountDataGridViewTextBoxColumn.DataPropertyName = "UserAccount";
            this.userAccountDataGridViewTextBoxColumn.HeaderText = "UserAccount";
            this.userAccountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userAccountDataGridViewTextBoxColumn.Name = "userAccountDataGridViewTextBoxColumn";
            this.userAccountDataGridViewTextBoxColumn.ReadOnly = true;
            this.userAccountDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailDataGridViewTextBoxColumn
            // 
            this.detailDataGridViewTextBoxColumn.DataPropertyName = "Detail";
            this.detailDataGridViewTextBoxColumn.HeaderText = "Detail";
            this.detailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailDataGridViewTextBoxColumn.Name = "detailDataGridViewTextBoxColumn";
            this.detailDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailDataGridViewTextBoxColumn.Width = 125;
            // 
            // poemIdDataGridViewTextBoxColumn
            // 
            this.poemIdDataGridViewTextBoxColumn.DataPropertyName = "PoemId";
            this.poemIdDataGridViewTextBoxColumn.HeaderText = "PoemId";
            this.poemIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poemIdDataGridViewTextBoxColumn.Name = "poemIdDataGridViewTextBoxColumn";
            this.poemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.poemIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // poemsDataGridViewTextBoxColumn
            // 
            this.poemsDataGridViewTextBoxColumn.DataPropertyName = "Poems";
            this.poemsDataGridViewTextBoxColumn.HeaderText = "Poems";
            this.poemsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poemsDataGridViewTextBoxColumn.Name = "poemsDataGridViewTextBoxColumn";
            this.poemsDataGridViewTextBoxColumn.ReadOnly = true;
            this.poemsDataGridViewTextBoxColumn.Width = 125;
            // 
            // praseDataGridViewTextBoxColumn
            // 
            this.praseDataGridViewTextBoxColumn.DataPropertyName = "Prase";
            this.praseDataGridViewTextBoxColumn.HeaderText = "Prase";
            this.praseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.praseDataGridViewTextBoxColumn.Name = "praseDataGridViewTextBoxColumn";
            this.praseDataGridViewTextBoxColumn.ReadOnly = true;
            this.praseDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDataGridViewTextBoxColumn.Width = 125;
            // 
            // commentBindingSource
            // 
            this.commentBindingSource.DataSource = typeof(Models.Comment);
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.uiPanel1);
            this.Name = "Comments";
            this.Text = "Comments";
            this.Load += new System.EventHandler(this.Comments_Load);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private Sunny.UI.UIButton uiButton1;
    private Sunny.UI.UIButton uiButton2;
    private Sunny.UI.UIPanel uiPanel1;
    private Sunny.UI.UILabel uiLabel1;
    private Sunny.UI.UIDataGridView commentGridView;
    private Sunny.UI.UIButton uiButton3;
    private Sunny.UI.UITextBox uiTextBox1;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn userAccountDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn poemIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn poemsDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn praseDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource commentBindingSource;
  }
}