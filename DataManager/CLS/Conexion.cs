using System;
using MySql.Data.MySqlClient;

namespace DataManager.CLS
{
    public class Conexion
    {
        // Variable global para realizar la conexion a la bd
        protected MySqlConnection _connection;

        public Conexion(string user , string psw, string dataBase)
        {
            var mySqlString = $"Server=localhost;Database={dataBase};Uid={user};Pwd={psw};";
            _connection = new MySqlConnection(mySqlString);
        }

        protected Boolean Connected()
        {
            var connected = false;

            try
            {
                _connection.Open();
                connected = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                connected = false;
            }

            return connected;
        }


        protected void Disconnected()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}