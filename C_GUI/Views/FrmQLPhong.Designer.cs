namespace C_GUI.Views
{
    partial class FrmQLPhong
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            PhongViewModelBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            label7 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            label8 = new Label();
            label12 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            dgvQLPhong = new MetroFramework.Controls.MetroGrid();
            txbSearch = new TextBox();
            btnLoad = new Button();
            label13 = new Label();
            panel8 = new Panel();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            panel1 = new Panel();
            panel6 = new Panel();
            label9 = new Label();
            panel9 = new Panel();
            Ten = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            Tang = new DataGridViewTextBoxColumn();
            tenLoaiPhongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            loaiPhongIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            trangThaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tangDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ghiChuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loaiPhongViewModelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phieuDatPhongViewModelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            intHienTrangDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            strHienTrangDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            strshowCBBDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            strTrangThaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ucBackColorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pnlBackColorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)PhongViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLPhong).BeginInit();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // PhongViewModelBindingSource
            // 
            PhongViewModelBindingSource.DataSource = typeof(B_BUS.ViewModels.PhongViewModel);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_search;
            pictureBox1.Location = new Point(14, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.DataBindings.Add(new Binding("Text", PhongViewModelBindingSource, "TenLoaiPhong", true));
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 9);
            label7.Name = "label7";
            label7.Size = new Size(501, 36);
            label7.TabIndex = 0;
            label7.Text = "label3";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(20, 246);
            panel4.Name = "panel4";
            panel4.Size = new Size(533, 52);
            panel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.DataBindings.Add(new Binding("Text", PhongViewModelBindingSource, "strTrangThai", true));
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 9);
            label5.Name = "label5";
            label5.Size = new Size(501, 36);
            label5.TabIndex = 0;
            label5.Text = "label3";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonShadow;
            panel5.Controls.Add(label7);
            panel5.Location = new Point(20, 468);
            panel5.Name = "panel5";
            panel5.Size = new Size(533, 52);
            panel5.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(20, 315);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 1;
            label8.Text = "Tầng:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(20, 533);
            label12.Name = "label12";
            label12.Size = new Size(107, 32);
            label12.TabIndex = 1;
            label12.Text = "Ghi chú:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 423);
            label6.Name = "label6";
            label6.Size = new Size(149, 32);
            label6.TabIndex = 1;
            label6.Text = "Loại phòng:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(20, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(533, 52);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.DataBindings.Add(new Binding("Text", PhongViewModelBindingSource, "Ten", true));
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 9);
            label3.Name = "label3";
            label3.Size = new Size(501, 36);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 201);
            label4.Name = "label4";
            label4.Size = new Size(136, 32);
            label4.TabIndex = 1;
            label4.Text = "Trạng thái:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 87);
            label2.Name = "label2";
            label2.Size = new Size(61, 32);
            label2.TabIndex = 1;
            label2.Text = "Tên:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 62, 80);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 65);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(233, 31);
            label1.TabIndex = 0;
            label1.Text = "lll  Thông tin chi tiết";
            // 
            // dgvQLPhong
            // 
            dgvQLPhong.AllowUserToAddRows = false;
            dgvQLPhong.AllowUserToDeleteRows = false;
            dgvQLPhong.AllowUserToResizeRows = false;
            dgvQLPhong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dgvQLPhong.AutoGenerateColumns = false;
            dgvQLPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLPhong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvQLPhong.BackgroundColor = SystemColors.Control;
            dgvQLPhong.BorderStyle = BorderStyle.Fixed3D;
            dgvQLPhong.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvQLPhong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQLPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQLPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLPhong.Columns.AddRange(new DataGridViewColumn[] { Ten, TrangThai, Tang, tenLoaiPhongDataGridViewTextBoxColumn, GhiChu, loaiPhongIdDataGridViewTextBoxColumn, tenDataGridViewTextBoxColumn, trangThaiDataGridViewTextBoxColumn, tangDataGridViewTextBoxColumn, ghiChuDataGridViewTextBoxColumn, loaiPhongViewModelDataGridViewTextBoxColumn, phieuDatPhongViewModelDataGridViewTextBoxColumn, intHienTrangDataGridViewTextBoxColumn, strHienTrangDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, strshowCBBDataGridViewTextBoxColumn, strTrangThaiDataGridViewTextBoxColumn, ucBackColorDataGridViewTextBoxColumn, pnlBackColorDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn });
            dgvQLPhong.DataSource = PhongViewModelBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvQLPhong.DefaultCellStyle = dataGridViewCellStyle2;
            dgvQLPhong.EnableHeadersVisualStyles = false;
            dgvQLPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvQLPhong.GridColor = Color.FromArgb(255, 255, 255);
            dgvQLPhong.Location = new Point(37, 147);
            dgvQLPhong.Name = "dgvQLPhong";
            dgvQLPhong.ReadOnly = true;
            dgvQLPhong.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvQLPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvQLPhong.RowHeadersVisible = false;
            dgvQLPhong.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvQLPhong.RowTemplate.Height = 25;
            dgvQLPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLPhong.Size = new Size(837, 777);
            dgvQLPhong.TabIndex = 7;
            // 
            // txbSearch
            // 
            txbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txbSearch.Location = new Point(55, 51);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(269, 39);
            txbSearch.TabIndex = 2;
            txbSearch.KeyPress += txbSearch_KeyPress;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(26, 188, 156);
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(992, 45);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(171, 50);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // label13
            // 
            label13.DataBindings.Add(new Binding("Text", PhongViewModelBindingSource, "GhiChu", true));
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(16, 9);
            label13.Name = "label13";
            label13.Size = new Size(501, 156);
            label13.TabIndex = 0;
            label13.Text = "label3";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(44, 62, 80);
            panel8.Controls.Add(txbSearch);
            panel8.Controls.Add(pictureBox1);
            panel8.Controls.Add(btnThem);
            panel8.Controls.Add(btnLoad);
            panel8.Controls.Add(btnXoa);
            panel8.Controls.Add(btnSua);
            panel8.Location = new Point(37, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1443, 109);
            panel8.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(46, 204, 113);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(363, 45);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(171, 50);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(230, 126, 34);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(791, 45);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(171, 50);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(52, 152, 219);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(577, 45);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(171, 50);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(907, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 777);
            panel1.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonShadow;
            panel6.Controls.Add(label9);
            panel6.Location = new Point(20, 360);
            panel6.Name = "panel6";
            panel6.Size = new Size(533, 52);
            panel6.TabIndex = 2;
            // 
            // label9
            // 
            label9.DataBindings.Add(new Binding("Text", PhongViewModelBindingSource, "Tang", true));
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(16, 9);
            label9.Name = "label9";
            label9.Size = new Size(501, 36);
            label9.TabIndex = 0;
            label9.Text = "label3";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonShadow;
            panel9.Controls.Add(label13);
            panel9.Location = new Point(20, 578);
            panel9.Name = "panel9";
            panel9.Size = new Size(533, 180);
            panel9.TabIndex = 2;
            // 
            // Ten
            // 
            Ten.DataPropertyName = "Ten";
            Ten.HeaderText = "Tên";
            Ten.Name = "Ten";
            Ten.ReadOnly = true;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "strTrangThai";
            TrangThai.HeaderText = "Trạng Thái";
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            // 
            // Tang
            // 
            Tang.DataPropertyName = "Tang";
            Tang.FillWeight = 50F;
            Tang.HeaderText = "Tầng";
            Tang.Name = "Tang";
            Tang.ReadOnly = true;
            // 
            // tenLoaiPhongDataGridViewTextBoxColumn
            // 
            tenLoaiPhongDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiPhong";
            tenLoaiPhongDataGridViewTextBoxColumn.HeaderText = "Loại";
            tenLoaiPhongDataGridViewTextBoxColumn.Name = "tenLoaiPhongDataGridViewTextBoxColumn";
            tenLoaiPhongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi Chú";
            GhiChu.Name = "GhiChu";
            GhiChu.ReadOnly = true;
            GhiChu.Visible = false;
            // 
            // loaiPhongIdDataGridViewTextBoxColumn
            // 
            loaiPhongIdDataGridViewTextBoxColumn.DataPropertyName = "LoaiPhongId";
            loaiPhongIdDataGridViewTextBoxColumn.HeaderText = "LoaiPhongId";
            loaiPhongIdDataGridViewTextBoxColumn.Name = "loaiPhongIdDataGridViewTextBoxColumn";
            loaiPhongIdDataGridViewTextBoxColumn.ReadOnly = true;
            loaiPhongIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            tenDataGridViewTextBoxColumn.ReadOnly = true;
            tenDataGridViewTextBoxColumn.Visible = false;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            trangThaiDataGridViewTextBoxColumn.Visible = false;
            // 
            // tangDataGridViewTextBoxColumn
            // 
            tangDataGridViewTextBoxColumn.DataPropertyName = "Tang";
            tangDataGridViewTextBoxColumn.HeaderText = "Tang";
            tangDataGridViewTextBoxColumn.Name = "tangDataGridViewTextBoxColumn";
            tangDataGridViewTextBoxColumn.ReadOnly = true;
            tangDataGridViewTextBoxColumn.Visible = false;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            ghiChuDataGridViewTextBoxColumn.Visible = false;
            // 
            // loaiPhongViewModelDataGridViewTextBoxColumn
            // 
            loaiPhongViewModelDataGridViewTextBoxColumn.DataPropertyName = "loaiPhongViewModel";
            loaiPhongViewModelDataGridViewTextBoxColumn.HeaderText = "loaiPhongViewModel";
            loaiPhongViewModelDataGridViewTextBoxColumn.Name = "loaiPhongViewModelDataGridViewTextBoxColumn";
            loaiPhongViewModelDataGridViewTextBoxColumn.ReadOnly = true;
            loaiPhongViewModelDataGridViewTextBoxColumn.Visible = false;
            // 
            // phieuDatPhongViewModelDataGridViewTextBoxColumn
            // 
            phieuDatPhongViewModelDataGridViewTextBoxColumn.DataPropertyName = "phieuDatPhongViewModel";
            phieuDatPhongViewModelDataGridViewTextBoxColumn.HeaderText = "phieuDatPhongViewModel";
            phieuDatPhongViewModelDataGridViewTextBoxColumn.Name = "phieuDatPhongViewModelDataGridViewTextBoxColumn";
            phieuDatPhongViewModelDataGridViewTextBoxColumn.ReadOnly = true;
            phieuDatPhongViewModelDataGridViewTextBoxColumn.Visible = false;
            // 
            // intHienTrangDataGridViewTextBoxColumn
            // 
            intHienTrangDataGridViewTextBoxColumn.DataPropertyName = "intHienTrang";
            intHienTrangDataGridViewTextBoxColumn.HeaderText = "intHienTrang";
            intHienTrangDataGridViewTextBoxColumn.Name = "intHienTrangDataGridViewTextBoxColumn";
            intHienTrangDataGridViewTextBoxColumn.ReadOnly = true;
            intHienTrangDataGridViewTextBoxColumn.Visible = false;
            // 
            // strHienTrangDataGridViewTextBoxColumn
            // 
            strHienTrangDataGridViewTextBoxColumn.DataPropertyName = "strHienTrang";
            strHienTrangDataGridViewTextBoxColumn.HeaderText = "strHienTrang";
            strHienTrangDataGridViewTextBoxColumn.Name = "strHienTrangDataGridViewTextBoxColumn";
            strHienTrangDataGridViewTextBoxColumn.ReadOnly = true;
            strHienTrangDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            statusDataGridViewTextBoxColumn.HeaderText = "status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // strshowCBBDataGridViewTextBoxColumn
            // 
            strshowCBBDataGridViewTextBoxColumn.DataPropertyName = "strshowCBB";
            strshowCBBDataGridViewTextBoxColumn.HeaderText = "strshowCBB";
            strshowCBBDataGridViewTextBoxColumn.Name = "strshowCBBDataGridViewTextBoxColumn";
            strshowCBBDataGridViewTextBoxColumn.ReadOnly = true;
            strshowCBBDataGridViewTextBoxColumn.Visible = false;
            // 
            // strTrangThaiDataGridViewTextBoxColumn
            // 
            strTrangThaiDataGridViewTextBoxColumn.DataPropertyName = "strTrangThai";
            strTrangThaiDataGridViewTextBoxColumn.HeaderText = "strTrangThai";
            strTrangThaiDataGridViewTextBoxColumn.Name = "strTrangThaiDataGridViewTextBoxColumn";
            strTrangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            strTrangThaiDataGridViewTextBoxColumn.Visible = false;
            // 
            // ucBackColorDataGridViewTextBoxColumn
            // 
            ucBackColorDataGridViewTextBoxColumn.DataPropertyName = "ucBackColor";
            ucBackColorDataGridViewTextBoxColumn.HeaderText = "ucBackColor";
            ucBackColorDataGridViewTextBoxColumn.Name = "ucBackColorDataGridViewTextBoxColumn";
            ucBackColorDataGridViewTextBoxColumn.ReadOnly = true;
            ucBackColorDataGridViewTextBoxColumn.Visible = false;
            // 
            // pnlBackColorDataGridViewTextBoxColumn
            // 
            pnlBackColorDataGridViewTextBoxColumn.DataPropertyName = "pnlBackColor";
            pnlBackColorDataGridViewTextBoxColumn.HeaderText = "pnlBackColor";
            pnlBackColorDataGridViewTextBoxColumn.Name = "pnlBackColorDataGridViewTextBoxColumn";
            pnlBackColorDataGridViewTextBoxColumn.ReadOnly = true;
            pnlBackColorDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmQLPhong
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1517, 950);
            Controls.Add(dgvQLPhong);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmQLPhong";
            Text = "FrmQLPhong_1";
            ((System.ComponentModel.ISupportInitialize)PhongViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLPhong).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label7;
        private BindingSource PhongViewModelBindingSource;
        private Panel panel4;
        private Label label5;
        private Panel panel5;
        private Label label8;
        private Label label12;
        private Label label6;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private MetroFramework.Controls.MetroGrid dgvQLPhong;
        private TextBox txbSearch;
        private Button btnLoad;
        private Label label13;
        private Panel panel8;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Panel panel1;
        private Panel panel6;
        private Label label9;
        private Panel panel9;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn Tang;
        private DataGridViewTextBoxColumn tenLoaiPhongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn GhiChu;
        private DataGridViewTextBoxColumn loaiPhongIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loaiPhongViewModelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phieuDatPhongViewModelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn intHienTrangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn strHienTrangDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn strshowCBBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn strTrangThaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ucBackColorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pnlBackColorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}