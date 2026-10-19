using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_OOP.Model
{
    public class tbl_Bookings
    {
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public Decimal TotalPrice { get; set; }
        public int BookingStatusId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
