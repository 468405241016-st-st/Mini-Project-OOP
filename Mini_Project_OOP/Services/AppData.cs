using Mini_Project_OOP.Model;

namespace Mini_Project_OOP.Services
{
    /// <summary>จุดรวม Repository ของทุกตาราง (ทุกหน้าจอใช้ตัวเดียวกันที่ส่งมาจาก FormMain)</summary>
    public class AppData
    {
        public Repository<Customer> Customers { get; }
        public Repository<RoomType> RoomTypes { get; }
        public Repository<RoomStatus> RoomStatuses { get; }
        public Repository<Room> Rooms { get; }
        public Repository<BookingStatus> BookingStatuses { get; }
        public Repository<Booking> Bookings { get; }

        public AppData(string dbPath)
        {
            var db = new DatabaseService(dbPath);
            Customers = new Repository<Customer>(db);
            RoomTypes = new Repository<RoomType>(db);
            RoomStatuses = new Repository<RoomStatus>(db);
            Rooms = new Repository<Room>(db);
            BookingStatuses = new Repository<BookingStatus>(db);
            Bookings = new Repository<Booking>(db);
        }
    }
}
