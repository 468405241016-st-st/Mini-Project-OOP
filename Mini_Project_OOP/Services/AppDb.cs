using Mini_Project_OOP.Model;
using System.IO;
using System.Windows.Forms;

namespace Mini_Project_OOP.Services
{
    public static class AppDb
    {
        private static readonly string DbPath =
            Path.Combine(Application.StartupPath, "Mini_Project_Database.accdb");

        public static readonly DatabaseService Instance = new DatabaseService(DbPath);
    }
}