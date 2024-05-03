using System.Data.Common;
using System.Data;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
//using System.Data

namespace System.Login.DAL
{
    public class Connection
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        SqlConnection conn;

        public static int Connect()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connStr))
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("select 1", sqlConnection);

                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                int val = 0;
                
                while (reader.Read())
                {
                    val = reader.GetInt32(0);
                }

                sqlConnection.Close();

                return val;
            }

        }

        public static DataTable ExecuteReader(string query, OleDbParameter[]? parameters = null)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(query);
                command.Connection = conn;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                OleDbDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                reader.Close();
                return dt;
            }
        }

        public static bool ExecuteNonQuery(string query, OleDbParameter[] parameters)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(query);

                command.Connection = conn;
                command.Parameters.AddRange(parameters);

                int rowAffected = command.ExecuteNonQuery();

                return rowAffected > 0;
            }
        }
    }
}