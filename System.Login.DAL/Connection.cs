using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace System.Login.DAL
{
    public class Connection
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

        SqlConnection conn;

        //public static DataTable ExecuteReader(string query, OleDbParameter[]? parameters = null)
        //{
        //    using (OleDbConnection conn = new OleDbConnection(connStr))
        //    {
        //        conn.Open();
        //        OleDbCommand command = new OleDbCommand(query);
        //        command.Connection = conn;

        //        if (parameters != null)
        //        {
        //            command.Parameters.AddRange(parameters);
        //        }

        //        OleDbDataReader reader = command.ExecuteReader();

        //        DataTable dt = new DataTable();
        //        dt.Load(reader);

        //        reader.Close();
        //        return dt;
        //    }
        //}

        public static bool ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, conn);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters);

                conn.Open();

                int rowAffected = command.ExecuteNonQuery();

                return rowAffected > 0;
            }
        }
    }
}