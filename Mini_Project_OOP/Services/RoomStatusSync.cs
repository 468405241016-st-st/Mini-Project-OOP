using Mini_Project_OOP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Project_OOP.Services
{
    public static class RoomStatusSync
    {
        /// <summary>
        /// คำนวณสถานะห้องใหม่จากการจองที่ยัง active ในวันนี้
        /// เรียกหลังจอง / ยกเลิก / เช็คเอาท์ / แก้ไขการจอง ทุกครั้ง
        /// </summary>
        public static async Task SyncAsync(AppData data)
        {
            var statuses = (await data.RoomStatuses.GetAllAsync()).ToList();
            int? availableId = statuses.FirstOrDefault(s => StatusText.RoomAvailable(s.Status))?.Id;
            int? occupiedId = statuses.FirstOrDefault(s => StatusText.RoomOccupied(s.Status))?.Id;
            if (availableId == null || occupiedId == null) return;   // หาสถานะไม่เจอ ไม่แตะข้อมูล

            var occupiedRoomIds = await FindOccupiedRoomIdsAsync(data, DateTime.Today);
            var rooms = await data.Rooms.GetAllAsync("RoomStatus");

            foreach (var room in rooms)
            {
                if (StatusText.RoomMaintenance(room.RoomStatus?.Status)) continue; // ห้องซ่อมไม่แตะ

                int target = occupiedRoomIds.Contains(room.Id) ? occupiedId.Value : availableId.Value;
                if (room.RoomStatusId == target) continue;

                room.RoomStatusId = target;
                await data.Rooms.UpdateAsync(room);
            }
        }

        // ดึงเฉพาะการจองที่คร่อมวันนี้ (เช็คอิน <= วันนี้ <= เช็คเอาท์) แทนการโหลดการจองทั้งตาราง
        private static async Task<HashSet<int>> FindOccupiedRoomIdsAsync(AppData data, DateTime today)
        {
            var coversToday = new Filter()
                .Lt("CheckinDate", today.AddDays(1))
                .Gte("CheckoutDate", today);

            var bookings = await data.Bookings.FindAsync(coversToday, "BookingStatus");

            return bookings
                .Where(b => !StatusText.BookingInactive(b.BookingStatus?.Status))
                .Select(b => b.RoomId)
                .ToHashSet();
        }
    }
}
