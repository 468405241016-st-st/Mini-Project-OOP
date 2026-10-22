using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Mini_Project_OOP.Model
{
    /// <summary>ชื่อตารางจริงในฐานข้อมูล เช่น [TableName("tbl_Customers")] (ถ้าไม่ใส่ จะใช้ชื่อคลาส)</summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class TableNameAttribute : Attribute
    {
        public string Name { get; }
        public TableNameAttribute(string name) { Name = name; }
    }

    /// <summary>ชื่อคอลัมน์จริง เช่น [ColumnName("full_name")] (ถ้าไม่ใส่ จะใช้ชื่อ property)</summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnNameAttribute : Attribute
    {
        public string Name { get; }
        public ColumnNameAttribute(string name) { Name = name; }
    }

    /// <summary>ระบุ Primary Key (ถ้าไม่ใส่ ระบบจะใช้ property ชื่อ Id)</summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKeyAttribute : Attribute { }

    /// <summary>
    /// ระบุชื่อ property ที่เป็น Foreign Key เองเมื่อไม่ตรง convention
    /// เช่น [ForeignKeyName("OwnerId")] public User Owner { get; set; }
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ForeignKeyNameAttribute : Attribute
    {
        public string Name { get; }
        public ForeignKeyNameAttribute(string name) { Name = name; }
    }

    /// <summary>
    /// ข้อมูล mapping ของคลาส 1 ชนิด (ตาราง, คีย์, คอลัมน์)
    /// อ่านด้วย reflection ครั้งเดียวแล้วเก็บไว้ใน cache ของ <see cref="EntityMap"/>
    /// </summary>
    internal sealed class EntityInfo
    {
        private readonly Type _type;
        private readonly PropertyInfo _key;
        private readonly Dictionary<string, string> _columnByProperty;
        private PropertyInfo[] _writableProps;
        private string[] _writableColumns;

        public EntityInfo(Type type)
        {
            _type = type;
            Table = type.GetCustomAttribute<TableNameAttribute>()?.Name ?? type.Name;

            var props = type.GetProperties();
            _key = props.FirstOrDefault(p => p.GetCustomAttribute<PrimaryKeyAttribute>() != null)
                   ?? type.GetProperty("Id");

            _columnByProperty = props.ToDictionary(p => p.Name, EntityMap.Column);

            ScalarProps = props.Where(p => p.CanRead && p.CanWrite && EntityMap.IsScalar(p.PropertyType)).ToArray();
            ScalarColumns = ScalarProps.Select(EntityMap.Column).ToArray();
        }

        public string Table { get; }

        /// <summary>property ที่เป็นคอลัมน์จริง (ไม่รวม navigation property)</summary>
        public PropertyInfo[] ScalarProps { get; }

        /// <summary>ชื่อคอลัมน์จริง เรียงตรงกับ <see cref="ScalarProps"/></summary>
        public string[] ScalarColumns { get; }

        public PropertyInfo Key
        {
            get
            {
                if (_key == null)
                    throw new InvalidOperationException($"{_type.Name} ไม่มี Primary Key (ตั้งชื่อ Id หรือใส่ [PrimaryKey])");
                return _key;
            }
        }

        /// <summary>คอลัมน์ที่เขียนได้ = คอลัมน์ทั้งหมด ยกเว้น Primary Key (AutoNumber)</summary>
        public PropertyInfo[] WritableProps
        {
            get
            {
                EnsureWritable();
                return _writableProps;
            }
        }

        public string[] WritableColumns
        {
            get
            {
                EnsureWritable();
                return _writableColumns;
            }
        }

        /// <summary>ถ้า name เป็นชื่อ property จะแปลงเป็นชื่อคอลัมน์ ถ้าไม่ใช่ถือว่าเป็นชื่อคอลัมน์ตรงๆ</summary>
        public string ResolveColumn(string name)
        {
            return _columnByProperty.TryGetValue(name, out string column) ? column : name;
        }

        private void EnsureWritable()
        {
            if (_writableProps != null) return;

            string keyName = Key.Name;
            var props = ScalarProps.Where(p => p.Name != keyName).ToArray();
            _writableColumns = props.Select(EntityMap.Column).ToArray();
            _writableProps = props;
        }
    }

    /// <summary>ตัวช่วยอ่าน mapping ระหว่างคลาส C# กับตาราง/คอลัมน์ใน Access (cache ผล reflection ต่อชนิด)</summary>
    internal static class EntityMap
    {
        private static readonly ConcurrentDictionary<Type, EntityInfo> Cache =
            new ConcurrentDictionary<Type, EntityInfo>();

        public static EntityInfo Of(Type type)
        {
            return Cache.GetOrAdd(type, t => new EntityInfo(t));
        }

        public static string Table(Type type)
        {
            return Of(type).Table;
        }

        public static string Column(PropertyInfo prop)
        {
            return prop.GetCustomAttribute<ColumnNameAttribute>()?.Name ?? prop.Name;
        }

        public static string ResolveColumn(Type type, string name)
        {
            return Of(type).ResolveColumn(name);
        }

        public static PropertyInfo Key(Type type)
        {
            return Of(type).Key;
        }

        public static bool IsScalar(Type type)
        {
            var u = Nullable.GetUnderlyingType(type) ?? type;
            return u.IsPrimitive || u.IsEnum || u == typeof(string) || u == typeof(decimal)
                || u == typeof(DateTime) || u == typeof(Guid) || u == typeof(TimeSpan) || u == typeof(byte[]);
        }
    }
}
