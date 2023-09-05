using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBdd_Edito
{
    internal class ArticleAndNewspaper
    {
        public int IDArticle { get; set; }
        public int IDJournal { get; set; }
        public string TitreArticle { get; set; }
        public string? Auteur { get; set; }
        public string Titrejournal { get; set; }
        public DateTime? DtParution { get; set; }
    }
}
