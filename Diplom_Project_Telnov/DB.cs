using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Diplom_Project_Telnov
{
    class DB
    {

        public static string choosePub { get; set; }
        //MySqlConnection connection = new MySqlConnection(choosePub);
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=Semenovski3Polk13;database=ohooligans_bakunina;port=3306");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public static string SimpleString { get; set; }
    }
}
