using Mini_Project_OOP.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Mini_Project_OOP.Model
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private const int ChunkSize = 500;
        private readonly DatabaseService _dbService;
        private readonly EntityInfo _entity;
        private readonly string _tableName;

        public Repository(DatabaseService dbService)
        {
            _dbService = dbService;
            _entity = EntityMap.Of(typeof(T));
            _tableName = _entity.Table; // [TableName] หรือชื่อคลาส
        }

        // ---------------------------------------------------------------
        // READ
        // ---------------------------------------------------------------
        public Task<IEnumerable<T>> GetAllAsync(params IncludeSpec[] includes)
        {
            return FindAsync(null, includes);
        }

        public async Task<IEnumerable<T>> FindAsync(Filter where, params IncludeSpec[] includes)
        {
            var parameters = new Dictionary<string, object>();
            string sql = BuildSelect(where, parameters, where?.Limit);

            var rows = await QueryAsync(typeof(T), sql, parameters);
            await LoadIncludesAsync(typeof(T), rows, includes);
            return rows.Cast<T>().ToList();
        }

        public async Task<T> FirstOrDefaultAsync(Filter where, params IncludeSpec[] includes)
        {
            var parameters = new Dictionary<string, object>();
            string sql = BuildSelect(where, parameters, 1);

            var rows = await QueryAsync(typeof(T), sql, parameters);
            if (rows.Count == 0) return null;

            await LoadIncludesAsync(typeof(T), rows, includes);
            return (T)rows[0];
        }

        public Task<T> GetByIdAsync(int id, params IncludeSpec[] includes)
        {
            string keyName = EntityMap.Key(typeof(T)).Name;
            return FirstOrDefaultAsync(new Filter().Eq(keyName, id), includes);
        }

        public async Task<int> CountAsync(Filter where = null)
        {
            var parameters = new Dictionary<string, object>();
            string cond = where?.BuildWhere(parameters, typeof(T)) ?? "";
            string sql = $"SELECT COUNT(*) FROM [{_tableName}]" + (cond.Length > 0 ? " WHERE " + cond : "");

            object result = await Task.Run(() => _dbService.ExecuteScalar(sql, parameters));
            return Convert.ToInt32(result);
        }

        private string BuildSelect(Filter where, Dictionary<string, object> parameters, int? limit)
        {
            string cond = where?.BuildWhere(parameters, typeof(T)) ?? "";
            return $"SELECT {(limit.HasValue ? "TOP " + limit.Value + " " : "")}* FROM [{_tableName}]"
                 + (cond.Length > 0 ? " WHERE " + cond : "")
                 + (where?.BuildOrderBy(typeof(T)) ?? "");
        }

        // ---------------------------------------------------------------
        // WRITE (ข้าม Primary Key และ navigation property อัตโนมัติ)
        // ---------------------------------------------------------------
        public async Task AddAsync(T entity)
        {
            var props = _entity.WritableProps;   // ข้าม Primary Key (AutoNumber)
            var columns = _entity.WritableColumns.Select(c => $"[{c}]");
            var parameters = new Dictionary<string, object>();

            foreach (var prop in props)
                parameters.Add($"@p{parameters.Count}", prop.GetValue(entity) ?? DBNull.Value);

            string sql = $"INSERT INTO [{_tableName}] ({string.Join(", ", columns)}) VALUES ({string.Join(", ", parameters.Keys)})";
            await Task.Run(() => _dbService.ExecuteNonQuery(sql, parameters));
        }

        public async Task UpdateAsync(T entity)
        {
            var key = _entity.Key;
            var props = _entity.WritableProps;
            var columns = _entity.WritableColumns;
            var updateFields = new List<string>(props.Length);
            var parameters = new Dictionary<string, object>();

            for (int i = 0; i < props.Length; i++)
            {
                string pn = $"@p{parameters.Count}";
                updateFields.Add($"[{columns[i]}] = {pn}");
                parameters.Add(pn, props[i].GetValue(entity) ?? DBNull.Value);
            }

            parameters.Add("@id", key.GetValue(entity)); // OleDb ใช้ลำดับ จึงต้องไว้ท้ายสุด
            string sql = $"UPDATE [{_tableName}] SET {string.Join(", ", updateFields)} WHERE [{EntityMap.Column(key)}] = @id";
            await Task.Run(() => _dbService.ExecuteNonQuery(sql, parameters));
        }

        public async Task DeleteAsync(int id)
        {
            var key = _entity.Key;
            string sql = $"DELETE FROM [{_tableName}] WHERE [{EntityMap.Column(key)}] = @id";
            var parameters = new Dictionary<string, object> { { "@id", id } };
            await Task.Run(() => _dbService.ExecuteNonQuery(sql, parameters));
        }

        // ---------------------------------------------------------------
        // INCLUDE ENGINE
        // ---------------------------------------------------------------
        private class NavRequest
        {
            public Filter Filter;
            public List<IncludeSpec> Nested = new List<IncludeSpec>();
        }

        private async Task LoadIncludesAsync(Type type, List<object> entities, IEnumerable<IncludeSpec> includes)
        {
            if (entities.Count == 0 || includes == null) return;

            // "Bookings.Room" + "Bookings" -> Bookings : { filter, nested [Room] }
            var groups = new Dictionary<string, NavRequest>();
            foreach (var inc in includes)
            {
                if (inc == null || string.IsNullOrWhiteSpace(inc.Path)) continue;

                var parts = inc.Path.Split(new[] { '.' }, 2);
                if (!groups.TryGetValue(parts[0], out var req))
                {
                    req = new NavRequest();
                    groups[parts[0]] = req;
                }

                if (parts.Length == 1)
                {
                    if (inc.Filter != null) req.Filter = inc.Filter;
                }
                else
                {
                    req.Nested.Add(new IncludeSpec(parts[1], inc.Filter));
                }
            }

            foreach (var g in groups)
                await LoadNavigationAsync(type, entities, g.Key, g.Value.Filter, g.Value.Nested);
        }

        private async Task LoadNavigationAsync(Type type, List<object> entities, string navName,
                                               Filter filter, List<IncludeSpec> nested)
        {
            var navProp = type.GetProperty(navName);
            if (navProp == null)
                throw new ArgumentException($"ไม่พบ property '{navName}' ใน {type.Name}");

            Type elementType = GetCollectionElementType(navProp.PropertyType);
            var idProp = EntityMap.Key(type);
            string fkName = navProp.GetCustomAttribute<ForeignKeyNameAttribute>()?.Name; // ชื่อ property ของ FK

            if (elementType != null)
            {
                // ---- One-to-Many: Customer.Bookings (FK อยู่ที่ Booking.CustomerId) ----
                fkName = fkName ?? type.Name + "Id";
                var childFk = elementType.GetProperty(fkName);
                if (childFk == null)
                    throw new ArgumentException($"ไม่พบ FK property '{fkName}' ใน {elementType.Name} (ใช้ [ForeignKeyName] ระบุเองได้)");

                var parentIds = entities.Select(e => Convert.ToInt32(idProp.GetValue(e))).Distinct().ToList();
                var children = await QueryByKeysAsync(elementType, EntityMap.Column(childFk), parentIds, filter);

                var lookup = children
                    .Where(c => childFk.GetValue(c) != null)
                    .GroupBy(c => Convert.ToInt32(childFk.GetValue(c)))
                    .ToDictionary(g => g.Key, g => g.ToList());

                var listType = typeof(List<>).MakeGenericType(elementType);
                foreach (var parent in entities)
                {
                    var list = (IList)Activator.CreateInstance(listType);
                    int pid = Convert.ToInt32(idProp.GetValue(parent));
                    if (lookup.TryGetValue(pid, out var items))
                        foreach (var item in items) list.Add(item);
                    navProp.SetValue(parent, list);
                }

                await LoadIncludesAsync(elementType, children, nested);
            }
            else
            {
                // ---- Many-to-One: Booking.Customer (FK อยู่ที่ Booking.CustomerId) ----
                fkName = fkName ?? navName + "Id";
                var fkProp = type.GetProperty(fkName);
                if (fkProp == null)
                    throw new ArgumentException($"ไม่พบ FK property '{fkName}' ใน {type.Name} (ใช้ [ForeignKeyName] ระบุเองได้)");

                var relatedType = navProp.PropertyType;
                var relatedKey = EntityMap.Key(relatedType);

                var fkValues = entities
                    .Select(e => fkProp.GetValue(e))
                    .Where(v => v != null)
                    .Select(v => Convert.ToInt32(v))
                    .Distinct().ToList();

                var related = await QueryByKeysAsync(relatedType, EntityMap.Column(relatedKey), fkValues, filter);
                var map = related.ToDictionary(r => Convert.ToInt32(relatedKey.GetValue(r)));

                foreach (var e in entities)
                {
                    var v = fkProp.GetValue(e);
                    if (v != null && map.TryGetValue(Convert.ToInt32(v), out var r))
                        navProp.SetValue(e, r); // ถ้าโดน filter ตัดออก จะเป็น null (เหมือน Prisma)
                }

                await LoadIncludesAsync(relatedType, related, nested);
            }
        }

        // SELECT * FROM [Table] WHERE [column] IN (?, ...) [AND filter] [ORDER BY ...] แบ่งเป็นชุดๆ
        // column = ชื่อคอลัมน์จริงในฐานข้อมูล
        private async Task<List<object>> QueryByKeysAsync(Type type, string column, List<int> keys, Filter filter)
        {
            var result = new List<object>();
            string table = EntityMap.Table(type);

            for (int i = 0; i < keys.Count; i += ChunkSize)
            {
                var chunk = keys.Skip(i).Take(ChunkSize).ToList();
                var parameters = new Dictionary<string, object>();
                foreach (var k in chunk)
                    parameters.Add($"@k{parameters.Count}", k); // key มาก่อน filter ตามลำดับ ? ใน SQL

                string sql = $"SELECT * FROM [{table}] WHERE [{column}] IN ({string.Join(", ", parameters.Keys)})";

                string cond = filter?.BuildWhere(parameters, type) ?? "";
                if (cond.Length > 0) sql += " AND " + cond;
                sql += filter?.BuildOrderBy(type) ?? "";

                result.AddRange(await QueryAsync(type, sql, parameters));
            }
            return result;
        }

        // ---------------------------------------------------------------
        // HELPERS
        // ---------------------------------------------------------------
        private async Task<List<object>> QueryAsync(Type type, string sql, Dictionary<string, object> parameters = null)
        {
            DataTable dt = await Task.Run(() => _dbService.ExecuteQuery(sql, parameters));
            return MapRows(type, dt);
        }

        private static List<object> MapRows(Type type, DataTable table)
        {
            // จับคู่ property กับคอลัมน์ของตารางผลลัพธ์ "ครั้งเดียวต่อตาราง" ไม่ค้นหาซ้ำทุกแถว
            var entity = EntityMap.Of(type);
            var props = new List<PropertyInfo>();
            var columns = new List<DataColumn>();
            for (int i = 0; i < entity.ScalarProps.Length; i++)
            {
                if (!table.Columns.Contains(entity.ScalarColumns[i])) continue;
                props.Add(entity.ScalarProps[i]);
                columns.Add(table.Columns[entity.ScalarColumns[i]]);
            }

            var list = new List<object>(table.Rows.Count);
            foreach (DataRow row in table.Rows)
            {
                var item = Activator.CreateInstance(type);
                for (int i = 0; i < props.Count; i++)
                {
                    object value = row[columns[i]];
                    if (value != DBNull.Value)
                        props[i].SetValue(item, ConvertValue(value, props[i].PropertyType));
                }
                list.Add(item);
            }
            return list;
        }

        private static object ConvertValue(object value, Type targetType)
        {
            var target = Nullable.GetUnderlyingType(targetType) ?? targetType;
            if (target.IsEnum) return Enum.ToObject(target, value);
            if (target.IsInstanceOfType(value)) return value;
            return Convert.ChangeType(value, target);
        }

        private static Type GetCollectionElementType(Type type)
        {
            if (type == typeof(string) || !type.IsGenericType) return null;
            var args = type.GetGenericArguments();
            if (args.Length == 1 && typeof(IEnumerable).IsAssignableFrom(type)) return args[0];
            return null;
        }
    }
}