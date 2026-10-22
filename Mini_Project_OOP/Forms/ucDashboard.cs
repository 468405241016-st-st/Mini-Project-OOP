using Mini_Project_OOP.Model;
using Mini_Project_OOP.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mini_Project_OOP.Forms
{
    public partial class ucDashboard : Form
    {
        private readonly AppData _data;
        private readonly Action _onNewBooking;

        // ให้ Designer เปิดหน้าได้
        public ucDashboard()
        {
            InitializeComponent();
        }

        private async void ucDashboard_Load(object sender, EventArgs e)
        {
            await RefreshDashboardAsync();
        }

        public ucDashboard(AppData data, Action onNewBooking) : this()
        {
            _data = data;
            _onNewBooking = onNewBooking;

            btnNewBooking.Click += (s, e) => _onNewBooking?.Invoke();
            
        }

        public async System.Threading.Tasks.Task RefreshDashboardAsync()
        {
            if (_data == null) return;   // เปิดใน Designer

            try
            {
                // ปรับสถานะห้องให้ตรงกับการจองก่อน (แก้เคสเช็คเอาท์/ยกเลิกแล้วห้องไม่ว่าง)
                await RoomStatusSync.SyncAsync(_data);

                var rooms = (await _data.Rooms.GetAllAsync("RoomStatus"))
                            .OrderBy(r => r.RoomNumber).ToList();
                var bookings = (await _data.Bookings.GetAllAsync("Customer", "Room", "BookingStatus"))
                               .OrderByDescending(b => b.Id).Take(10).ToList();

                ShowSummary(rooms);
                ShowRecentBookings(bookings);
                ShowRoomTiles(rooms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("โหลดข้อมูล Dashboard ไม่สำเร็จ\n" + ex.Message);
            }
        }

        // การ์ด 4 ใบด้านบน
        private void ShowSummary(System.Collections.Generic.List<Room> rooms)
        {
            lblTotal.Text = rooms.Count.ToString("00");
            lblAvailable.Text = rooms.Count(r => StatusText.RoomAvailable(r.RoomStatus?.Status)).ToString("00");
            lblOccupied.Text = rooms.Count(r => StatusText.RoomOccupied(r.RoomStatus?.Status)).ToString("00");
            lblMaintenance.Text = rooms.Count(r => StatusText.RoomMaintenance(r.RoomStatus?.Status)).ToString("00");
        }

        // ตาราง "การจองล่าสุด" (6 คอลัมน์: รหัส, ลูกค้า, ห้อง, เช็คอิน, เช็คเอาท์, สถานะ)
        private void ShowRecentBookings(System.Collections.Generic.List<Booking> bookings)
        {

            if (dataGridView1.Columns.Count == 0) return;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Rows.Clear();

            foreach (var b in bookings)
            {
                dataGridView1.Rows.Add(
                    b.Id,
                    b.Customer?.FullName ?? "-",
                    b.Room?.RoomNumber ?? "-",
                    b.CheckinDate.ToString("dd/MM/yyyy"),
                    b.CheckoutDate.ToString("dd/MM/yyyy"),
                    b.BookingStatus?.Status ?? "-");
            }
        }

        // กล่อง "สถานะห้องพัก" สี่เหลี่ยมต่อห้อง สีตามสถานะ
        private void ShowRoomTiles(System.Collections.Generic.List<Room> rooms)
        {
            var tip = new ToolTip();
            flowRooms.SuspendLayout();
            flowRooms.Controls.Clear();

            foreach (var r in rooms)
            {
                string status = r.RoomStatus?.Status;
                Color color = Color.FromArgb(220, 252, 231);                      // ว่าง
                if (StatusText.RoomOccupied(status))
                    color = Color.FromArgb(254, 226, 226);                        // มีผู้เข้าพัก
                else if (StatusText.RoomMaintenance(status))
                    color = Color.FromArgb(254, 243, 199);                        // ซ่อมบำรุง

                var tile = new Label
                {
                    Text = r.RoomNumber,
                    BackColor = color,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(56, 40),
                    Margin = new Padding(4)
                };
                tip.SetToolTip(tile, $"ห้อง {r.RoomNumber} : {status}");
                flowRooms.Controls.Add(tile);
            }

            flowRooms.ResumeLayout();
        }
    }
}