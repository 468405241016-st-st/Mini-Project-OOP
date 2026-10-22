using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Mini_Project_OOP.Services
{
    /// <summary>ส่งคำสั่ง SQL (แบบ parameter) ไปยังฐานข้อมูล Access ผ่าน OleDb</summary>
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string dbPath)
        {
            _connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;";
        }

        public DataTable ExecuteQuery(string sql, Dictionary<string, object> parameters = null)
        {
            return Execute(sql, parameters, command =>
            {
                var table = new DataTable();
                using (var adapter = new OleDbDataAdapter(command))
                {
                    adapter.Fill(table);
                }
                return table;
            });
        }

        public int ExecuteNonQuery(string sql, Dictionary<string, object> parameters = null)
        {
            return Execute(sql, parameters, command => command.ExecuteNonQuery());
        }

        public object ExecuteScalar(string sql, Dictionary<string, object> parameters = null)
        {
            return Execute(sql, parameters, command => command.ExecuteScalar());
        }

        // เปิด-ปิดการเชื่อมต่อและสร้าง command ที่เดียว เพื่อให้ทุกเมธอดข้างบนเหลือแค่ส่วนที่ต่างกัน
        private T Execute<T>(string sql, Dictionary<string, object> parameters, Func<OleDbCommand, T> run)
        {
            using (var connection = new OleDbConnection(_connectionString))
            using (var command = new OleDbCommand(sql, connection))
            {
                AddParameters(command, parameters);
                connection.Open();
                return run(command);
            }
        }

        private static void AddParameters(OleDbCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null) return;

            foreach (var parameter in parameters)
            {
                object value = parameter.Value ?? DBNull.Value;

                if (value is DateTime dt)
                {
                    // ตัดมิลลิวินาทีทิ้ง และบอกชนิดเป็น Date ให้ Access
                    var dateParameter = command.Parameters.Add(parameter.Key, OleDbType.Date);
                    dateParameter.Value = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);
                }
                else
                {
                    command.Parameters.AddWithValue(parameter.Key, value);
                }
            }
        }
    }
}
