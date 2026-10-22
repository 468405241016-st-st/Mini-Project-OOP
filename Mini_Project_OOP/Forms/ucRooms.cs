using Mini_Project_OOP.Constants;
using Mini_Project_OOP.Helper;
using Mini_Project_OOP.Model;
using Mini_Project_OOP.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mini_Project_OOP.Helper.TextUtils;

namespace Mini_Project_OOP.Forms
{
    public partial class ucRooms : DataForm
    {
        // แถวของตารางห้องพัก: ตารางผูกกับ property ซ้อนกัน (Room.RoomType.NameType) ไม่ได้ จึงแปลงเป็นแถวแบนๆ ก่อน
        private sealed class RoomRow
        {
            public Room Room { get; set; }
            public string RoomNumber { get; set; }
            public string TypeName { get; set; }
            public string StatusName { get; set; }
        }

        private readonly AppData _data;

        private List<RoomType> _types = new List<RoomType>();
        private List<RoomStatus> _statuses = new List<RoomStatus>();
        private List<Room> _rooms = new List<Room>();

        private RoomType _selectedType;     // null = กำลังเพิ่มประเภทใหม่
        private Room _selectedRoom;         // null = กำลังเพิ่มห้องใหม่
        private bool _binding;              // กัน SelectionChanged ตอนกำลัง bind ข้อมูล

        // ใช้ตอนเปิดใน Designer เท่านั้น
        public ucRooms()
        {
            InitializeComponent();
            SetupGrids();
            WireEvents();
            UpdateButtons();
        }

        public ucRooms(AppData data) : this()
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }

        // ---------------------------------------------------------------
        // SETUP
        // ---------------------------------------------------------------
        private void SetupGrids()
        {
            dgvRoomTypes.AutoGenerateColumns = false;
            colTypeName.DataPropertyName = nameof(RoomType.NameType);
            colTypePrice.DataPropertyName = nameof(RoomType.PricePerNight);
            colTypeCapacity.DataPropertyName = nameof(RoomType.Capacity);

            dgvRooms.AutoGenerateColumns = false;
            colRoomNo.DataPropertyName = nameof(RoomRow.RoomNumber);
            colRoomType.DataPropertyName = nameof(RoomRow.TypeName);
            colRoomStatusCol.DataPropertyName = nameof(RoomRow.StatusName);

            cboRoomStatus.DisplayMember = nameof(RoomStatus.Status);
            cboRoomStatus.ValueMember = nameof(RoomStatus.Id);
            cboRoomTypeId.DisplayMember = nameof(RoomType.NameType);
            cboRoomTypeId.ValueMember = nameof(RoomType.Id);

            dgvRoomTypes.EnableDoubleBuffer();
            dgvRooms.EnableDoubleBuffer();
        }

        private void WireEvents()
        {
            Load += async (s, e) =>
            {
                if (DesignMode || _data == null) return;
                await TryAsync(LoadAllAsync, "โหลดข้อมูลห้องพักไม่สำเร็จ");
                BindStatusCombo();
                BindTypeCombo();
                BindTypes();
                BindRooms();
                UpdateButtons();
            };

            // ประเภทห้อง
            btnTypeAdd.Click += async (s, e) => await SaveTypeAsync();
            btnTypeEdit.Click += async (s, e) => await SaveTypeAsync();
            btnTypeDelete.Click += async (s, e) => await DeleteTypeAsync();
            dgvRoomTypes.SelectionChanged += (s, e) => OnTypeSelectionChanged();

            // รายการห้องพัก
            btnRoomAdd.Click += async (s, e) => await SaveRoomAsync();
            btnRoomEdit.Click += async (s, e) => await SaveRoomAsync();
            btnRoomDelete.Click += async (s, e) => await DeleteRoomAsync();
            dgvRooms.SelectionChanged += (s, e) => OnRoomSelectionChanged();
            dgvRooms.CellFormatting += OnRoomCellFormatting;

            // คลิกพื้นที่ว่าง = ล้างการเลือก (กลับไปโหมดเพิ่ม)
            dgvRoomTypes.MouseDown += (s, e) =>
            {
                if (dgvRoomTypes.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None) ClearTypeForm();
            };
            dgvRooms.MouseDown += (s, e) =>
            {
                if (dgvRooms.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None) ClearRoomForm();
            };
            pnlRoomTypes.Click += (s, e) => ClearTypeForm();
            pnlRoomTypesHeader.Click += (s, e) => ClearTypeForm();
            lblRoomTypesTitle.Click += (s, e) => ClearTypeForm();
            pnlRoomList.Click += (s, e) => ClearRoomForm();
            pnlRoomListHeader.Click += (s, e) => ClearRoomForm();
            lblRoomListTitle.Click += (s, e) => ClearRoomForm();
            Click += (s, e) => { ClearTypeForm(); ClearRoomForm(); };

            // กด Esc = ล้างการเลือกฝั่งที่กำลังใช้งานอยู่ (ถ้าไม่รู้ว่าฝั่งไหน ล้างทั้งสองฝั่ง)
            KeyPreview = true;
            KeyDown += OnFormKeyDown;
        }

        private void OnFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape) return;
            if (ActiveControl is ComboBox cb && cb.DroppedDown) return;   // ให้ Esc ปิดรายการของ ComboBox ก่อน

            if (pnlRoomTypes.ContainsFocus) ClearTypeForm();
            else if (pnlRoomList.ContainsFocus) ClearRoomForm();
            else { ClearTypeForm(); ClearRoomForm(); }

            e.Handled = true;
        }

        // ---------------------------------------------------------------
        // LOAD / BIND
        // ---------------------------------------------------------------
        private async Task LoadAllAsync()
        {
            _statuses = (await _data.RoomStatuses.GetAllAsync()).ToList();
            await ReloadTypesAsync();
            await ReloadRoomsAsync();
        }

        private async Task ReloadTypesAsync()
        {
            _types = (await _data.RoomTypes.FindAsync(new Filter().OrderBy("Id"))).ToList();
        }

        private async Task ReloadRoomsAsync()
        {
            _rooms = (await _data.Rooms.FindAsync(new Filter().OrderBy("RoomNumber"))).ToList();
        }

        private void BindTypes()
        {
            _binding = true;
            try
            {
                dgvRoomTypes.DataSource = _types;
                dgvRoomTypes.ClearSelection();
            }
            finally
            {
                _binding = false;
            }
        }

        private void BindRooms()
        {
            int? keepId = _selectedRoom?.Id;
            var typeNames = _types.ToDictionary(t => t.Id, t => t.NameType);
            var statusNames = _statuses.ToDictionary(s => s.Id, s => s.Status);

            var rows = _rooms.Select(r => new RoomRow
            {
                Room = r,
                RoomNumber = r.RoomNumber,
                TypeName = NameOf(typeNames, r.RoomTypeId),
                StatusName = NameOf(statusNames, r.RoomStatusId)
            }).ToList();

            _binding = true;
            try
            {
                dgvRooms.DataSource = rows;
                dgvRooms.ClearSelection();
                if (keepId.HasValue)
                {
                    int index = rows.FindIndex(r => r.Room.Id == keepId.Value);
                    if (index >= 0)
                    {
                        dgvRooms.Rows[index].Selected = true;
                        dgvRooms.CurrentCell = dgvRooms.Rows[index].Cells[colRoomNo.Index];
                    }
                }
            }
            finally
            {
                _binding = false;
            }
        }

        private void BindStatusCombo()
        {
            _binding = true;
            try
            {
                cboRoomStatus.DataSource = null;
                cboRoomStatus.Items.Clear();               // ล้างค่าที่ฮาร์ดโค้ดไว้ใน Designer ก่อนใช้ข้อมูลจริง
                cboRoomStatus.DataSource = _statuses;
                cboRoomStatus.SelectedIndex = -1;
            }
            finally
            {
                _binding = false;
            }
        }

        private void BindTypeCombo()
        {
            object keep = cboRoomTypeId.SelectedValue;     // จำค่าที่เลือกไว้ แล้วคืนให้หลัง bind ใหม่
            _binding = true;
            try
            {
                cboRoomTypeId.DataSource = _types;
                if (keep != null) cboRoomTypeId.SelectedValue = keep;
                else cboRoomTypeId.SelectedIndex = -1;
            }
            finally
            {
                _binding = false;
            }
        }

        // ระบายสีช่องสถานะตาม AppTheme
        private void OnRoomCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colRoomStatusCol.Index) return;
            string status = e.Value as string;
            if (string.IsNullOrEmpty(status)) return;

            var style = e.CellStyle;
            style.BackColor = AppTheme.StatusBack(status);
            style.ForeColor = AppTheme.StatusFore(status);
            style.SelectionBackColor = style.BackColor;
            style.SelectionForeColor = style.ForeColor;
        }

        private static string NameOf(Dictionary<int, string> names, int id)
        {
            return names.TryGetValue(id, out var name) ? name : "-";
        }

        // ---------------------------------------------------------------
        // ROOM TYPES : FORM
        // ---------------------------------------------------------------
        private void OnTypeSelectionChanged()
        {
            if (_binding || dgvRoomTypes.SelectedRows.Count == 0) return;
            var type = dgvRoomTypes.SelectedRows[0].DataBoundItem as RoomType;
            if (type != null) ShowType(type);
        }

        private void ShowType(RoomType t)
        {
            _selectedType = t;
            txtTypeName.Text = t.NameType;
            txtTypePrice.Text = t.PricePerNight.ToString("0.##", CultureInfo.CurrentCulture);
            txtTypeCapacity.Text = t.Capacity.ToString(CultureInfo.CurrentCulture);
            txtTypeDesc.Text = t.Description;
            UpdateButtons();
        }

        private void ClearTypeForm()
        {
            _selectedType = null;
            txtTypeName.Clear();
            txtTypePrice.Clear();
            txtTypeCapacity.Clear();
            txtTypeDesc.Clear();
            dgvRoomTypes.ClearSelection();
            UpdateButtons();
            txtTypeName.Focus();
        }

        // ---------------------------------------------------------------
        // ROOM TYPES : SAVE / DELETE
        // ---------------------------------------------------------------
        private async Task SaveTypeAsync()
        {
            if (IsBusy) return;

            string name = txtTypeName.Text.Trim();
            if (name.Length == 0) { Warn("กรุณากรอกชื่อประเภทห้อง", txtTypeName); return; }

            if (!TryParsePrice(txtTypePrice.Text, out decimal price))
            { Warn("กรุณากรอกราคาต่อคืนเป็นตัวเลขที่มากกว่า 0", txtTypePrice); return; }

            if (!int.TryParse(txtTypeCapacity.Text.Trim(), NumberStyles.Integer, CultureInfo.CurrentCulture, out int capacity) || capacity <= 0)
            { Warn("กรุณากรอกความจุเป็นจำนวนเต็มที่มากกว่า 0", txtTypeCapacity); return; }

            int selfId = _selectedType?.Id ?? 0;
            if (_types.Any(t => t.Id != selfId && string.Equals(t.NameType?.Trim(), name, StringComparison.OrdinalIgnoreCase)))
            { Warn("มีประเภทห้องชื่อนี้อยู่แล้ว", txtTypeName); return; }

            bool isNew = _selectedType == null;
            var entity = new RoomType
            {
                Id = selfId,
                NameType = name,
                PricePerNight = price,
                Capacity = capacity,
                Description = NullIfEmpty(txtTypeDesc.Text)
            };

            bool saved = await TryAsync(
                () => isNew ? _data.RoomTypes.AddAsync(entity) : _data.RoomTypes.UpdateAsync(entity),
                "บันทึกข้อมูลไม่สำเร็จ");
            if (!saved) return;

            if (!await TryAsync(ReloadTypesAsync, "บันทึกแล้ว แต่โหลดรายการใหม่ไม่สำเร็จ")) return;

            RefreshTypeViews();
            ShowSuccess(isNew ? "เพิ่มประเภทห้องเรียบร้อยแล้ว" : "บันทึกการแก้ไขเรียบร้อยแล้ว");
        }

        private async Task DeleteTypeAsync()
        {
            if (IsBusy || _selectedType == null) return;
            var target = _selectedType;

            // ประเภทที่มีห้องใช้อยู่ลบไม่ได้
            int rooms = 0;
            if (!await TryAsync(async () =>
                    rooms = await _data.Rooms.CountAsync(new Filter().Eq("RoomTypeId", target.Id)),
                    "ตรวจสอบห้องที่ใช้ประเภทนี้ไม่สำเร็จ"))
                return;

            if (rooms > 0)
            {
                ShowCannotDelete($"ลบไม่ได้ เพราะประเภท \"{target.NameType}\" ถูกใช้กับห้องพัก {rooms} ห้อง");
                return;
            }

            if (!ConfirmDelete($"ต้องการลบประเภทห้อง \"{target.NameType}\" ใช่หรือไม่?")) return;

            if (!await TryAsync(() => _data.RoomTypes.DeleteAsync(target.Id), "ลบข้อมูลไม่สำเร็จ")) return;
            if (!await TryAsync(ReloadTypesAsync, "ลบแล้ว แต่โหลดรายการใหม่ไม่สำเร็จ")) return;

            RefreshTypeViews();
            ShowSuccess("ลบประเภทห้องเรียบร้อยแล้ว");
        }

        // หลังประเภทห้องเปลี่ยน: อัปเดตตารางประเภท, ComboBox ประเภทห้อง และชื่อประเภทในตารางห้องพัก (ไม่ต้องโหลดห้องใหม่)
        private void RefreshTypeViews()
        {
            BindTypes();
            ClearTypeForm();
            BindTypeCombo();
            BindRooms();
        }

        // ---------------------------------------------------------------
        // ROOMS : FORM
        // ---------------------------------------------------------------
        private void OnRoomSelectionChanged()
        {
            if (_binding || dgvRooms.SelectedRows.Count == 0) return;
            var row = dgvRooms.SelectedRows[0].DataBoundItem as RoomRow;
            if (row != null) ShowRoom(row.Room);
        }

        private void ShowRoom(Room r)
        {
            _selectedRoom = r;
            txtRoomNumber.Text = r.RoomNumber;
            cboRoomStatus.SelectedValue = r.RoomStatusId;
            cboRoomTypeId.SelectedValue = r.RoomTypeId;
            UpdateButtons();
        }

        private void ClearRoomForm()
        {
            _selectedRoom = null;
            txtRoomNumber.Clear();
            cboRoomStatus.SelectedIndex = -1;
            cboRoomTypeId.SelectedIndex = -1;
            dgvRooms.ClearSelection();
            UpdateButtons();
            txtRoomNumber.Focus();
        }

        // ---------------------------------------------------------------
        // ROOMS : SAVE / DELETE
        // ---------------------------------------------------------------
        private async Task SaveRoomAsync()
        {
            if (IsBusy) return;

            string number = txtRoomNumber.Text.Trim();
            if (number.Length == 0) { Warn("กรุณากรอกเลขห้อง", txtRoomNumber); return; }
            if (!(cboRoomTypeId.SelectedValue is int typeId)) { Warn("กรุณาเลือกประเภทห้อง", cboRoomTypeId); return; }
            if (!(cboRoomStatus.SelectedValue is int statusId)) { Warn("กรุณาเลือกสถานะห้อง", cboRoomStatus); return; }

            int selfId = _selectedRoom?.Id ?? 0;
            if (_rooms.Any(r => r.Id != selfId && string.Equals(r.RoomNumber?.Trim(), number, StringComparison.OrdinalIgnoreCase)))
            { Warn("มีเลขห้องนี้อยู่แล้ว", txtRoomNumber); return; }

            bool isNew = _selectedRoom == null;
            var entity = new Room
            {
                Id = selfId,
                RoomNumber = number,
                RoomTypeId = typeId,
                RoomStatusId = statusId
            };

            bool saved = await TryAsync(
                () => isNew ? _data.Rooms.AddAsync(entity) : _data.Rooms.UpdateAsync(entity),
                "บันทึกข้อมูลไม่สำเร็จ");
            if (!saved) return;

            if (!await TryAsync(ReloadRoomsAsync, "บันทึกแล้ว แต่โหลดรายการใหม่ไม่สำเร็จ")) return;

            ClearRoomForm();
            BindRooms();
            ShowSuccess(isNew ? "เพิ่มห้องพักเรียบร้อยแล้ว" : "บันทึกการแก้ไขเรียบร้อยแล้ว");
        }

        private async Task DeleteRoomAsync()
        {
            if (IsBusy || _selectedRoom == null) return;
            var target = _selectedRoom;

            // ห้องที่มีประวัติการจองลบไม่ได้
            int bookings = 0;
            if (!await TryAsync(async () =>
                    bookings = await _data.Bookings.CountAsync(new Filter().Eq("RoomId", target.Id)),
                    "ตรวจสอบประวัติการจองไม่สำเร็จ"))
                return;

            if (bookings > 0)
            {
                ShowCannotDelete($"ลบไม่ได้ เพราะห้อง \"{target.RoomNumber}\" มีประวัติการจอง {bookings} รายการ");
                return;
            }

            if (!ConfirmDelete($"ต้องการลบห้อง \"{target.RoomNumber}\" ใช่หรือไม่?")) return;

            if (!await TryAsync(() => _data.Rooms.DeleteAsync(target.Id), "ลบข้อมูลไม่สำเร็จ")) return;
            if (!await TryAsync(ReloadRoomsAsync, "ลบแล้ว แต่โหลดรายการใหม่ไม่สำเร็จ")) return;

            ClearRoomForm();
            BindRooms();
            ShowSuccess("ลบห้องพักเรียบร้อยแล้ว");
        }

        // ---------------------------------------------------------------
        // HELPERS
        // ---------------------------------------------------------------
        // เพิ่ม = ใช้ได้เฉพาะตอนไม่ได้เลือกแถว / แก้ไข+ลบ = ใช้ได้เฉพาะตอนเลือกแถวอยู่
        protected override void UpdateButtons()
        {
            bool hasType = _selectedType != null;
            btnTypeAdd.Enabled = !IsBusy && !hasType;
            btnTypeEdit.Enabled = !IsBusy && hasType;
            btnTypeDelete.Enabled = !IsBusy && hasType;

            bool hasRoom = _selectedRoom != null;
            btnRoomAdd.Enabled = !IsBusy && !hasRoom;
            btnRoomEdit.Enabled = !IsBusy && hasRoom;
            btnRoomDelete.Enabled = !IsBusy && hasRoom;
        }

        private static bool TryParsePrice(string text, out decimal price)
        {
            text = (text ?? "").Replace("฿", "").Trim();
            if (decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out price) && price > 0)
            {
                price = Math.Round(price, 2);
                return true;
            }
            return false;
        }
    }
}
