using Mini_Project_OOP.Constants;
using Mini_Project_OOP.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Mini_Project_OOP.Forms
{
    public partial class FormMain : Form
    {
        // ไฟล์ฐานข้อมูลอยู่ที่โฟลเดอร์โปรเจกต์ (ขึ้นจาก bin\Debug สองชั้น)
        public string DatabaseRelativePath = AppDb.DbPath;
        private const int IndicatorWidth = 3;

        private readonly AppData _appData;
        private readonly List<Button> _navItems = new List<Button>();
        private readonly Dictionary<Button, Panel> _indicators = new Dictionary<Button, Panel>();

        private Form _activeForm;

        public FormMain()
        {
            InitializeComponent();

            if (CurrentUser.User != null)
            {
                lblUserName.Text = CurrentUser.User.UserName;   // เปลี่ยนเป็น FullName ถ้าอยากโชว์ชื่อเต็ม
                lblUserRole.Text = CurrentUser.User.UserRole;
            }

            btnLogout.Click += btnLogout_Click;

            RegisterNavItem(btnNavDashboard);
            RegisterNavItem(btnNavBooking);
            RegisterNavItem(btnNavRooms);
            RegisterNavItem(btnNavCustomers);
            RegisterNavItem(btnNavBookingList);

            _appData = new AppData(Path.GetFullPath(
                Path.Combine(Application.StartupPath, DatabaseRelativePath)));

            ShowDashboard();
        }

        // ---------------------------------------------------------------
        // NAVIGATION
        // ---------------------------------------------------------------
        private void ShowDashboard()
        {
            ShowPage(btnNavDashboard, new ucDashboard(_appData, () => btnNavBooking.PerformClick()));
        }

        // เลือกเมนู + เปิดหน้าลงในพื้นที่หลัก + ตั้งหัวข้อหน้าตามชื่อเมนู
        private void ShowPage(Button navItem, Form page)
        {
            SelectNavItem(navItem);
            OpenChildForm(page);
            lblPageTitle.Text = navItem.Text;
        }

        private void RegisterNavItem(Button button)
        {
            _navItems.Add(button);

            button.FlatStyle = FlatStyle.Flat;
            button.UseVisualStyleBackColor = false;

            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = AppTheme.Sidebar;
            button.FlatAppearance.MouseDownBackColor = AppTheme.SidebarActive;
            button.FlatAppearance.MouseOverBackColor = AppTheme.SidebarActive;

            button.BackColor = AppTheme.Sidebar;
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;
            button.TextAlign = ContentAlignment.MiddleLeft;

            var indicator = new Panel
            {
                Width = IndicatorWidth,
                Dock = DockStyle.Left,
                BackColor = AppTheme.Accent,
                Visible = false
            };

            button.Controls.Add(indicator);
            indicator.BringToFront();

            _indicators.Add(button, indicator);
        }

        private void SelectNavItem(Button selectedButton)
        {
            foreach (Button button in _navItems)
            {
                bool isSelected = button == selectedButton;
                Color background = isSelected ? AppTheme.SidebarActive : AppTheme.Sidebar;

                button.BackColor = background;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.BorderColor = background;

                _indicators[button].Visible = isSelected;
                _indicators[button].BringToFront();
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
            {
                pnlHost.Controls.Remove(_activeForm);
                _activeForm.Close();
                _activeForm.Dispose();
            }

            _activeForm = childForm;

            childForm.SuspendLayout();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.WindowState = FormWindowState.Normal;
            childForm.Dock = DockStyle.Fill;
            childForm.Margin = Padding.Empty;

            pnlHost.Controls.Add(childForm);

            childForm.ResumeLayout();
            childForm.Show();
            childForm.BringToFront();
        }

        // ---------------------------------------------------------------
        // EVENT HANDLERS (ผูกจาก Designer)
        // ---------------------------------------------------------------
        private void btnNavDashboard_Click(object sender, EventArgs e) => ShowDashboard();

        private void btnNavBooking_Click(object sender, EventArgs e) =>
            ShowPage(btnNavBooking, new ucBooking(_appData));

        private void btnNavRooms_Click(object sender, EventArgs e) =>
            ShowPage(btnNavRooms, new ucRooms(_appData));

        private void btnNavCustomers_Click(object sender, EventArgs e) =>
            ShowPage(btnNavCustomers, new ucCustomers(_appData));

        private void btnNavBookingList_Click(object sender, EventArgs e) =>
            ShowPage(btnNavBookingList, new ucBookingList(_appData));

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ต้องการออกจากระบบหรือไม่?", "ออกจากระบบ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            CurrentUser.User = null;
            Application.Restart();   // กลับไปหน้า login
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = $"วันที่ {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }

        protected override bool ShowFocusCues => false;
    }
}
