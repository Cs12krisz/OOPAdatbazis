using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdatbazis.Services
{
    internal class Library : ISqlStatements
    {
        
        public List<object> GetAllData(string dbName)
        {

            Connect library = new Connect(dbName);
            List<object> cars = new List<object>();
            library.Connection.Open();

            string sql = "SELECT * FROM books";

            MySqlCommand cmd = new MySqlCommand(sql, library.Connection);

            MySqlDataReader rekordok = cmd.ExecuteReader();
            

            while (rekordok.Read())
            {
                var car = new
                {
                    id = rekordok.GetInt32("id"),
                    title = rekordok.GetString("title"),
                    author = rekordok.GetString("author"),
                    releaseDate = rekordok.GetDateTime("releaseDate")
                };
                cars.Add(car);
            }

            library.Connection.Close();
            return cars;
        }

        public object AddNewItem(object newRecord)
        {
            Connect library = new Connect("library");

            library.Connection.Open();

            string sql = "INSERT INTO books (title, author, releaseDate) VALUES (@title, @author, @releaseDate)";

            MySqlCommand cmd = new MySqlCommand(sql, library.Connection);
            
            var book = newRecord.GetType().GetProperties();
            cmd.Parameters.AddWithValue("@title", book[0].Name);
            cmd.Parameters.AddWithValue("@author", book[1].Name);
            cmd.Parameters.AddWithValue("@releaseDate", book[2].Name);
            cmd.ExecuteNonQuery();

            library.Connection.Close();

            var result = new
            {
                message = "Sikeres felvétel",
                result = newRecord
            };

            return result;
        }

        public object DeleteItem(int id)
        {
            throw new NotImplementedException();
        }


        public object GetById(int id)
        {
            Connect library = new Connect("library");

            library.Connection.Open();

            string sql = "SELECT * FROM books WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, library.Connection);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dr = cmd.ExecuteReader();
            
            dr.Read();

            var record = new
            {
                id = dr.GetInt32("id"),
                title = dr.GetString("title"),
                author = dr.GetString("author"),
                releaseDate = dr.GetDateTime("releaseDate")
            };

            library.Connection.Close();

            return record;
        }

        public object UpdateItem(object modifiedItem)
        {
            throw new NotImplementedException();
        }
    }
}
