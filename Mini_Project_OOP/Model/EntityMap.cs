using System;
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

    /// <summary>ตัวช่วยอ่าน mapping ระหว่างคลาส C# กับตาราง/คอลัมน์ใน Access</summary>
    internal static class EntityMap
    {
        public static string Table(Type type)
        {
            return type.GetCustomAttribute<TableNameAttribute>()?.Name ?? type.Name;
        }

        public static string Column(PropertyInfo prop)
        {
            return prop.GetCustomAttribute<ColumnNameAttribute>()?.Name ?? prop.Name;
        }

        // ถ้า name เป็นชื่อ property จะแปลงเป็นชื่อคอลัมน์ ถ้าไม่ใช่ถือว่าเป็นชื่อคอลัมน์ตรงๆ
        public static string ResolveColumn(Type type, string name)
        {
            var prop = type.GetProperty(name);
            return prop != null ? Column(prop) : name;
        }

        public static PropertyInfo Key(Type type)
        {
            var key = type.GetProperties().FirstOrDefault(p => p.GetCustomAttribute<PrimaryKeyAttribute>() != null)
                      ?? type.GetProperty("Id");
            if (key == null)
                throw new InvalidOperationException($"{type.Name} ไม่มี Primary Key (ตั้งชื่อ Id หรือใส่ [PrimaryKey])");
            return key;
        }

        // property ที่เป็นคอลัมน์จริง (ไม่รวม navigation property)
        public static IEnumerable<PropertyInfo> ScalarProps(Type type)
        {
            return type.GetProperties().Where(p => p.CanRead && p.CanWrite && IsScalar(p.PropertyType));
        }

        public static bool IsScalar(Type type)
        {
            var u = Nullable.GetUnderlyingType(type) ?? type;
            return u.IsPrimitive || u.IsEnum || u == typeof(string) || u == typeof(decimal)
                || u == typeof(DateTime) || u == typeof(Guid) || u == typeof(TimeSpan) || u == typeof(byte[]);
        }
    }
}
