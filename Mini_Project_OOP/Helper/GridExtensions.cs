using System.Reflection;
using System.Windows.Forms;

namespace Mini_Project_OOP.Helper
{
    internal static class GridExtensions
    {
        private static readonly PropertyInfo DoubleBufferedProperty =
            typeof(DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);

        /// <summary>เปิด Double buffer ให้ตารางเลื่อน/วาดลื่นขึ้น (DataGridView ไม่เปิดให้ตั้งค่าตรงๆ)</summary>
        public static void EnableDoubleBuffer(this DataGridView grid)
        {
            DoubleBufferedProperty?.SetValue(grid, true, null);
        }
    }
}
