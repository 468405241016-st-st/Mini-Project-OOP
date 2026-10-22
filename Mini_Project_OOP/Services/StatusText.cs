using System.Linq;

namespace Mini_Project_OOP.Services
{
    /// <summary>ตัวช่วยเช็กชื่อสถานะ (ปรับคำให้ตรงกับข้อมูลในตาราง status ได้)</summary>
    public static class StatusText
    {
        public static bool RoomAvailable(string status) => ContainsAny(status, "ว่าง", "available");
        public static bool RoomOccupied(string status) => ContainsAny(status, "เข้าพัก", "ไม่ว่าง", "occupied");
        public static bool RoomMaintenance(string status) => ContainsAny(status, "ซ่อม", "maintenance");

        /// <summary>การจองที่จบแล้ว/ยกเลิก = ไม่ทำให้ห้องไม่ว่าง</summary>
        public static bool BookingInactive(string status) =>
            ContainsAny(status, "ยกเลิก", "cancel", "เช็คเอาท์", "เช็กเอาท์", "check-out", "checkout", "check out", "checkedout", "เสร็จ", "complete");

        private static bool ContainsAny(string text, params string[] keywords)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;

            string lower = text.ToLower();
            return keywords.Any(keyword => lower.Contains(keyword));
        }
    }
}
