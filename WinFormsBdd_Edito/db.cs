using Dapper;
using MySql.Data.MySqlClient;
using WinFormsBdd_Edito;
using WinFormsBdd_Edito.Properties;
using Dapper;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Xml.Linq;

namespace WinFormsBdd_Edito
{
    internal class db
    {
        private readonly MySqlConnection _dbconnection;
        public db()
        {
           
            _dbconnection = new(Settings.Default.dbConnect);
        }
       
        public IEnumerable<Article> GetUtilisateurs()
        {
        
            try
            {
                _dbconnection.Open();
                var q = "SELECT * from article";
                return _dbconnection.Query<Article>(q);
            }
            
            finally
            {
                _dbconnection.Close();
            }

        }
    }
}
