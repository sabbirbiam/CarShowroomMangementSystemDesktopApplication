using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CarShowRoomManagmentSystem.Data
{
    public static class DataAccess
    {
        static SqlConnection conn;

        static SqlConnection Connection
        {
            get
            {
                conn = new SqlConnection(Contacto.Data.Properties.Settings.Default.personDbConnectionString);
                conn.Open();
                return conn;
            }
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteNonQuery();
        }

        public static SqlDataReader GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteReader();
        }
    }
}
