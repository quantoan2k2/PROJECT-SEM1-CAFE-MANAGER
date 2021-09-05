using System;
using MySql.Data.MySqlClient;

namespace LoginDal
{
    public class DbHelper
    {
        private static MySqlConnection connection;
        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection
                {
                    ConnectionString = "server=localhost;user id=vtca;password=vtcacademy;port=3306;database=login;"
                };
            }
            return connection;
        }
        private DbHelper(){}
    }
}
