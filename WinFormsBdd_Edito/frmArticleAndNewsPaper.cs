using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsBdd_Edito
{
    public partial class frmArticleAndNewsPaper : Form
    {
        db _db = new db();
        BindingList<ArticleAndNewspaper> _articleAndNewspapers = new();
        public frmArticleAndNewsPaper()
        {
            InitializeComponent();
            InitializeBinding();
        }

        private void frmArticleAndNewsPaper_Load(object sender, EventArgs e)
        {
            btRefresh.PerformClick();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            ArticleAndNewspaper current = bsArticleAndNews.Current as ArticleAndNewspaper;

            _articleAndNewspapers.Clear();

            var aAndNews = _db.GetArticleAndNewspaper();

            foreach (ArticleAndNewspaper ArticleAndNewspaper in aAndNews)
                _articleAndNewspapers.Add(ArticleAndNewspaper);

            if (current is not null)
            {
                bsArticleAndNews.Position = _articleAndNewspapers.IndexOf(_articleAndNewspapers.Where(u => u.Titrejournal == current.Titrejournal).FirstOrDefault());
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void btupdate_Click(object sender, EventArgs e)
        {

        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitializeBinding()
        {
            _articleAndNewspapers = new BindingList<ArticleAndNewspaper>();
            bsArticleAndNews.DataSource = _articleAndNewspapers;
            dgvArticleAndNews.DataSource = bsArticleAndNews;
            dgvArticleAndNews.Columns["iDArticle"].Visible = false;
            dgvArticleAndNews.Columns["IDJournal"].Visible = false;
            txbArticleTitle.DataBindings.Add("text", bsArticleAndNews, "TitreArticle", false, DataSourceUpdateMode.Never);
            txbAutor.DataBindings.Add("text", bsArticleAndNews, "Auteur", false, DataSourceUpdateMode.Never);
            txbNewsTitle.DataBindings.Add("text", bsArticleAndNews, "Titrejournal", false, DataSourceUpdateMode.Never);
            dtpRelease.DataBindings.Add("text", bsArticleAndNews, "DtParution", false, DataSourceUpdateMode.Never);
        }


    }
}
