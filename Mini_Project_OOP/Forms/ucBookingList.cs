using Mini_Project_OOP.Model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mini_Project_OOP.Forms
{
    public partial class ucBookingList : Form
    {
        private readonly DatabaseService _dbService;
        private readonly IRepository<tbl_Bookings> _booking;

        private Dictionary<string,object> _data;
        public ucBookingList()
        {
            InitializeComponent();
            cboFilterStatus.SelectedIndex = 0;

            string dbPath = Application.StartupPath + @"\Mini_Project_Database.accdb";
            _dbService = new DatabaseService(dbPath);
            _booking = new Repository<tbl_Bookings>(_dbService);

            _data = new Dictionary<string,object>();
        }

        private void _ValidateData()
        {
            string Status = cboFilterStatus.SelectedItem?.ToString() ?? "";
            DateTime FromDate = dtpFilterFrom.Value;
            DateTime ToDate = dtpFilterTo.Value;

            if (FromDate > ToDate)
            {
                MessageBox.Show("กรุณาใส่วันที่ให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
            _data["Status"] = Status; 
            _data["FromDate"] = FromDate.ToString();
            _data["ToDate"] = FromDate.ToString();
            _data["TextKeyword"] = txtFilterKeyword?.Text??"";
        }

        private async void btnFilterSearch_Click(object sender, EventArgs e)
        {

            _ValidateData();
            var data = await _booking.GetAllAsync();
            dgvBookings.DataSource = data.ToList();
            lblTotalCount.Text = $"รวม { data.Count()} รายการ";
        }

        private void btnFilterReset_Click(object sender, EventArgs e)
        {
            cboFilterStatus.SelectedIndex = 0;
            dtpFilterFrom.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpFilterTo.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFilterKeyword.Text = "";
        }
    }
}
