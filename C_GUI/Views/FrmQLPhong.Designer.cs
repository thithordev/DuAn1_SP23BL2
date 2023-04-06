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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.loaiPhongViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoaiPhong = new MetroFramework.Controls.MetroGrid();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGiuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaGioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNgayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongViewModelBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
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
            // label7
            // 
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongViewModelBindingSource, "StrGiaNgay", true));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(501, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "label3";
            // 
            // loaiPhongViewModelBindingSource
            // 
            this.loaiPhongViewModelBindingSource.DataSource = typeof(B_BUS.ViewModels.LoaiPhongViewModel);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(20, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(533, 52);
            this.panel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongViewModelBindingSource, "OToiDa", true));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(501, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "label3";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(20, 468);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(533, 52);
            this.panel5.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(20, 637);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mô tả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(20, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giá giờ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(20, 533);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "Giá đêm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giá ngày:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(20, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 52);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongViewModelBindingSource, "Ten", true));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ở tối đa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
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
            this.dgvLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLoaiPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLoaiPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDataGridViewTextBoxColumn,
            this.soGiuongDataGridViewTextBoxColumn,
            this.giaGioDataGridViewTextBoxColumn,
            this.giaNgayDataGridViewTextBoxColumn,
            this.giaDemDataGridViewTextBoxColumn,
            this.motaDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dgvLoaiPhong.DataSource = this.loaiPhongViewModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soGiuongDataGridViewTextBoxColumn
            // 
            this.soGiuongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soGiuongDataGridViewTextBoxColumn.DataPropertyName = "OToiDa";
            this.soGiuongDataGridViewTextBoxColumn.HeaderText = "Ở TĐ";
            this.soGiuongDataGridViewTextBoxColumn.Name = "soGiuongDataGridViewTextBoxColumn";
            this.soGiuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soGiuongDataGridViewTextBoxColumn.Width = 102;
            // 
            // giaGioDataGridViewTextBoxColumn
            // 
            this.giaGioDataGridViewTextBoxColumn.DataPropertyName = "StrGiaGio";
            this.giaGioDataGridViewTextBoxColumn.HeaderText = "Giá Giờ";
            this.giaGioDataGridViewTextBoxColumn.Name = "giaGioDataGridViewTextBoxColumn";
            this.giaGioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaNgayDataGridViewTextBoxColumn
            // 
            this.giaNgayDataGridViewTextBoxColumn.DataPropertyName = "StrGiaNgay";
            this.giaNgayDataGridViewTextBoxColumn.HeaderText = "Giá Ngày";
            this.giaNgayDataGridViewTextBoxColumn.Name = "giaNgayDataGridViewTextBoxColumn";
            this.giaNgayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaDemDataGridViewTextBoxColumn
            // 
            this.giaDemDataGridViewTextBoxColumn.DataPropertyName = "StrGiaDem";
            this.giaDemDataGridViewTextBoxColumn.HeaderText = "Giá Đêm";
            this.giaDemDataGridViewTextBoxColumn.Name = "giaDemDataGridViewTextBoxColumn";
            this.giaDemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motaDataGridViewTextBoxColumn
            // 
            this.motaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.motaDataGridViewTextBoxColumn.DataPropertyName = "Mota";
            this.motaDataGridViewTextBoxColumn.HeaderText = "Mô Tả";
            this.motaDataGridViewTextBoxColumn.Name = "motaDataGridViewTextBoxColumn";
            this.motaDataGridViewTextBoxColumn.ReadOnly = true;
            this.motaDataGridViewTextBoxColumn.Visible = false;
            this.motaDataGridViewTextBoxColumn.Width = 222;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.Location = new System.Drawing.Point(55, 51);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(269, 39);
            this.txbSearch.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(992, 45);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(171, 50);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongViewModelBindingSource, "StrGiaDem", true));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(16, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(501, 36);
            this.label13.TabIndex = 0;
            this.label13.Text = "label3";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel8.Controls.Add(this.txbSearch);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.btnThem);
            this.panel8.Controls.Add(this.btnLoad);
            this.panel8.Controls.Add(this.btnXoa);
            this.panel8.Controls.Add(this.btnSua);
            this.panel8.Location = new System.Drawing.Point(37, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1443, 109);
            this.panel8.TabIndex = 9;
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
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(791, 45);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(171, 50);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(577, 45);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(171, 50);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
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
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(20, 683);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(533, 75);
            this.panel7.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongViewModelBindingSource, "Mota", true));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(501, 74);
            this.label11.TabIndex = 0;
            this.label11.Text = "label3";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(20, 360);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(533, 52);
            this.panel6.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loaiPhongViewModelBindingSource, "StrGiaGio", true));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(501, 36);
            this.label9.TabIndex = 0;
            this.label9.Text = "label3";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel9.Controls.Add(this.label13);
            this.panel9.Location = new System.Drawing.Point(20, 578);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(533, 52);
            this.panel9.TabIndex = 2;
            // 
            // FrmQLPhong_1
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmQLPhong_1";
            this.Text = "FrmQLPhong_1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongViewModelBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label7;
        private BindingSource loaiPhongViewModelBindingSource;
        private Panel panel4;
        private Label label5;
        private Panel panel5;
        private Label label10;
        private Label label8;
        private Label label12;
        private Label label6;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private MetroFramework.Controls.MetroGrid dgvLoaiPhong;
        private DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soGiuongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaGioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaNgayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private TextBox txbSearch;
        private Button btnLoad;
        private Label label13;
        private Panel panel8;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Panel panel1;
        private Panel panel7;
        private Label label11;
        private Panel panel6;
        private Label label9;
        private Panel panel9;
    }
}