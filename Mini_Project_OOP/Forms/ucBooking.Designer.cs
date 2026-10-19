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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblPricePerNight = new System.Windows.Forms.Label();
            this.lblSelectedRoom = new System.Windows.Forms.Label();
            this.lblStatusCap = new System.Windows.Forms.Label();
            this.lblTotalCap = new System.Windows.Forms.Label();
            this.lblNightsCap = new System.Windows.Forms.Label();
            this.lblPriceCap = new System.Windows.Forms.Label();
            this.lblRoomCap = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCheckAvail = new System.Windows.Forms.Button();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDatesTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAvailTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.tlpRight.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlLeft, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1044, 596);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.tlpRight);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(531, 3);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(510, 590);
            this.pnlRight.TabIndex = 1;
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Controls.Add(this.pnlSummary, 0, 1);
            this.tlpRight.Controls.Add(this.panel3, 0, 0);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(0, 0);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 2;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Size = new System.Drawing.Size(510, 590);
            this.tlpRight.TabIndex = 0;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.White;
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.tlpButtons);
            this.pnlSummary.Controls.Add(this.cboStatus);
            this.pnlSummary.Controls.Add(this.lblTotal);
            this.pnlSummary.Controls.Add(this.panel7);
            this.pnlSummary.Controls.Add(this.lblNights);
            this.pnlSummary.Controls.Add(this.lblPricePerNight);
            this.pnlSummary.Controls.Add(this.lblSelectedRoom);
            this.pnlSummary.Controls.Add(this.lblStatusCap);
            this.pnlSummary.Controls.Add(this.lblTotalCap);
            this.pnlSummary.Controls.Add(this.lblNightsCap);
            this.pnlSummary.Controls.Add(this.lblPriceCap);
            this.pnlSummary.Controls.Add(this.lblRoomCap);
            this.pnlSummary.Controls.Add(this.panel4);
            this.pnlSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSummary.Location = new System.Drawing.Point(0, 190);
            this.pnlSummary.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(510, 400);
            this.pnlSummary.TabIndex = 1;
            this.pnlSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSummary_Paint);
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpButtons.Controls.Add(this.btnSave, 0, 0);
            this.tlpButtons.Controls.Add(this.btnClear, 1, 0);
            this.tlpButtons.Location = new System.Drawing.Point(19, 347);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(462, 43);
            this.tlpButtons.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(6, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(311, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึกการจอง";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            this.btnClear.Location = new System.Drawing.Point(329, 6);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 31);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "ล้างฟอร์ม";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Confirmed",
            "CheckedIn",
            "Cancelled"});
            this.cboStatus.Location = new System.Drawing.Point(16, 244);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(463, 26);
            this.cboStatus.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.lblTotal.Location = new System.Drawing.Point(264, 170);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(220, 50);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "ราคารวมสุทธิ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.panel7.Location = new System.Drawing.Point(22, 161);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(465, 1);
            this.panel7.TabIndex = 16;
            // 
            // lblNights
            // 
            this.lblNights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNights.AutoSize = true;
            this.lblNights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblNights.Location = new System.Drawing.Point(386, 126);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(77, 14);
            this.lblNights.TabIndex = 15;
            this.lblNights.Text = "สถานะการจอง";
            this.lblNights.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPricePerNight
            // 
            this.lblPricePerNight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPricePerNight.AutoSize = true;
            this.lblPricePerNight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblPricePerNight.Location = new System.Drawing.Point(386, 94);
            this.lblPricePerNight.Name = "lblPricePerNight";
            this.lblPricePerNight.Size = new System.Drawing.Size(77, 14);
            this.lblPricePerNight.TabIndex = 14;
            this.lblPricePerNight.Text = "สถานะการจอง";
            this.lblPricePerNight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSelectedRoom
            // 
            this.lblSelectedRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedRoom.AutoSize = true;
            this.lblSelectedRoom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSelectedRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblSelectedRoom.Location = new System.Drawing.Point(363, 62);
            this.lblSelectedRoom.Name = "lblSelectedRoom";
            this.lblSelectedRoom.Size = new System.Drawing.Size(100, 14);
            this.lblSelectedRoom.TabIndex = 13;
            this.lblSelectedRoom.Text = "102 · Standard";
            this.lblSelectedRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusCap
            // 
            this.lblStatusCap.AutoSize = true;
            this.lblStatusCap.Location = new System.Drawing.Point(16, 226);
            this.lblStatusCap.Name = "lblStatusCap";
            this.lblStatusCap.Size = new System.Drawing.Size(77, 14);
            this.lblStatusCap.TabIndex = 12;
            this.lblStatusCap.Text = "สถานะการจอง";
            // 
            // lblTotalCap
            // 
            this.lblTotalCap.AutoSize = true;
            this.lblTotalCap.Location = new System.Drawing.Point(16, 192);
            this.lblTotalCap.Name = "lblTotalCap";
            this.lblTotalCap.Size = new System.Drawing.Size(71, 14);
            this.lblTotalCap.TabIndex = 11;
            this.lblTotalCap.Text = "ราคารวมสุทธิ";
            // 
            // lblNightsCap
            // 
            this.lblNightsCap.AutoSize = true;
            this.lblNightsCap.Location = new System.Drawing.Point(16, 126);
            this.lblNightsCap.Name = "lblNightsCap";
            this.lblNightsCap.Size = new System.Drawing.Size(54, 14);
            this.lblNightsCap.TabIndex = 10;
            this.lblNightsCap.Text = "\tจำนวนคืน";
            // 
            // lblPriceCap
            // 
            this.lblPriceCap.AutoSize = true;
            this.lblPriceCap.Location = new System.Drawing.Point(16, 94);
            this.lblPriceCap.Name = "lblPriceCap";
            this.lblPriceCap.Size = new System.Drawing.Size(59, 14);
            this.lblPriceCap.TabIndex = 9;
            this.lblPriceCap.Text = "\tราคาต่อคืน";
            // 
            // lblRoomCap
            // 
            this.lblRoomCap.AutoSize = true;
            this.lblRoomCap.Location = new System.Drawing.Point(16, 62);
            this.lblRoomCap.Name = "lblRoomCap";
            this.lblRoomCap.Size = new System.Drawing.Size(62, 14);
            this.lblRoomCap.TabIndex = 8;
            this.lblRoomCap.Text = "ห้องที่เลือก";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.panel4.Location = new System.Drawing.Point(19, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 1);
            this.panel4.TabIndex = 7;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblSummaryTitle.Size = new System.Drawing.Size(508, 40);
            this.lblSummaryTitle.TabIndex = 1;
            this.lblSummaryTitle.Text = "3. สรุปการจอง";
            this.lblSummaryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCheckAvail);
            this.panel3.Controls.Add(this.cboRoomType);
            this.panel3.Controls.Add(this.dtpCheckOut);
            this.panel3.Controls.Add(this.dtpCheckIn);
            this.panel3.Controls.Add(this.lblRoomType);
            this.panel3.Controls.Add(this.lblCheckOut);
            this.panel3.Controls.Add(this.lblCheckIn);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.lblDatesTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 182);
            this.panel3.TabIndex = 0;
            // 
            // btnCheckAvail
            // 
            this.btnCheckAvail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckAvail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckAvail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnCheckAvail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAvail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCheckAvail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnCheckAvail.Location = new System.Drawing.Point(319, 136);
            this.btnCheckAvail.Name = "btnCheckAvail";
            this.btnCheckAvail.Size = new System.Drawing.Size(160, 28);
            this.btnCheckAvail.TabIndex = 15;
            this.btnCheckAvail.Text = "ตรวจสอบห้องว่าง";
            this.btnCheckAvail.UseVisualStyleBackColor = true;
            // 
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRoomType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Items.AddRange(new object[] {
            "ทุกประเภท",
            "Standard",
            "Deluxe"});
            this.cboRoomType.Location = new System.Drawing.Point(19, 134);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(290, 26);
            this.cboRoomType.TabIndex = 14;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCheckOut.CustomFormat = "dd/MM/yyyy";
            this.dtpCheckOut.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(256, 70);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(225, 26);
            this.dtpCheckOut.TabIndex = 13;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CustomFormat = "dd/MM/yyyy";
            this.dtpCheckIn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(16, 70);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(225, 26);
            this.dtpCheckIn.TabIndex = 0;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(16, 111);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(66, 14);
            this.lblRoomType.TabIndex = 9;
            this.lblRoomType.Text = "ประเภทห้อง";
            this.lblRoomType.Click += new System.EventHandler(this.lblRoomType_Click);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(256, 52);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(134, 14);
            this.lblCheckOut.TabIndex = 8;
            this.lblCheckOut.Text = "วันที่คืนห้อง (Check-out)";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(16, 52);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(120, 14);
            this.lblCheckIn.TabIndex = 7;
            this.lblCheckIn.Text = "\tวันที่เข้าพัก (Check-in)";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.panel6.Location = new System.Drawing.Point(35, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(465, 1);
            this.panel6.TabIndex = 6;
            // 
            // lblDatesTitle
            // 
            this.lblDatesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDatesTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDatesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            this.lblDatesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDatesTitle.Name = "lblDatesTitle";
            this.lblDatesTitle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblDatesTitle.Size = new System.Drawing.Size(508, 40);
            this.lblDatesTitle.TabIndex = 0;
            this.lblDatesTitle.Text = "2. ช่วงเวลาเข้าพัก";
            this.lblDatesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.tableLayoutPanel2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(15, 3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(510, 590);
            this.pnlLeft.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pnlCustomer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(510, 590);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.White;
            this.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomer.Controls.Add(this.panel5);
            this.pnlCustomer.Controls.Add(this.txtEmail);
            this.pnlCustomer.Controls.Add(this.label5);
            this.pnlCustomer.Controls.Add(this.txtIdCard);
            this.pnlCustomer.Controls.Add(this.label4);
            this.pnlCustomer.Controls.Add(this.txtPhone);
            this.pnlCustomer.Controls.Add(this.label3);
            this.pnlCustomer.Controls.Add(this.txtName);
            this.pnlCustomer.Controls.Add(this.label2);
            this.pnlCustomer.Controls.Add(this.panel1);
            this.pnlCustomer.Controls.Add(this.txtSearch);
            this.pnlCustomer.Controls.Add(this.btnSearch);
            this.pnlCustomer.Controls.Add(this.label1);
            this.pnlCustomer.Controls.Add(this.lblCustomerTitle);
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(510, 357);
            this.pnlCustomer.TabIndex = 0;
            this.pnlCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCustomer_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.panel5.Location = new System.Drawing.Point(17, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(465, 1);
            this.panel5.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtEmail.Location = new System.Drawing.Point(30, 302);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(452, 23);
            this.txtEmail.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "อีเมล";
            // 
            // txtIdCard
            // 
            this.txtIdCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCard.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtIdCard.Location = new System.Drawing.Point(258, 234);
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(224, 23);
            this.txtIdCard.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "เลขบัตรประชาชน / พาสปอร์ต";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPhone.Location = new System.Drawing.Point(30, 234);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(213, 23);
            this.txtPhone.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "เบอร์โทรศัพท์";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtName.Location = new System.Drawing.Point(30, 167);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(452, 23);
            this.txtName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "ชื่อ-นามสกุล";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.panel1.Location = new System.Drawing.Point(17, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 1);
            this.panel1.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSearch.Location = new System.Drawing.Point(30, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(360, 23);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnSearch.Location = new System.Drawing.Point(396, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 22);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "ค้นหาลูกค้าเดิม (เบอร์โทร / เลขบัตร)";
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCustomerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            this.lblCustomerTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblCustomerTitle.Size = new System.Drawing.Size(508, 40);
            this.lblCustomerTitle.TabIndex = 0;
            this.lblCustomerTitle.Text = "1. ข้อมูลลูกค้า";
            this.lblCustomerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvAvailable);
            this.panel2.Controls.Add(this.lblAvailTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 217);
            this.panel2.TabIndex = 1;
            // 
            // dgvAvailable
            // 
            this.dgvAvailable.AllowUserToAddRows = false;
            this.dgvAvailable.AllowUserToDeleteRows = false;
            this.dgvAvailable.AllowUserToResizeColumns = false;
            this.dgvAvailable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.dgvAvailable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvailable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailable.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvailable.ColumnHeadersHeight = 34;
            this.dgvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoom,
            this.colType,
            this.colPrice,
            this.colCapacity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvailable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvailable.EnableHeadersVisualStyles = false;
            this.dgvAvailable.Location = new System.Drawing.Point(0, 40);
            this.dgvAvailable.MultiSelect = false;
            this.dgvAvailable.Name = "dgvAvailable";
            this.dgvAvailable.ReadOnly = true;
            this.dgvAvailable.RowHeadersVisible = false;
            this.dgvAvailable.RowTemplate.Height = 36;
            this.dgvAvailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailable.Size = new System.Drawing.Size(508, 175);
            this.dgvAvailable.TabIndex = 2;
            // 
            // colRoom
            // 
            this.colRoom.HeaderText = "ห้อง";
            this.colRoom.Name = "colRoom";
            this.colRoom.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "ประเภท";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "ราคา/คืน";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colCapacity
            // 
            this.colCapacity.HeaderText = "ความจุ";
            this.colCapacity.Name = "colCapacity";
            this.colCapacity.ReadOnly = true;
            // 
            // lblAvailTitle
            // 
            this.lblAvailTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAvailTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblAvailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            this.lblAvailTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAvailTitle.Name = "lblAvailTitle";
            this.lblAvailTitle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblAvailTitle.Size = new System.Drawing.Size(508, 40);
            this.lblAvailTitle.TabIndex = 0;
            this.lblAvailTitle.Text = "ห้องว่างตามช่วงวันที่";
            this.lblAvailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1044, 596);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.Name = "ucBooking";
            this.Text = "ucBooking";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.tlpRight.ResumeLayout(false);
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAvailTitle;
        private System.Windows.Forms.DataGridView dgvAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCapacity;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDatesTitle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Button btnCheckAvail;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblPricePerNight;
        private System.Windows.Forms.Label lblSelectedRoom;
        private System.Windows.Forms.Label lblStatusCap;
        private System.Windows.Forms.Label lblTotalCap;
        private System.Windows.Forms.Label lblNightsCap;
        private System.Windows.Forms.Label lblPriceCap;
        private System.Windows.Forms.Label lblRoomCap;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.Label label1;

    }
}