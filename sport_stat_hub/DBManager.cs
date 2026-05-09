using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBapplication
{
    public class DBManager
    {
        private string connectionString;

        public DBManager(string connString)
        {
            connectionString = connString;
        }

        private SqlConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }

        public int ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = CreateConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public DataTable ExecuteReader(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = CreateConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                using (SqlConnection conn = CreateConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message); 
                return null;
            }
        }
    }
}