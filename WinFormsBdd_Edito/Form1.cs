namespace WinFormsBdd_Edito
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            using frmArticle frmArticle = new();
            frmArticle.ShowDialog();

        }

        private void btNewsPaper_Click(object sender, EventArgs e)
        {
            using frmNewsPaper frmNewsPaper = new();
            frmNewsPaper.ShowDialog();
        }

        private void btCompo_Click(object sender, EventArgs e)
        {
            using frmArticleAndNewsPaper frmArticleAndNewsPaper = new();
            frmArticleAndNewsPaper.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}