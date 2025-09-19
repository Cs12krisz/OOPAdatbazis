using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdatbazis.Services
{
    internal class Cars : ISqlStatements
    {
        public List<object> GetAllData(string dbName)
        {
            Connect library = new Connect(dbName);
            List<object> cars = new List<object>();
            library.Connection.Open();

            string sql = "SELECT * FROM cars";

            MySqlCommand cmd = new MySqlCommand(sql, library.Connection);

            MySqlDataReader rekordok = cmd.ExecuteReader();


            while (rekordok.Read())
            {
                var car = new
                {
                    id = rekordok.GetInt32("id"),
                    brand = rekordok.GetString("brand"),
                    type = rekordok.GetString("type"),
                    mDate = rekordok.GetDateTime("mDate")
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
            Connect library = new Connect("library");

            library.Connection.Open();

            string sql = "SELECT * FROM cars WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(sql, library.Connection);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            var record = new
            {
                id = dr.GetInt32("id"),
                brand = dr.GetString("brand"),
                type = dr.GetString("type"),
                mDate = dr.GetDateTime("mDate")
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
