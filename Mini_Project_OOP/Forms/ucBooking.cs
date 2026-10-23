using Mini_Project_OOP.Constants;
using Mini_Project_OOP.Helper;
using Mini_Project_OOP.Model;
using Mini_Project_OOP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mini_Project_OOP.Helper.TextUtils;

namespace Mini_Project_OOP.Forms
{
    public partial class ucBooking : DataForm
    {
        // แถวของตารางห้องว่าง (แปลงจาก Room + RoomType เป็นแถวแบนๆ ให้ตารางผูกได้)
        private sealed class AvailRow
        {
            public Room Room { get; set; }
            public string RoomNumber { get; set; }
            public string TypeName { get; set; }
            public decimal PricePerNight { get; set; }
            public int Capacity { get; set; }
        }

        private static readonly Color ReadOnlyBack = Color.FromArgb(238, 246, 245);

        private readonly AppData _data;

        private List<RoomType> _types = new List<RoomType>();
        private List<RoomStatus> _roomStatuses = new List<RoomStatus>();
        private List<BookingStatus> _bookingStatuses = new List<BookingStatus>();

        private Customer _customer;     // null = ลูกค้าใหม่ (กรอกเอง) / มีค่า = เลือกลูกค้าเดิมจากการค้นหา
        private bool _binding;          // กัน event ตอนกำลังตั้งค่า/bind ข้อมูล

        protected override string ValidationTitle => "ข้อมูลไม่ถูกต้อง";

        // ใช้ตอนเปิดใน Designer เท่านั้น
        public ucBooking()
        {
            InitializeComponent();
            SetupControls();
            WireEvents();
            UpdateButtons();
        }

        public ucBooking(AppData data) : this()
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }

        // ---------------------------------------------------------------
        // SETUP
        // ---------------------------------------------------------------
        private void SetupControls()
        {
            dgvAvailableRooms.AutoGenerateColumns = false;
            colPrice.DataPropertyName = nameof(AvailRow.PricePerNight);
            colCapacity.DataPropertyName = nameof(AvailRow.Capacity);

            cboRoomType.DisplayMember = nameof(RoomType.NameType);
            cboRoomType.ValueMember = nameof(RoomType.Id);
            cboStatus.DisplayMember = nameof(BookingStatus.Status);
            cboStatus.ValueMember = nameof(BookingStatus.Id);

            dgvAvailableRooms.EnableDoubleBuffer();
        }

        // ตารางใน Designer มีแค่ราคา/ความจุ จึงเพิ่มคอลัมน์ เลขห้อง + ประเภท ตอนรันจริง (ไม่แตะ Designer)
        private void AddRoomColumns()
        {
            if (dgvAvailableRooms.Columns.Contains("colRoomNumber")) return;

            dgvAvailableRooms.Columns.Insert(0, new DataGridViewTextBoxColumn
            {
                Name = "colRoomNumber",
                HeaderText = "เลขห้อง",
                DataPropertyName = nameof(AvailRow.RoomNumber),
                ReadOnly = true,
                Resizable = DataGridViewTriState.False,
                Width = 90
            });
            dgvAvailableRooms.Columns.Insert(1, new DataGridViewTextBoxColumn
            {
                Name = "colRoomTypeName",
                HeaderText = "ประเภท",
                DataPropertyName = nameof(AvailRow.TypeName),
                ReadOnly = true,
                Resizable = DataGridViewTriState.False,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 60
            });
        }

        private void WireEvents()
        {
            Load += async (s, e) =>
            {
                if (DesignMode || _data == null) return;
                AddRoomColumns();
                ResetDates();
                await TryAsync(LoadLookupsAsync, "โหลดข้อมูลไม่สำเร็จ");
                BindCombos();
                UpdateSummary();
                UpdateButtons();
            };

            btnSearchCustomer.Click += async (s, e) => await SearchCustomerAsync();
            txtSearch.KeyDown += async (s, e) =>
            {
                if (e.KeyCode != Keys.Enter) return;
                e.SuppressKeyPress = true;
                await SearchCustomerAsync();
            };

            btnCheckAvailability.Click += async (s, e) => await CheckAvailabilityAsync();
            btnSave.Click += async (s, e) => await SaveAsync();
            btnClear.Click += (s, e) => ClearForm();

            // เปลี่ยนวันที่/ประเภท = ผลตรวจห้องว่างเดิมใช้ไม่ได้แล้ว ต้องล้างแล้วตรวจใหม่
            dtpCheckIn.ValueChanged += (s, e) =>
            {
                if (_binding) return;
                if (dtpCheckOut.Value.Date <= dtpCheckIn.Value.Date)
                    dtpCheckOut.Value = dtpCheckIn.Value.Date.AddDays(1);
                InvalidateResults();
            };
            dtpCheckOut.ValueChanged += (s, e) => { if (!_binding) InvalidateResults(); };
            cboRoomType.SelectedIndexChanged += (s, e) => { if (!_binding) InvalidateResults(); };

            dgvAvailableRooms.SelectionChanged += (s, e) => { if (!_binding) UpdateSummary(); };
        }

        // ---------------------------------------------------------------
        // LOAD / BIND
        // ---------------------------------------------------------------
        private async Task LoadLookupsAsync()
        {
            _types = (await _data.RoomTypes.FindAsync(new Filter().OrderBy("Id"))).ToList();
            _roomStatuses = (await _data.RoomStatuses.GetAllAsync()).ToList();
            _bookingStatuses = (await _data.BookingStatuses.GetAllAsync()).ToList();
        }

        private void BindCombos()
        {
            _binding = true;
            try
            {
                // ตัวเลือก "ทุกประเภท" (Id = 0) + ประเภทห้องจากฐานข้อมูล (แทนค่าที่ฮาร์ดโค้ดใน Designer)
                var choices = new List<RoomType> { new RoomType { Id = 0, NameType = "ทุกประเภท" } };
                choices.AddRange(_types);
                cboRoomType.DataSource = null;
                cboRoomType.Items.Clear();
                cboRoomType.DataSource = choices;
                if (cboRoomType.Items.Count > 0) cboRoomType.SelectedIndex = 0;

                cboStatus.DataSource = null;
                cboStatus.Items.Clear();
                cboStatus.DataSource = _bookingStatuses;
                int? confirmed = StatusId(BookingStatusName.Confirmed);
                if (confirmed.HasValue) cboStatus.SelectedValue = confirmed.Value;
                else cboStatus.SelectedIndex = -1;
            }
            finally
            {
                _binding = false;
            }
        }

        private void ResetDates()
        {
            _binding = true;
            try
            {
                dtpCheckIn.Value = DateTime.Today;
                dtpCheckOut.Value = DateTime.Today.AddDays(1);
            }
            finally
            {
                _binding = false;
            }
        }

        private void BindAvailable(List<AvailRow> rows)
        {
            _binding = true;
            try
            {
                dgvAvailableRooms.DataSource = rows;
                dgvAvailableRooms.ClearSelection();
            }
            finally
            {
                _binding = false;
            }
            UpdateSummary();
        }

        private void InvalidateResults()
        {
            BindAvailable(new List<AvailRow>());
        }

        private int? StatusId(string name)
        {
            return _bookingStatuses.FirstOrDefault(s => s.Status == name)?.Id;
        }

        private List<int> ActiveStatusIds()
        {
            // การจองที่ยังกินห้องอยู่ = Confirmed / CheckedIn (Cancelled และ CheckedOut ไม่นับ)
            return _bookingStatuses
                .Where(s => s.Status == BookingStatusName.Confirmed || s.Status == BookingStatusName.CheckedIn)
                .Select(s => s.Id).ToList();
        }

        // ---------------------------------------------------------------
        // CUSTOMER SEARCH
        // ---------------------------------------------------------------
        private async Task SearchCustomerAsync()
        {
            if (IsBusy) return;

            string term = txtSearch.Text.Trim();
            if (term.Length == 0) { Warn("กรุณากรอกเบอร์โทรหรือเลขบัตรที่ต้องการค้นหา", txtSearch); return; }

            List<Customer> all = null;
            if (!await TryAsync(async () =>
                    all = (await _data.Customers.FindAsync(new Filter().OrderBy("Id"))).ToList(),
                    "ค้นหาลูกค้าไม่สำเร็จ"))
                return;

            // เบอร์/เลขบัตรเทียบแบบตัดช่องว่างและขีด เพื่อให้พิมพ์ "081-234" แล้วเจอ "0812345678"
            string compact = IsNumericLike(term) ? Compact(term) : "";

            var matches = compact.Length > 0
                ? all.Where(c => Compact(c.PhoneNumber) == compact || Compact(c.NationalId) == compact).ToList()
                : new List<Customer>();

            if (matches.Count == 0)
            {
                matches = all.Where(c =>
                    ContainsIgnoreCase(c.FullName, term) || ContainsIgnoreCase(c.Email, term)
                    || ContainsIgnoreCase(c.PhoneNumber, term) || ContainsIgnoreCase(c.NationalId, term)
                    || (compact.Length > 0 && (Compact(c.PhoneNumber).Contains(compact) || Compact(c.NationalId).Contains(compact))))
                    .ToList();
            }

            if (matches.Count == 0)
            {
                MessageBox.Show("ไม่พบลูกค้าเดิม ถ้าเป็นลูกค้าใหม่ กรอกข้อมูลด้านล่างได้เลย",
                    "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (matches.Count > 1)
            {
                MessageBox.Show($"พบลูกค้า {matches.Count} รายการ กรุณาระบุให้เจาะจงขึ้น (เช่น เบอร์โทรหรือเลขบัตรเต็ม)",
                    "พบหลายรายการ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FillCustomer(matches[0]);
        }

        private void FillCustomer(Customer c)
        {
            _customer = c;
            txtCustomerName.Text = c.FullName;
            txtPhone.Text = c.PhoneNumber;
            txtIdCard.Text = c.NationalId;
            txtEmail.Text = c.Email;
            SetCustomerReadOnly(true);   // ลูกค้าเดิม: ล็อกช่องไว้ ถ้าจะกรอกลูกค้าใหม่ให้กด "ล้างฟอร์ม"
        }

        private void SetCustomerReadOnly(bool readOnly)
        {
            foreach (var box in new[] { txtCustomerName, txtPhone, txtIdCard, txtEmail })
            {
                box.ReadOnly = readOnly;
                box.BackColor = readOnly ? ReadOnlyBack : Color.White;
            }
        }

        // ---------------------------------------------------------------
        // AVAILABILITY
        // ---------------------------------------------------------------
        private async Task CheckAvailabilityAsync()
        {
            if (IsBusy) return;
            if (!TryGetStay(out DateTime checkIn, out DateTime checkOut)) return;

            int typeId = cboRoomType.SelectedValue is int v ? v : 0;

            List<AvailRow> rows = null;
            if (!await TryAsync(async () => rows = await FindAvailableAsync(checkIn, checkOut, typeId),
                    "ตรวจสอบห้องว่างไม่สำเร็จ"))
                return;

            BindAvailable(rows);

            if (rows.Count == 0)
                MessageBox.Show("ไม่พบห้องว่างในช่วงวันที่นี้ ลองเปลี่ยนวันที่หรือประเภทห้อง",
                    "ไม่มีห้องว่าง", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task<List<AvailRow>> FindAvailableAsync(DateTime checkIn, DateTime checkOut, int typeId)
        {
            // โหลดประเภทใหม่ทุกครั้ง เผื่อมีการแก้ราคา/ความจุจากหน้าห้องพัก
            _types = (await _data.RoomTypes.FindAsync(new Filter().OrderBy("Id"))).ToList();
            var typeMap = _types.ToDictionary(t => t.Id);

            var roomFilter = new Filter();
            if (typeId > 0) roomFilter = roomFilter.Eq("RoomTypeId", typeId);
            roomFilter = roomFilter.OrderBy("RoomNumber");
            var rooms = (await _data.Rooms.FindAsync(roomFilter)).ToList();

            var booked = new HashSet<int>((await _data.Bookings.FindAsync(OverlapFilter(null, checkIn, checkOut)))
                .Select(b => b.RoomId));

            int? maintenanceId = _roomStatuses.FirstOrDefault(s => s.Status == RoomStatusName.Maintenance)?.Id;

            return rooms
                .Where(r => r.RoomStatusId != maintenanceId && !booked.Contains(r.Id) && typeMap.ContainsKey(r.RoomTypeId))
                .Select(r =>
                {
                    var t = typeMap[r.RoomTypeId];
                    return new AvailRow
                    {
                        Room = r,
                        RoomNumber = r.RoomNumber,
                        TypeName = t.NameType,
                        PricePerNight = t.PricePerNight,
                        Capacity = t.Capacity
                    };
                })
                .ToList();
        }

        // การจองที่ซ้อนช่วงวันที่กัน: เข้าพักก่อนวันคืนของเรา และคืนห้องหลังวันเข้าของเรา (วันคืน = วันเข้าของคนถัดไปได้)
        private Filter OverlapFilter(int? roomId, DateTime checkIn, DateTime checkOut)
        {
            var f = new Filter();
            if (roomId.HasValue) f = f.Eq("RoomId", roomId.Value);
            f = f.Lt("CheckinDate", checkOut).Gt("CheckoutDate", checkIn);
            var ids = ActiveStatusIds();
            if (ids.Count > 0) f = f.In("BookingStatusId", ids.Cast<object>());
            return f;
        }

        private bool TryGetStay(out DateTime checkIn, out DateTime checkOut)
        {
            checkIn = dtpCheckIn.Value.Date;
            checkOut = dtpCheckOut.Value.Date;

            if (checkIn < DateTime.Today)
            { Warn("วันที่เข้าพักต้องไม่เป็นวันที่ผ่านมาแล้ว", dtpCheckIn); return false; }
            if (checkOut <= checkIn)
            { Warn("วันที่คืนห้องต้องหลังวันที่เข้าพักอย่างน้อย 1 วัน", dtpCheckOut); return false; }
            return true;
        }

        // ---------------------------------------------------------------
        // SUMMARY
        // ---------------------------------------------------------------
        private AvailRow SelectedRoom()
        {
            return dgvAvailableRooms.SelectedRows.Count > 0
                ? dgvAvailableRooms.SelectedRows[0].DataBoundItem as AvailRow
                : null;
        }

        private int Nights()
        {
            return Math.Max(0, (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days);
        }

        private static string Baht(decimal value)
        {
            return value.ToString("฿#,##0.##", CultureInfo.CurrentCulture);
        }

        private void UpdateSummary()
        {
            var row = SelectedRoom();
            int nights = Nights();

            lblNightsValue.Text = nights + " คืน";
            if (row == null)
            {
                lblSelectedRoomValue.Text = "-";
                lblPricePerNightValue.Text = Baht(0);
                lblTotalPrice.Text = Baht(0);
                return;
            }

            lblSelectedRoomValue.Text = $"{row.RoomNumber} ({row.TypeName})";
            lblPricePerNightValue.Text = Baht(row.PricePerNight);
            lblTotalPrice.Text = Baht(row.PricePerNight * nights);
        }

        // ---------------------------------------------------------------
        // SAVE / CLEAR
        // ---------------------------------------------------------------
        private async Task SaveAsync()
        {
            if (IsBusy) return;

            var row = SelectedRoom();
            if (row == null) { Warn("กรุณาตรวจสอบห้องว่างแล้วเลือกห้องจากตาราง", dgvAvailableRooms); return; }
            if (!TryGetStay(out DateTime checkIn, out DateTime checkOut)) return;

            string name = txtCustomerName.Text.Trim();
            string email = txtEmail.Text.Trim();
            if (_customer == null)
            {
                if (name.Length == 0) { Warn("กรุณากรอกชื่อ-นามสกุล", txtCustomerName); return; }
                if (email.Length == 0) { Warn("กรุณากรอกอีเมล", txtEmail); return; }
                if (!IsValidEmail(email)) { Warn("รูปแบบอีเมลไม่ถูกต้อง", txtEmail); return; }
            }

            int? statusId = StatusId(BookingStatusName.Confirmed);
            if (!statusId.HasValue)
            {
                MessageBox.Show("ไม่พบสถานะการจอง \"Confirmed\" ในฐานข้อมูล", "เกิดข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phone = NullIfEmpty(txtPhone.Text);
            string idCard = NullIfEmpty(txtIdCard.Text);
            decimal total = row.PricePerNight * Nights();

            string problem = null;
            Control problemFocus = null;
            bool conflict = false;

            bool ok = await TryAsync(async () =>
            {
                // เช็กซ้ำก่อนบันทึก เผื่อมีคนจองห้องนี้ตัดหน้าไปแล้ว
                if (await _data.Bookings.CountAsync(OverlapFilter(row.Room.Id, checkIn, checkOut)) > 0)
                {
                    conflict = true;
                    problem = $"ห้อง {row.RoomNumber} ถูกจองในช่วงวันที่นี้แล้ว กรุณาเลือกห้องอื่น";
                    return;
                }

                int customerId;
                if (_customer != null)
                {
                    customerId = _customer.Id;
                }
                else
                {
                    var all = (await _data.Customers.FindAsync(new Filter().OrderBy("Id"))).ToList();
                    string cPhone = Compact(phone), cId = Compact(idCard);
                    if (all.Any(c => (cPhone.Length > 0 && Compact(c.PhoneNumber) == cPhone)
                                  || (cId.Length > 0 && Compact(c.NationalId) == cId)))
                    {
                        problem = "มีลูกค้าที่ใช้เบอร์โทรหรือเลขบัตรนี้อยู่แล้ว กรุณาค้นหาลูกค้าเดิมแทนการกรอกใหม่";
                        problemFocus = txtSearch;
                        return;
                    }

                    await _data.Customers.AddAsync(new Customer
                    {
                        FullName = name,
                        PhoneNumber = phone,
                        NationalId = idCard,
                        Email = email
                    });

                    // AddAsync ไม่คืน Id: ถามฐานข้อมูลหาแถวล่าสุดที่ชื่อ+อีเมลตรงกัน (ดึงแถวเดียว ไม่โหลดลูกค้าทั้งหมดซ้ำ)
                    var created = await _data.Customers.FirstOrDefaultAsync(
                        new Filter().Eq("FullName", name).Eq("Email", email).OrderBy("Id", desc: true));
                    if (created == null) throw new InvalidOperationException("เพิ่มลูกค้าแล้ว แต่หารหัสลูกค้าที่เพิ่งสร้างไม่พบ");
                    customerId = created.Id;
                }

                await _data.Bookings.AddAsync(new Booking
                {
                    CustomerId = customerId,
                    RoomId = row.Room.Id,
                    CheckinDate = checkIn,
                    CheckoutDate = checkOut,
                    TotalPrice = total,
                    BookingStatusId = statusId.Value,
                    CreatedAt = DateTime.Now
                });
            }, "บันทึกการจองไม่สำเร็จ");

            if (!ok) return;

            if (problem != null)
            {
                MessageBox.Show(problem, conflict ? "ห้องไม่ว่าง" : "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (conflict) await CheckAvailabilityAsync();   // รีเฟรชรายการห้องว่างให้ตรงความจริง
                else problemFocus?.Focus();
                return;
            }

            ShowSuccess($"บันทึกการจองเรียบร้อยแล้ว\nห้อง {row.RoomNumber}  {checkIn:dd/MM/yyyy} - {checkOut:dd/MM/yyyy}  รวม {Baht(total)}");
            ClearForm();
        }

        private void ClearForm()
        {
            _customer = null;
            SetCustomerReadOnly(false);
            txtSearch.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtIdCard.Clear();
            txtEmail.Clear();

            ResetDates();
            _binding = true;
            try
            {
                if (cboRoomType.Items.Count > 0) cboRoomType.SelectedIndex = 0;
            }
            finally
            {
                _binding = false;
            }

            InvalidateResults();
            txtSearch.Focus();
        }

        // ---------------------------------------------------------------
        // HELPERS
        // ---------------------------------------------------------------
        protected override void UpdateButtons()
        {
            btnSearchCustomer.Enabled = !IsBusy;
            btnCheckAvailability.Enabled = !IsBusy;
            btnSave.Enabled = !IsBusy;
            btnClear.Enabled = !IsBusy;
        }
    }
}
