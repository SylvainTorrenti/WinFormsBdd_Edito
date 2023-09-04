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
            bsArticle = new BindingSource(components);
            tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticle).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsArticle).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(dgvArticle, 0, 0);
            tlpMain.Controls.Add(flowLayoutPanel1, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70.6666641F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 29.333334F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            dgvArticle.Size = new Size(794, 311);
            dgvArticle.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btRefresh);
            flowLayoutPanel1.Controls.Add(btAdd);
            flowLayoutPanel1.Controls.Add(btDelete);
            flowLayoutPanel1.Controls.Add(btUpdate);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 320);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 127);
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
            // frmArticle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmArticle";
            Text = "frmArticle";
            tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArticle).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
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
    }
}