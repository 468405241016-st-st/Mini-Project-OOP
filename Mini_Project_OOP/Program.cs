using Mini_Project_OOP.Forms;
using System;
using System.Windows.Forms;

namespace Mini_Project_OOP
{
    internal static class Program
    {
        /// <summary>จุดเริ่มต้นของโปรแกรม</summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
