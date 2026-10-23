using System;
using System.IO;
using System.Windows.Forms;

namespace Mini_Project_OOP.Services
{
    public static class AppDb
    {
        public const string DatabaseFileName = "Mini_Project_Database.accdb";

        // เรียกใช้ฟังก์ชันย้ายฐานข้อมูลไปไว้ใน AppData\Local ที่ถาวรและปลอดภัย
        public static readonly string DbPath = GetOrCreatePersistentDatabasePath();

        public static readonly DatabaseService Instance = new DatabaseService(DbPath);

        private static string GetOrCreatePersistentDatabasePath()
        {
            // 1. กำหนดโฟลเดอร์ส่วนตัวของแอปเราในเครื่องผู้ใช้ (เช่น AppData\Local\Mini_Project_OOP)
            string appName = "Mini_Project_OOP";
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string targetDirectory = Path.Combine(localAppData, appName);

            // ถ้ายังไม่มีโฟลเดอร์นี้ ให้สร้างขึ้นมาใหม่
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            string targetFilePath = Path.Combine(targetDirectory, DatabaseFileName);

            // 2. ถ้ารันครั้งแรก (ใน AppData ยังไม่มีไฟล์) ให้ก๊อปปี้ไฟล์ต้นฉบับที่ติดมากับโปรแกรมมาวางไว้ที่นี่
            if (!File.Exists(targetFilePath))
            {
                string sourceFilePath = Path.Combine(Application.StartupPath, DatabaseFileName);
                if (File.Exists(sourceFilePath))
                {
                    File.Copy(sourceFilePath, targetFilePath);
                }
            }

            // 3. คืนค่า Path นี้ให้โปรแกรมใช้งาน (Path นี้จะคงที่ถาวร ไม่เปลี่ยนตาม ClickOnce อีกต่อไป)
            return targetFilePath;
        }
    }
}