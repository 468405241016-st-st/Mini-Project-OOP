using Mini_Project_OOP.Helper;
using Mini_Project_OOP.Model;
using Mini_Project_OOP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mini_Project_OOP.Helper.TextUtils;

namespace Mini_Project_OOP.Forms
{
    public partial class ucCustomers : DataForm
    {
        private readonly AppData _data;
        private readonly System.Windows.Forms.Timer _searchTimer = new System.Windows.Forms.Timer { Interval = 250 };

        private List<Customer> _all = new List<Customer>();                       // ลูกค้าทั้งหมด (cache ในหน่วยความจำ)
        private Dictionary<int, string> _keys = new Dictionary<int, string>();    // ข้อความรวมทุกช่อง ไว้ค้นหาเร็วๆ (คีย์ = Id)
        private Customer _selected;                                               // null = กำลังเพิ่มลูกค้าใหม่
        private bool _binding;                                                    // กัน SelectionChanged ตอนกำลัง bind ข้อมูล

        // ใช้ตอนเปิดใน Designer เท่านั้น
        public ucCustomers()
        {
            InitializeComponent();
            SetupGrid();
            WireEvents();
        }

        public ucCustomers(AppData data) : this()
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }

        // ---------------------------------------------------------------
        // SETUP
        // ---------------------------------------------------------------
        private void SetupGrid()
        {
            // DataPropertyName = บอกคอลัมน์ว่าให้แสดงค่าจาก property ไหนของ Customer
            dgvCustomers.AutoGenerateColumns = false;
            colCustomerId.DataPropertyName = nameof(Customer.Id);
            colFullName.DataPropertyName = nameof(Customer.FullName);
            colPhone.DataPropertyName = nameof(Customer.PhoneNumber);
            colIdCard.DataPropertyName = nameof(Customer.NationalId);
            colEmail.DataPropertyName = nameof(Customer.Email);

            dgvCustomers.EnableDoubleBuffer();
        }

        private void WireEvents()
        {
            Load += async (s, e) =>
            {
                if (DesignMode || _data == null) return;
                await TryAsync(ReloadCacheAsync, "โหลดข้อมูลลูกค้าไม่สำเร็จ");
                ApplyFilter();
                UpdateButtons();
            };
            FormClosed += (s, e) => _searchTimer.Dispose();

            btnSaveCustomer.Click += async (s, e) => await SaveAsync();
            btnClearCustomer.Click += (s, e) => ClearForm();
            btnDeleteCustomer.Click += async (s, e) => await DeleteAsync();

            btnSearch.Click += (s, e) => ApplyFilter();
            btnShowAll.Click += (s, e) =>
            {
                ClearSearch();
                ApplyFilter();
            };

            // พิมพ์ค้นหาแล้วรอ 250ms ค่อยกรอง (ไม่กรองทุกตัวอักษร)
            txtSearch.TextChanged += (s, e) => { _searchTimer.Stop(); _searchTimer.Start(); };
            _searchTimer.Tick += (s, e) => ApplyFilter();
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode != Keys.Enter) return;
                e.SuppressKeyPress = true;
                ApplyFilter();
            };

            dgvCustomers.SelectionChanged += (s, e) => OnGridSelectionChanged();
        }

        // ---------------------------------------------------------------
        // LOAD / SEARCH
        // ---------------------------------------------------------------
        // ดึงลูกค้าทั้งหมดครั้งเดียว แล้วค้นหาในหน่วยความจำ (Filter ไม่รองรับ OR ข้ามหลายคอลัมน์ และเร็วกว่ายิงฐานข้อมูลทุกครั้ง)
        private async Task ReloadCacheAsync()
        {
            var rows = await _data.Customers.FindAsync(new Filter().OrderBy("Id"));
            _all = rows.ToList();
            _keys = _all.ToDictionary(c => c.Id, BuildKey);
        }

        private static string BuildKey(Customer c)
        {
            // เก็บเบอร์/เลขบัตรแบบตัดช่องว่างและขีดไว้ด้วย เพื่อให้พิมพ์ "081-234" แล้วเจอ "0812345678"
            return string.Join("\u0001",
                c.FullName, c.PhoneNumber, Compact(c.PhoneNumber), c.NationalId, Compact(c.NationalId), c.Email);
        }

        private void ClearSearch()
        {
            txtSearch.Text = "";
            _searchTimer.Stop();
        }

        private void ApplyFilter()
        {
            _searchTimer.Stop();
            string term = txtSearch.Text.Trim();

            List<Customer> view;
            if (term.Length == 0)
            {
                view = _all;
            }
            else
            {
                string compact = IsNumericLike(term) ? Compact(term) : "";
                view = _all.Where(c =>
                {
                    string key = _keys[c.Id];
                    return ContainsIgnoreCase(key, term)
                        || (compact.Length > 0 && ContainsIgnoreCase(key, compact));
                }).ToList();
            }

            Bind(view);
        }

        private void Bind(List<Customer> view)
        {
            int? keepId = _selected?.Id;
            _binding = true;
            try
            {
                dgvCustomers.DataSource = view;
                dgvCustomers.ClearSelection();
                if (keepId.HasValue) SelectRow(view, keepId.Value);
            }
            finally
            {
                _binding = false;
            }
        }

        private void SelectRow(List<Customer> view, int id)
        {
            int index = view.FindIndex(c => c.Id == id);
            if (index < 0) return;
            dgvCustomers.Rows[index].Selected = true;
            dgvCustomers.CurrentCell = dgvCustomers.Rows[index].Cells[colFullName.Index];
        }

        private void OnGridSelectionChanged()
        {
            if (_binding || dgvCustomers.SelectedRows.Count == 0) return;
            var customer = dgvCustomers.SelectedRows[0].DataBoundItem as Customer;
            if (customer != null) ShowCustomer(customer);
        }

        // ---------------------------------------------------------------
        // FORM
        // ---------------------------------------------------------------
        private void ShowCustomer(Customer c)
        {
            _selected = c;
            txtFullName.Text = c.FullName;
            txtPhoneDetail.Text = c.PhoneNumber;
            txtIdCardDetail.Text = c.NationalId;
            txtEmailDetail.Text = c.Email;
            UpdateButtons();
        }

        private void ClearForm()
        {
            _selected = null;
            txtFullName.Clear();
            txtPhoneDetail.Clear();
            txtIdCardDetail.Clear();
            txtEmailDetail.Clear();
            dgvCustomers.ClearSelection();
            UpdateButtons();
            txtFullName.Focus();
        }

        protected override void UpdateButtons()
        {
            btnSaveCustomer.Enabled = !IsBusy;
            btnClearCustomer.Enabled = !IsBusy;
            btnDeleteCustomer.Enabled = !IsBusy && _selected != null;
        }

        // ---------------------------------------------------------------
        // SAVE / DELETE
        // ---------------------------------------------------------------
        private async Task SaveAsync()
        {
            if (IsBusy) return;

            string name = txtFullName.Text.Trim();
            string email = txtEmailDetail.Text.Trim();

            if (name.Length == 0) { Warn("กรุณากรอกชื่อ-นามสกุล", txtFullName); return; }
            if (email.Length == 0) { Warn("กรุณากรอกอีเมล", txtEmailDetail); return; }
            if (!IsValidEmail(email)) { Warn("รูปแบบอีเมลไม่ถูกต้อง", txtEmailDetail); return; }

            bool isNew = _selected == null;
            var entity = new Customer
            {
                Id = _selected?.Id ?? 0,
                FullName = name,
                PhoneNumber = NullIfEmpty(txtPhoneDetail.Text),
                NationalId = NullIfEmpty(txtIdCardDetail.Text),
                Email = email
            };

            bool saved = await TryAsync(
                () => isNew ? _data.Customers.AddAsync(entity) : _data.Customers.UpdateAsync(entity),
                "บันทึกข้อมูลไม่สำเร็จ");
            if (!saved) return;

            if (!await TryAsync(ReloadCacheAsync, "บันทึกแล้ว แต่โหลดรายการใหม่ไม่สำเร็จ")) return;

            // แสดงทุกแถว แล้วเลือกแถวที่เพิ่งบันทึก (ลูกค้าใหม่ = Id ล่าสุดที่ชื่อ+อีเมลตรงกัน)
            ClearSearch();
            int? savedId = isNew
                ? _all.Where(c => c.FullName == name && c.Email == email)
                      .OrderByDescending(c => c.Id).FirstOrDefault()?.Id
                : entity.Id;

            _selected = null;
            ApplyFilter();
            if (savedId.HasValue) SelectRow(_all, savedId.Value);   // SelectionChanged จะเติมฟอร์มให้เอง
            UpdateButtons();

            ShowSuccess(isNew ? "เพิ่มลูกค้าใหม่เรียบร้อยแล้ว" : "บันทึกการแก้ไขเรียบร้อยแล้ว");
        }

        private async Task DeleteAsync()
        {
            if (IsBusy || _selected == null) return;
            var target = _selected;

            // ลูกค้าที่มีประวัติการจองลบไม่ได้ (กันข้อมูลการจองกลายเป็นกำพร้า)
            int bookings = 0;
            if (!await TryAsync(async () =>
                    bookings = await _data.Bookings.CountAsync(new Filter().Eq("CustomerId", target.Id)),
                    "ตรวจสอบประวัติการจองไม่สำเร็จ"))
                return;

            if (bookings > 0)
            {
                ShowCannotDelete($"ลบไม่ได้ เพราะ \"{target.FullName}\" มีประวัติการจอง {bookings} รายการ");
                return;
            }

            if (!ConfirmDelete($"ต้องการลบลูกค้า \"{target.FullName}\" ใช่หรือไม่?")) return;

            if (!await TryAsync(() => _data.Customers.DeleteAsync(target.Id), "ลบข้อมูลไม่สำเร็จ")) return;
            if (!await TryAsync(ReloadCacheAsync, "ลบแล้ว แต่โหลดรายการใหม่ไม่สำเร็จ")) return;

            ClearForm();
            ApplyFilter();
            ShowSuccess("ลบลูกค้าเรียบร้อยแล้ว");
        }
    }
}
