using Mini_Project_OOP.Forms;
using Mini_Project_OOP.Model;
using Mini_Project_OOP.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Mini_Project_OOP
{
    public partial class FormLogin : Form
    {
        private readonly DatabaseService _db = AppDb.Instance;

        public FormLogin()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            this.AcceptButton = btnLogin;

            btnLogin.Click += btnLogin_Click;
            checkBox1.CheckedChanged += (s, e) =>
                txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();   // ถ้าเปลี่ยนชื่อเป็น txtUsername แล้ว ให้แก้ตรงนี้
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้และรหัสผ่าน", "แจ้งเตือน",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"SELECT user_id, User_name, full_name, user_role
                               FROM tbl_Users
                               WHERE User_name = @User_name AND [PassWord] = @PassWord";

                // OleDb ใช้พารามิเตอร์ตามลำดับ ต้องเรียง User_name ก่อน PassWord
                var parameters = new Dictionary<string, object>
                {
                    { "@User_name", username },
                    { "@PassWord", password }
                };

                DataTable dt = _db.ExecuteQuery(sql, parameters);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "เข้าสู่ระบบไม่สำเร็จ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                DataRow row = dt.Rows[0];

                CurrentUser.User = new tbl_Users
                {
                    UserName = row["User_name"].ToString(),
                    FullName = row["full_name"].ToString(),
                    UserRole = row["user_role"].ToString()
                };

                FormMain main = new FormMain();
                main.FormClosed += (s, args) => this.Close();
                this.Hide();
                main.Show();
            }
            catch (Exception ex)
            {
                string dbFile = System.IO.Path.Combine(Application.StartupPath, "Mini_Project_Database.accdb");
                MessageBox.Show(
                    "เชื่อมต่อฐานข้อมูลไม่สำเร็จ\n" + ex.Message +
                    "\n\nPath: " + dbFile +
                    "\nมีไฟล์อยู่: " + System.IO.File.Exists(dbFile) +
                    "\nProcess 64-bit: " + Environment.Is64BitProcess);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}