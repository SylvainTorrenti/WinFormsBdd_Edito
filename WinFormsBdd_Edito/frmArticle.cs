using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBdd_Edito
{
    public partial class frmArticle : Form
    {
        db _db = new db();
        BindingList<Article> _articles = new();
        public frmArticle()
        {
            InitializeComponent();
            InitializeBinding();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            Article current = bsArticle.Current as Article;

            _articles.Clear();

            var u = _db.GetUtilisateurs();

            foreach (Article utilisateur in u)
                _articles.Add(utilisateur);

            if (current is not null)
            {
                bsArticle.Position = _articles.IndexOf(_articles.Where(u => u.iDArticle == current.iDArticle).FirstOrDefault());
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }
        private void InitializeBinding()
        {
            _articles = new BindingList<Article>();
            bsArticle.DataSource = _articles;
            dgvArticle.DataSource = bsArticle;
            dgvArticle.Columns["iDArticle"].Visible = false;
        }
    }
}
