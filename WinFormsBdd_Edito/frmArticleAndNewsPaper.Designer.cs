namespace WinFormsBdd_Edito
{
    partial class frmArticleAndNewsPaper
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticleAndNewsPaper));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dtpRelease = new DateTimePicker();
            txbNewsTitle = new TextBox();
            txbAutor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbArticleTitle = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btRefresh = new Button();
            btAdd = new Button();
            btDelete = new Button();
            btupdate = new Button();
            btExit = new Button();
            dgvArticleAndNews = new DataGridView();
            bsArticleAndNews = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticleAndNews).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsArticleAndNews).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(dgvArticleAndNews, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.46749F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.53251F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.52141F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.47859F));
            tableLayoutPanel2.Controls.Add(dtpRelease, 1, 3);
            tableLayoutPanel2.Controls.Add(txbNewsTitle, 1, 2);
            tableLayoutPanel2.Controls.Add(txbAutor, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(txbArticleTitle, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 251);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.Size = new Size(794, 136);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dtpRelease
            // 
            dtpRelease.Dock = DockStyle.Fill;
            dtpRelease.Location = new Point(158, 105);
            dtpRelease.Name = "dtpRelease";
            dtpRelease.ShowCheckBox = true;
            dtpRelease.Size = new Size(633, 23);
            dtpRelease.TabIndex = 0;
            // 
            // txbNewsTitle
            // 
            txbNewsTitle.Dock = DockStyle.Fill;
            txbNewsTitle.Location = new Point(158, 73);
            txbNewsTitle.Name = "txbNewsTitle";
            txbNewsTitle.Size = new Size(633, 23);
            txbNewsTitle.TabIndex = 6;
            // 
            // txbAutor
            // 
            txbAutor.Dock = DockStyle.Fill;
            txbAutor.Location = new Point(158, 38);
            txbAutor.Name = "txbAutor";
            txbAutor.Size = new Size(633, 23);
            txbAutor.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 35);
            label1.TabIndex = 0;
            label1.Text = "Titre de l'article";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(149, 35);
            label2.TabIndex = 1;
            label2.Text = "Auteur de l'article";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 2;
            label3.Text = "Titre du journal";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 102);
            label4.Name = "label4";
            label4.Size = new Size(149, 34);
            label4.TabIndex = 3;
            label4.Text = "Date de parution du journal";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbArticleTitle
            // 
            txbArticleTitle.Dock = DockStyle.Fill;
            txbArticleTitle.Location = new Point(158, 3);
            txbArticleTitle.Name = "txbArticleTitle";
            txbArticleTitle.Size = new Size(633, 23);
            txbArticleTitle.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btRefresh);
            flowLayoutPanel1.Controls.Add(btAdd);
            flowLayoutPanel1.Controls.Add(btDelete);
            flowLayoutPanel1.Controls.Add(btupdate);
            flowLayoutPanel1.Controls.Add(btExit);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 393);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 54);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btRefresh
            // 
            btRefresh.Image = Properties.Resources.refresh_arrow_1546;
            btRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btRefresh.Location = new Point(3, 3);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(120, 46);
            btRefresh.TabIndex = 0;
            btRefresh.Text = "Actualiser";
            btRefresh.TextAlign = ContentAlignment.MiddleRight;
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // btAdd
            // 
            btAdd.Image = Properties.Resources.add_icon_icons_com_74429;
            btAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btAdd.Location = new Point(129, 3);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(120, 46);
            btAdd.TabIndex = 1;
            btAdd.Text = "Ajouter";
            btAdd.TextAlign = ContentAlignment.MiddleRight;
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btDelete
            // 
            btDelete.Image = Properties.Resources.recycle_recyclebin_full_delete_trash_1772;
            btDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btDelete.Location = new Point(255, 3);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(120, 46);
            btDelete.TabIndex = 2;
            btDelete.Text = "Supprimer";
            btDelete.TextAlign = ContentAlignment.MiddleRight;
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btupdate
            // 
            btupdate.Image = Properties.Resources.pen_edit_modify_pencil_icon_181536;
            btupdate.ImageAlign = ContentAlignment.MiddleLeft;
            btupdate.Location = new Point(381, 3);
            btupdate.Name = "btupdate";
            btupdate.Size = new Size(120, 46);
            btupdate.TabIndex = 3;
            btupdate.Text = "Modifier";
            btupdate.TextAlign = ContentAlignment.MiddleRight;
            btupdate.UseVisualStyleBackColor = true;
            btupdate.Click += btupdate_Click;
            // 
            // btExit
            // 
            btExit.Image = Properties.Resources.exit_closethesession_close_6317;
            btExit.ImageAlign = ContentAlignment.MiddleLeft;
            btExit.Location = new Point(664, 3);
            btExit.Margin = new Padding(160, 3, 3, 3);
            btExit.Name = "btExit";
            btExit.Size = new Size(120, 46);
            btExit.TabIndex = 4;
            btExit.Text = "Quitter";
            btExit.TextAlign = ContentAlignment.MiddleRight;
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // dgvArticleAndNews
            // 
            dgvArticleAndNews.AllowUserToAddRows = false;
            dgvArticleAndNews.AllowUserToDeleteRows = false;
            dgvArticleAndNews.AllowUserToResizeRows = false;
            dgvArticleAndNews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticleAndNews.BackgroundColor = SystemColors.Control;
            dgvArticleAndNews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticleAndNews.Dock = DockStyle.Fill;
            dgvArticleAndNews.Location = new Point(3, 3);
            dgvArticleAndNews.Name = "dgvArticleAndNews";
            dgvArticleAndNews.ReadOnly = true;
            dgvArticleAndNews.RowHeadersVisible = false;
            dgvArticleAndNews.RowTemplate.Height = 25;
            dgvArticleAndNews.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticleAndNews.Size = new Size(794, 242);
            dgvArticleAndNews.TabIndex = 2;
            // 
            // frmArticleAndNewsPaper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "frmArticleAndNewsPaper";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Articles et Journaux";
            Load += frmArticleAndNewsPaper_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArticleAndNews).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsArticleAndNews).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private DateTimePicker dtpRelease;
        private TextBox txbNewsTitle;
        private TextBox txbAutor;
        private TextBox txbArticleTitle;
        private DataGridView dgvArticleAndNews;
        private BindingSource bsArticleAndNews;
        private Button btRefresh;
        private Button btAdd;
        private Button btDelete;
        private Button btupdate;
        private Button btExit;
    }
}