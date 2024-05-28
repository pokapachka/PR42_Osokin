using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ПР42_Осокин.Classes
{
    public class Connection
    {
        private static readonly string config = "server=KAKTYC\\SQLEXPRESS;Trusted_Connection=No;DataBase=ShopContent;User=Pepsi;pwd=0000";

        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(config);
            connection.Open();
            return connection;
        }

        public static SqlDataReader Query(string SQL, out SqlConnection connection)
        {
            connection = OpenConnection();
            return new SqlCommand(SQL, connection).ExecuteReader();
        }

        public static void CloseConnection(SqlConnection connection)
        {
            connection.Close();
            SqlConnection.ClearPool(connection);
        }
    }
}
