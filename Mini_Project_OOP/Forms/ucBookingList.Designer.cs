namespace Mini_Project_OOP.Forms
{
    partial class ucBookingList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterFrom = new System.Windows.Forms.Label();
            this.dtpFilterFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFilterTo = new System.Windows.Forms.Label();
            this.dtpFilterTo = new System.Windows.Forms.DateTimePicker();
            this.lblFilterKeyword = new System.Windows.Forms.Label();
            this.txtFilterKeyword = new System.Windows.Forms.TextBox();
            this.btnFilterSearch = new System.Windows.Forms.Button();
            this.btnFilterReset = new System.Windows.Forms.Button();
            this.pnlBookingGrid = new System.Windows.Forms.Panel();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.colBkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBkCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBkRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBkCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBkCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBkTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBkStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBkCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooterLine = new System.Windows.Forms.Panel();
            this.pnlBookingFooter = new System.Windows.Forms.Panel();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.pnlFilter.SuspendLayout();
            this.pnlBookingGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.pnlBookingFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.lblFilterStatus);
            this.pnlFilter.Controls.Add(this.cboFilterStatus);
            this.pnlFilter.Controls.Add(this.lblFilterFrom);
            this.pnlFilter.Controls.Add(this.dtpFilterFrom);
            this.pnlFilter.Controls.Add(this.lblFilterTo);
            this.pnlFilter.Controls.Add(this.dtpFilterTo);
            this.pnlFilter.Controls.Add(this.lblFilterKeyword);
            this.pnlFilter.Controls.Add(this.txtFilterKeyword);
            this.pnlFilter.Controls.Add(this.btnFilterSearch);
            this.pnlFilter.Controls.Add(this.btnFilterReset);
            this.pnlFilter.Location = new System.Drawing.Point(20, 9);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1020, 90);
            this.pnlFilter.TabIndex = 0;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblFilterStatus.Location = new System.Drawing.Point(16, 16);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(44, 19);
            this.lblFilterStatus.TabIndex = 0;
            this.lblFilterStatus.Text = "สถานะ";
            // 
            // cboFilterStatus
            // 
            this.cboFilterStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilterStatus.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Items.AddRange(new object[] {
            "ทั้งหมด",
            "Confirmed",
            "CheckedIn",
            "CheckedOut",
            "Cancelled"});
            this.cboFilterStatus.Location = new System.Drawing.Point(16, 40);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(160, 28);
            this.cboFilterStatus.TabIndex = 2;
            // 
            // lblFilterFrom
            // 
            this.lblFilterFrom.AutoSize = true;
            this.lblFilterFrom.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFilterFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblFilterFrom.Location = new System.Drawing.Point(188, 16);
            this.lblFilterFrom.Name = "lblFilterFrom";
            this.lblFilterFrom.Size = new System.Drawing.Size(72, 19);
            this.lblFilterFrom.TabIndex = 3;
            this.lblFilterFrom.Text = "เช็คอินตั้งแต่";
            // 
            // dtpFilterFrom
            // 
            this.dtpFilterFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFilterFrom.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpFilterFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterFrom.Location = new System.Drawing.Point(188, 40);
            this.dtpFilterFrom.Name = "dtpFilterFrom";
            this.dtpFilterFrom.Size = new System.Drawing.Size(140, 27);
            this.dtpFilterFrom.TabIndex = 4;
            // 
            // lblFilterTo
            // 
            this.lblFilterTo.AutoSize = true;
            this.lblFilterTo.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFilterTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblFilterTo.Location = new System.Drawing.Point(340, 16);
            this.lblFilterTo.Name = "lblFilterTo";
            this.lblFilterTo.Size = new System.Drawing.Size(44, 19);
            this.lblFilterTo.TabIndex = 5;
            this.lblFilterTo.Text = "ถึงวันที่";
            // 
            // dtpFilterTo
            // 
            this.dtpFilterTo.CustomFormat = "dd/MM/yyyy";
            this.dtpFilterTo.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpFilterTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterTo.Location = new System.Drawing.Point(340, 40);
            this.dtpFilterTo.Name = "dtpFilterTo";
            this.dtpFilterTo.Size = new System.Drawing.Size(140, 27);
            this.dtpFilterTo.TabIndex = 6;
            // 
            // lblFilterKeyword
            // 
            this.lblFilterKeyword.AutoSize = true;
            this.lblFilterKeyword.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFilterKeyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblFilterKeyword.Location = new System.Drawing.Point(492, 16);
            this.lblFilterKeyword.Name = "lblFilterKeyword";
            this.lblFilterKeyword.Size = new System.Drawing.Size(107, 19);
            this.lblFilterKeyword.TabIndex = 7;
            this.lblFilterKeyword.Text = "ชื่อลูกค้า / เลขห้อง";
            // 
            // txtFilterKeyword
            // 
            this.txtFilterKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterKeyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFilterKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterKeyword.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtFilterKeyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.txtFilterKeyword.Location = new System.Drawing.Point(492, 40);
            this.txtFilterKeyword.Name = "txtFilterKeyword";
            this.txtFilterKeyword.Size = new System.Drawing.Size(294, 32);
            this.txtFilterKeyword.TabIndex = 8;
            // 
            // btnFilterSearch
            // 
            this.btnFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnFilterSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterSearch.FlatAppearance.BorderSize = 0;
            this.btnFilterSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterSearch.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnFilterSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFilterSearch.Location = new System.Drawing.Point(798, 40);
            this.btnFilterSearch.Name = "btnFilterSearch";
            this.btnFilterSearch.Size = new System.Drawing.Size(96, 32);
            this.btnFilterSearch.TabIndex = 9;
            this.btnFilterSearch.Text = "ค้นหา";
            this.btnFilterSearch.UseVisualStyleBackColor = false;
            // 
            // btnFilterReset
            // 
            this.btnFilterReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFilterReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnFilterReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterReset.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnFilterReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnFilterReset.Location = new System.Drawing.Point(906, 40);
            this.btnFilterReset.Name = "btnFilterReset";
            this.btnFilterReset.Size = new System.Drawing.Size(96, 32);
            this.btnFilterReset.TabIndex = 10;
            this.btnFilterReset.Text = "รีเซ็ต";
            this.btnFilterReset.UseVisualStyleBackColor = false;
            // 
            // pnlBookingGrid
            // 
            this.pnlBookingGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBookingGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlBookingGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBookingGrid.Controls.Add(this.dgvBookings);
            this.pnlBookingGrid.Controls.Add(this.pnlFooterLine);
            this.pnlBookingGrid.Controls.Add(this.pnlBookingFooter);
            this.pnlBookingGrid.Location = new System.Drawing.Point(20, 116);
            this.pnlBookingGrid.Name = "pnlBookingGrid";
            this.pnlBookingGrid.Size = new System.Drawing.Size(1020, 541);
            this.pnlBookingGrid.TabIndex = 1;
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.dgvBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookings.ColumnHeadersHeight = 32;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBkId,
            this.colBkCustomer,
            this.colBkRoom,
            this.colBkType,
            this.colBkCheckIn,
            this.colBkCheckOut,
            this.colBkTotal,
            this.colBkStatus,
            this.colBkCreated});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBookings.EnableHeadersVisualStyles = false;
            this.dgvBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.dgvBookings.Location = new System.Drawing.Point(0, 0);
            this.dgvBookings.MultiSelect = false;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersVisible = false;
            this.dgvBookings.RowTemplate.Height = 36;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(1018, 482);
            this.dgvBookings.TabIndex = 0;
            // 
            // colBkId
            // 
            this.colBkId.HeaderText = "รหัส";
            this.colBkId.Name = "colBkId";
            this.colBkId.ReadOnly = true;
            this.colBkId.Width = 70;
            // 
            // colBkCustomer
            // 
            this.colBkCustomer.HeaderText = "ลูกค้า";
            this.colBkCustomer.Name = "colBkCustomer";
            this.colBkCustomer.ReadOnly = true;
            this.colBkCustomer.Width = 190;
            // 
            // colBkRoom
            // 
            this.colBkRoom.HeaderText = "ห้อง";
            this.colBkRoom.Name = "colBkRoom";
            this.colBkRoom.ReadOnly = true;
            this.colBkRoom.Width = 80;
            // 
            // colBkType
            // 
            this.colBkType.HeaderText = "ประเภท";
            this.colBkType.Name = "colBkType";
            this.colBkType.ReadOnly = true;
            this.colBkType.Width = 110;
            // 
            // colBkCheckIn
            // 
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.colBkCheckIn.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBkCheckIn.HeaderText = "เช็คอิน";
            this.colBkCheckIn.Name = "colBkCheckIn";
            this.colBkCheckIn.ReadOnly = true;
            this.colBkCheckIn.Width = 110;
            // 
            // colBkCheckOut
            // 
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.colBkCheckOut.DefaultCellStyle = dataGridViewCellStyle4;
            this.colBkCheckOut.HeaderText = "เช็คเอาท์";
            this.colBkCheckOut.Name = "colBkCheckOut";
            this.colBkCheckOut.ReadOnly = true;
            this.colBkCheckOut.Width = 110;
            // 
            // colBkTotal
            // 
            dataGridViewCellStyle5.Format = "฿#,##0";
            dataGridViewCellStyle5.NullValue = null;
            this.colBkTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.colBkTotal.HeaderText = "ราคารวม";
            this.colBkTotal.Name = "colBkTotal";
            this.colBkTotal.ReadOnly = true;
            this.colBkTotal.Width = 110;
            // 
            // colBkStatus
            // 
            this.colBkStatus.HeaderText = "สถานะ";
            this.colBkStatus.Name = "colBkStatus";
            this.colBkStatus.ReadOnly = true;
            this.colBkStatus.Width = 120;
            // 
            // colBkCreated
            // 
            this.colBkCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            dataGridViewCellStyle6.NullValue = null;
            this.colBkCreated.DefaultCellStyle = dataGridViewCellStyle6;
            this.colBkCreated.HeaderText = "สร้างเมื่อ";
            this.colBkCreated.MinimumWidth = 60;
            this.colBkCreated.Name = "colBkCreated";
            this.colBkCreated.ReadOnly = true;
            // 
            // pnlFooterLine
            // 
            this.pnlFooterLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooterLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.pnlFooterLine.Location = new System.Drawing.Point(0, 482);
            this.pnlFooterLine.Name = "pnlFooterLine";
            this.pnlFooterLine.Size = new System.Drawing.Size(1018, 1);
            this.pnlFooterLine.TabIndex = 1;
            // 
            // pnlBookingFooter
            // 
            this.pnlBookingFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBookingFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlBookingFooter.Controls.Add(this.btnCheckIn);
            this.pnlBookingFooter.Controls.Add(this.btnCheckOut);
            this.pnlBookingFooter.Controls.Add(this.btnCancelBooking);
            this.pnlBookingFooter.Controls.Add(this.lblTotalCount);
            this.pnlBookingFooter.Location = new System.Drawing.Point(0, 483);
            this.pnlBookingFooter.Name = "pnlBookingFooter";
            this.pnlBookingFooter.Size = new System.Drawing.Size(1018, 56);
            this.pnlBookingFooter.TabIndex = 2;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCheckIn.Location = new System.Drawing.Point(16, 8);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(140, 40);
            this.btnCheckIn.TabIndex = 15;
            this.btnCheckIn.Text = "เช็คอิน";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.Enabled = false;
            this.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnCheckOut.Location = new System.Drawing.Point(164, 8);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(140, 40);
            this.btnCheckOut.TabIndex = 16;
            this.btnCheckOut.Text = "เช็คเอาท์";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelBooking.FlatAppearance.BorderSize = 0;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancelBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelBooking.Location = new System.Drawing.Point(312, 8);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(160, 40);
            this.btnCancelBooking.TabIndex = 17;
            this.btnCancelBooking.Text = "ยกเลิกการจอง";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCount.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblTotalCount.Location = new System.Drawing.Point(802, 16);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(200, 24);
            this.lblTotalCount.TabIndex = 18;
            this.lblTotalCount.Text = "รวม 0 รายการ";
            this.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucBookingList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1044, 657);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlBookingGrid);
            this.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "ucBookingList";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlBookingGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.pnlBookingFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Label lblFilterFrom;
        private System.Windows.Forms.DateTimePicker dtpFilterFrom;
        private System.Windows.Forms.Label lblFilterTo;
        private System.Windows.Forms.DateTimePicker dtpFilterTo;
        private System.Windows.Forms.Label lblFilterKeyword;
        private System.Windows.Forms.TextBox txtFilterKeyword;
        private System.Windows.Forms.Button btnFilterSearch;
        private System.Windows.Forms.Button btnFilterReset;
        private System.Windows.Forms.Panel pnlBookingGrid;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Panel pnlFooterLine;
        private System.Windows.Forms.Panel pnlBookingFooter;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBkCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBkRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBkType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBkCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBkCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBkTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBkStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBkCreated;
    }
}