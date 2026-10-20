namespace Mini_Project_OOP.Forms
{
    partial class ucRooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRoomTypes = new System.Windows.Forms.Panel();
            this.pnlRoomTypesHeader = new System.Windows.Forms.Panel();
            this.lblRoomTypesTitle = new System.Windows.Forms.Label();
            this.pnlRoomTypesHeaderLine = new System.Windows.Forms.Panel();
            this.dgvRoomTypes = new System.Windows.Forms.DataGridView();
            this.colTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.lblTypePrice = new System.Windows.Forms.Label();
            this.txtTypePrice = new System.Windows.Forms.TextBox();
            this.lblTypeCapacity = new System.Windows.Forms.Label();
            this.txtTypeCapacity = new System.Windows.Forms.TextBox();
            this.lblTypeDesc = new System.Windows.Forms.Label();
            this.txtTypeDesc = new System.Windows.Forms.TextBox();
            this.btnTypeAdd = new System.Windows.Forms.Button();
            this.btnTypeEdit = new System.Windows.Forms.Button();
            this.btnTypeDelete = new System.Windows.Forms.Button();
            this.pnlRoomList = new System.Windows.Forms.Panel();
            this.pnlRoomListHeader = new System.Windows.Forms.Panel();
            this.lblRoomListTitle = new System.Windows.Forms.Label();
            this.pnlRoomListHeaderLine = new System.Windows.Forms.Panel();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomStatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.cboRoomStatus = new System.Windows.Forms.ComboBox();
            this.lblRoomTypeId = new System.Windows.Forms.Label();
            this.cboRoomTypeId = new System.Windows.Forms.ComboBox();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.btnRoomEdit = new System.Windows.Forms.Button();
            this.btnRoomDelete = new System.Windows.Forms.Button();
            this.pnlRoomTypes.SuspendLayout();
            this.pnlRoomTypesHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypes)).BeginInit();
            this.pnlRoomList.SuspendLayout();
            this.pnlRoomListHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRoomTypes
            // 
            this.pnlRoomTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlRoomTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlRoomTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoomTypes.Controls.Add(this.pnlRoomTypesHeader);
            this.pnlRoomTypes.Controls.Add(this.dgvRoomTypes);
            this.pnlRoomTypes.Controls.Add(this.lblTypeName);
            this.pnlRoomTypes.Controls.Add(this.txtTypeName);
            this.pnlRoomTypes.Controls.Add(this.lblTypePrice);
            this.pnlRoomTypes.Controls.Add(this.txtTypePrice);
            this.pnlRoomTypes.Controls.Add(this.lblTypeCapacity);
            this.pnlRoomTypes.Controls.Add(this.txtTypeCapacity);
            this.pnlRoomTypes.Controls.Add(this.lblTypeDesc);
            this.pnlRoomTypes.Controls.Add(this.txtTypeDesc);
            this.pnlRoomTypes.Controls.Add(this.btnTypeAdd);
            this.pnlRoomTypes.Controls.Add(this.btnTypeEdit);
            this.pnlRoomTypes.Controls.Add(this.btnTypeDelete);
            this.pnlRoomTypes.Location = new System.Drawing.Point(20, -1);
            this.pnlRoomTypes.Name = "pnlRoomTypes";
            this.pnlRoomTypes.Size = new System.Drawing.Size(500, 660);
            this.pnlRoomTypes.TabIndex = 0;
            // 
            // pnlRoomTypesHeader
            // 
            this.pnlRoomTypesHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRoomTypesHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlRoomTypesHeader.Controls.Add(this.lblRoomTypesTitle);
            this.pnlRoomTypesHeader.Controls.Add(this.pnlRoomTypesHeaderLine);
            this.pnlRoomTypesHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlRoomTypesHeader.Name = "pnlRoomTypesHeader";
            this.pnlRoomTypesHeader.Size = new System.Drawing.Size(498, 44);
            this.pnlRoomTypesHeader.TabIndex = 0;
            // 
            // lblRoomTypesTitle
            // 
            this.lblRoomTypesTitle.AutoSize = true;
            this.lblRoomTypesTitle.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRoomTypesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            this.lblRoomTypesTitle.Location = new System.Drawing.Point(16, 11);
            this.lblRoomTypesTitle.Name = "lblRoomTypesTitle";
            this.lblRoomTypesTitle.Size = new System.Drawing.Size(114, 24);
            this.lblRoomTypesTitle.TabIndex = 0;
            this.lblRoomTypesTitle.Text = "ประเภทห้องพัก";
            // 
            // pnlRoomTypesHeaderLine
            // 
            this.pnlRoomTypesHeaderLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRoomTypesHeaderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.pnlRoomTypesHeaderLine.Location = new System.Drawing.Point(0, 43);
            this.pnlRoomTypesHeaderLine.Name = "pnlRoomTypesHeaderLine";
            this.pnlRoomTypesHeaderLine.Size = new System.Drawing.Size(498, 1);
            this.pnlRoomTypesHeaderLine.TabIndex = 1;
            // 
            // dgvRoomTypes
            // 
            this.dgvRoomTypes.AllowUserToAddRows = false;
            this.dgvRoomTypes.AllowUserToDeleteRows = false;
            this.dgvRoomTypes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.dgvRoomTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoomTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoomTypes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRoomTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoomTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRoomTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Prompt", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoomTypes.ColumnHeadersHeight = 32;
            this.dgvRoomTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoomTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTypeName,
            this.colTypePrice,
            this.colTypeCapacity});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomTypes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRoomTypes.EnableHeadersVisualStyles = false;
            this.dgvRoomTypes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.dgvRoomTypes.Location = new System.Drawing.Point(0, 44);
            this.dgvRoomTypes.MultiSelect = false;
            this.dgvRoomTypes.Name = "dgvRoomTypes";
            this.dgvRoomTypes.ReadOnly = true;
            this.dgvRoomTypes.RowHeadersVisible = false;
            this.dgvRoomTypes.RowTemplate.Height = 36;
            this.dgvRoomTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomTypes.Size = new System.Drawing.Size(498, 140);
            this.dgvRoomTypes.TabIndex = 1;
            // 
            // colTypeName
            // 
            this.colTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTypeName.HeaderText = "ชื่อประเภท";
            this.colTypeName.MinimumWidth = 60;
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.ReadOnly = true;
            // 
            // colTypePrice
            // 
            dataGridViewCellStyle3.Format = "฿#,##0";
            dataGridViewCellStyle3.NullValue = null;
            this.colTypePrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTypePrice.HeaderText = "ราคา/คืน";
            this.colTypePrice.Name = "colTypePrice";
            this.colTypePrice.ReadOnly = true;
            this.colTypePrice.Width = 130;
            // 
            // colTypeCapacity
            // 
            dataGridViewCellStyle4.Format = "0 \"คน\"";
            dataGridViewCellStyle4.NullValue = null;
            this.colTypeCapacity.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTypeCapacity.HeaderText = "ความจุ";
            this.colTypeCapacity.Name = "colTypeCapacity";
            this.colTypeCapacity.ReadOnly = true;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Font = new System.Drawing.Font("Prompt", 10F);
            this.lblTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblTypeName.Location = new System.Drawing.Point(16, 200);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(183, 21);
            this.lblTypeName.TabIndex = 2;
            this.lblTypeName.Text = "ชื่อประเภทห้อง (TypeName)";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTypeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeName.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.txtTypeName.Location = new System.Drawing.Point(16, 224);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(466, 27);
            this.txtTypeName.TabIndex = 6;
            // 
            // lblTypePrice
            // 
            this.lblTypePrice.AutoSize = true;
            this.lblTypePrice.Font = new System.Drawing.Font("Prompt", 10F);
            this.lblTypePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblTypePrice.Location = new System.Drawing.Point(16, 268);
            this.lblTypePrice.Name = "lblTypePrice";
            this.lblTypePrice.Size = new System.Drawing.Size(113, 21);
            this.lblTypePrice.TabIndex = 7;
            this.lblTypePrice.Text = "ราคาต่อคืน (บาท)";
            // 
            // txtTypePrice
            // 
            this.txtTypePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTypePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypePrice.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTypePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.txtTypePrice.Location = new System.Drawing.Point(16, 292);
            this.txtTypePrice.Name = "txtTypePrice";
            this.txtTypePrice.Size = new System.Drawing.Size(227, 27);
            this.txtTypePrice.TabIndex = 8;
            // 
            // lblTypeCapacity
            // 
            this.lblTypeCapacity.AutoSize = true;
            this.lblTypeCapacity.Font = new System.Drawing.Font("Prompt", 10F);
            this.lblTypeCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblTypeCapacity.Location = new System.Drawing.Point(255, 268);
            this.lblTypeCapacity.Name = "lblTypeCapacity";
            this.lblTypeCapacity.Size = new System.Drawing.Size(83, 21);
            this.lblTypeCapacity.TabIndex = 9;
            this.lblTypeCapacity.Text = "ความจุ (คน)";
            // 
            // txtTypeCapacity
            // 
            this.txtTypeCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTypeCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeCapacity.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTypeCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.txtTypeCapacity.Location = new System.Drawing.Point(255, 292);
            this.txtTypeCapacity.Name = "txtTypeCapacity";
            this.txtTypeCapacity.Size = new System.Drawing.Size(227, 27);
            this.txtTypeCapacity.TabIndex = 10;
            // 
            // lblTypeDesc
            // 
            this.lblTypeDesc.AutoSize = true;
            this.lblTypeDesc.Font = new System.Drawing.Font("Prompt", 10F);
            this.lblTypeDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblTypeDesc.Location = new System.Drawing.Point(16, 336);
            this.lblTypeDesc.Name = "lblTypeDesc";
            this.lblTypeDesc.Size = new System.Drawing.Size(208, 21);
            this.lblTypeDesc.TabIndex = 11;
            this.lblTypeDesc.Text = "รายละเอียดสิ่งอำนวยความสะดวก";
            // 
            // txtTypeDesc
            // 
            this.txtTypeDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTypeDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTypeDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeDesc.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTypeDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.txtTypeDesc.Location = new System.Drawing.Point(16, 360);
            this.txtTypeDesc.Multiline = true;
            this.txtTypeDesc.Name = "txtTypeDesc";
            this.txtTypeDesc.Size = new System.Drawing.Size(466, 80);
            this.txtTypeDesc.TabIndex = 12;
            // 
            // btnTypeAdd
            // 
            this.btnTypeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnTypeAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTypeAdd.FlatAppearance.BorderSize = 0;
            this.btnTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeAdd.Font = new System.Drawing.Font("Prompt", 11F);
            this.btnTypeAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTypeAdd.Location = new System.Drawing.Point(16, 602);
            this.btnTypeAdd.Name = "btnTypeAdd";
            this.btnTypeAdd.Size = new System.Drawing.Size(150, 40);
            this.btnTypeAdd.TabIndex = 13;
            this.btnTypeAdd.Text = "เพิ่ม";
            this.btnTypeAdd.UseVisualStyleBackColor = false;
            // 
            // btnTypeEdit
            // 
            this.btnTypeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypeEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTypeEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTypeEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnTypeEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeEdit.Font = new System.Drawing.Font("Prompt", 11F);
            this.btnTypeEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnTypeEdit.Location = new System.Drawing.Point(174, 602);
            this.btnTypeEdit.Name = "btnTypeEdit";
            this.btnTypeEdit.Size = new System.Drawing.Size(150, 40);
            this.btnTypeEdit.TabIndex = 14;
            this.btnTypeEdit.Text = "แก้ไข";
            this.btnTypeEdit.UseVisualStyleBackColor = false;
            // 
            // btnTypeDelete
            // 
            this.btnTypeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTypeDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnTypeDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTypeDelete.FlatAppearance.BorderSize = 0;
            this.btnTypeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeDelete.Font = new System.Drawing.Font("Prompt", 11F);
            this.btnTypeDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTypeDelete.Location = new System.Drawing.Point(332, 602);
            this.btnTypeDelete.Name = "btnTypeDelete";
            this.btnTypeDelete.Size = new System.Drawing.Size(150, 40);
            this.btnTypeDelete.TabIndex = 15;
            this.btnTypeDelete.Text = "ลบ";
            this.btnTypeDelete.UseVisualStyleBackColor = false;
            // 
            // pnlRoomList
            // 
            this.pnlRoomList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRoomList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlRoomList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoomList.Controls.Add(this.pnlRoomListHeader);
            this.pnlRoomList.Controls.Add(this.dgvRooms);
            this.pnlRoomList.Controls.Add(this.lblRoomNumber);
            this.pnlRoomList.Controls.Add(this.txtRoomNumber);
            this.pnlRoomList.Controls.Add(this.lblRoomStatus);
            this.pnlRoomList.Controls.Add(this.cboRoomStatus);
            this.pnlRoomList.Controls.Add(this.lblRoomTypeId);
            this.pnlRoomList.Controls.Add(this.cboRoomTypeId);
            this.pnlRoomList.Controls.Add(this.btnRoomAdd);
            this.pnlRoomList.Controls.Add(this.btnRoomEdit);
            this.pnlRoomList.Controls.Add(this.btnRoomDelete);
            this.pnlRoomList.Location = new System.Drawing.Point(540, -1);
            this.pnlRoomList.Name = "pnlRoomList";
            this.pnlRoomList.Size = new System.Drawing.Size(500, 660);
            this.pnlRoomList.TabIndex = 1;
            // 
            // pnlRoomListHeader
            // 
            this.pnlRoomListHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRoomListHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlRoomListHeader.Controls.Add(this.lblRoomListTitle);
            this.pnlRoomListHeader.Controls.Add(this.pnlRoomListHeaderLine);
            this.pnlRoomListHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlRoomListHeader.Name = "pnlRoomListHeader";
            this.pnlRoomListHeader.Size = new System.Drawing.Size(498, 44);
            this.pnlRoomListHeader.TabIndex = 0;
            // 
            // lblRoomListTitle
            // 
            this.lblRoomListTitle.AutoSize = true;
            this.lblRoomListTitle.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRoomListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            this.lblRoomListTitle.Location = new System.Drawing.Point(16, 11);
            this.lblRoomListTitle.Name = "lblRoomListTitle";
            this.lblRoomListTitle.Size = new System.Drawing.Size(113, 24);
            this.lblRoomListTitle.TabIndex = 0;
            this.lblRoomListTitle.Text = "รายการห้องพัก";
            // 
            // pnlRoomListHeaderLine
            // 
            this.pnlRoomListHeaderLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRoomListHeaderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(226)))), ((int)(((byte)(224)))));
            this.pnlRoomListHeaderLine.Location = new System.Drawing.Point(0, 43);
            this.pnlRoomListHeaderLine.Name = "pnlRoomListHeaderLine";
            this.pnlRoomListHeaderLine.Size = new System.Drawing.Size(498, 1);
            this.pnlRoomListHeaderLine.TabIndex = 1;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.dgvRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Prompt", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(98)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRooms.ColumnHeadersHeight = 32;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomNo,
            this.colRoomType,
            this.colRoomStatusCol});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRooms.EnableHeadersVisualStyles = false;
            this.dgvRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.dgvRooms.Location = new System.Drawing.Point(0, 44);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowTemplate.Height = 36;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(498, 320);
            this.dgvRooms.TabIndex = 1;
            // 
            // colRoomNo
            // 
            this.colRoomNo.HeaderText = "เลขห้อง";
            this.colRoomNo.Name = "colRoomNo";
            this.colRoomNo.ReadOnly = true;
            this.colRoomNo.Width = 90;
            // 
            // colRoomType
            // 
            this.colRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomType.HeaderText = "ประเภท";
            this.colRoomType.MinimumWidth = 60;
            this.colRoomType.Name = "colRoomType";
            this.colRoomType.ReadOnly = true;
            // 
            // colRoomStatusCol
            // 
            this.colRoomStatusCol.HeaderText = "สถานะ";
            this.colRoomStatusCol.Name = "colRoomStatusCol";
            this.colRoomStatusCol.ReadOnly = true;
            this.colRoomStatusCol.Width = 130;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Prompt", 10F);
            this.lblRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblRoomNumber.Location = new System.Drawing.Point(16, 380);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(165, 21);
            this.lblRoomNumber.TabIndex = 2;
            this.lblRoomNumber.Text = "เลขห้อง (RoomNumber)";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomNumber.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.txtRoomNumber.Location = new System.Drawing.Point(16, 404);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(227, 27);
            this.txtRoomNumber.TabIndex = 22;
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Font = new System.Drawing.Font("Prompt", 10F);
            this.lblRoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblRoomStatus.Location = new System.Drawing.Point(255, 380);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(75, 21);
            this.lblRoomStatus.TabIndex = 23;
            this.lblRoomStatus.Text = "สถานะห้อง";
            // 
            // cboRoomStatus
            // 
            this.cboRoomStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRoomStatus.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboRoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.cboRoomStatus.FormattingEnabled = true;
            this.cboRoomStatus.Items.AddRange(new object[] {
            "Occupied",
            "Available",
            "Maintenance"});
            this.cboRoomStatus.Location = new System.Drawing.Point(255, 404);
            this.cboRoomStatus.Name = "cboRoomStatus";
            this.cboRoomStatus.Size = new System.Drawing.Size(227, 28);
            this.cboRoomStatus.TabIndex = 24;
            // 
            // lblRoomTypeId
            // 
            this.lblRoomTypeId.AutoSize = true;
            this.lblRoomTypeId.Font = new System.Drawing.Font("Prompt", 10F);
            this.lblRoomTypeId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(108)))));
            this.lblRoomTypeId.Location = new System.Drawing.Point(16, 448);
            this.lblRoomTypeId.Name = "lblRoomTypeId";
            this.lblRoomTypeId.Size = new System.Drawing.Size(177, 21);
            this.lblRoomTypeId.TabIndex = 25;
            this.lblRoomTypeId.Text = "ประเภทห้อง (RoomTypeID)";
            // 
            // cboRoomTypeId
            // 
            this.cboRoomTypeId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoomTypeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboRoomTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomTypeId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRoomTypeId.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboRoomTypeId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(42)))));
            this.cboRoomTypeId.FormattingEnabled = true;
            this.cboRoomTypeId.Location = new System.Drawing.Point(16, 472);
            this.cboRoomTypeId.Name = "cboRoomTypeId";
            this.cboRoomTypeId.Size = new System.Drawing.Size(466, 28);
            this.cboRoomTypeId.TabIndex = 26;
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRoomAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnRoomAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomAdd.FlatAppearance.BorderSize = 0;
            this.btnRoomAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomAdd.Font = new System.Drawing.Font("Prompt", 11F);
            this.btnRoomAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRoomAdd.Location = new System.Drawing.Point(16, 602);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(150, 40);
            this.btnRoomAdd.TabIndex = 27;
            this.btnRoomAdd.Text = "เพิ่ม";
            this.btnRoomAdd.UseVisualStyleBackColor = false;
            // 
            // btnRoomEdit
            // 
            this.btnRoomEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRoomEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRoomEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnRoomEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomEdit.Font = new System.Drawing.Font("Prompt", 11F);
            this.btnRoomEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(122)))), ((int)(((byte)(115)))));
            this.btnRoomEdit.Location = new System.Drawing.Point(174, 602);
            this.btnRoomEdit.Name = "btnRoomEdit";
            this.btnRoomEdit.Size = new System.Drawing.Size(150, 40);
            this.btnRoomEdit.TabIndex = 28;
            this.btnRoomEdit.Text = "แก้ไข";
            this.btnRoomEdit.UseVisualStyleBackColor = false;
            // 
            // btnRoomDelete
            // 
            this.btnRoomDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRoomDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRoomDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomDelete.FlatAppearance.BorderSize = 0;
            this.btnRoomDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomDelete.Font = new System.Drawing.Font("Prompt", 11F);
            this.btnRoomDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRoomDelete.Location = new System.Drawing.Point(332, 602);
            this.btnRoomDelete.Name = "btnRoomDelete";
            this.btnRoomDelete.Size = new System.Drawing.Size(150, 40);
            this.btnRoomDelete.TabIndex = 29;
            this.btnRoomDelete.Text = "ลบ";
            this.btnRoomDelete.UseVisualStyleBackColor = false;
            // 
            // ucRooms
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1044, 657);
            this.Controls.Add(this.pnlRoomTypes);
            this.Controls.Add(this.pnlRoomList);
            this.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "ucRooms";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "ucRooms";
            this.pnlRoomTypes.ResumeLayout(false);
            this.pnlRoomTypes.PerformLayout();
            this.pnlRoomTypesHeader.ResumeLayout(false);
            this.pnlRoomTypesHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomTypes)).EndInit();
            this.pnlRoomList.ResumeLayout(false);
            this.pnlRoomList.PerformLayout();
            this.pnlRoomListHeader.ResumeLayout(false);
            this.pnlRoomListHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRoomTypes;
        private System.Windows.Forms.Panel pnlRoomTypesHeader;
        private System.Windows.Forms.Label lblRoomTypesTitle;
        private System.Windows.Forms.Panel pnlRoomTypesHeaderLine;
        private System.Windows.Forms.DataGridView dgvRoomTypes;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblTypePrice;
        private System.Windows.Forms.TextBox txtTypePrice;
        private System.Windows.Forms.Label lblTypeCapacity;
        private System.Windows.Forms.TextBox txtTypeCapacity;
        private System.Windows.Forms.Label lblTypeDesc;
        private System.Windows.Forms.TextBox txtTypeDesc;
        private System.Windows.Forms.Button btnTypeAdd;
        private System.Windows.Forms.Button btnTypeEdit;
        private System.Windows.Forms.Button btnTypeDelete;
        private System.Windows.Forms.Panel pnlRoomList;
        private System.Windows.Forms.Panel pnlRoomListHeader;
        private System.Windows.Forms.Label lblRoomListTitle;
        private System.Windows.Forms.Panel pnlRoomListHeaderLine;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.ComboBox cboRoomStatus;
        private System.Windows.Forms.Label lblRoomTypeId;
        private System.Windows.Forms.ComboBox cboRoomTypeId;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.Button btnRoomEdit;
        private System.Windows.Forms.Button btnRoomDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomStatusCol;
    }
}