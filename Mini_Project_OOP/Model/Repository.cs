using Mini_Project_OOP.Model;
using Mini_Project_OOP.Services; // มั่นใจว่า using แฟ้มที่เก็บ DatabaseService แล้ว
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;


namespace Mini_Project_OOP.Model
{
    // กำหนดให้ T ต้องเป็น Class และสามารถ new() เปล่าๆ ได้
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly DatabaseService _dbService;
        private readonly string _tableName;

        // รับ DatabaseService เข้ามาใช้งานผ่าน Constructor
        public Repository(DatabaseService dbService)
        {
            _dbService = dbService;
            _tableName = typeof(T).Name; // ชื่อคลาส T ต้องตรงกับชื่อตารางใน Access
        }

        // 1. ดึงข้อมูลทั้งหมด
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            string sql = $"SELECT * FROM [{_tableName}]";

            // เรียกใช้ ExecuteQuery ของคุณ (รันแบบ Task เพื่อให้เป็น Async)
            DataTable dt = await Task.Run(() => _dbService.ExecuteQuery(sql));

            var list = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapRowToEntity(row));
            }
            return list;
        }

        // 2. ดึงข้อมูลตาม ID
        public async Task<T> GetByIdAsync(int id)
        {
            string sql = $"SELECT * FROM [{_tableName}] WHERE [Id] = @Id";
            var parameters = new Dictionary<string, object> { { "@Id", id } };

            DataTable dt = await Task.Run(() => _dbService.ExecuteQuery(sql, parameters));

            if (dt.Rows.Count > 0)
            {
                return MapRowToEntity(dt.Rows[0]);
            }
            return null;
        }

        // 3. เพิ่มข้อมูลใหม่
        public async Task AddAsync(T entity)
        {
            var properties = typeof(T).GetProperties();
            var columns = new List<string>();
            var parameters = new Dictionary<string, object>();

            foreach (var prop in properties)
            {
                if (prop.Name == "Id") continue; // ข้ามช่อง Id ที่เป็น AutoNumber ของ Access

                columns.Add($"[{prop.Name}]");
                // ใน Access OleDb ลำดับพารามิเตอร์สำคัญมาก แนะนำให้ใช้เครื่องหมาย ? หรือชื่อที่สื่อสาร
                parameters.Add($"@{prop.Name}", prop.GetValue(entity) ?? DBNull.Value);
            }

            string sql = $"INSERT INTO [{_tableName}] ({string.Join(", ", columns)}) VALUES ({string.Join(", ", parameters.Keys)})";

            // เรียกใช้ ExecuteNonQuery ของคุณ
            await Task.Run(() => _dbService.ExecuteNonQuery(sql, parameters));
        }

        // 4. แก้ไขข้อมูล
        public async Task UpdateAsync(T entity)
        {
            var properties = typeof(T).GetProperties();
            var updateFields = new List<string>();
            var parameters = new Dictionary<string, object>();
            object idValue = null;

            foreach (var prop in properties)
            {
                if (prop.Name == "Id")
                {
                    idValue = prop.GetValue(entity);
                    continue;
                }

                updateFields.Add($"[{prop.Name}] = @{prop.Name}");
                parameters.Add($"@{prop.Name}", prop.GetValue(entity) ?? DBNull.Value);
            }

            // ใส่พารามิเตอร์ของ WHERE ต่อท้ายสุด (สำคัญมากสำหรับ Access OleDb)
            parameters.Add("@Id", idValue);

            string sql = $"UPDATE [{_tableName}] SET {string.Join(", ", updateFields)} WHERE [Id] = @Id";

            await Task.Run(() => _dbService.ExecuteNonQuery(sql, parameters));
        }

        // 5. ลบข้อมูล
        public async Task DeleteAsync(int id)
        {
            string sql = $"DELETE FROM [{_tableName}] WHERE [Id] = @Id";
            var parameters = new Dictionary<string, object> { { "@Id", id } };

            await Task.Run(() => _dbService.ExecuteNonQuery(sql, parameters));
        }

        // ฟังก์ชันภายใน: แปลง DataRow จาก DataTable ให้กลายเป็น Class C# วัตถุอัตโนมัติ
        private T MapRowToEntity(DataRow row)
        {
            var item = new T();
            var properties = typeof(T).GetProperties();

            foreach (var prop in properties)
            {
                // ตรวจสอบว่าใน DataTable มีคอลัมน์ชื่อตรงกับ Property ไหม และข้อมูลไม่เป็น Null
                if (row.Table.Columns.Contains(prop.Name) && row[prop.Name] != DBNull.Value)
                {
                    prop.SetValue(item, row[prop.Name]);
                }
            }
            return item;
        }
    }
}
