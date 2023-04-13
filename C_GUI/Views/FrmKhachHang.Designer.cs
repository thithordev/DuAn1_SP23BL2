﻿namespace C_GUI.Views
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel7 = new Panel();
            label11 = new Label();
            khachHangViewModelBindingSource = new BindingSource(components);
            panel1 = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label10 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            txbSearch = new TextBox();
            pictureBox1 = new PictureBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            panel8 = new Panel();
            btn_Load = new Button();
            dgvLoaiPhong = new MetroFramework.Controls.MetroGrid();
            tenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sDTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaySinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaChiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)khachHangViewModelBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonShadow;
            panel7.Controls.Add(label11);
            panel7.Location = new Point(20, 486);
            panel7.Name = "panel7";
            panel7.Size = new Size(533, 168);
            panel7.TabIndex = 2;
            // 
            // label11
            // 
            label11.DataBindings.Add(new Binding("Text", khachHangViewModelBindingSource, "GhiChu", true));
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(16, 13);
            label11.Name = "label11";
            label11.Size = new Size(501, 144);
            label11.TabIndex = 0;
            label11.Text = "label3";
            // 
            // khachHangViewModelBindingSource
            // 
            khachHangViewModelBindingSource.DataSource = typeof(B_BUS.ViewModels.KhachHangViewModel);
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(907, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 777);
            panel1.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonShadow;
            panel5.Controls.Add(label7);
            panel5.Location = new Point(20, 362);
            panel5.Name = "panel5";
            panel5.Size = new Size(533, 52);
            panel5.TabIndex = 2;
            // 
            // label7
            // 
            label7.DataBindings.Add(new Binding("Text", khachHangViewModelBindingSource, "TrangThai", true));
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
            label5.DataBindings.Add(new Binding("Text", khachHangViewModelBindingSource, "strGioiTinh", true));
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 9);
            label5.Name = "label5";
            label5.Size = new Size(501, 36);
            label5.TabIndex = 0;
            label5.Text = "label3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(20, 441);
            label10.Name = "label10";
            label10.Size = new Size(107, 32);
            label10.TabIndex = 1;
            label10.Text = "Ghi chú:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 317);
            label6.Name = "label6";
            label6.Size = new Size(136, 32);
            label6.TabIndex = 1;
            label6.Text = "Trạng thái:";
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
            label3.DataBindings.Add(new Binding("Text", khachHangViewModelBindingSource, "CCCD", true));
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
            label4.Size = new Size(119, 32);
            label4.TabIndex = 1;
            label4.Text = "Giới tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 87);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 1;
            label2.Text = "CCCD:";
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
            // txbSearch
            // 
            txbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txbSearch.Location = new Point(55, 51);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(269, 39);
            txbSearch.TabIndex = 2;
            txbSearch.KeyPress += txbSearch_KeyPress;
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
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(44, 62, 80);
            panel8.Controls.Add(txbSearch);
            panel8.Controls.Add(pictureBox1);
            panel8.Controls.Add(btnThem);
            panel8.Controls.Add(btn_Load);
            panel8.Controls.Add(btnXoa);
            panel8.Controls.Add(btnSua);
            panel8.Location = new Point(37, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1443, 109);
            panel8.TabIndex = 12;
            // 
            // btn_Load
            // 
            btn_Load.BackColor = Color.FromArgb(26, 188, 156);
            btn_Load.FlatAppearance.BorderSize = 0;
            btn_Load.FlatStyle = FlatStyle.Flat;
            btn_Load.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Load.ForeColor = Color.White;
            btn_Load.Location = new Point(992, 45);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(171, 50);
            btn_Load.TabIndex = 2;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = false;
            btn_Load.Click += btn_Load_Click;
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.AllowUserToAddRows = false;
            dgvLoaiPhong.AllowUserToDeleteRows = false;
            dgvLoaiPhong.AllowUserToOrderColumns = true;
            dgvLoaiPhong.AllowUserToResizeRows = false;
            dgvLoaiPhong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dgvLoaiPhong.AutoGenerateColumns = false;
            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiPhong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoaiPhong.BackgroundColor = SystemColors.Control;
            dgvLoaiPhong.BorderStyle = BorderStyle.Fixed3D;
            dgvLoaiPhong.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvLoaiPhong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { tenDataGridViewTextBoxColumn, sDTDataGridViewTextBoxColumn, ngaySinhDataGridViewTextBoxColumn, diaChiDataGridViewTextBoxColumn });
            dgvLoaiPhong.DataSource = khachHangViewModelBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLoaiPhong.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLoaiPhong.EnableHeadersVisualStyles = false;
            dgvLoaiPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvLoaiPhong.GridColor = Color.FromArgb(255, 255, 255);
            dgvLoaiPhong.Location = new Point(37, 147);
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.ReadOnly = true;
            dgvLoaiPhong.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLoaiPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLoaiPhong.RowHeadersVisible = false;
            dgvLoaiPhong.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvLoaiPhong.RowTemplate.Height = 25;
            dgvLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiPhong.Size = new Size(837, 777);
            dgvLoaiPhong.TabIndex = 10;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            tenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            sDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmKhachHang
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1517, 950);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(dgvLoaiPhong);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmKhachHang";
            Text = "FrmKhachHang";
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)khachHangViewModelBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
    }
}