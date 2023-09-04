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
    }
}