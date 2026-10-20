namespace Mini_Project_OOP.Forms
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlNavActive = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlLogoLine = new System.Windows.Forms.Panel();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNavBooking = new System.Windows.Forms.Button();
            this.btnNavRooms = new System.Windows.Forms.Button();
            this.btnNavCustomers = new System.Windows.Forms.Button();
            this.btnNavBookingList = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pnlUserLine = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.pnlHost = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlUser.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.pnlSidebar.Controls.Add(this.pnlNavActive);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.btnNavBooking);
            this.pnlSidebar.Controls.Add(this.btnNavRooms);
            this.pnlSidebar.Controls.Add(this.btnNavCustomers);
            this.pnlSidebar.Controls.Add(this.btnNavBookingList);
            this.pnlSidebar.Controls.Add(this.pnlUser);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 760);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlNavActive
            // 
            this.pnlNavActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
            this.pnlNavActive.Location = new System.Drawing.Point(0, 76);
            this.pnlNavActive.Name = "pnlNavActive";
            this.pnlNavActive.Size = new System.Drawing.Size(4, 48);
            this.pnlNavActive.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Controls.Add(this.lblBrand);
            this.pnlLogo.Controls.Add(this.pnlLogoLine);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 64);
            this.pnlLogo.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Mini_Project_OOP.Properties.Resources.App_Icon;
            this.picLogo.Location = new System.Drawing.Point(20, 19);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(26, 26);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBrand.Location = new System.Drawing.Point(56, 20);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(120, 21);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Hotel Booking";
            // 
            // pnlLogoLine
            // 
            this.pnlLogoLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogoLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(106)))), ((int)(((byte)(101)))));
            this.pnlLogoLine.Location = new System.Drawing.Point(0, 63);
            this.pnlLogoLine.Name = "pnlLogoLine";
            this.pnlLogoLine.Size = new System.Drawing.Size(220, 1);
            this.pnlLogoLine.TabIndex = 2;
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(106)))), ((int)(((byte)(101)))));
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.ImageKey = "Dashboard_Icon.png";
            this.btnNavDashboard.ImageList = this.imageList1;
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 76);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavDashboard.Size = new System.Drawing.Size(220, 48);
            this.btnNavDashboard.TabIndex = 6;
            this.btnNavDashboard.Text = " Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Booking_Icon.png");
            this.imageList1.Images.SetKeyName(1, "Customer_Icon.png");
            this.imageList1.Images.SetKeyName(2, "Dashboard_Icon.png");
            this.imageList1.Images.SetKeyName(3, "Order_Icon.png");
            this.imageList1.Images.SetKeyName(4, "Room_Icon.png");
            // 
            // btnNavBooking
            // 
            this.btnNavBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.btnNavBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBooking.FlatAppearance.BorderSize = 0;
            this.btnNavBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBooking.Font = new System.Drawing.Font("Prompt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnNavBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.btnNavBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBooking.ImageKey = "Booking_Icon.png";
            this.btnNavBooking.ImageList = this.imageList1;
            this.btnNavBooking.Location = new System.Drawing.Point(0, 124);
            this.btnNavBooking.Name = "btnNavBooking";
            this.btnNavBooking.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavBooking.Size = new System.Drawing.Size(220, 48);
            this.btnNavBooking.TabIndex = 7;
            this.btnNavBooking.Text = " จองห้องพัก";
            this.btnNavBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavBooking.UseVisualStyleBackColor = false;
            // 
            // btnNavRooms
            // 
            this.btnNavRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.btnNavRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavRooms.FlatAppearance.BorderSize = 0;
            this.btnNavRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRooms.Font = new System.Drawing.Font("Prompt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnNavRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.btnNavRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRooms.ImageKey = "Room_Icon.png";
            this.btnNavRooms.ImageList = this.imageList1;
            this.btnNavRooms.Location = new System.Drawing.Point(0, 172);
            this.btnNavRooms.Name = "btnNavRooms";
            this.btnNavRooms.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavRooms.Size = new System.Drawing.Size(220, 48);
            this.btnNavRooms.TabIndex = 8;
            this.btnNavRooms.Text = " ห้องพัก / ประเภท";
            this.btnNavRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavRooms.UseVisualStyleBackColor = false;
            // 
            // btnNavCustomers
            // 
            this.btnNavCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.btnNavCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCustomers.FlatAppearance.BorderSize = 0;
            this.btnNavCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCustomers.Font = new System.Drawing.Font("Prompt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnNavCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.btnNavCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCustomers.ImageKey = "Customer_Icon.png";
            this.btnNavCustomers.ImageList = this.imageList1;
            this.btnNavCustomers.Location = new System.Drawing.Point(0, 220);
            this.btnNavCustomers.Name = "btnNavCustomers";
            this.btnNavCustomers.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavCustomers.Size = new System.Drawing.Size(220, 48);
            this.btnNavCustomers.TabIndex = 9;
            this.btnNavCustomers.Text = " ลูกค้า";
            this.btnNavCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavCustomers.UseVisualStyleBackColor = false;
            // 
            // btnNavBookingList
            // 
            this.btnNavBookingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.btnNavBookingList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBookingList.FlatAppearance.BorderSize = 0;
            this.btnNavBookingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBookingList.Font = new System.Drawing.Font("Prompt", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnNavBookingList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            this.btnNavBookingList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBookingList.ImageKey = "Order_Icon.png";
            this.btnNavBookingList.ImageList = this.imageList1;
            this.btnNavBookingList.Location = new System.Drawing.Point(0, 268);
            this.btnNavBookingList.Name = "btnNavBookingList";
            this.btnNavBookingList.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnNavBookingList.Size = new System.Drawing.Size(220, 48);
            this.btnNavBookingList.TabIndex = 10;
            this.btnNavBookingList.Text = " รายการจอง";
            this.btnNavBookingList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBookingList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNavBookingList.UseVisualStyleBackColor = false;
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.pnlUser.Controls.Add(this.pnlUserLine);
            this.pnlUser.Controls.Add(this.lblUserName);
            this.pnlUser.Controls.Add(this.lblUserRole);
            this.pnlUser.Controls.Add(this.btnLogout);
            this.pnlUser.Location = new System.Drawing.Point(0, 642);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(220, 118);
            this.pnlUser.TabIndex = 11;
            // 
            // pnlUserLine
            // 
            this.pnlUserLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(106)))), ((int)(((byte)(101)))));
            this.pnlUserLine.Location = new System.Drawing.Point(0, 0);
            this.pnlUserLine.Name = "pnlUserLine";
            this.pnlUserLine.Size = new System.Drawing.Size(220, 1);
            this.pnlUserLine.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Prompt", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUserName.Location = new System.Drawing.Point(20, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 22);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "สมศรี ใจงาม";
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(228)))), ((int)(((byte)(223)))));
            this.lblUserRole.Location = new System.Drawing.Point(20, 38);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(72, 15);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "Receptionist";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(70)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Prompt", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.Location = new System.Drawing.Point(20, 66);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 36);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "ออกจากระบบ";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.pnlHeaderLine);
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1060, 64);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Leelawadee UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.lblPageTitle.Location = new System.Drawing.Point(20, 18);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(126, 30);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Dashboard";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblDate.Location = new System.Drawing.Point(740, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(300, 24);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "วันที่ 16/10/2026";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlHeaderLine
            // 
            this.pnlHeaderLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.pnlHeaderLine.Location = new System.Drawing.Point(0, 63);
            this.pnlHeaderLine.Name = "pnlHeaderLine";
            this.pnlHeaderLine.Size = new System.Drawing.Size(1060, 1);
            this.pnlHeaderLine.TabIndex = 2;
            // 
            // pnlHost
            // 
            this.pnlHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.pnlHost.Location = new System.Drawing.Point(220, 64);
            this.pnlHost.Name = "pnlHost";
            this.pnlHost.Size = new System.Drawing.Size(1060, 696);
            this.pnlHost.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlHost);
            this.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Booking";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlNavActive;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel pnlLogoLine;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavBooking;
        private System.Windows.Forms.Button btnNavRooms;
        private System.Windows.Forms.Button btnNavCustomers;
        private System.Windows.Forms.Button btnNavBookingList;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlUserLine;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlHost;
        private System.Windows.Forms.ImageList imageList1;
    }
}