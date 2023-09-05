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
    public partial class frmNewsPaper : Form
    {
        db _db = new db();
        BindingList<NewsPaper> _NewsPaper = new();
        public frmNewsPaper()
        {
            InitializeComponent();
            InitializeBinding();
        }
        private void frmNewsPaper_Load(object sender, EventArgs e)
        {
            btRefresh.PerformClick();
        }
        private void btRefresh_Click(object sender, EventArgs e)
        {
            NewsPaper current = bsNewsPaper.Current as NewsPaper;

            _NewsPaper.Clear();

            var j = _db.GetNewsPaper();

            foreach (NewsPaper journal in j)
                _NewsPaper.Add(journal);

            if (current is not null)
            {
                bsNewsPaper.Position = _NewsPaper.IndexOf(_NewsPaper.Where(u => u.IDJournal == current.IDJournal).FirstOrDefault());
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (_NewsPaper.Where(newspaper => newspaper.Titre == tbxTitle.Text && newspaper.DtParution == dtpRelease.Value).Count() >= 1 || _NewsPaper.Where(newspaper => newspaper.Titre == tbxTitle.Text && newspaper.DtParution == null).Count() >= 1)
            {
                MessageBox.Show("Le journal que vous voulez créé existe déjà", "Erreur de creation", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (dtpRelease.Checked == true)
            {
                if (MessageBox.Show($"Confirmer la creation du journal \n nom : {tbxTitle.Text} \n date de parution {dtpRelease.Text}", "Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var iDArticle = _db.AddNewsPaper(tbxTitle.Text, dtpRelease.Value);
                    btRefresh.PerformClick();
                    bsNewsPaper.Position = _NewsPaper.IndexOf(_NewsPaper.Where(u => u.IDJournal == iDArticle).FirstOrDefault());
                    return;
                }
            }
            else
            {
                if (MessageBox.Show($"Confirmer la creation du journal \n nom : {tbxTitle.Text} \n sans date de parution", "Creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var iDArticle = _db.AddNewsPaper(tbxTitle.Text, null);
                    btRefresh.PerformClick();
                    bsNewsPaper.Position = _NewsPaper.IndexOf(_NewsPaper.Where(u => u.IDJournal == iDArticle).FirstOrDefault());
                    return;
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            NewsPaper current = bsNewsPaper.Current as NewsPaper;
            if (current is not null)
            {
                if (MessageBox.Show($"Accepter la suppression du journal {current.Titre} ?", "Suprression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    _db.DeleteNewsPaper(current.IDJournal);
                    btRefresh.PerformClick();
                }

            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            NewsPaper current = bsNewsPaper.Current as NewsPaper;
            if (current is not null)
            {
                if (MessageBox.Show($"Confirmer la modification du journal {current.Titre} ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    if (dtpRelease.Checked == true)
                    {
                        if (current.DtParution == null)
                        {
                            var nb2 = _db.UpdateNewsPaper(current.IDJournal, tbxTitle.Text, dtpRelease.Value);
                            if (nb2 == 1)
                            {
                                if (dtpRelease.Checked == true)
                                {
                                    MessageBox.Show($"Les modifications du journal {current.Titre} ont étaient effectuées. \n Maintenant elles sont : \n Nom : {tbxTitle.Text} \n  \n Date de naissance : {dtpRelease.Text}", "Modifications effectuées");
                                }
                                else
                                {

                                    _db.UpdateNewsPaper(current.IDJournal, tbxTitle.Text, null);
                                    MessageBox.Show($"Les modifications du journal {current.Titre} ont étaient effectuées. \n Maintenant elles sont : \n Nom : {tbxTitle.Text} \n Date de parution : Sans date", "Modifications effectuées");
                                }

                                btRefresh.PerformClick();
                            }
                        }




                        var nb = _db.UpdateNewsPaper(current.IDJournal, tbxTitle.Text, dtpRelease.Value);
                        if (nb == 1)
                        {

                            if (dtpRelease.Checked == true)
                            {

                                MessageBox.Show($"Les modifications du journal {current.Titre} ont étaient effectuées. \n Maintenant elles sont : \n Nom : {tbxTitle.Text} \n Date de parution : {dtpRelease.Text}", "Modifications effectuées");
                            }
                            else
                            {

                                _db.UpdateNewsPaper(current.IDJournal, tbxTitle.Text, null);
                                MessageBox.Show($"Les modifications du journal {current.Titre} ont étaient effectuées. \n Maintenant elles sont : \n Nom : {tbxTitle.Text} \n Date de parution : Sans date", "Modifications effectuées");
                            }

                            btRefresh.PerformClick();
                        }

                    }
                    else if (dtpRelease.Checked == false)
                    {
                        var nb = _db.UpdateNewsPaper(current.IDJournal, tbxTitle.Text, null);
                        if (nb == 1)
                        {
                            MessageBox.Show($"Les modifications du journal {current.Titre} ont étaient effectuées. \n Maintenant elles sont : \n Nom : {tbxTitle.Text} \n Date de parution : Sans date", "Modifications effectuées");
                        }

                        btRefresh.PerformClick();

                    }
            }
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitializeBinding()
        {
            _NewsPaper = new BindingList<NewsPaper>();
            bsNewsPaper.DataSource = _NewsPaper;
            dgvNewsPaper.DataSource = bsNewsPaper;
            dgvNewsPaper.Columns["IDJournal"].Visible = false;
            tbxTitle.DataBindings.Add("text", bsNewsPaper, "Titre", false, DataSourceUpdateMode.Never);
            dtpRelease.DataBindings.Add("text", bsNewsPaper, "DtParution", false, DataSourceUpdateMode.Never);
        }


    }
}
