namespace WinFormsBdd_Edito
{
    partial class frmNewsPaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewsPaper));
            tlpNewsPaper = new TableLayoutPanel();
            tlpBox = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tbxTitle = new TextBox();
            dtpRelease = new DateTimePicker();
            dgvNewsPaper = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btRefresh = new Button();
            btAdd = new Button();
            btDelete = new Button();
            btUpdate = new Button();
            bsNewsPaper = new BindingSource(components);
            btExit = new Button();
            tlpNewsPaper.SuspendLayout();
            tlpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNewsPaper).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsNewsPaper).BeginInit();
            SuspendLayout();
            // 
            // tlpNewsPaper
            // 
            tlpNewsPaper.ColumnCount = 1;
            tlpNewsPaper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNewsPaper.Controls.Add(tlpBox, 0, 1);
            tlpNewsPaper.Controls.Add(dgvNewsPaper, 0, 0);
            tlpNewsPaper.Controls.Add(flowLayoutPanel1, 0, 2);
            tlpNewsPaper.Dock = DockStyle.Fill;
            tlpNewsPaper.Location = new Point(0, 0);
            tlpNewsPaper.Name = "tlpNewsPaper";
            tlpNewsPaper.RowCount = 3;
            tlpNewsPaper.RowStyles.Add(new RowStyle(SizeType.Percent, 83.42105F));
            tlpNewsPaper.RowStyles.Add(new RowStyle(SizeType.Percent, 16.5789471F));
            tlpNewsPaper.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tlpNewsPaper.Size = new Size(800, 450);
            tlpNewsPaper.TabIndex = 0;
            // 
            // tlpBox
            // 
            tlpBox.ColumnCount = 2;
            tlpBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6322422F));
            tlpBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.36776F));
            tlpBox.Controls.Add(label1, 0, 0);
            tlpBox.Controls.Add(label2, 0, 1);
            tlpBox.Controls.Add(tbxTitle, 1, 0);
            tlpBox.Controls.Add(dtpRelease, 1, 1);
            tlpBox.Dock = DockStyle.Fill;
            tlpBox.Location = new Point(3, 325);
            tlpBox.Name = "tlpBox";
            tlpBox.RowCount = 2;
            tlpBox.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBox.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBox.Size = new Size(794, 58);
            tlpBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 0;
            label1.Text = "Titre";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(134, 29);
            label2.TabIndex = 1;
            label2.Text = "Date de parution";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxTitle
            // 
            tbxTitle.Dock = DockStyle.Fill;
            tbxTitle.Location = new Point(143, 3);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new Size(648, 23);
            tbxTitle.TabIndex = 2;
            // 
            // dtpRelease
            // 
            dtpRelease.Dock = DockStyle.Fill;
            dtpRelease.Location = new Point(143, 32);
            dtpRelease.Name = "dtpRelease";
            dtpRelease.ShowCheckBox = true;
            dtpRelease.Size = new Size(648, 23);
            dtpRelease.TabIndex = 3;
            // 
            // dgvNewsPaper
            // 
            dgvNewsPaper.AllowUserToAddRows = false;
            dgvNewsPaper.AllowUserToDeleteRows = false;
            dgvNewsPaper.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNewsPaper.BackgroundColor = SystemColors.Control;
            dgvNewsPaper.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNewsPaper.Dock = DockStyle.Fill;
            dgvNewsPaper.Location = new Point(3, 3);
            dgvNewsPaper.Name = "dgvNewsPaper";
            dgvNewsPaper.ReadOnly = true;
            dgvNewsPaper.RowHeadersVisible = false;
            dgvNewsPaper.RowTemplate.Height = 25;
            dgvNewsPaper.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNewsPaper.Size = new Size(794, 316);
            dgvNewsPaper.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btRefresh);
            flowLayoutPanel1.Controls.Add(btAdd);
            flowLayoutPanel1.Controls.Add(btDelete);
            flowLayoutPanel1.Controls.Add(btUpdate);
            flowLayoutPanel1.Controls.Add(btExit);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 389);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(794, 58);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btRefresh
            // 
            btRefresh.Image = Properties.Resources.refresh_arrow_1546;
            btRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btRefresh.Location = new Point(3, 3);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(104, 52);
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
            btAdd.Location = new Point(113, 3);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(104, 52);
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
            btDelete.Location = new Point(223, 3);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(104, 52);
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
            btUpdate.Location = new Point(333, 3);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(104, 52);
            btUpdate.TabIndex = 3;
            btUpdate.Text = "Modifier";
            btUpdate.TextAlign = ContentAlignment.MiddleRight;
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btExit
            // 
            btExit.Image = Properties.Resources.exit_closethesession_close_6317;
            btExit.ImageAlign = ContentAlignment.MiddleLeft;
            btExit.Location = new Point(685, 3);
            btExit.Margin = new Padding(245, 3, 3, 3);
            btExit.Name = "btExit";
            btExit.Size = new Size(104, 52);
            btExit.TabIndex = 4;
            btExit.Text = "Quitter";
            btExit.TextAlign = ContentAlignment.MiddleRight;
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // frmNewsPaper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpNewsPaper);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNewsPaper";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Journals";
            Load += frmNewsPaper_Load;
            tlpNewsPaper.ResumeLayout(false);
            tlpBox.ResumeLayout(false);
            tlpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNewsPaper).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsNewsPaper).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpNewsPaper;
        private TableLayoutPanel tlpBox;
        private Label label1;
        private Label label2;
        private TextBox tbxTitle;
        private DateTimePicker dtpRelease;
        private DataGridView dgvNewsPaper;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btRefresh;
        private Button btAdd;
        private Button btDelete;
        private Button btUpdate;
        private BindingSource bsNewsPaper;
        private Button btExit;
    }
}