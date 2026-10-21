using Mini_Project_OOP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project_OOP.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            if (CurrentUser.User != null)
            {
                lblUserName.Text = CurrentUser.User.UserName;   // หรือ FullName ถ้าอยากโชว์ชื่อเต็ม
                lblUserRole.Text = CurrentUser.User.UserRole;
            }

            btnLogout.Click += (s, e) =>
            {
                CurrentUser.User = null;
                Application.Restart();
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlHost_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
