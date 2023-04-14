namespace C_GUI.Views
{
    partial class FrmPhieuDat
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvLoaiPhong = new MetroFramework.Controls.MetroGrid();
            this.khachHangIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDatTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phiPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPhong = new System.Windows.Forms.Label();
            this.tbNgayDat = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbNgayDatTra = new System.Windows.Forms.Label();
            this.tbNgayNhan = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbGhiChu = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbNgayTra = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbPhiDichVu = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.Location = new System.Drawing.Point(55, 51);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(269, 39);
            this.txbSearch.TabIndex = 2;
            this.txbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearch_KeyPress_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1235, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AllowUserToAddRows = false;
            this.dgvLoaiPhong.AllowUserToDeleteRows = false;
            this.dgvLoaiPhong.AllowUserToResizeRows = false;
            this.dgvLoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLoaiPhong.AutoGenerateColumns = false;
            this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoaiPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLoaiPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.khachHangIdDataGridViewTextBoxColumn,
            this.phongIdDataGridViewTextBoxColumn,
            this.ngayDatDataGridViewTextBoxColumn,
            this.ngayNhanDataGridViewTextBoxColumn,
            this.ngayTraDataGridViewTextBoxColumn,
            this.strTrangThai,
            this.trangThaiDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn,
            this.ngayDatTraDataGridViewTextBoxColumn,
            this.hoaDonIdDataGridViewTextBoxColumn,
            this.nhanVienIdDataGridViewTextBoxColumn,
            this.phiPhongDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dgvLoaiPhong.DataSource = this.BindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiPhong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiPhong.EnableHeadersVisualStyles = false;
            this.dgvLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvLoaiPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLoaiPhong.Location = new System.Drawing.Point(37, 147);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.ReadOnly = true;
            this.dgvLoaiPhong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiPhong.RowHeadersVisible = false;
            this.dgvLoaiPhong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLoaiPhong.RowTemplate.Height = 25;
            this.dgvLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(837, 777);
            this.dgvLoaiPhong.TabIndex = 7;
            // 
            // khachHangIdDataGridViewTextBoxColumn
            // 
            this.khachHangIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.khachHangIdDataGridViewTextBoxColumn.DataPropertyName = "HoTenKhach";
            this.khachHangIdDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.khachHangIdDataGridViewTextBoxColumn.Name = "khachHangIdDataGridViewTextBoxColumn";
            this.khachHangIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.khachHangIdDataGridViewTextBoxColumn.Width = 103;
            // 
            // phongIdDataGridViewTextBoxColumn
            // 
            this.phongIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phongIdDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.phongIdDataGridViewTextBoxColumn.HeaderText = "Phòng";
            this.phongIdDataGridViewTextBoxColumn.Name = "phongIdDataGridViewTextBoxColumn";
            this.phongIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.phongIdDataGridViewTextBoxColumn.Width = 99;
            // 
            // ngayDatDataGridViewTextBoxColumn
            // 
            this.ngayDatDataGridViewTextBoxColumn.DataPropertyName = "NgayDat";
            this.ngayDatDataGridViewTextBoxColumn.HeaderText = "Đặt ngày";
            this.ngayDatDataGridViewTextBoxColumn.Name = "ngayDatDataGridViewTextBoxColumn";
            this.ngayDatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayNhanDataGridViewTextBoxColumn
            // 
            this.ngayNhanDataGridViewTextBoxColumn.DataPropertyName = "NgayNhan";
            this.ngayNhanDataGridViewTextBoxColumn.HeaderText = "Nhận ngày";
            this.ngayNhanDataGridViewTextBoxColumn.Name = "ngayNhanDataGridViewTextBoxColumn";
            this.ngayNhanDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayNhanDataGridViewTextBoxColumn.Visible = false;
            // 
            // ngayTraDataGridViewTextBoxColumn
            // 
            this.ngayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.HeaderText = "Trả ngày";
            this.ngayTraDataGridViewTextBoxColumn.Name = "ngayTraDataGridViewTextBoxColumn";
            this.ngayTraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strTrangThai
            // 
            this.strTrangThai.DataPropertyName = "strTrangThai";
            this.strTrangThai.HeaderText = "Trạng Thái";
            this.strTrangThai.Name = "strTrangThai";
            this.strTrangThai.ReadOnly = true;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "Status";
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.trangThaiDataGridViewTextBoxColumn.Visible = false;
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "NgayTao";
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "Tạo";
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            this.ngayTaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayTaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // ngayDatTraDataGridViewTextBoxColumn
            // 
            this.ngayDatTraDataGridViewTextBoxColumn.DataPropertyName = "NgayDatTra";
            this.ngayDatTraDataGridViewTextBoxColumn.HeaderText = "Đặt Trả";
            this.ngayDatTraDataGridViewTextBoxColumn.Name = "ngayDatTraDataGridViewTextBoxColumn";
            this.ngayDatTraDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayDatTraDataGridViewTextBoxColumn.Visible = false;
            // 
            // hoaDonIdDataGridViewTextBoxColumn
            // 
            this.hoaDonIdDataGridViewTextBoxColumn.DataPropertyName = "HoaDonId";
            this.hoaDonIdDataGridViewTextBoxColumn.HeaderText = "HoaDonId";
            this.hoaDonIdDataGridViewTextBoxColumn.Name = "hoaDonIdDataGridViewTextBoxColumn";
            this.hoaDonIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoaDonIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nhanVienIdDataGridViewTextBoxColumn
            // 
            this.nhanVienIdDataGridViewTextBoxColumn.DataPropertyName = "NhanVienId";
            this.nhanVienIdDataGridViewTextBoxColumn.HeaderText = "NhanVienId";
            this.nhanVienIdDataGridViewTextBoxColumn.Name = "nhanVienIdDataGridViewTextBoxColumn";
            this.nhanVienIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.nhanVienIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // phiPhongDataGridViewTextBoxColumn
            // 
            this.phiPhongDataGridViewTextBoxColumn.DataPropertyName = "PhiPhong";
            this.phiPhongDataGridViewTextBoxColumn.HeaderText = "PhiPhong";
            this.phiPhongDataGridViewTextBoxColumn.Name = "phiPhongDataGridViewTextBoxColumn";
            this.phiPhongDataGridViewTextBoxColumn.ReadOnly = true;
            this.phiPhongDataGridViewTextBoxColumn.Visible = false;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiChuDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // BindingSource1
            // 
            this.BindingSource1.DataSource = typeof(B_BUS.ViewModels.PhieuDatPhongViewModel);
            this.BindingSource1.CurrentItemChanged += new System.EventHandler(this.BindingSource1_CurrentChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "lll  Thông tin chi tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(458, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 65);
            this.panel2.TabIndex = 0;
            // 
            // lbHoTen
            // 
            this.lbHoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource1, "HoTenKhach", true));
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHoTen.ForeColor = System.Drawing.Color.White;
            this.lbHoTen.Location = new System.Drawing.Point(16, 9);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(323, 36);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "label3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(20, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ghi Chú:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(20, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nhận ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đặt ngày:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.lbPhong);
            this.panel3.Controls.Add(this.lbHoTen);
            this.panel3.Location = new System.Drawing.Point(20, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 52);
            this.panel3.TabIndex = 2;
            // 
            // lbPhong
            // 
            this.lbPhong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource1, "TenPhong", true));
            this.lbPhong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhong.ForeColor = System.Drawing.Color.White;
            this.lbPhong.Location = new System.Drawing.Point(345, 9);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(172, 36);
            this.lbPhong.TabIndex = 0;
            this.lbPhong.Text = "label3";
            this.lbPhong.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbNgayDat
            // 
            this.tbNgayDat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource1, "NgayDat", true));
            this.tbNgayDat.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNgayDat.ForeColor = System.Drawing.Color.White;
            this.tbNgayDat.Location = new System.Drawing.Point(16, 9);
            this.tbNgayDat.Name = "tbNgayDat";
            this.tbNgayDat.Size = new System.Drawing.Size(255, 36);
            this.tbNgayDat.TabIndex = 0;
            this.tbNgayDat.Text = "label3";
            this.tbNgayDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.Controls.Add(this.tbNgayDatTra);
            this.panel5.Controls.Add(this.tbNgayDat);
            this.panel5.Location = new System.Drawing.Point(20, 222);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(533, 52);
            this.panel5.TabIndex = 2;
            // 
            // tbNgayDatTra
            // 
            this.tbNgayDatTra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource1, "NgayDatTra", true));
            this.tbNgayDatTra.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNgayDatTra.ForeColor = System.Drawing.Color.White;
            this.tbNgayDatTra.Location = new System.Drawing.Point(277, 9);
            this.tbNgayDatTra.Name = "tbNgayDatTra";
            this.tbNgayDatTra.Size = new System.Drawing.Size(253, 36);
            this.tbNgayDatTra.TabIndex = 0;
            this.tbNgayDatTra.Text = "label3";
            this.tbNgayDatTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNgayNhan
            // 
            this.tbNgayNhan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource1, "NgayNhan", true));
            this.tbNgayNhan.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNgayNhan.ForeColor = System.Drawing.Color.White;
            this.tbNgayNhan.Location = new System.Drawing.Point(16, 9);
            this.tbNgayNhan.Name = "tbNgayNhan";
            this.tbNgayNhan.Size = new System.Drawing.Size(255, 36);
            this.tbNgayNhan.TabIndex = 0;
            this.tbNgayNhan.Text = "label3";
            this.tbNgayNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel8.Controls.Add(this.txbSearch);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.btnThem);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.btnHuy);
            this.panel8.Controls.Add(this.btnXoa);
            this.panel8.Controls.Add(this.btnSua);
            this.panel8.Location = new System.Drawing.Point(37, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1443, 109);
            this.panel8.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_GUI.Properties.Resources.white_search;
            this.pictureBox1.Location = new System.Drawing.Point(14, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(363, 45);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(171, 50);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DimGray;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(1017, 45);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(171, 50);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(799, 45);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(171, 50);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(581, 45);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(171, 50);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(907, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 777);
            this.panel1.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel10.Controls.Add(this.lbTongTien);
            this.panel10.Location = new System.Drawing.Point(184, 702);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(369, 52);
            this.panel10.TabIndex = 4;
            // 
            // lbTongTien
            // 
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTongTien.ForeColor = System.Drawing.Color.White;
            this.lbTongTien.Location = new System.Drawing.Point(11, 8);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(352, 36);
            this.lbTongTien.TabIndex = 0;
            this.lbTongTien.Text = "label3";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(20, 712);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 32);
            this.label14.TabIndex = 3;
            this.label14.Text = "Tổng:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel7.Controls.Add(this.tbGhiChu);
            this.panel7.Location = new System.Drawing.Point(20, 417);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(533, 115);
            this.panel7.TabIndex = 2;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource1, "GhiChu", true));
            this.tbGhiChu.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbGhiChu.ForeColor = System.Drawing.Color.White;
            this.tbGhiChu.Location = new System.Drawing.Point(16, 13);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(501, 93);
            this.tbGhiChu.TabIndex = 0;
            this.tbGhiChu.Text = "label3";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel6.Controls.Add(this.tbNgayTra);
            this.panel6.Controls.Add(this.tbNgayNhan);
            this.panel6.Location = new System.Drawing.Point(20, 321);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(533, 52);
            this.panel6.TabIndex = 2;
            // 
            // tbNgayTra
            // 
            this.tbNgayTra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource1, "NgayTra", true));
            this.tbNgayTra.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNgayTra.ForeColor = System.Drawing.Color.White;
            this.tbNgayTra.Location = new System.Drawing.Point(277, 9);
            this.tbNgayTra.Name = "tbNgayTra";
            this.tbNgayTra.Size = new System.Drawing.Size(253, 36);
            this.tbNgayTra.TabIndex = 0;
            this.tbNgayTra.Text = "label3";
            this.tbNgayTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.lbPhiDichVu);
            this.panel4.Location = new System.Drawing.Point(184, 630);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 52);
            this.panel4.TabIndex = 2;
            // 
            // lbPhiDichVu
            // 
            this.lbPhiDichVu.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhiDichVu.ForeColor = System.Drawing.Color.White;
            this.lbPhiDichVu.Location = new System.Drawing.Point(11, 8);
            this.lbPhiDichVu.Name = "lbPhiDichVu";
            this.lbPhiDichVu.Size = new System.Drawing.Size(352, 36);
            this.lbPhiDichVu.TabIndex = 0;
            this.lbPhiDichVu.Text = "label3";
            this.lbPhiDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(184, 555);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(369, 52);
            this.panel9.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSource1, "StrPhiPhong", true));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(352, 36);
            this.label9.TabIndex = 0;
            this.label9.Text = "label3";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 640);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dịch Vụ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(20, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Phí phòng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(423, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "đến ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(429, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "đến ngày:";
            // 
            // FrmPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1517, 950);
            this.Controls.Add(this.dgvLoaiPhong);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPhieuDat";
            this.Text = "FrmTrangChu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txbSearch;
        private Button button1;
        private MetroFramework.Controls.MetroGrid dgvLoaiPhong;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private Label label1;
        private Label label4;
        private Label label2;
        private Panel panel2;
        private Label lbHoTen;
        private Label label10;
        private Label label8;
        private Label label6;
        private Panel panel3;
        private Label lbPhong;
        private Label tbNgayDat;
        private Panel panel5;
        private Label tbNgayNhan;
        private Panel panel8;
        private PictureBox pictureBox1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Panel panel1;
        private Panel panel7;
        private Label tbGhiChu;
        private Panel panel6;
        private BindingSource BindingSource1;
        private Button btnHuy;
        private Label tbNgayDatTra;
        private Label tbNgayTra;
        private Label label12;
        private Label label3;
        private DataGridViewTextBoxColumn khachHangIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phongIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayDatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayNhanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn strTrangThai;
        private DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayDatTraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoaDonIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nhanVienIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phiPhongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private Panel panel9;
        private Label label9;
        private Label label7;
        private Panel panel10;
        private Label lbTongTien;
        private Label label14;
        private Panel panel4;
        private Label lbPhiDichVu;
        private Label label5;
    }
}