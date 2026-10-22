namespace Mini_Project_OOP.Forms
{
    partial class ucBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.lblIdCard = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.pnlCustomerSeparator = new System.Windows.Forms.Panel();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlCustomerHeaderLine = new System.Windows.Forms.Panel();
            this.lblCustomerHeader = new System.Windows.Forms.Label();
            this.pnlAvailableRooms = new System.Windows.Forms.Panel();
            this.dgvAvailableRooms = new System.Windows.Forms.DataGridView();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAvailableHeaderLine = new System.Windows.Forms.Panel();
            this.lblAvailableHeader = new System.Windows.Forms.Label();
            this.pnlStay = new System.Windows.Forms.Panel();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.pnlStayHeaderLine = new System.Windows.Forms.Panel();
            this.lblStayHeader = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.pnlSummarySeparator = new System.Windows.Forms.Panel();
            this.lblNightsValue = new System.Windows.Forms.Label();
            this.lblNightsCaption = new System.Windows.Forms.Label();
            this.lblPricePerNightValue = new System.Windows.Forms.Label();
            this.lblPricePerNightCaption = new System.Windows.Forms.Label();
            this.lblSelectedRoomValue = new System.Windows.Forms.Label();
            this.lblSelectedRoomCaption = new System.Windows.Forms.Label();
            this.pnlSummaryHeaderLine = new System.Windows.Forms.Panel();
            this.lblSummaryHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlCustomer.SuspendLayout();
            this.pnlAvailableRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableRooms)).BeginInit();
            this.pnlStay.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.White;
            this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomer.Controls.Add(this.txtEmail);
            this.pnlCustomer.Controls.Add(this.lblEmail);
            this.pnlCustomer.Controls.Add(this.txtIdCard);
            this.pnlCustomer.Controls.Add(this.lblIdCard);
            this.pnlCustomer.Controls.Add(this.txtPhone);
            this.pnlCustomer.Controls.Add(this.lblPhone);
            this.pnlCustomer.Controls.Add(this.txtCustomerName);
            this.pnlCustomer.Controls.Add(this.lblCustomerName);
            this.pnlCustomer.Controls.Add(this.pnlCustomerSeparator);
            this.pnlCustomer.Controls.Add(this.btnSearchCustomer);
            this.pnlCustomer.Controls.Add(this.txtSearch);
            this.pnlCustomer.Controls.Add(this.lblSearch);
            this.pnlCustomer.Controls.Add(this.pnlCustomerHeaderLine);
            this.pnlCustomer.Controls.Add(this.lblCustomerHeader);
            this.pnlCustomer.Location = new System.Drawing.Point(19, 13);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(500, 352);
            this.pnlCustomer.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.txtEmail.Location = new System.Drawing.Point(16, 302);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(466, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblEmail.Location = new System.Drawing.Point(16, 278);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 19);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "อีเมล";
            // 
            // txtIdCard
            // 
            this.txtIdCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCard.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtIdCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.txtIdCard.Location = new System.Drawing.Point(255, 234);
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(227, 27);
            this.txtIdCard.TabIndex = 4;
            // 
            // lblIdCard
            // 
            this.lblIdCard.AutoSize = true;
            this.lblIdCard.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblIdCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblIdCard.Location = new System.Drawing.Point(255, 210);
            this.lblIdCard.Name = "lblIdCard";
            this.lblIdCard.Size = new System.Drawing.Size(165, 19);
            this.lblIdCard.TabIndex = 6;
            this.lblIdCard.Text = "เลขบัตรประชาชน / พาสปอร์ต";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.txtPhone.Location = new System.Drawing.Point(16, 234);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(227, 27);
            this.txtPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblPhone.Location = new System.Drawing.Point(16, 210);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(79, 19);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "เบอร์โทรศัพท์";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.txtCustomerName.Location = new System.Drawing.Point(16, 166);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(466, 27);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblCustomerName.Location = new System.Drawing.Point(16, 142);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(76, 19);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "ชื่อ-นามสกุล";
            // 
            // pnlCustomerSeparator
            // 
            this.pnlCustomerSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.pnlCustomerSeparator.Location = new System.Drawing.Point(16, 129);
            this.pnlCustomerSeparator.Name = "pnlCustomerSeparator";
            this.pnlCustomerSeparator.Size = new System.Drawing.Size(466, 1);
            this.pnlCustomerSeparator.TabIndex = 3;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnSearchCustomer.Location = new System.Drawing.Point(386, 85);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(96, 32);
            this.btnSearchCustomer.TabIndex = 1;
            this.btnSearchCustomer.Text = "ค้นหา";
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.txtSearch.Location = new System.Drawing.Point(16, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(362, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblSearch.Location = new System.Drawing.Point(16, 61);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(201, 19);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "ค้นหาลูกค้าเดิม (เบอร์โทร / เลขบัตร)";
            // 
            // pnlCustomerHeaderLine
            // 
            this.pnlCustomerHeaderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.pnlCustomerHeaderLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomerHeaderLine.Location = new System.Drawing.Point(0, 44);
            this.pnlCustomerHeaderLine.Name = "pnlCustomerHeaderLine";
            this.pnlCustomerHeaderLine.Size = new System.Drawing.Size(498, 1);
            this.pnlCustomerHeaderLine.TabIndex = 1;
            // 
            // lblCustomerHeader
            // 
            this.lblCustomerHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomerHeader.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCustomerHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            this.lblCustomerHeader.Location = new System.Drawing.Point(0, 0);
            this.lblCustomerHeader.Name = "lblCustomerHeader";
            this.lblCustomerHeader.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblCustomerHeader.Size = new System.Drawing.Size(498, 44);
            this.lblCustomerHeader.TabIndex = 0;
            this.lblCustomerHeader.Text = "1. ข้อมูลลูกค้า";
            this.lblCustomerHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAvailableRooms
            // 
            this.pnlAvailableRooms.BackColor = System.Drawing.Color.White;
            this.pnlAvailableRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvailableRooms.Controls.Add(this.dgvAvailableRooms);
            this.pnlAvailableRooms.Controls.Add(this.pnlAvailableHeaderLine);
            this.pnlAvailableRooms.Controls.Add(this.lblAvailableHeader);
            this.pnlAvailableRooms.Location = new System.Drawing.Point(20, 388);
            this.pnlAvailableRooms.Name = "pnlAvailableRooms";
            this.pnlAvailableRooms.Size = new System.Drawing.Size(500, 276);
            this.pnlAvailableRooms.TabIndex = 2;
            // 
            // dgvAvailableRooms
            // 
            this.dgvAvailableRooms.AllowUserToAddRows = false;
            this.dgvAvailableRooms.AllowUserToDeleteRows = false;
            this.dgvAvailableRooms.AllowUserToResizeColumns = false;
            this.dgvAvailableRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.dgvAvailableRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvailableRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvailableRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailableRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAvailableRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvailableRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvailableRooms.ColumnHeadersHeight = 32;
            this.dgvAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAvailableRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrice,
            this.colCapacity});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvailableRooms.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAvailableRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvailableRooms.EnableHeadersVisualStyles = false;
            this.dgvAvailableRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.dgvAvailableRooms.Location = new System.Drawing.Point(0, 45);
            this.dgvAvailableRooms.MultiSelect = false;
            this.dgvAvailableRooms.Name = "dgvAvailableRooms";
            this.dgvAvailableRooms.ReadOnly = true;
            this.dgvAvailableRooms.RowHeadersVisible = false;
            this.dgvAvailableRooms.RowTemplate.Height = 36;
            this.dgvAvailableRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableRooms.Size = new System.Drawing.Size(498, 229);
            this.dgvAvailableRooms.TabIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "PricePerNight";
            dataGridViewCellStyle3.Format = "฿#,##0";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPrice.HeaderText = "ราคา/คืน";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPrice.Width = 120;
            // 
            // colCapacity
            // 
            this.colCapacity.DataPropertyName = "Capacity";
            dataGridViewCellStyle4.Format = "0 \"คน\"";
            this.colCapacity.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCapacity.HeaderText = "ความจุ";
            this.colCapacity.Name = "colCapacity";
            this.colCapacity.ReadOnly = true;
            this.colCapacity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCapacity.Width = 90;
            // 
            // pnlAvailableHeaderLine
            // 
            this.pnlAvailableHeaderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.pnlAvailableHeaderLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAvailableHeaderLine.Location = new System.Drawing.Point(0, 44);
            this.pnlAvailableHeaderLine.Name = "pnlAvailableHeaderLine";
            this.pnlAvailableHeaderLine.Size = new System.Drawing.Size(498, 1);
            this.pnlAvailableHeaderLine.TabIndex = 1;
            // 
            // lblAvailableHeader
            // 
            this.lblAvailableHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAvailableHeader.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblAvailableHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            this.lblAvailableHeader.Location = new System.Drawing.Point(0, 0);
            this.lblAvailableHeader.Name = "lblAvailableHeader";
            this.lblAvailableHeader.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblAvailableHeader.Size = new System.Drawing.Size(498, 44);
            this.lblAvailableHeader.TabIndex = 0;
            this.lblAvailableHeader.Text = "ห้องว่างตามช่วงวันที่";
            this.lblAvailableHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStay
            // 
            this.pnlStay.BackColor = System.Drawing.Color.White;
            this.pnlStay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStay.Controls.Add(this.btnCheckAvailability);
            this.pnlStay.Controls.Add(this.cboRoomType);
            this.pnlStay.Controls.Add(this.lblRoomType);
            this.pnlStay.Controls.Add(this.dtpCheckOut);
            this.pnlStay.Controls.Add(this.lblCheckOut);
            this.pnlStay.Controls.Add(this.dtpCheckIn);
            this.pnlStay.Controls.Add(this.lblCheckIn);
            this.pnlStay.Controls.Add(this.pnlStayHeaderLine);
            this.pnlStay.Controls.Add(this.lblStayHeader);
            this.pnlStay.Location = new System.Drawing.Point(540, 12);
            this.pnlStay.Name = "pnlStay";
            this.pnlStay.Size = new System.Drawing.Size(500, 204);
            this.pnlStay.TabIndex = 1;
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.BackColor = System.Drawing.Color.White;
            this.btnCheckAvailability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckAvailability.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnCheckAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAvailability.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCheckAvailability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnCheckAvailability.Location = new System.Drawing.Point(322, 153);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(160, 32);
            this.btnCheckAvailability.TabIndex = 3;
            this.btnCheckAvailability.Text = "ตรวจสอบห้องว่าง";
            this.btnCheckAvailability.UseVisualStyleBackColor = false;
            // 
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Items.AddRange(new object[] {
            "ทุกประเภท",
            "Standard",
            "Deluxe"});
            this.cboRoomType.Location = new System.Drawing.Point(16, 153);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(294, 28);
            this.cboRoomType.TabIndex = 2;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblRoomType.Location = new System.Drawing.Point(16, 129);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(68, 19);
            this.lblRoomType.TabIndex = 4;
            this.lblRoomType.Text = "ประเภทห้อง";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.dtpCheckOut.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpCheckOut.CustomFormat = "dd/MM/yyyy";
            this.dtpCheckOut.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(255, 85);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(227, 27);
            this.dtpCheckOut.TabIndex = 1;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblCheckOut.Location = new System.Drawing.Point(255, 61);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(143, 19);
            this.lblCheckOut.TabIndex = 3;
            this.lblCheckOut.Text = "วันที่คืนห้อง (Check-out)";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.dtpCheckIn.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpCheckIn.CustomFormat = "dd/MM/yyyy";
            this.dtpCheckIn.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(16, 85);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(227, 27);
            this.dtpCheckIn.TabIndex = 0;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblCheckIn.Location = new System.Drawing.Point(16, 61);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(132, 19);
            this.lblCheckIn.TabIndex = 2;
            this.lblCheckIn.Text = "วันที่เข้าพัก (Check-in)";
            // 
            // pnlStayHeaderLine
            // 
            this.pnlStayHeaderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.pnlStayHeaderLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStayHeaderLine.Location = new System.Drawing.Point(0, 44);
            this.pnlStayHeaderLine.Name = "pnlStayHeaderLine";
            this.pnlStayHeaderLine.Size = new System.Drawing.Size(498, 1);
            this.pnlStayHeaderLine.TabIndex = 1;
            // 
            // lblStayHeader
            // 
            this.lblStayHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStayHeader.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblStayHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            this.lblStayHeader.Location = new System.Drawing.Point(0, 0);
            this.lblStayHeader.Name = "lblStayHeader";
            this.lblStayHeader.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblStayHeader.Size = new System.Drawing.Size(498, 44);
            this.lblStayHeader.TabIndex = 0;
            this.lblStayHeader.Text = "2. ช่วงเวลาเข้าพัก";
            this.lblStayHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.White;
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.cboStatus);
            this.pnlSummary.Controls.Add(this.lblStatus);
            this.pnlSummary.Controls.Add(this.lblTotalPrice);
            this.pnlSummary.Controls.Add(this.lblTotalCaption);
            this.pnlSummary.Controls.Add(this.pnlSummarySeparator);
            this.pnlSummary.Controls.Add(this.lblNightsValue);
            this.pnlSummary.Controls.Add(this.lblNightsCaption);
            this.pnlSummary.Controls.Add(this.lblPricePerNightValue);
            this.pnlSummary.Controls.Add(this.lblPricePerNightCaption);
            this.pnlSummary.Controls.Add(this.lblSelectedRoomValue);
            this.pnlSummary.Controls.Add(this.lblSelectedRoomCaption);
            this.pnlSummary.Controls.Add(this.pnlSummaryHeaderLine);
            this.pnlSummary.Controls.Add(this.lblSummaryHeader);
            this.pnlSummary.Location = new System.Drawing.Point(540, 236);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(500, 361);
            this.pnlSummary.TabIndex = 3;
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Enabled = false;
            this.cboStatus.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Confirmed",
            "CheckedIn",
            "CheckedOut",
            "Cancelled"});
            this.cboStatus.Location = new System.Drawing.Point(16, 270);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(466, 28);
            this.cboStatus.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblStatus.Location = new System.Drawing.Point(16, 246);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 19);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "สถานะการจอง";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Leelawadee UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(232, 182);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(250, 48);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "฿0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblTotalCaption.Location = new System.Drawing.Point(16, 190);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(200, 40);
            this.lblTotalCaption.TabIndex = 9;
            this.lblTotalCaption.Text = "ราคารวมสุทธิ";
            this.lblTotalCaption.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlSummarySeparator
            // 
            this.pnlSummarySeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.pnlSummarySeparator.Location = new System.Drawing.Point(16, 169);
            this.pnlSummarySeparator.Name = "pnlSummarySeparator";
            this.pnlSummarySeparator.Size = new System.Drawing.Size(466, 1);
            this.pnlSummarySeparator.TabIndex = 8;
            // 
            // lblNightsValue
            // 
            this.lblNightsValue.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblNightsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.lblNightsValue.Location = new System.Drawing.Point(232, 125);
            this.lblNightsValue.Name = "lblNightsValue";
            this.lblNightsValue.Size = new System.Drawing.Size(250, 32);
            this.lblNightsValue.TabIndex = 7;
            this.lblNightsValue.Text = "0 คืน";
            this.lblNightsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNightsCaption
            // 
            this.lblNightsCaption.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblNightsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblNightsCaption.Location = new System.Drawing.Point(16, 125);
            this.lblNightsCaption.Name = "lblNightsCaption";
            this.lblNightsCaption.Size = new System.Drawing.Size(200, 32);
            this.lblNightsCaption.TabIndex = 6;
            this.lblNightsCaption.Text = "จำนวนคืน";
            this.lblNightsCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPricePerNightValue
            // 
            this.lblPricePerNightValue.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPricePerNightValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.lblPricePerNightValue.Location = new System.Drawing.Point(232, 93);
            this.lblPricePerNightValue.Name = "lblPricePerNightValue";
            this.lblPricePerNightValue.Size = new System.Drawing.Size(250, 32);
            this.lblPricePerNightValue.TabIndex = 5;
            this.lblPricePerNightValue.Text = "฿0";
            this.lblPricePerNightValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPricePerNightCaption
            // 
            this.lblPricePerNightCaption.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPricePerNightCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblPricePerNightCaption.Location = new System.Drawing.Point(16, 93);
            this.lblPricePerNightCaption.Name = "lblPricePerNightCaption";
            this.lblPricePerNightCaption.Size = new System.Drawing.Size(200, 32);
            this.lblPricePerNightCaption.TabIndex = 4;
            this.lblPricePerNightCaption.Text = "ราคาต่อคืน";
            this.lblPricePerNightCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectedRoomValue
            // 
            this.lblSelectedRoomValue.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSelectedRoomValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.lblSelectedRoomValue.Location = new System.Drawing.Point(232, 61);
            this.lblSelectedRoomValue.Name = "lblSelectedRoomValue";
            this.lblSelectedRoomValue.Size = new System.Drawing.Size(250, 32);
            this.lblSelectedRoomValue.TabIndex = 3;
            this.lblSelectedRoomValue.Text = "-";
            this.lblSelectedRoomValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSelectedRoomCaption
            // 
            this.lblSelectedRoomCaption.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSelectedRoomCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblSelectedRoomCaption.Location = new System.Drawing.Point(16, 61);
            this.lblSelectedRoomCaption.Name = "lblSelectedRoomCaption";
            this.lblSelectedRoomCaption.Size = new System.Drawing.Size(200, 32);
            this.lblSelectedRoomCaption.TabIndex = 2;
            this.lblSelectedRoomCaption.Text = "ห้องที่เลือก";
            this.lblSelectedRoomCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSummaryHeaderLine
            // 
            this.pnlSummaryHeaderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.pnlSummaryHeaderLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummaryHeaderLine.Location = new System.Drawing.Point(0, 44);
            this.pnlSummaryHeaderLine.Name = "pnlSummaryHeaderLine";
            this.pnlSummaryHeaderLine.Size = new System.Drawing.Size(498, 1);
            this.pnlSummaryHeaderLine.TabIndex = 1;
            // 
            // lblSummaryHeader
            // 
            this.lblSummaryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSummaryHeader.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSummaryHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            this.lblSummaryHeader.Location = new System.Drawing.Point(0, 0);
            this.lblSummaryHeader.Name = "lblSummaryHeader";
            this.lblSummaryHeader.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblSummaryHeader.Size = new System.Drawing.Size(498, 44);
            this.lblSummaryHeader.TabIndex = 0;
            this.lblSummaryHeader.Text = "3. สรุปการจอง";
            this.lblSummaryHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(540, 620);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(348, 44);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "บันทึกการจอง";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnClear.Location = new System.Drawing.Point(894, 619);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 44);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "ล้างฟอร์ม";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // ucBooking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1044, 657);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlStay);
            this.Controls.Add(this.pnlAvailableRooms);
            this.Controls.Add(this.pnlCustomer);
            this.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.Name = "ucBooking";
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlAvailableRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableRooms)).EndInit();
            this.pnlStay.ResumeLayout(false);
            this.pnlStay.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustomerHeader;
        private System.Windows.Forms.Panel pnlCustomerHeaderLine;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Panel pnlCustomerSeparator;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblIdCard;
        private System.Windows.Forms.TextBox txtIdCard;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlAvailableRooms;
        private System.Windows.Forms.Label lblAvailableHeader;
        private System.Windows.Forms.Panel pnlAvailableHeaderLine;
        private System.Windows.Forms.DataGridView dgvAvailableRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacity;
        private System.Windows.Forms.Panel pnlStay;
        private System.Windows.Forms.Label lblStayHeader;
        private System.Windows.Forms.Panel pnlStayHeaderLine;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSummaryHeader;
        private System.Windows.Forms.Panel pnlSummaryHeaderLine;
        private System.Windows.Forms.Label lblSelectedRoomCaption;
        private System.Windows.Forms.Label lblSelectedRoomValue;
        private System.Windows.Forms.Label lblPricePerNightCaption;
        private System.Windows.Forms.Label lblPricePerNightValue;
        private System.Windows.Forms.Label lblNightsCaption;
        private System.Windows.Forms.Label lblNightsValue;
        private System.Windows.Forms.Panel pnlSummarySeparator;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}