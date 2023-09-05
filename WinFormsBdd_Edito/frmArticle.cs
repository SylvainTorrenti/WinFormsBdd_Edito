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
    public partial class frmArticle : Form
    {
        db _db = new db();
        BindingList<Article> _articles = new();
        public frmArticle()
        {
            InitializeComponent();
            InitializeBinding();
        }
        private void frmArticle_Load(object sender, EventArgs e)
        {
            btRefresh.PerformClick();
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
            if (_articles.Where(article => article.Titre == tbxTitle.Text && article.Auteur == tbxAutor.Text && article.Corps == tbxCorps.Text).Count() >= 1 || _articles.Where(article => article.Titre == tbxTitle.Text && article.Auteur == null && article.Corps == tbxCorps.Text).Count() >= 1)
            {
                MessageBox.Show("L'article que vous voulez créé existe déjà", "Erreur de creation", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (MessageBox.Show($"Confirmer la creation de l'article \n nom : {tbxTitle.Text} \n corps : {tbxCorps.Text} \n auteur : {tbxAutor.Text}", "Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                var iDArticle = _db.AddArticle(tbxTitle.Text, tbxCorps.Text, tbxAutor.Text);
                btRefresh.PerformClick();
                bsArticle.Position = _articles.IndexOf(_articles.Where(u => u.iDArticle == iDArticle).FirstOrDefault());
                return;
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Article current = bsArticle.Current as Article;
            if (current is not null)
            {
                if (MessageBox.Show($"Accepter la suppression de l'article {current.Titre} ?", "Suprression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    _db.DeleteArticle(current.iDArticle);
                    btRefresh.PerformClick();
                }

            }

        }


        private void btUpdate_Click(object sender, EventArgs e)
        {
            Article current = bsArticle.Current as Article;
            if (current is not null)
            {
                if (MessageBox.Show($"Confirmer la modification de l'article {current.Titre} ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (tbxAutor != null)
                    {
                        MessageBox.Show($"L'article {current.Titre} a bien était modifier", "Modifications effectuées", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _db.UpdateUser(current.iDArticle, tbxTitle.Text, tbxCorps.Text, tbxAutor.Text);
                        btRefresh.PerformClick();
                    }
                }
            }
        }
        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitializeBinding()
        {
            _articles = new BindingList<Article>();
            bsArticle.DataSource = _articles;
            dgvArticle.DataSource = bsArticle;
            dgvArticle.Columns["iDArticle"].Visible = false;
            tbxTitle.DataBindings.Add("text", bsArticle, "Titre", false, DataSourceUpdateMode.Never);
            tbxAutor.DataBindings.Add("text", bsArticle, "Auteur", false, DataSourceUpdateMode.Never);
            tbxCorps.DataBindings.Add("text", bsArticle, "Corps", false, DataSourceUpdateMode.Never);
        }

       
    }
}
