namespace WinFormsBdd_Edito
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnArticle = new Button();
            btNewsPaper = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnArticle, 0, 0);
            tableLayoutPanel1.Controls.Add(btNewsPaper, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnArticle
            // 
            btnArticle.Anchor = AnchorStyles.None;
            btnArticle.Location = new Point(162, 101);
            btnArticle.Name = "btnArticle";
            btnArticle.Size = new Size(75, 23);
            btnArticle.TabIndex = 0;
            btnArticle.Text = "Article";
            btnArticle.UseVisualStyleBackColor = true;
            btnArticle.Click += btnArticle_Click;
            // 
            // btNewsPaper
            // 
            btNewsPaper.Anchor = AnchorStyles.None;
            btNewsPaper.Location = new Point(562, 101);
            btNewsPaper.Name = "btNewsPaper";
            btNewsPaper.Size = new Size(75, 23);
            btNewsPaper.TabIndex = 1;
            btNewsPaper.Text = "Journal";
            btNewsPaper.UseVisualStyleBackColor = true;
            btNewsPaper.Click += btNewsPaper_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edito";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnArticle;
        private Button btNewsPaper;
    }
}