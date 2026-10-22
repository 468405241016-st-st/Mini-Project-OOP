namespace Mini_Project_OOP.Model
{
    /// <summary>ผู้ใช้ที่เข้าสู่ระบบ (ข้อมูลจากตาราง tbl_Users)</summary>
    public class AppUser
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string UserRole { get; set; }
    }
}
