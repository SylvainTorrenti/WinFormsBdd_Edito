using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBdd_Edito
{
    internal class Article
    {
        public int iDArticle { get; set; }
        public string Titre { get; set; }
        public string Corps { get; set; }
        public string? Auteur { get; set; }
    }
}
