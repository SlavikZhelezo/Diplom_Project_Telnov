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

        public static string Name_user { get; set; }

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

        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=Semenovski3Polk13;database=client_database;port=3306");

        public void openClient()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        public void closeClient()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public MySqlConnection getClient()
        {
            return conn;
        }

        //MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=Semenovski3Polk13;database=ohooligans_bakunina;port=3306");

        MySqlConnection connector = new MySqlConnection("server=localhost;user=root;password=Semenovski3Polk13;database=bakunina_history;port=3306");

        public void openConn()
        {
            if (connector.State == System.Data.ConnectionState.Closed)
                connector.Open();
        }

        public void closeConn()
        {
            if (connector.State == System.Data.ConnectionState.Open)
                connector.Close();
        }

        public MySqlConnection getConn()
        {
            return connector;

        }
    }
}
