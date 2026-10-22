using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Mini_Project_OOP.Model
{
    /// <summary>
    /// ตัวสร้างเงื่อนไข where / orderBy แบบ fluent ใช้ parameter ทุกค่า (กัน SQL Injection)
    /// ใส่ชื่อ property ของ Model ได้เลย (ระบบแปลงเป็นชื่อคอลัมน์จริงให้)
    /// ตัวอย่าง: new Filter().Eq("Status", "Paid").Gt("TotalPrice", 100).OrderBy("Id", desc: true).Take(10)
    /// </summary>
    public class Filter
    {
        private class Cond
        {
            public string Column;
            public string Op;
            public object Value;
        }

        private readonly List<Cond> _conds = new List<Cond>();
        private readonly List<KeyValuePair<string, bool>> _orders = new List<KeyValuePair<string, bool>>();
        private int? _limit;

        public Filter Eq(string col, object value) => Add(col, "=", value);
        public Filter NotEq(string col, object value) => Add(col, "<>", value);
        public Filter Gt(string col, object value) => Add(col, ">", value);
        public Filter Gte(string col, object value) => Add(col, ">=", value);
        public Filter Lt(string col, object value) => Add(col, "<", value);
        public Filter Lte(string col, object value) => Add(col, "<=", value);
        public Filter Like(string col, string pattern) => Add(col, "LIKE", pattern); // OleDb ใช้ % และ _
        public Filter In(string col, IEnumerable<object> values) => Add(col, "IN", values.ToList());
        public Filter IsNull(string col) => Add(col, "IS NULL", null);
        public Filter NotNull(string col) => Add(col, "IS NOT NULL", null);

        public Filter OrderBy(string col, bool desc = false)
        {
            CheckName(col);
            _orders.Add(new KeyValuePair<string, bool>(col, desc));
            return this;
        }

        /// <summary>จำกัดจำนวนแถวที่ดึงจากฐานข้อมูล (SELECT TOP n) ใช้กับ FindAsync ควรใช้ร่วมกับ OrderBy</summary>
        public Filter Take(int count)
        {
            if (count <= 0) throw new ArgumentOutOfRangeException(nameof(count), "จำนวนแถวต้องมากกว่า 0");
            _limit = count;
            return this;
        }

        // ---- ใช้ภายใน Repository ----
        internal int? Limit => _limit;

        internal string BuildWhere(Dictionary<string, object> parameters, Type entityType)
        {
            var parts = new List<string>();
            foreach (var c in _conds)
            {
                string col = $"[{EntityMap.ResolveColumn(entityType, c.Column)}]";
                switch (c.Op)
                {
                    case "IS NULL":
                    case "IS NOT NULL":
                        parts.Add($"{col} {c.Op}");
                        break;
                    case "IN":
                        var list = (List<object>)c.Value;
                        if (list.Count == 0) { parts.Add("1 = 0"); break; }
                        var names = new List<string>();
                        foreach (var v in list)
                        {
                            string n = $"@f{parameters.Count}";
                            parameters.Add(n, v ?? DBNull.Value);
                            names.Add(n);
                        }
                        parts.Add($"{col} IN ({string.Join(", ", names)})");
                        break;
                    default:
                        string pn = $"@f{parameters.Count}";
                        parameters.Add(pn, c.Value ?? DBNull.Value);
                        parts.Add($"{col} {c.Op} {pn}");
                        break;
                }
            }
            return string.Join(" AND ", parts);
        }

        internal string BuildOrderBy(Type entityType)
        {
            if (_orders.Count == 0) return "";
            var items = _orders.Select(o => $"[{EntityMap.ResolveColumn(entityType, o.Key)}]{(o.Value ? " DESC" : "")}");
            return " ORDER BY " + string.Join(", ", items);
        }

        private Filter Add(string col, string op, object value)
        {
            CheckName(col);
            // Eq(null) -> IS NULL ให้อัตโนมัติ
            if (value == null && op == "=") op = "IS NULL";
            else if (value == null && op == "<>") op = "IS NOT NULL";
            _conds.Add(new Cond { Column = col, Op = op, Value = value });
            return this;
        }

        private static void CheckName(string col)
        {
            if (string.IsNullOrEmpty(col) || !Regex.IsMatch(col, @"^\w+$"))
                throw new ArgumentException($"ชื่อคอลัมน์ไม่ถูกต้อง: '{col}'");
        }
    }

    /// <summary>
    /// ระบุ relation ที่ต้องการ include พร้อม filter (ไม่บังคับ)
    /// string แปลงเป็น IncludeSpec ได้อัตโนมัติ: "Orders" หรือ "Orders.Items"
    /// filter มีผลกับ relation ปลายทางของ path นั้น
    /// </summary>
    public class IncludeSpec
    {
        public string Path { get; }
        public Filter Filter { get; }

        public IncludeSpec(string path, Filter filter = null)
        {
            Path = path;
            Filter = filter;
        }

        public static implicit operator IncludeSpec(string path) => new IncludeSpec(path);
    }
}