namespace C_GUI.Views
{
    partial class FrmKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.khachHangViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Load = new System.Windows.Forms.Button();
            this.dgvLoaiPhong = new MetroFramework.Controls.MetroGrid();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangViewModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(20, 486);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(533, 168);
            this.panel7.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangViewModelBindingSource, "GhiChu", true));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(501, 144);
            this.label11.TabIndex = 0;
            this.label11.Text = "label3";
            // 
            // khachHangViewModelBindingSource
            // 
            this.khachHangViewModelBindingSource.DataSource = typeof(B_BUS.ViewModels.KhachHangViewModel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(907, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 777);
            this.panel1.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(20, 362);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(533, 52);
            this.panel5.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangViewModelBindingSource, "Id", true));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(501, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "label3";
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
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangViewModelBindingSource, "strGioiTinh", true));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(501, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "label3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(20, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID:";
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
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangViewModelBindingSource, "CCCD", true));
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
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "CCCD:";
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
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSearch.Location = new System.Drawing.Point(55, 51);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(269, 39);
            this.txbSearch.TabIndex = 2;
            this.txbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearch_KeyPress);
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
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel8.Controls.Add(this.txbSearch);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.btnThem);
            this.panel8.Controls.Add(this.btn_Load);
            this.panel8.Controls.Add(this.btnXoa);
            this.panel8.Controls.Add(this.btnSua);
            this.panel8.Location = new System.Drawing.Point(37, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1443, 109);
            this.panel8.TabIndex = 12;
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Load.FlatAppearance.BorderSize = 0;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Load.ForeColor = System.Drawing.Color.White;
            this.btn_Load.Location = new System.Drawing.Point(992, 45);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(171, 50);
            this.btn_Load.TabIndex = 2;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AllowUserToAddRows = false;
            this.dgvLoaiPhong.AllowUserToDeleteRows = false;
            this.dgvLoaiPhong.AllowUserToOrderColumns = true;
            this.dgvLoaiPhong.AllowUserToResizeRows = false;
            this.dgvLoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLoaiPhong.AutoGenerateColumns = false;
            this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoaiPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLoaiPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLoaiPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.CCCD,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn});
            this.dgvLoaiPhong.DataSource = this.khachHangViewModelBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiPhong.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvLoaiPhong.EnableHeadersVisualStyles = false;
            this.dgvLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvLoaiPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLoaiPhong.Location = new System.Drawing.Point(37, 147);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.ReadOnly = true;
            this.dgvLoaiPhong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvLoaiPhong.RowHeadersVisible = false;
            this.dgvLoaiPhong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLoaiPhong.RowTemplate.Height = 25;
            this.dgvLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(837, 777);
            this.dgvLoaiPhong.TabIndex = 10;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "HoTenKhach";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1517, 950);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dgvLoaiPhong);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangViewModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel7;
        private Label label11;
        private Panel panel1;
        private Panel panel5;
        private Label label7;
        private Panel panel4;
        private Label label5;
        private Label label10;
        private Label label6;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private TextBox txbSearch;
        private PictureBox pictureBox1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Panel panel8;
        private Button btn_Load;
        private MetroFramework.Controls.MetroGrid dgvLoaiPhong;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private BindingSource khachHangViewModelBindingSource;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
    }
}