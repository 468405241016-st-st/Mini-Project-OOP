using System;
using System.Net.Mail;
using System.Text;

namespace Mini_Project_OOP.Helper
{
    /// <summary>ตัวช่วยจัดการข้อความที่หลายหน้าจอใช้ร่วมกัน (ค้นหา, ตรวจอีเมล, ทำความสะอาดข้อมูลที่กรอก)</summary>
    internal static class TextUtils
    {
        /// <summary>ตัดช่องว่างหัวท้าย แล้วคืน null ถ้าว่าง (ให้บันทึกเป็น NULL ใน DB)</summary>
        public static string NullIfEmpty(string text)
        {
            text = text?.Trim();
            return string.IsNullOrEmpty(text) ? null : text;
        }

        /// <summary>ตัดช่องว่างและขีดทิ้ง เพื่อให้พิมพ์ "081-234" แล้วเจอ "0812345678"</summary>
        public static string Compact(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";

            var result = new StringBuilder(text.Length);
            foreach (char ch in text)
            {
                if (ch != ' ' && ch != '-') result.Append(ch);
            }
            return result.ToString();
        }

        /// <summary>ข้อความที่มีแต่ตัวเลข ช่องว่าง และขีด (เบอร์โทร/เลขบัตร)</summary>
        public static bool IsNumericLike(string text)
        {
            foreach (char ch in text)
            {
                if (!char.IsDigit(ch) && ch != ' ' && ch != '-') return false;
            }
            return true;
        }

        public static bool ContainsIgnoreCase(string source, string term)
        {
            return source != null && source.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public static bool IsValidEmail(string email)
        {
            try { return new MailAddress(email).Address == email; }
            catch (FormatException) { return false; }
        }
    }
}
