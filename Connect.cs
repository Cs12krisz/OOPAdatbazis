using MySql.Data.MySqlClient;
using OOPAdatbazis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdatbazis
{
    internal class Connect
    {
        public MySqlConnection Connection;

        private string _host;
        private string _database;
        private string _user;
        private string _password;
        private string _conectionString;

        public Connect(string database)
        {
            _host = "localhost";
            _database = database;
            _user = "root";
            _password = "";

            _conectionString = $"Server={_host}; Database={_database}; UID={_user}; Password='{_password}'; SslMode=None;";

            Connection = new MySqlConnection(_conectionString);

            try
            {
                Connection.Open();
                Console.WriteLine("Sikeres csatlakozás");
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
