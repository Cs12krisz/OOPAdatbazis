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
            throw new NotImplementedException();
        }

        public object DeleteItem(int id)
        {
            throw new NotImplementedException();
        }


        public object GetById(int id)
        {
            throw new NotImplementedException();
        }

        public object UpdateItem(object modifiedItem)
        {
            throw new NotImplementedException();
        }
    }
}
