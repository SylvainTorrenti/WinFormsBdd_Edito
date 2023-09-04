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
            using frmArticle frm = new();
            frm.ShowDialog();

        }
    }
}