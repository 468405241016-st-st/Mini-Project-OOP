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
using Mini_Project_OOP.Constants;

namespace Mini_Project_OOP.Forms
{
    public partial class FormMain : Form
    {

        private Form _activeForm = null;

        private readonly Color sidebarColor = AppTheme.Sidebar;
        private readonly Color activeColor = AppTheme.SidebarActive;

        private readonly Color indicatorColor = AppTheme.Accent;
        private readonly List<Button> navItems = new List<Button>();
        private readonly Dictionary<Button, Panel> indicators =
            new Dictionary<Button, Panel>();
        public FormMain()
        {
            InitializeComponent();

            RegisterNavItem(btnNavDashboard);
            RegisterNavItem(btnNavBooking);
            RegisterNavItem(btnNavRooms);
            RegisterNavItem(btnNavCustomers);
            RegisterNavItem(btnNavBookingList);

            SelectNavItem(btnNavDashboard);
        }

        private void RegisterNavItem(Button button)
        {
            navItems.Add(button);

            button.FlatStyle = FlatStyle.Flat;
            button.UseVisualStyleBackColor = false;

            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = sidebarColor;
            button.FlatAppearance.MouseDownBackColor = activeColor;
            button.FlatAppearance.MouseOverBackColor = activeColor;

            button.BackColor = sidebarColor;
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;
            button.TextAlign = ContentAlignment.MiddleLeft;

            Panel indicator = new Panel
            {
                Width = 3,
                Dock = DockStyle.Left,
                BackColor = indicatorColor,
                Visible = false
            };

            button.Controls.Add(indicator);
            indicator.BringToFront();

            indicators.Add(button, indicator);
        }

        private void SelectNavItem(Button selectedButton)
        {
            foreach (Button button in navItems)
            {
                bool isSelected = button == selectedButton;

                Color bgColor = isSelected
                    ? activeColor
                    : sidebarColor;

                button.BackColor = bgColor;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.BorderColor = bgColor;

                indicators[button].Visible = isSelected;
                indicators[button].BringToFront();
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

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            SelectNavItem(btnNavDashboard);
            OpenChildForm(new ucDashboard());
            lblPageTitle.Text = btnNavDashboard.Text;
        }

        private void btnNavBooking_Click(object sender, EventArgs e)
        {
            SelectNavItem(btnNavBooking);
            OpenChildForm(new ucBooking());
            lblPageTitle.Text = btnNavBooking.Text;
        }

        private void btnNavRooms_Click(object sender, EventArgs e)
        {
            SelectNavItem(btnNavRooms);
            OpenChildForm(new ucRooms());
            lblPageTitle.Text = btnNavRooms.Text;
        }

        private void btnNavCustomers_Click(object sender, EventArgs e)
        {
            SelectNavItem(btnNavCustomers);
            OpenChildForm(new ucCustomers());
            lblPageTitle.Text = btnNavCustomers.Text;
        }

        private void btnNavBookingList_Click(object sender, EventArgs e)
        {
            SelectNavItem(btnNavBookingList);
            OpenChildForm(new ucBookingList());
            lblPageTitle.Text = btnNavBookingList.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text =
                $"วันที่ {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }
        protected override bool ShowFocusCues
        {
            get { return false; }
        }

    }
}
