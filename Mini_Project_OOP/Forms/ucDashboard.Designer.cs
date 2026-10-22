namespace Mini_Project_OOP.Forms
{
    partial class ucDashboard
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLegend = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.lblBookingTitle = new System.Windows.Forms.Label();
            this.lblRoomTitle = new System.Windows.Forms.Label();
            this.pnlBookings = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.pnlStripe4 = new System.Windows.Forms.Panel();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblOccupied = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.pnlStripe3 = new System.Windows.Forms.Panel();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pnlStripe2 = new System.Windows.Forms.Panel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.pnlStripe1 = new System.Windows.Forms.Panel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRooms = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLegend.SuspendLayout();
            this.pnlBookings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.pnlRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 2, 14, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ซ่อมบำรุง";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCustomer,
            this.colRoom,
            this.colCheckIn,
            this.colCheckOut,
            this.colStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(244)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 36;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(608, 479);
            this.dataGridView1.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.FillWeight = 60F;
            this.colId.HeaderText = "รหัส";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colCustomer
            // 
            this.colCustomer.FillWeight = 130F;
            this.colCustomer.HeaderText = "ลูกค้า";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            // 
            // colRoom
            // 
            this.colRoom.FillWeight = 60F;
            this.colRoom.HeaderText = "ห้อง";
            this.colRoom.Name = "colRoom";
            this.colRoom.ReadOnly = true;
            // 
            // colCheckIn
            // 
            this.colCheckIn.HeaderText = "เช็คอิน";
            this.colCheckIn.Name = "colCheckIn";
            this.colCheckIn.ReadOnly = true;
            // 
            // colCheckOut
            // 
            this.colCheckOut.HeaderText = "เช็คเอาท์";
            this.colCheckOut.Name = "colCheckOut";
            this.colCheckOut.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "สถานะ";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // flowRooms
            // 
            this.flowRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowRooms.Location = new System.Drawing.Point(0, 45);
            this.flowRooms.Name = "flowRooms";
            this.flowRooms.Padding = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.flowRooms.Size = new System.Drawing.Size(265, 301);
            this.flowRooms.TabIndex = 3;
            // 
            // flowLegend
            // 
            this.flowLegend.Controls.Add(this.panel1);
            this.flowLegend.Controls.Add(this.label1);
            this.flowLegend.Controls.Add(this.panel2);
            this.flowLegend.Controls.Add(this.label2);
            this.flowLegend.Controls.Add(this.panel3);
            this.flowLegend.Controls.Add(this.label3);
            this.flowLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLegend.Location = new System.Drawing.Point(0, 346);
            this.flowLegend.Name = "flowLegend";
            this.flowLegend.Padding = new System.Windows.Forms.Padding(16, 4, 0, 0);
            this.flowLegend.Size = new System.Drawing.Size(265, 28);
            this.flowLegend.TabIndex = 2;
            this.flowLegend.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(16, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 14);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 2, 14, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ว่าง";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(71, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 14);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 2, 14, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "\tมีผู้เข้าพัก";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(156, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 14);
            this.panel3.TabIndex = 4;
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnNewBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewBooking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNewBooking.FlatAppearance.BorderSize = 0;
            this.btnNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnNewBooking.ForeColor = System.Drawing.Color.White;
            this.btnNewBooking.Location = new System.Drawing.Point(0, 374);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(265, 40);
            this.btnNewBooking.TabIndex = 1;
            this.btnNewBooking.Text = "+ จองห้องใหม่";
            this.btnNewBooking.UseVisualStyleBackColor = false;
            // 
            // lblBookingTitle
            // 
            this.lblBookingTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBookingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(222)));
            this.lblBookingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            this.lblBookingTitle.Location = new System.Drawing.Point(0, 0);
            this.lblBookingTitle.Name = "lblBookingTitle";
            this.lblBookingTitle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblBookingTitle.Size = new System.Drawing.Size(442, 45);
            this.lblBookingTitle.TabIndex = 0;
            this.lblBookingTitle.Text = "การจองล่าสุด";
            this.lblBookingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomTitle
            // 
            this.lblRoomTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRoomTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblRoomTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(92)))), ((int)(((byte)(87)))));
            this.lblRoomTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRoomTitle.Name = "lblRoomTitle";
            this.lblRoomTitle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblRoomTitle.Size = new System.Drawing.Size(265, 45);
            this.lblRoomTitle.TabIndex = 0;
            this.lblRoomTitle.Text = "สถานะห้องพัก";
            this.lblRoomTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBookings
            // 
            this.pnlBookings.BackColor = System.Drawing.Color.White;
            this.pnlBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBookings.Controls.Add(this.dataGridView1);
            this.pnlBookings.Controls.Add(this.lblBookingTitle);
            this.pnlBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookings.Location = new System.Drawing.Point(16, 8);
            this.pnlBookings.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlBookings.Name = "pnlBookings";
            this.pnlBookings.Size = new System.Drawing.Size(444, 416);
            this.pnlBookings.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pnlCard4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlCard3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlCard2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlCard1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(779, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.White;
            this.pnlCard4.Controls.Add(this.lblMaintenance);
            this.pnlCard4.Controls.Add(this.lblTitle4);
            this.pnlCard4.Controls.Add(this.pnlStripe4);
            this.pnlCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard4.Location = new System.Drawing.Point(590, 8);
            this.pnlCard4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(181, 84);
            this.pnlCard4.TabIndex = 3;
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(222)));
            this.lblMaintenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(64)))), ((int)(((byte)(14)))));
            this.lblMaintenance.Location = new System.Drawing.Point(20, 40);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(57, 39);
            this.lblMaintenance.TabIndex = 2;
            this.lblMaintenance.Text = "00";
            // 
            // lblTitle4
            // 
            this.lblTitle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTitle4.Location = new System.Drawing.Point(20, 15);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(154, 19);
            this.lblTitle4.TabIndex = 1;
            this.lblTitle4.Text = "\tซ่อมบำรุง (Maintenance)";
            // 
            // pnlStripe4
            // 
            this.pnlStripe4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.pnlStripe4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStripe4.Location = new System.Drawing.Point(0, 0);
            this.pnlStripe4.Name = "pnlStripe4";
            this.pnlStripe4.Size = new System.Drawing.Size(5, 84);
            this.pnlStripe4.TabIndex = 0;
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.Controls.Add(this.lblOccupied);
            this.pnlCard3.Controls.Add(this.lblTitle3);
            this.pnlCard3.Controls.Add(this.pnlStripe3);
            this.pnlCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard3.Location = new System.Drawing.Point(396, 8);
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(178, 84);
            this.pnlCard3.TabIndex = 2;
            // 
            // lblOccupied
            // 
            this.lblOccupied.AutoSize = true;
            this.lblOccupied.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(222)));
            this.lblOccupied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblOccupied.Location = new System.Drawing.Point(20, 40);
            this.lblOccupied.Name = "lblOccupied";
            this.lblOccupied.Size = new System.Drawing.Size(57, 39);
            this.lblOccupied.TabIndex = 2;
            this.lblOccupied.Text = "00";
            // 
            // lblTitle3
            // 
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTitle3.Location = new System.Drawing.Point(20, 15);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(135, 19);
            this.lblTitle3.TabIndex = 1;
            this.lblTitle3.Text = "\tมีผู้เข้าพัก (Occupied)";
            // 
            // pnlStripe3
            // 
            this.pnlStripe3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlStripe3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStripe3.Location = new System.Drawing.Point(0, 0);
            this.pnlStripe3.Name = "pnlStripe3";
            this.pnlStripe3.Size = new System.Drawing.Size(5, 84);
            this.pnlStripe3.TabIndex = 0;
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.Controls.Add(this.lblAvailable);
            this.pnlCard2.Controls.Add(this.lblTitle2);
            this.pnlCard2.Controls.Add(this.pnlStripe2);
            this.pnlCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard2.Location = new System.Drawing.Point(202, 8);
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(178, 84);
            this.pnlCard2.TabIndex = 1;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(222)));
            this.lblAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblAvailable.Location = new System.Drawing.Point(20, 40);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(57, 39);
            this.lblAvailable.TabIndex = 2;
            this.lblAvailable.Text = "00";
            // 
            // lblTitle2
            // 
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(20, 15);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(98, 19);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "ว่าง (Available)";
            // 
            // pnlStripe2
            // 
            this.pnlStripe2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.pnlStripe2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStripe2.Location = new System.Drawing.Point(0, 0);
            this.pnlStripe2.Name = "pnlStripe2";
            this.pnlStripe2.Size = new System.Drawing.Size(5, 84);
            this.pnlStripe2.TabIndex = 0;
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.Controls.Add(this.lblTotal);
            this.pnlCard1.Controls.Add(this.lblTitle1);
            this.pnlCard1.Controls.Add(this.pnlStripe1);
            this.pnlCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard1.Location = new System.Drawing.Point(8, 8);
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(178, 84);
            this.pnlCard1.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(222)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTotal.Location = new System.Drawing.Point(20, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 39);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "00";
            // 
            // lblTitle1
            // 
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(20, 15);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(74, 19);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "ห้องทั้งหมด";
            // 
            // pnlStripe1
            // 
            this.pnlStripe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.pnlStripe1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStripe1.Location = new System.Drawing.Point(0, 0);
            this.pnlStripe1.Name = "pnlStripe1";
            this.pnlStripe1.Size = new System.Drawing.Size(5, 84);
            this.pnlStripe1.TabIndex = 0;
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tlpMain.Controls.Add(this.pnlBookings, 0, 0);
            this.tlpMain.Controls.Add(this.pnlRooms, 1, 0);
            this.tlpMain.Location = new System.Drawing.Point(12, 120);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(759, 440);
            this.tlpMain.TabIndex = 3;
            // 
            // pnlRooms
            // 
            this.pnlRooms.BackColor = System.Drawing.Color.White;
            this.pnlRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRooms.Controls.Add(this.flowRooms);
            this.pnlRooms.Controls.Add(this.flowLegend);
            this.pnlRooms.Controls.Add(this.btnNewBooking);
            this.pnlRooms.Controls.Add(this.lblRoomTitle);
            this.pnlRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRooms.Location = new System.Drawing.Point(476, 8);
            this.pnlRooms.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(267, 416);
            this.pnlRooms.TabIndex = 1;
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ucDashboard";
            this.Text = "ucDashboard";
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLegend.ResumeLayout(false);
            this.flowLegend.PerformLayout();
            this.pnlBookings.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard4.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.pnlRooms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.FlowLayoutPanel flowRooms;
        private System.Windows.Forms.FlowLayoutPanel flowLegend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Label lblBookingTitle;
        private System.Windows.Forms.Label lblRoomTitle;
        private System.Windows.Forms.Panel pnlBookings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.Panel pnlStripe4;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblOccupied;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Panel pnlStripe3;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Panel pnlStripe2;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Panel pnlStripe1;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlRooms;
    }
}