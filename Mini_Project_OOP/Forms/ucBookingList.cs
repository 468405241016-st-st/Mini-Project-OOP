using Mini_Project_OOP.Constants;
using Mini_Project_OOP.Model;
using Mini_Project_OOP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project_OOP.Forms
{
    public partial class ucBookingList : Form
    {
        // ------------------------------------------------------------------
        // ค่าคงที่ / ชนิดข้อมูลช่วย
        // ------------------------------------------------------------------
        private const string AllStatuses = "ทั้งหมด";

        // ชื่อสถานะต้องตรงกับคอลัมน์ status ใน tbl_BookingStatus
        private static class StatusName
        {
            public const string Confirmed = "Confirmed";
            public const string CheckedIn = "CheckedIn";
            public const string CheckedOut = "CheckedOut";
            public const string Cancelled = "Cancelled";
        }

        // 1 ปุ่ม = เปลี่ยนสถานะจาก From -> To
        private sealed class StatusAction
        {
            public string From { get; }
            public string To { get; }
            public string Label { get; }

            public StatusAction(string from, string to, string label)
            {
                From = from;
                To = to;
                Label = label;
            }
        }

        // แถวที่แสดงในตาราง (property ต้องตรงกับ DataPropertyName ของแต่ละคอลัมน์)
        private sealed class BookingRow
        {
            public int Id { get; set; }
            public string Customer { get; set; }
            public string RoomNumber { get; set; }
            public string RoomType { get; set; }
            public DateTime CheckinDate { get; set; }
            public DateTime CheckoutDate { get; set; }
            public decimal TotalPrice { get; set; }
            public string Status { get; set; }
            public DateTime CreatedAt { get; set; }
        }

        // ------------------------------------------------------------------
        // Fields
        // ------------------------------------------------------------------
        private readonly Repository<Booking> bookingRepo;
        private readonly Repository<Customer> customerRepo;
        private readonly Repository<BookingStatus> statusRepo;
        private readonly Repository<Room> roomRepo;
        private readonly Dictionary<Button, StatusAction> statusActions;

        // cache ชื่อสถานะ -> Id (ตารางสถานะเล็กและแทบไม่เปลี่ยน โหลดครั้งเดียวพอ)
        private Dictionary<string, int> statusIds;
        private AppData _data;

        // ------------------------------------------------------------------
        // Constructor
        // ------------------------------------------------------------------
        public ucBookingList(AppData data)
        {
            InitializeComponent();

            // รับ AppData ตัวเดียวกันจากฟอร์มหลัก (ไม่สร้างเองแล้ว)
            if (data == null) throw new ArgumentNullException(nameof(data));
            _data = data;
            bookingRepo = data.Bookings;
            customerRepo = data.Customers;
            statusRepo = data.BookingStatuses;
            roomRepo = data.Rooms;

            statusActions = new Dictionary<Button, StatusAction>
            {
                [btnCheckIn] = new StatusAction(StatusName.Confirmed, StatusName.CheckedIn, "เช็คอิน"),
                [btnCheckOut] = new StatusAction(StatusName.CheckedIn, StatusName.CheckedOut, "เช็คเอาท์"),
                [btnCancelBooking] = new StatusAction(StatusName.Confirmed, StatusName.Cancelled, "ยกเลิก"),
            };

            cboFilterStatus.SelectedIndex = 0;
            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.SelectionChanged += (s, e) => UpdateActionButtons();
            dgvBookings.CellFormatting += dgvBookings_CellFormatting;

            foreach (var pair in statusActions)
            {
                StatusAction action = pair.Value;
                pair.Key.Click += async (s, e) => await RunSafeAsync(() => ChangeStatusAsync(action));
            }

            UpdateActionButtons();
        }

        // ------------------------------------------------------------------
        // ค้นหา / แสดงผล
        // ------------------------------------------------------------------
        private async Task ApplyFilterAsync()
        {
            DateTime from = dtpFilterFrom.Value.Date;
            DateTime to = dtpFilterTo.Value.Date;

            if (from > to)
            {
                MessageBox.Show("กรุณาใส่วันที่ให้ถูกต้อง", "แจ้งเตือน",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = cboFilterStatus.SelectedItem?.ToString() ?? "";
            string keyword = txtFilterKeyword.Text.Trim();

            List<Booking> bookings = await SearchBookingsAsync(status, from, to, keyword);
            BindBookings(bookings);
        }

        private async Task<List<Booking>> SearchBookingsAsync(
            string status, DateTime from, DateTime to, string keyword)
        {
            int? statusId = null;
            if (!string.IsNullOrEmpty(status) && status != AllStatuses)
            {
                statusId = await GetStatusIdAsync(status);
                if (statusId == null) return new List<Booking>();
            }

            if (string.IsNullOrEmpty(keyword))
                return await QueryBookingsAsync(from, to, statusId, null, null);

            // คำค้นตรงกับ "ชื่อ/เบอร์ลูกค้า" หรือ "เลขห้อง" อย่างใดอย่างหนึ่ง
            // Filter ไม่มี OR ข้ามคอลัมน์ จึงค้นแยกแล้วรวมผลลัพธ์
            List<int> customerIds = await FindCustomerIdsAsync(keyword);
            List<int> roomIds = await FindRoomIdsAsync(keyword);

            var found = new List<Booking>();
            if (customerIds.Count > 0)
                found.AddRange(await QueryBookingsAsync(from, to, statusId, "CustomerId", customerIds));
            if (roomIds.Count > 0)
                found.AddRange(await QueryBookingsAsync(from, to, statusId, "RoomId", roomIds));

            return found
                .GroupBy(b => b.Id)               // การจองที่เจอทั้งสองทางเอาแค่อันเดียว
                .Select(g => g.First())
                .OrderByDescending(b => b.CreatedAt)
                .ToList();
        }

        // keyColumn/keyIds = จำกัดเฉพาะ CustomerId หรือ RoomId ที่ระบุ (null = ไม่จำกัด)
        private async Task<List<Booking>> QueryBookingsAsync(
            DateTime from, DateTime to, int? statusId, string keyColumn, List<int> keyIds)
        {
            var filter = new Filter()
                .Gte("CheckinDate", from)
                .Lt("CheckoutDate", to.AddDays(1))
                .OrderBy("CreatedAt", desc: true);

            if (statusId != null)
                filter.Eq("BookingStatusId", statusId.Value);

            if (keyColumn != null)
                filter.In(keyColumn, keyIds.Cast<object>());

            var result = await bookingRepo.FindAsync(
                filter, "Customer", "Room.RoomType", "BookingStatus");
            return result.ToList();
        }

        private async Task<List<int>> FindRoomIdsAsync(string keyword)
        {
            var rooms = await roomRepo.FindAsync(new Filter().Like("RoomNumber", "%" + keyword + "%"));
            return rooms.Select(r => r.Id).ToList();
        }

        // Filter ไม่มี OR จึงค้นชื่อกับเบอร์แยกกัน แล้วรวม Id
        private async Task<List<int>> FindCustomerIdsAsync(string keyword)
        {
            string pattern = "%" + keyword + "%";
            var byName = await customerRepo.FindAsync(new Filter().Like("FullName", pattern));
            var byPhone = await customerRepo.FindAsync(new Filter().Like("PhoneNumber", pattern));

            return byName.Concat(byPhone).Select(c => c.Id).Distinct().ToList();
        }

        private void BindBookings(List<Booking> bookings)
        {
            dgvBookings.DataSource = bookings.Select(b => new BookingRow
            {
                Id = b.Id,
                Customer = b.Customer?.FullName,
                RoomNumber = b.Room?.RoomNumber,
                RoomType = b.Room?.RoomType?.NameType,
                CheckinDate = b.CheckinDate,
                CheckoutDate = b.CheckoutDate,
                TotalPrice = b.TotalPrice,
                Status = b.BookingStatus?.Status,
                CreatedAt = b.CreatedAt
            }).ToList();

            lblTotalCount.Text = $"รวม {bookings.Count} รายการ";
            UpdateActionButtons();
        }

        // ------------------------------------------------------------------
        // เปลี่ยนสถานะการจอง
        // ------------------------------------------------------------------
        private BookingRow GetSelectedBooking()
        {
            return dgvBookings.SelectedRows.Count > 0
                ? dgvBookings.SelectedRows[0].DataBoundItem as BookingRow
                : null;
        }

        // เปิดปุ่มเฉพาะที่ใช้ได้กับสถานะของแถวที่เลือก
        private void UpdateActionButtons()
        {
            string current = GetSelectedBooking()?.Status;

            foreach (var pair in statusActions)
                pair.Key.Enabled = current == pair.Value.From;
        }

        private async Task ChangeStatusAsync(StatusAction action)
        {
            BookingRow selected = GetSelectedBooking();
            if (selected == null) return;

            var confirm = MessageBox.Show(
                $"ยืนยัน{action.Label}การจอง #{selected.Id} ?", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            int? fromId = await GetStatusIdAsync(action.From);
            int? toId = await GetStatusIdAsync(action.To);
            if (fromId == null || toId == null)
            {
                ShowError("ไม่พบสถานะที่ต้องใช้ในตาราง tbl_BookingStatus");
                return;
            }

            // ดึงข้อมูลล่าสุดจาก DB กันกรณีข้อมูลในตารางเก่าไปแล้ว
            Booking booking = await bookingRepo.GetByIdAsync(selected.Id);
            if (booking == null || booking.BookingStatusId != fromId.Value)
            {
                ShowError("สถานะการจองนี้ถูกเปลี่ยนไปแล้ว กรุณาค้นหาใหม่");
                await ApplyFilterAsync();
                return;
            }

            booking.BookingStatusId = toId.Value;
            await bookingRepo.UpdateAsync(booking);

            await Mini_Project_OOP.Services.RoomStatusSync.SyncAsync(_data);   // <-- เพิ่มบรรทัดนี้

            await ApplyFilterAsync();
            SelectRowById(selected.Id);
        }

        // หาแถวเดิมกลับมาเลือกหลังโหลดตารางใหม่ (ถ้าโดนตัวกรองตัดออกก็จะไม่เจอ)
        private void SelectRowById(int id)
        {
            foreach (DataGridViewRow row in dgvBookings.Rows)
            {
                if ((row.DataBoundItem as BookingRow)?.Id != id) continue;

                dgvBookings.CurrentCell = row.Cells[0];
                row.Selected = true;
                return;
            }
        }

        // โหลดตารางสถานะครั้งแรกครั้งเดียว แล้วใช้ cache
        private async Task<int?> GetStatusIdAsync(string name)
        {
            if (statusIds == null)
            {
                var map = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                foreach (BookingStatus s in await statusRepo.GetAllAsync())
                {
                    if (s.Status != null) map[s.Status] = s.Id;
                }
                statusIds = map;
            }

            return statusIds.TryGetValue(name, out int id) ? id : (int?)null;
        }

        // ------------------------------------------------------------------
        // Helpers
        // ------------------------------------------------------------------
        // กัน exception หลุดจาก async void แล้วทำให้โปรแกรมปิดเอง
        private static async Task RunSafeAsync(Func<Task> work)
        {
            try
            {
                await work();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ------------------------------------------------------------------
        // Event handlers (ผูกจาก Designer)
        // ------------------------------------------------------------------
        // ใส่สีคอลัมน์สถานะตาม AppTheme (วาดทุกครั้งที่เซลล์ถูกแสดง)
        private void dgvBookings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvBookings.Columns[e.ColumnIndex] != colBkStatus) return;

            string status = e.Value as string;
            if (string.IsNullOrEmpty(status)) return;

            var back = AppTheme.StatusBack(status);
            var fore = AppTheme.StatusFore(status);

            e.CellStyle.BackColor = back;
            e.CellStyle.ForeColor = fore;
            // ตอนแถวถูกเลือกให้สีสถานะยังอยู่ ไม่ถูกสีเลือกแถวทับ
            e.CellStyle.SelectionBackColor = back;
            e.CellStyle.SelectionForeColor = fore;
        }

        private async void btnFilterSearch_Click(object sender, EventArgs e)
        {
            await RunSafeAsync(ApplyFilterAsync);
        }

        private void btnFilterReset_Click(object sender, EventArgs e)
        {
            cboFilterStatus.SelectedIndex = 0;
            dtpFilterFrom.Value = DateTime.Today;
            dtpFilterTo.Value = DateTime.Today;
            txtFilterKeyword.Clear();

            dgvBookings.DataSource = null;
            lblTotalCount.Text = "รวม 0 รายการ";
            UpdateActionButtons();
        }

        private void ucBookingList_Load(object sender, EventArgs e)
        {

        }
    }
}