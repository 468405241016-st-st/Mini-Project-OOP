using Mini_Project_OOP.Model;

namespace Mini_Project_OOP.Services
{
    /// <summary>ผู้ใช้ที่กำลังล็อกอินอยู่ (null = ยังไม่ได้ล็อกอิน)</summary>
    public static class CurrentUser
    {
        public static AppUser User { get; set; }
    }
}
