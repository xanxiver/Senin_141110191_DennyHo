
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sql = MySql.Data.MySqlClient;
namespace Latihan_Pos.Class
{
    class Database
    {
        private static string connectionString = "Server=localhost;Uid=root;Pwd=xCJxNr2U5xan9U6Z;";
        private static Sql.MySqlConnection conn = new Sql.MySqlConnection();
        public static void OpenConnection()
        {
            try
            {
                conn.ConnectionString = connectionString;
                conn.Open();
            }
            catch (Sql.MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public static void InsertData(string table, Dictionary<string, object> parameters)
        {
            int i = 0;
            Sql.MySqlCommand cmd = conn.CreateCommand();
            string cmdText = "INSERT INTO " + table + "(";

            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                if (i > 0)
                {
                    cmdText += ", ";
                }
                cmdText += parameter.Key;
                cmd.Parameters.AddWithValue('@' + parameter.Key, parameter.Value);
                i++;
            }
            cmdText += ", created_at, updated_at) VALUES (";
            cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
            i = 0;
            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                if (i > 0)
                {
                    cmdText += ", ";
                }
                cmdText += '@' + parameter.Key;
                i++;
            }
            cmdText += ", @created_at, @updated_at)";
            cmd.CommandText = cmdText;
            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateData(string table, Dictionary<string, object> parameters, int id)
        {
            int i = 0;
            Sql.MySqlCommand cmd = conn.CreateCommand();
            string cmdText = "UPDATE " + table + " SET ";

            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                if (i > 0)
                {
                    cmdText += ", ";
                }
                cmdText += parameter.Key + " = @" + parameter.Key;
                cmd.Parameters.AddWithValue('@' + parameter.Key, parameter.Value);
                i++;
            }
            cmdText += ", updated_at = @updated_at WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
            cmd.CommandText = cmdText;
            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteData(string table, int id)
        {
            int i = 0;
            Sql.MySqlCommand cmd = conn.CreateCommand();
            string cmdText = "DELETE FROM " + table + " WHERE id = @id";
            Console.WriteLine(cmdText);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = cmdText;
            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw new Exception(ex.Message);
            }
        }

        public static DataTable SelectData(string table)
        {
            OpenConnection();
            string select = "SELECT * FROM " + table;
            Sql.MySqlDataAdapter da = new Sql.MySqlDataAdapter(select, conn);

            Sql.MySqlCommandBuilder cb = new Sql.MySqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            CloseConnection();

            DataTable dt = ds.Tables[0].Clone();

            foreach (DataColumn dc in dt.Columns)
            {
                dc.DataType = typeof(string);
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dt.ImportRow(row);
            }
            return dt;
        }
    }
}
