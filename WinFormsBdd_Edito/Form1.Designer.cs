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
            btCompo = new Button();
            btExit = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.6616325F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.3383675F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 339F));
            tableLayoutPanel1.Controls.Add(btnArticle, 0, 0);
            tableLayoutPanel1.Controls.Add(btNewsPaper, 1, 0);
            tableLayoutPanel1.Controls.Add(btCompo, 2, 0);
            tableLayoutPanel1.Controls.Add(btExit, 1, 1);
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
            btnArticle.Image = Properties.Resources._1486486291_article_news_newspaper_paper_rss_81203;
            btnArticle.ImageAlign = ContentAlignment.MiddleLeft;
            btnArticle.Location = new Point(42, 84);
            btnArticle.Name = "btnArticle";
            btnArticle.Size = new Size(153, 57);
            btnArticle.TabIndex = 0;
            btnArticle.Text = "Article";
            btnArticle.TextAlign = ContentAlignment.MiddleRight;
            btnArticle.UseVisualStyleBackColor = true;
            btnArticle.Click += btnArticle_Click;
            // 
            // btNewsPaper
            // 
            btNewsPaper.Anchor = AnchorStyles.None;
            btNewsPaper.Image = Properties.Resources.diagram_01_24516;
            btNewsPaper.ImageAlign = ContentAlignment.MiddleLeft;
            btNewsPaper.Location = new Point(272, 84);
            btNewsPaper.Name = "btNewsPaper";
            btNewsPaper.Size = new Size(153, 57);
            btNewsPaper.TabIndex = 1;
            btNewsPaper.Text = "Journal";
            btNewsPaper.TextAlign = ContentAlignment.MiddleRight;
            btNewsPaper.UseVisualStyleBackColor = true;
            btNewsPaper.Click += btNewsPaper_Click;
            // 
            // btCompo
            // 
            btCompo.Anchor = AnchorStyles.None;
            btCompo.Image = Properties.Resources._62871rolledupnewspaper_109257;
            btCompo.ImageAlign = ContentAlignment.MiddleLeft;
            btCompo.Location = new Point(553, 84);
            btCompo.Name = "btCompo";
            btCompo.Size = new Size(153, 57);
            btCompo.TabIndex = 2;
            btCompo.Text = "Journaux et articles";
            btCompo.TextAlign = ContentAlignment.MiddleRight;
            btCompo.UseVisualStyleBackColor = true;
            btCompo.Click += btCompo_Click;
            // 
            // btExit
            // 
            btExit.Anchor = AnchorStyles.None;
            btExit.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btExit.Image = Properties.Resources.exit_closethesession_close_6317;
            btExit.ImageAlign = ContentAlignment.MiddleLeft;
            btExit.Location = new Point(266, 301);
            btExit.Name = "btExit";
            btExit.Size = new Size(165, 73);
            btExit.TabIndex = 3;
            btExit.Text = "Quitter";
            btExit.TextAlign = ContentAlignment.MiddleRight;
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
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
        private Button btCompo;
        private Button btExit;
    }
}