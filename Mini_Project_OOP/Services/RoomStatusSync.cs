using Mini_Project_OOP.Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Project_OOP.Services
{
    // ตัวช่วยเช็กชื่อสถานะ (ปรับคำให้ตรงกับข้อมูลในตาราง status ได้)
    public static class StatusText
    {
        private static bool Has(string s, params string[] keys)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            s = s.ToLower();
            return keys.Any(k => s.Contains(k));
        }

        public static bool RoomAvailable(string s) => Has(s, "ว่าง", "available");
        public static bool RoomOccupied(string s) => Has(s, "เข้าพัก", "ไม่ว่าง", "occupied");
        public static bool RoomMaintenance(string s) => Has(s, "ซ่อม", "maintenance");

        // การจองที่จบแล้ว/ยกเลิก = ไม่ทำให้ห้องไม่ว่าง
        public static bool BookingInactive(string s) =>
            Has(s, "ยกเลิก", "cancel", "เช็คเอาท์", "เช็กเอาท์", "check-out", "checkout", "check out", "checkedout", "เสร็จ", "complete");
    }

    public static class RoomStatusSync
    {
        // คำนวณสถานะห้องใหม่จากการจองที่ยัง active ในวันนี้
        // เรียกหลังจอง / ยกเลิก / เช็คเอาท์ / แก้ไขการจอง ทุกครั้ง
        public static async Task SyncAsync(AppData data)
        {
            var statuses = (await data.RoomStatuses.GetAllAsync()).ToList();
            var availableId = statuses.FirstOrDefault(s => StatusText.RoomAvailable(s.Status))?.Id;
            var occupiedId = statuses.FirstOrDefault(s => StatusText.RoomOccupied(s.Status))?.Id;
            if (availableId == null || occupiedId == null) return;   // หาสถานะไม่เจอ ไม่แตะข้อมูล

            var rooms = (await data.Rooms.GetAllAsync("RoomStatus")).ToList();
            var bookings = (await data.Bookings.GetAllAsync("BookingStatus")).ToList();

            DateTime today = DateTime.Today;
            var occupiedRoomIds = bookings
                .Where(b => !StatusText.BookingInactive(b.BookingStatus?.Status)
                            && b.CheckinDate.Date <= today && today <= b.CheckoutDate.Date)
                .Select(b => b.RoomId)
                .ToHashSet();

            foreach (var room in rooms)
            {
                if (StatusText.RoomMaintenance(room.RoomStatus?.Status)) continue; // ห้องซ่อมไม่แตะ

                int target = occupiedRoomIds.Contains(room.Id) ? occupiedId.Value : availableId.Value;
                if (room.RoomStatusId != target)
                {
                    room.RoomStatusId = target;
                    await data.Rooms.UpdateAsync(room);
                }
            }
        }
    }
}