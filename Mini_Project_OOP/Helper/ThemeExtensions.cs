using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mini_Project_OOP.Constants;

namespace Mini_Project_OOP.Helper
{
    internal  static class ThemeExtensions
    {
        public static void ToPrimaryButton(this Button btn)
        {
            btn.BackColor = AppTheme.Primary;
            btn.ForeColor = Color.White;
            btn.Font = AppTheme.Body;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }
    }
}
