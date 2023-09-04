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
            _db.AddArticle(tbxTitle.Text, tbxCorps.Text, tbxAutor.Text);
            btRefresh.PerformClick();
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
            //Verifie que le current n'est pas null
            if (current is not null)
            {
                //Affiche une MessageBox demandant la confirmation de l'update de l'utilisateur.
                //Dans ce MessageBox les information fournit pour l'update sont présente pour que l'utilisateur voit precisement ce qu'il va mettre à jour
                //Si l'utilisateur confirme la requête est affectuée
                if (MessageBox.Show($"Confirmer la modification de l'article {current.Titre} ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    _db.UpdateUser(current.iDArticle, tbxTitle.Text, tbxCorps.Text, tbxAutor.Text);
                    btRefresh.PerformClick();
                }
            }
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
