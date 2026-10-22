using System.IO;
using System.Windows.Forms;

namespace Mini_Project_OOP.Services
{
    /// <summary>การเชื่อมต่อฐานข้อมูลสำหรับหน้าเข้าสู่ระบบ (ไฟล์ .accdb อยู่โฟลเดอร์เดียวกับโปรแกรม)</summary>
    public static class AppDb
    {
        public const string DatabaseFileName = "Mini_Project_Database.accdb";
        public static readonly string ProjectDirectory = Directory.GetParent(Application.StartupPath).Parent.FullName;

        public static readonly string DbPath = Path.Combine(ProjectDirectory, DatabaseFileName);

        public static readonly DatabaseService Instance = new DatabaseService(DbPath);
    }
}
