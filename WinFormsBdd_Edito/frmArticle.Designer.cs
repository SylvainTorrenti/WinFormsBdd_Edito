namespace WinFormsBdd_Edito
{
    partial class frmArticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticle));
            tlpMain = new TableLayoutPanel();
            dgvArticle = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btRefresh = new Button();
            btAdd = new Button();
            btDelete = new Button();
            btUpdate = new Button();
            tlpBox = new TableLayoutPanel();
            Titre = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxTitle = new TextBox();
            tbxCorps = new TextBox();
            tbxAutor = new TextBox();
            bsArticle = new BindingSource(components);
            tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticle).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tlpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsArticle).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(dgvArticle, 0, 0);
            tlpMain.Controls.Add(flowLayoutPanel1, 0, 2);
            tlpMain.Controls.Add(tlpBox, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 64.6666641F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20.666666F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4444447F));
            tlpMain.Size = new Size(800, 450);
            tlpMain.TabIndex = 0;
            // 
            // dgvArticle
            // 
            dgvArticle.AllowUserToAddRows = false;
            dgvArticle.AllowUserToDeleteRows = false;
            dgvArticle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticle.BackgroundColor = SystemColors.Control;
            dgvArticle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticle.Dock = DockStyle.Fill;
            dgvArticle.Location = new Point(3, 3);
            dgvArticle.Name = "dgvArticle";
            dgvArticle.ReadOnly = true;
            dgvArticle.RowHeadersVisible = false;
            dgvArticle.RowTemplate.Height = 25;
            dgvArticle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticle.Size = new Size(794, 285);
            dgvArticle.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btRefresh);
            flowLayoutPanel1.Controls.Add(btAdd);
            flowLayoutPanel1.Controls.Add(btDelete);
            flowLayoutPanel1.Controls.Add(btUpdate);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 387);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 60);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btRefresh
            // 
            btRefresh.Image = Properties.Resources.refresh_arrow_1546;
            btRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btRefresh.Location = new Point(3, 3);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(103, 55);
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
            btAdd.Location = new Point(112, 3);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(103, 55);
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
            btDelete.Location = new Point(221, 3);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(103, 55);
            btDelete.TabIndex = 2;
            btDelete.Text = "Supprimer";
            btDelete.TextAlign = ContentAlignment.MiddleRight;
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btUpdate
            // 
            btUpdate.Image = Properties.Resources.pen_edit_modify_pencil_icon_181536;
            btUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btUpdate.Location = new Point(330, 3);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(103, 55);
            btUpdate.TabIndex = 3;
            btUpdate.Text = "Modifier";
            btUpdate.TextAlign = ContentAlignment.MiddleRight;
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // tlpBox
            // 
            tlpBox.ColumnCount = 2;
            tlpBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.86902F));
            tlpBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.13098F));
            tlpBox.Controls.Add(Titre, 0, 0);
            tlpBox.Controls.Add(label2, 0, 1);
            tlpBox.Controls.Add(label3, 0, 2);
            tlpBox.Controls.Add(tbxTitle, 1, 0);
            tlpBox.Controls.Add(tbxCorps, 1, 1);
            tlpBox.Controls.Add(tbxAutor, 1, 2);
            tlpBox.Dock = DockStyle.Fill;
            tlpBox.Location = new Point(3, 294);
            tlpBox.Name = "tlpBox";
            tlpBox.RowCount = 3;
            tlpBox.RowStyles.Add(new RowStyle());
            tlpBox.RowStyles.Add(new RowStyle());
            tlpBox.RowStyles.Add(new RowStyle());
            tlpBox.Size = new Size(794, 87);
            tlpBox.TabIndex = 2;
            // 
            // Titre
            // 
            Titre.AutoSize = true;
            Titre.Dock = DockStyle.Fill;
            Titre.Location = new Point(3, 0);
            Titre.Name = "Titre";
            Titre.Size = new Size(120, 29);
            Titre.TabIndex = 0;
            Titre.Text = "Titre";
            Titre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(120, 29);
            label2.TabIndex = 1;
            label2.Text = "Corps";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 58);
            label3.Name = "label3";
            label3.Size = new Size(120, 29);
            label3.TabIndex = 2;
            label3.Text = "Auteur";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxTitle
            // 
            tbxTitle.Dock = DockStyle.Fill;
            tbxTitle.Location = new Point(129, 3);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new Size(662, 23);
            tbxTitle.TabIndex = 3;
            // 
            // tbxCorps
            // 
            tbxCorps.Dock = DockStyle.Fill;
            tbxCorps.Location = new Point(129, 32);
            tbxCorps.Name = "tbxCorps";
            tbxCorps.Size = new Size(662, 23);
            tbxCorps.TabIndex = 4;
            // 
            // tbxAutor
            // 
            tbxAutor.Dock = DockStyle.Fill;
            tbxAutor.Location = new Point(129, 61);
            tbxAutor.Name = "tbxAutor";
            tbxAutor.Size = new Size(662, 23);
            tbxAutor.TabIndex = 5;
            // 
            // frmArticle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmArticle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmArticle";
            Load += frmArticle_Load;
            tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArticle).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tlpBox.ResumeLayout(false);
            tlpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsArticle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private DataGridView dgvArticle;
        private BindingSource bsArticle;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btRefresh;
        private Button btAdd;
        private Button btDelete;
        private Button btUpdate;
        private TableLayoutPanel tlpBox;
        private Label Titre;
        private Label label2;
        private Label label3;
        private TextBox tbxTitle;
        private TextBox tbxCorps;
        private TextBox tbxAutor;
    }
}