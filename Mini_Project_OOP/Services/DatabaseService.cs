using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_OOP.Services
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public string ConnectionString => _connectionString;

        public DatabaseService(string dbPath)
        {
            _connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;";
        }

        public DatabaseService(string connectionString, bool isCustomString)
        {
            _connectionString = connectionString;
        }

        public DataTable ExecuteQuery(string sql, Dictionary<string, object> parameters = null)
        {
            DataTable dt = new DataTable();

            using (OleDbConnection conn = new OleDbConnection(_connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    AddParameters(cmd, parameters);
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public int ExecuteNonQuery(string sql, Dictionary<string, object> parameters = null)
        {
            int rowsAffected = 0;

            using (OleDbConnection conn = new OleDbConnection(_connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    AddParameters(cmd, parameters);
                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

        public object ExecuteScalar(string sql, Dictionary<string, object> parameters = null)
        {
            object result = null;

            using (OleDbConnection conn = new OleDbConnection(_connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    AddParameters(cmd, parameters);
                    conn.Open();
                    result = cmd.ExecuteScalar();
                }
            }

            return result;
        }

        public bool TestConnection()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(_connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void AddParameters(OleDbCommand cmd, Dictionary<string, object> parameters)
        {
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }
            }
        }
    }
}
