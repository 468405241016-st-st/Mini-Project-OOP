using System.Drawing;

namespace Mini_Project_OOP.Constants
{
    public static class AppTheme
    {
        public static readonly Color Primary = Color.FromArgb(11, 122, 115);   // ปุ่มหลัก
        public static readonly Color PrimaryDark = Color.FromArgb(8, 98, 92);      // หัวข้อการ์ด, หัวตาราง
        public static readonly Color Sidebar = Color.FromArgb(9, 74, 70);
        public static readonly Color SidebarActive = Color.FromArgb(30, 106, 101);
        public static readonly Color Accent = Color.FromArgb(94, 234, 212);   // แถบเมนูที่เลือก
        public static readonly Color SidebarText = Color.FromArgb(213, 240, 236);
        public static readonly Color FormBack = Color.FromArgb(243, 250, 249);  // พื้นหลังหน้า
        public static readonly Color Border = Color.FromArgb(207, 226, 224);
        public static readonly Color InputBorder = Color.FromArgb(107, 148, 144);
        public static readonly Color Text = Color.FromArgb(23, 43, 42);
        public static readonly Color TextMuted = Color.FromArgb(84, 110, 108);
        public static readonly Color GridHeader = Color.FromArgb(224, 242, 240);
        public static readonly Color GridAlt = Color.FromArgb(247, 252, 251);
        public static readonly Color GridSelect = Color.FromArgb(204, 239, 234);
        public static readonly Color Danger = Color.FromArgb(185, 28, 28);

        public static readonly Font Body = new Font("Leelawadee UI", 10F);
        public static readonly Font Input = new Font("Leelawadee UI", 11F);
        public static readonly Font Title = new Font("Leelawadee UI", 16F, FontStyle.Bold);

        // สีป้ายสถานะ (RoomStatus และ BookingStatus) สถานะที่ไม่รู้จัก = สีเทา (เช่น CheckedOut)
        public static Color StatusBack(string s)
        {
            switch (s)
            {
                case RoomStatusName.Available: return Color.FromArgb(220, 252, 231);
                case RoomStatusName.Occupied:
                case BookingStatusName.Cancelled: return Color.FromArgb(254, 226, 226);
                case RoomStatusName.Maintenance: return Color.FromArgb(254, 243, 199);
                case BookingStatusName.Confirmed: return Color.FromArgb(219, 234, 254);
                case BookingStatusName.CheckedIn: return Color.FromArgb(204, 251, 241);
                default: return Color.FromArgb(229, 231, 235);
            }
        }

        public static Color StatusFore(string s)
        {
            switch (s)
            {
                case RoomStatusName.Available: return Color.FromArgb(22, 101, 52);
                case RoomStatusName.Occupied:
                case BookingStatusName.Cancelled: return Color.FromArgb(153, 27, 27);
                case RoomStatusName.Maintenance: return Color.FromArgb(146, 64, 14);
                case BookingStatusName.Confirmed: return Color.FromArgb(30, 64, 175);
                case BookingStatusName.CheckedIn: return Color.FromArgb(17, 94, 89);
                default: return Color.FromArgb(55, 65, 81);
            }
        }
    }
}
