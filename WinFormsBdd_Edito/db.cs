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
        public int AddArticle(string Titre, string Corps, string? Auteur)
        {
            try
            {
                _dbconnection.Open();
                var sql = "INSERT INTO article (Titre, Corps , Auteur) VALUES (@Titre, @Corps,@Auteur); SELECT LAST_INSERT_ID() ";
                var result = _dbconnection.Query<int>(sql, new { Titre, Corps, Auteur });
                return result.Single();
            }
            finally
            {
                _dbconnection.Close();
            }
        }
        public int DeleteArticle(int IDArticle)
        {
            try
            {
                _dbconnection.Open();
                var sql = "DELETE FROM article WHERE IDArticle = @IDArticle;";
                return _dbconnection.Execute(sql, new { IDArticle });
            }
            finally
            {
                _dbconnection.Close();
            }
        }
        public int UpdateUser(int IDArticle, string Titre, string Corps, string? Auteur)
        {
            try
            {
                _dbconnection.Open();
                var sql = "UPDATE article SET Titre = @Titre, Corps=@Corps, Auteur=@Auteur WHERE IDArticle = @IDArticle ;";
                return _dbconnection.Execute(sql, new { IDArticle, Titre, Corps, Auteur });
                
            }
            finally
            {
                _dbconnection.Close();
            }
            
        }
    }
}
