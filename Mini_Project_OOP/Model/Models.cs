using System;
using System.Collections.Generic;

namespace Mini_Project_OOP.Model
{
    // ตารางหลัก: ลูกค้า
    [TableName("tbl_Customers")]
    public class Customer
    {
        [ColumnName("customer_id")] public int Id { get; set; }
        [ColumnName("full_name")] public string FullName { get; set; }
        [ColumnName("phone_number")] public string PhoneNumber { get; set; }
        [ColumnName("national_id")] public string NationalId { get; set; }
        [ColumnName("email")] public string Email { get; set; }

        // Navigation: ลูกค้า 1 คน มีได้หลายการจอง
        public List<Booking> Bookings { get; set; }
    }

    // ตารางหลัก: ประเภทห้อง
    [TableName("tbl_RoomTypes")]
    public class RoomType
    {
        [ColumnName("room_type_id")] public int Id { get; set; }
        [ColumnName("name_type")] public string NameType { get; set; }
        [ColumnName("price_per_night")] public decimal PricePerNight { get; set; }
        [ColumnName("capacity")] public int Capacity { get; set; }
        [ColumnName("desciption")] public string Description { get; set; } // คอลัมน์ใน DB สะกดว่า desciption

        public List<Room> Rooms { get; set; }
    }

    // ตารางสถานะห้อง
    [TableName("tbl_RoomStatus")]
    public class RoomStatus
    {
        [ColumnName("room_status_id")] public int Id { get; set; }
        [ColumnName("status")] public string Status { get; set; }

        public List<Room> Rooms { get; set; }
    }

    // ห้องพัก
    [TableName("tbl_Rooms")]
    public class Room
    {
        [ColumnName("room_id")] public int Id { get; set; }
        [ColumnName("room_number")] public string RoomNumber { get; set; }  // ถ้าใน Access เป็นชนิดตัวเลข ให้เปลี่ยนเป็น int
        [ColumnName("room_type_id")] public int RoomTypeId { get; set; }    // FK -> RoomType
        [ColumnName("room_status_id")] public int RoomStatusId { get; set; } // FK -> RoomStatus

        public RoomType RoomType { get; set; }
        public RoomStatus RoomStatus { get; set; }
        public List<Booking> Bookings { get; set; }
    }

    // ตารางสถานะการจอง
    [TableName("tbl_BookingStatus")]
    public class BookingStatus
    {
        [ColumnName("booking_status_id")] public int Id { get; set; }
        [ColumnName("status")] public string Status { get; set; }

        public List<Booking> Bookings { get; set; }
    }

    // การจอง
    [TableName("tbl_Bookings")]
    public class Booking
    {
        [ColumnName("booking_id")] public int Id { get; set; }
        [ColumnName("customer_id")] public int CustomerId { get; set; }          // FK -> Customer
        [ColumnName("room_id")] public int RoomId { get; set; }                  // FK -> Room
        [ColumnName("checkin_date")] public DateTime CheckinDate { get; set; }
        [ColumnName("checkout_date")] public DateTime CheckoutDate { get; set; }
        [ColumnName("total_price")] public decimal TotalPrice { get; set; }
        [ColumnName("booking_status_id")] public int BookingStatusId { get; set; } // FK -> BookingStatus
        [ColumnName("Created_at")] public DateTime CreatedAt { get; set; }

        public Customer Customer { get; set; }
        public Room Room { get; set; }
        public BookingStatus BookingStatus { get; set; }

        public Booking()
        {
            CreatedAt = DateTime.Now; // ค่าเริ่มต้นตอนสร้างการจองใหม่ (ตอนอ่านจาก DB จะถูกทับด้วยค่าจริง)
        }
    }
}
