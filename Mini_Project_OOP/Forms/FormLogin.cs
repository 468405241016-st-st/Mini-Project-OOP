using Mini_Project_OOP.Forms;
using Mini_Project_OOP.Model;
using Mini_Project_OOP.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Mini_Project_OOP
{
    public partial class FormLogin : Form
    {
        private readonly DatabaseService _db = AppDb.Instance;

        public FormLogin()
        {
            InitializeComponent();

            AcceptButton = btnLogin;
            btnLogin.Click += btnLogin_Click;

            txtPassword.UseSystemPasswordChar = checkBox1.Checked;
            checkBox1.CheckedChanged += (s, e) =>
                txtPassword.UseSystemPasswordChar = checkBox1.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้และรหัสผ่าน", "แจ้งเตือน",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AppUser user = FindUser(username, password);
                if (user == null)
                {
                    ShowLoginFailed();
                    return;
                }

                CurrentUser.User = user;
                OpenMainForm();
            }
            catch (Exception ex)
            {
                ShowConnectionError(ex);
            }
        }

        // คืน null ถ้าชื่อผู้ใช้หรือรหัสผ่านไม่ตรง
        private AppUser FindUser(string username, string password)
        {
            const string sql = @"SELECT user_id, User_name, full_name, user_role
                                 FROM tbl_Users
                                 WHERE User_name = @User_name AND [PassWord] = @PassWord";

            // OleDb ใช้พารามิเตอร์ตามลำดับ ต้องเรียง User_name ก่อน PassWord
            var parameters = new Dictionary<string, object>
            {
                { "@User_name", username },
                { "@PassWord", password }
            };

            DataTable table = _db.ExecuteQuery(sql, parameters);
            if (table.Rows.Count == 0) return null;

            DataRow row = table.Rows[0];
            return new AppUser
            {
                UserName = row["User_name"].ToString(),
                FullName = row["full_name"].ToString(),
                UserRole = row["user_role"].ToString()
            };
        }

        private void ShowLoginFailed()
        {
            MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "เข้าสู่ระบบไม่สำเร็จ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void OpenMainForm()
        {
            var main = new FormMain();
            main.FormClosed += (s, args) => Close();
            Hide();
            main.Show();
        }

        private static void ShowConnectionError(Exception ex)
        {
            MessageBox.Show(
                "เชื่อมต่อฐานข้อมูลไม่สำเร็จ\n" + ex.Message +
                "\n\nPath: " + AppDb.DbPath +
                "\nมีไฟล์อยู่: " + File.Exists(AppDb.DbPath) +
                "\nProcess 64-bit: " + Environment.Is64BitProcess);
        }
    }
}
