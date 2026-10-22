namespace Mini_Project_OOP.Constants
{
    /// <summary>ชื่อสถานะห้อง ต้องตรงกับคอลัมน์ status ใน tbl_RoomStatus</summary>
    public static class RoomStatusName
    {
        public const string Available = "Available";
        public const string Occupied = "Occupied";
        public const string Maintenance = "Maintenance";
    }

    /// <summary>ชื่อสถานะการจอง ต้องตรงกับคอลัมน์ status ใน tbl_BookingStatus</summary>
    public static class BookingStatusName
    {
        public const string Confirmed = "Confirmed";
        public const string CheckedIn = "CheckedIn";
        public const string CheckedOut = "CheckedOut";
        public const string Cancelled = "Cancelled";
    }
}
