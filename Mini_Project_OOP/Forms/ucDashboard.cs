using Mini_Project_OOP.Constants;
using Mini_Project_OOP.Model;
using Mini_Project_OOP.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project_OOP.Forms
{
    public partial class ucDashboard : Form
    {
        private const int RecentBookingCount = 10;

        private readonly AppData _data;
        private readonly Action _onNewBooking;
        private readonly ToolTip _roomTip = new ToolTip();   // ตัวเดียวใช้ซ้ำทุกครั้งที่รีเฟรช

        // ให้ Designer เปิดหน้าได้
        public ucDashboard()
        {
            InitializeComponent();
            Disposed += (s, e) => _roomTip.Dispose();
        }

        public ucDashboard(AppData data, Action onNewBooking) : this()
        {
            _data = data;
            _onNewBooking = onNewBooking;

            btnNewBooking.Click += (s, e) => _onNewBooking?.Invoke();
        }

        private async void ucDashboard_Load(object sender, EventArgs e)
        {
            await RefreshDashboardAsync();
        }

        public async Task RefreshDashboardAsync()
        {
            if (_data == null) return;   // เปิดใน Designer

            try
            {
                // ปรับสถานะห้องให้ตรงกับการจองก่อน (แก้เคสเช็คเอาท์/ยกเลิกแล้วห้องไม่ว่าง)
                await RoomStatusSync.SyncAsync(_data);

                var rooms = (await _data.Rooms.GetAllAsync("RoomStatus"))
                            .OrderBy(r => r.RoomNumber).ToList();
                var recentBookings = await LoadRecentBookingsAsync();

                ShowSummary(rooms);
                ShowRecentBookings(recentBookings);
                ShowRoomTiles(rooms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("โหลดข้อมูล Dashboard ไม่สำเร็จ\n" + ex.Message);
            }
        }

        // ดึงเฉพาะการจองล่าสุดจากฐานข้อมูล (ไม่โหลดการจองทั้งตารางมาเรียงในหน่วยความจำ)
        private async Task<List<Booking>> LoadRecentBookingsAsync()
        {
            var latestFirst = new Filter().OrderBy("Id", desc: true).Take(RecentBookingCount);
            var bookings = await _data.Bookings.FindAsync(latestFirst, "Customer", "Room", "BookingStatus");
            return bookings.ToList();
        }

        // การ์ด 4 ใบด้านบน
        private void ShowSummary(List<Room> rooms)
        {
            lblTotal.Text = rooms.Count.ToString("00");
            lblAvailable.Text = CountByStatus(rooms, StatusText.RoomAvailable);
            lblOccupied.Text = CountByStatus(rooms, StatusText.RoomOccupied);
            lblMaintenance.Text = CountByStatus(rooms, StatusText.RoomMaintenance);
        }

        private static string CountByStatus(List<Room> rooms, Func<string, bool> isStatus)
        {
            return rooms.Count(r => isStatus(r.RoomStatus?.Status)).ToString("00");
        }

        // ตาราง "การจองล่าสุด" (6 คอลัมน์: รหัส, ลูกค้า, ห้อง, เช็คอิน, เช็คเอาท์, สถานะ)
        private void ShowRecentBookings(List<Booking> bookings)
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
        private void ShowRoomTiles(List<Room> rooms)
        {
            flowRooms.SuspendLayout();
            DisposeRoomTiles();

            foreach (var room in rooms)
            {
                string status = room.RoomStatus?.Status;

                var tile = new Label
                {
                    Text = room.RoomNumber,
                    BackColor = TileColor(status),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(56, 40),
                    Margin = new Padding(4)
                };
                _roomTip.SetToolTip(tile, $"ห้อง {room.RoomNumber} : {status}");
                flowRooms.Controls.Add(tile);
            }

            flowRooms.ResumeLayout();
        }

        // Controls.Clear() ไม่ได้ปล่อย handle ของ control เดิม ต้อง Dispose เองไม่งั้นรีเฟรชซ้ำแล้วหน่วยความจำเพิ่มเรื่อยๆ
        private void DisposeRoomTiles()
        {
            foreach (Control tile in flowRooms.Controls.Cast<Control>().ToList())
                tile.Dispose();
        }

        private static Color TileColor(string status)
        {
            if (StatusText.RoomOccupied(status)) return AppTheme.StatusBack(RoomStatusName.Occupied);
            if (StatusText.RoomMaintenance(status)) return AppTheme.StatusBack(RoomStatusName.Maintenance);
            return AppTheme.StatusBack(RoomStatusName.Available);
        }
    }
}
