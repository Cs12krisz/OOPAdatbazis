using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdatbazis.Services
{
    internal class Library : ILibrary
    {


        public Library() { }
        
        public List<object> GetAllData(string dbName)
        {

            Connect library = new Connect(dbName);
            List<object> books = new List<object>();
            library.Connection.Open();

            string sql = "SELECT * FROM books";

            MySqlCommand cmd = new MySqlCommand(sql, library.Connection);

            MySqlDataReader rekordok = cmd.ExecuteReader();
            

            while (rekordok.Read())
            {
                var book = new
                {
                    id = rekordok.GetInt32("id"),
                    title = rekordok.GetString("title"),
                    author = rekordok.GetString("author"),
                    releaseDate = rekordok.GetDateTime("releaseDate")
                };
                books.Add(book);
            }

            library.Connection.Close();
            return books;
        }

    }
}
