namespace C_GUI.Views
{
    partial class FrmHoaDonChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonChiTiet));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.hoaDonViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_nhanvien = new System.Windows.Forms.Label();
            this.lb_songay = new System.Windows.Forms.Label();
            this.lb_maphong = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_loaiphong = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvLoaiPhong = new MetroFramework.Controls.MetroGrid();
            this.tenDichVuVMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDonGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strThanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietPhieuDichVuViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txb_idhd = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.cbb_Trangthai = new System.Windows.Forms.ComboBox();
            this.lb_ngaytt = new System.Windows.Forms.Label();
            this.cbb_pttt = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_ngaytra = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lb_tienphong = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_ngaynhan = new System.Windows.Forms.Label();
            this.pcb_in = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_pp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuDichVuViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_in)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(279, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày nhận :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã hóa đơn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhân viên :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số giờ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số phòng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(373, 797);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 37);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tổng tiền :";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "StrTongTien", true));
            this.lb_tongtien.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb_tongtien.Location = new System.Drawing.Point(514, 787);
            this.lb_tongtien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(285, 50);
            this.lb_tongtien.TabIndex = 10;
            this.lb_tongtien.Text = "0";
            this.lb_tongtien.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // hoaDonViewModelBindingSource
            // 
            this.hoaDonViewModelBindingSource.DataSource = typeof(B_BUS.ViewModels.HoaDonViewModel);
            // 
            // lb_nhanvien
            // 
            this.lb_nhanvien.AutoSize = true;
            this.lb_nhanvien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "TenDayDu_NV", true));
            this.lb_nhanvien.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nhanvien.Location = new System.Drawing.Point(405, 89);
            this.lb_nhanvien.Name = "lb_nhanvien";
            this.lb_nhanvien.Size = new System.Drawing.Size(117, 25);
            this.lb_nhanvien.TabIndex = 14;
            this.lb_nhanvien.Text = "Dương Hiếu";
            // 
            // lb_songay
            // 
            this.lb_songay.AutoSize = true;
            this.lb_songay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_songay.Location = new System.Drawing.Point(180, 359);
            this.lb_songay.Name = "lb_songay";
            this.lb_songay.Size = new System.Drawing.Size(23, 25);
            this.lb_songay.TabIndex = 16;
            this.lb_songay.Text = "3";
            // 
            // lb_maphong
            // 
            this.lb_maphong.AutoSize = true;
            this.lb_maphong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "SoPhong", true));
            this.lb_maphong.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_maphong.Location = new System.Drawing.Point(578, 259);
            this.lb_maphong.Name = "lb_maphong";
            this.lb_maphong.Size = new System.Drawing.Size(45, 25);
            this.lb_maphong.TabIndex = 18;
            this.lb_maphong.Text = "PH1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // lb_loaiphong
            // 
            this.lb_loaiphong.AutoSize = true;
            this.lb_loaiphong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "loaiPhong", true));
            this.lb_loaiphong.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_loaiphong.Location = new System.Drawing.Point(675, 259);
            this.lb_loaiphong.Name = "lb_loaiphong";
            this.lb_loaiphong.Size = new System.Drawing.Size(41, 25);
            this.lb_loaiphong.TabIndex = 23;
            this.lb_loaiphong.Text = "VIP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 25);
            this.label13.TabIndex = 26;
            this.label13.Text = "Ngày tạo :";
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AllowUserToAddRows = false;
            this.dgvLoaiPhong.AllowUserToDeleteRows = false;
            this.dgvLoaiPhong.AllowUserToResizeRows = false;
            this.dgvLoaiPhong.AutoGenerateColumns = false;
            this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoaiPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLoaiPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLoaiPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDichVuVMDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.strDonGiaDataGridViewTextBoxColumn,
            this.strThanhTienDataGridViewTextBoxColumn});
            this.dgvLoaiPhong.DataSource = this.chiTietPhieuDichVuViewModelBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiPhong.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLoaiPhong.EnableHeadersVisualStyles = false;
            this.dgvLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvLoaiPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLoaiPhong.Location = new System.Drawing.Point(12, 404);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.ReadOnly = true;
            this.dgvLoaiPhong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLoaiPhong.RowHeadersVisible = false;
            this.dgvLoaiPhong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLoaiPhong.RowTemplate.Height = 25;
            this.dgvLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(791, 344);
            this.dgvLoaiPhong.TabIndex = 31;
            // 
            // tenDichVuVMDataGridViewTextBoxColumn
            // 
            this.tenDichVuVMDataGridViewTextBoxColumn.DataPropertyName = "Ten_DichVuVM";
            this.tenDichVuVMDataGridViewTextBoxColumn.HeaderText = "Tên dịch vụ";
            this.tenDichVuVMDataGridViewTextBoxColumn.Name = "tenDichVuVMDataGridViewTextBoxColumn";
            this.tenDichVuVMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strDonGiaDataGridViewTextBoxColumn
            // 
            this.strDonGiaDataGridViewTextBoxColumn.DataPropertyName = "strDonGia";
            this.strDonGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.strDonGiaDataGridViewTextBoxColumn.Name = "strDonGiaDataGridViewTextBoxColumn";
            this.strDonGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strThanhTienDataGridViewTextBoxColumn
            // 
            this.strThanhTienDataGridViewTextBoxColumn.DataPropertyName = "strThanhTien";
            this.strThanhTienDataGridViewTextBoxColumn.HeaderText = "Thành tiền";
            this.strThanhTienDataGridViewTextBoxColumn.Name = "strThanhTienDataGridViewTextBoxColumn";
            this.strThanhTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chiTietPhieuDichVuViewModelBindingSource
            // 
            this.chiTietPhieuDichVuViewModelBindingSource.DataSource = typeof(B_BUS.ViewModels.ChiTietPhieuDichVuViewModel);
            // 
            // txb_idhd
            // 
            this.txb_idhd.BackColor = System.Drawing.Color.Yellow;
            this.txb_idhd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_idhd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "Id", true));
            this.txb_idhd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_idhd.ForeColor = System.Drawing.Color.Black;
            this.txb_idhd.Location = new System.Drawing.Point(180, 312);
            this.txb_idhd.Name = "txb_idhd";
            this.txb_idhd.Size = new System.Drawing.Size(117, 26);
            this.txb_idhd.TabIndex = 32;
            this.txb_idhd.Text = "dấdda";
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(545, 860);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(226, 75);
            this.btn_luu.TabIndex = 34;
            this.btn_luu.Text = "Thanh toán";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // cbb_Trangthai
            // 
            this.cbb_Trangthai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "TrangThai1", true));
            this.cbb_Trangthai.Enabled = false;
            this.cbb_Trangthai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_Trangthai.FormattingEnabled = true;
            this.cbb_Trangthai.Location = new System.Drawing.Point(57, 815);
            this.cbb_Trangthai.Name = "cbb_Trangthai";
            this.cbb_Trangthai.Size = new System.Drawing.Size(226, 33);
            this.cbb_Trangthai.TabIndex = 37;
            // 
            // lb_ngaytt
            // 
            this.lb_ngaytt.AutoSize = true;
            this.lb_ngaytt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "NgayTao", true));
            this.lb_ngaytt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_ngaytt.ForeColor = System.Drawing.Color.Blue;
            this.lb_ngaytt.Location = new System.Drawing.Point(180, 262);
            this.lb_ngaytt.Name = "lb_ngaytt";
            this.lb_ngaytt.Size = new System.Drawing.Size(45, 25);
            this.lb_ngaytt.TabIndex = 39;
            this.lb_ngaytt.Text = "PH1";
            // 
            // cbb_pttt
            // 
            this.cbb_pttt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_pttt.FormattingEnabled = true;
            this.cbb_pttt.Location = new System.Drawing.Point(60, 902);
            this.cbb_pttt.Name = "cbb_pttt";
            this.cbb_pttt.Size = new System.Drawing.Size(223, 33);
            this.cbb_pttt.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 874);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 25);
            this.label15.TabIndex = 42;
            this.label15.Text = "Phương thức thanh toán :";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // lb_ngaytra
            // 
            this.lb_ngaytra.AutoSize = true;
            this.lb_ngaytra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "ngayTra", true));
            this.lb_ngaytra.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_ngaytra.ForeColor = System.Drawing.Color.Blue;
            this.lb_ngaytra.Location = new System.Drawing.Point(578, 209);
            this.lb_ngaytra.Name = "lb_ngaytra";
            this.lb_ngaytra.Size = new System.Drawing.Size(45, 25);
            this.lb_ngaytra.TabIndex = 46;
            this.lb_ngaytra.Text = "PH1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "ngayDat", true));
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(581, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 25);
            this.label12.TabIndex = 45;
            this.label12.Text = "123";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(463, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 25);
            this.label17.TabIndex = 44;
            this.label17.Text = "Ngày trả :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(459, 159);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 25);
            this.label18.TabIndex = 43;
            this.label18.Text = "Ngày đặt :";
            // 
            // lb_tienphong
            // 
            this.lb_tienphong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "tienPhong", true));
            this.lb_tienphong.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tienphong.ForeColor = System.Drawing.Color.Red;
            this.lb_tienphong.Location = new System.Drawing.Point(459, 302);
            this.lb_tienphong.Name = "lb_tienphong";
            this.lb_tienphong.Size = new System.Drawing.Size(342, 32);
            this.lb_tienphong.TabIndex = 47;
            this.lb_tienphong.Text = "label14";
            this.lb_tienphong.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(38, 159);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 25);
            this.label20.TabIndex = 48;
            this.label20.Text = "Khách hàng :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "TenDayDu_KH", true));
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(180, 159);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 25);
            this.label21.TabIndex = 48;
            this.label21.Text = "Dương Hiếu";
            // 
            // lb_ngaynhan
            // 
            this.lb_ngaynhan.AutoSize = true;
            this.lb_ngaynhan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "ngayNhan", true));
            this.lb_ngaynhan.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_ngaynhan.ForeColor = System.Drawing.Color.Blue;
            this.lb_ngaynhan.Location = new System.Drawing.Point(180, 212);
            this.lb_ngaynhan.Name = "lb_ngaynhan";
            this.lb_ngaynhan.Size = new System.Drawing.Size(42, 25);
            this.lb_ngaynhan.TabIndex = 38;
            this.lb_ngaynhan.Text = "123";
            // 
            // pcb_in
            // 
            this.pcb_in.Image = ((System.Drawing.Image)(resources.GetObject("pcb_in.Image")));
            this.pcb_in.Location = new System.Drawing.Point(675, 40);
            this.pcb_in.Name = "pcb_in";
            this.pcb_in.Size = new System.Drawing.Size(43, 46);
            this.pcb_in.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_in.TabIndex = 21;
            this.pcb_in.TabStop = false;
            this.pcb_in.Click += new System.EventHandler(this.pcb_in_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 787);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "Trạng thái :";
            this.label11.Click += new System.EventHandler(this.label15_Click);
            // 
            // lb_pp
            // 
            this.lb_pp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonViewModelBindingSource, "TongTienPhong", true));
            this.lb_pp.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_pp.ForeColor = System.Drawing.Color.Red;
            this.lb_pp.Location = new System.Drawing.Point(459, 352);
            this.lb_pp.Name = "lb_pp";
            this.lb_pp.Size = new System.Drawing.Size(342, 32);
            this.lb_pp.TabIndex = 47;
            this.lb_pp.Text = "label14";
            this.lb_pp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmHoaDonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 966);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lb_pp);
            this.Controls.Add(this.lb_tienphong);
            this.Controls.Add(this.lb_ngaytra);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbb_pttt);
            this.Controls.Add(this.lb_ngaynhan);
            this.Controls.Add(this.lb_ngaytt);
            this.Controls.Add(this.cbb_Trangthai);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txb_idhd);
            this.Controls.Add(this.dgvLoaiPhong);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lb_loaiphong);
            this.Controls.Add(this.pcb_in);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lb_songay);
            this.Controls.Add(this.lb_maphong);
            this.Controls.Add(this.lb_nhanvien);
            this.Controls.Add(this.lb_tongtien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmHoaDonChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHoaDonChiTiet";
            this.Load += new System.EventHandler(this.FrmHoaDonChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuDichVuViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_in)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PrintPreviewDialog printPreviewDialog1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label lb_tongtien;
        private Label lb_nhanvien;
        private Label lb_songay;
        private Label lb_maphong;
        private PictureBox pictureBox3;
        private Label lb_loaiphong;
        private Label label13;
        private MetroFramework.Controls.MetroGrid dgvLoaiPhong;
        private TextBox txb_idhd;
        private Button btn_luu;
        private ComboBox cbb_Trangthai;
        private BindingSource hoaDonViewModelBindingSource;
        private Label lb_ngaytt;
        private ComboBox cbb_pttt;
        private Label label15;
        private Label lb_ngaytra;
        private Label label12;
        private Label label17;
        private Label label18;
        private Label lb_tienphong;
        private Label label20;
        private Label label21;
        private Label lb_ngaynhan;
        private PictureBox pcb_in;
        private Label label11;
        private Label lb_pp;
        private DataGridViewTextBoxColumn tenDichVuVMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn strDonGiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn strThanhTienDataGridViewTextBoxColumn;
        private BindingSource chiTietPhieuDichVuViewModelBindingSource;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}