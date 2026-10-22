using Mini_Project_OOP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_OOP.Services
{
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
