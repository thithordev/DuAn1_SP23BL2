﻿namespace C_GUI.Views
{
    partial class FrmHoaDon
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
            BindingSource1 = new BindingSource(components);
            panel6 = new Panel();
            label12 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            label9 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            txb_timkiem = new TextBox();
            pictureBox1 = new PictureBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            panel8 = new Panel();
            button1 = new Button();
            dgvLoaiPhong = new MetroFramework.Controls.MetroGrid();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tongTienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BindingSource1).BeginInit();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonShadow;
            panel7.Controls.Add(label11);
            panel7.Location = new Point(20, 590);
            panel7.Name = "panel7";
            panel7.Size = new Size(449, 168);
            panel7.TabIndex = 2;
            // 
            // label11
            // 
            label11.DataBindings.Add(new Binding("Text", BindingSource1, "GhiChu", true));
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(16, 13);
            label11.Name = "label11";
            label11.Size = new Size(428, 144);
            label11.TabIndex = 0;
            label11.Text = "label3";
            // 
            // BindingSource1
            // 
            BindingSource1.DataSource = typeof(B_BUS.ViewModels.HoaDonViewModel);
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonShadow;
            panel6.Controls.Add(label12);
            panel6.Location = new Point(20, 474);
            panel6.Name = "panel6";
            panel6.Size = new Size(449, 52);
            panel6.TabIndex = 2;
            // 
            // label12
            // 
            label12.DataBindings.Add(new Binding("Text", BindingSource1, "NgayThanhToan", true));
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(10, 8);
            label12.Name = "label12";
            label12.Size = new Size(428, 36);
            label12.TabIndex = 2;
            label12.Text = "label3";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(997, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 777);
            panel1.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonShadow;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(20, 362);
            panel5.Name = "panel5";
            panel5.Size = new Size(449, 52);
            panel5.TabIndex = 2;
            // 
            // label9
            // 
            label9.DataBindings.Add(new Binding("Text", BindingSource1, "NgayTao", true));
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(10, 8);
            label9.Name = "label9";
            label9.Size = new Size(428, 36);
            label9.TabIndex = 1;
            label9.Text = "label3";
            // 
            // label7
            // 
            label7.DataBindings.Add(new Binding("Text", BindingSource1, "TongTien", true));
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 9);
            label7.Name = "label7";
            label7.Size = new Size(428, 36);
            label7.TabIndex = 0;
            label7.Text = "label3";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(20, 246);
            panel4.Name = "panel4";
            panel4.Size = new Size(449, 52);
            panel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.DataBindings.Add(new Binding("Text", BindingSource1, "TenDayDu_NV", true));
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 9);
            label5.Name = "label5";
            label5.Size = new Size(428, 36);
            label5.TabIndex = 0;
            label5.Text = "label3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(20, 545);
            label10.Name = "label10";
            label10.Size = new Size(114, 32);
            label10.TabIndex = 1;
            label10.Text = "Ghi chú :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(20, 429);
            label8.Name = "label8";
            label8.Size = new Size(219, 32);
            label8.TabIndex = 1;
            label8.Text = "Ngày thanh toán :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 317);
            label6.Name = "label6";
            label6.Size = new Size(132, 32);
            label6.TabIndex = 1;
            label6.Text = "Ngày tạo :";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonShadow;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(17, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 52);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.DataBindings.Add(new Binding("Text", BindingSource1, "TenDayDu_KH", true));
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 9);
            label3.Name = "label3";
            label3.Size = new Size(428, 36);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 201);
            label4.Name = "label4";
            label4.Size = new Size(187, 32);
            label4.TabIndex = 1;
            label4.Text = "Tên nhân viên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 87);
            label2.Name = "label2";
            label2.Size = new Size(205, 32);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 62, 80);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(483, 65);
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
            // txb_timkiem
            // 
            txb_timkiem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txb_timkiem.Location = new Point(55, 51);
            txb_timkiem.Name = "txb_timkiem";
            txb_timkiem.Size = new Size(269, 39);
            txb_timkiem.TabIndex = 2;
            txb_timkiem.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_search1;
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
            panel8.Controls.Add(txb_timkiem);
            panel8.Controls.Add(pictureBox1);
            panel8.Controls.Add(btnThem);
            panel8.Controls.Add(button1);
            panel8.Controls.Add(btnXoa);
            panel8.Controls.Add(btnSua);
            panel8.Location = new Point(37, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1443, 109);
            panel8.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 188, 156);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(992, 45);
            button1.Name = "button1";
            button1.Size = new Size(171, 50);
            button1.TabIndex = 2;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.AllowUserToAddRows = false;
            dgvLoaiPhong.AllowUserToDeleteRows = false;
            dgvLoaiPhong.AllowUserToResizeRows = false;
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
            dgvLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, tongTienDataGridViewTextBoxColumn });
            dgvLoaiPhong.DataSource = BindingSource1;
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
            dgvLoaiPhong.Location = new Point(38, 147);
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
            dgvLoaiPhong.Size = new Size(937, 777);
            dgvLoaiPhong.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Mã HD";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
<<<<<<< HEAD
            tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            tongTienDataGridViewTextBoxColumn.ReadOnly = true;
=======
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "StrTongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.ReadOnly = true;
>>>>>>> GopFormHieu
            // 
            // FrmHoaDon
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1517, 950);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(dgvLoaiPhong);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmHoaDon";
            Text = "Form1";
            Load += FrmHoaDon_Load;
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BindingSource1).EndInit();
            panel6.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox6;
        private Label label6;
        private Label label13;
        private Label label26;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn cl_loai;
        private DataGridViewTextBoxColumn cl_songuoi;
        private DataGridViewTextBoxColumn cl_gia;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label18;
        private Label label22;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label23;
        private Label label24;
        private Label label25;

        //private Label label1;

        private Label label27;
        private Panel panel7;
        private Label label11;
        private Panel panel6;
        private Panel panel1;
        private Panel panel5;
        private Label label7;
        private Panel panel4;
        private Label label5;
        private Label label10;
        private Label label8;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private TextBox txb_timkiem;
        private PictureBox pictureBox1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Panel panel8;
        private Button button1;
        private MetroFramework.Controls.MetroGrid dgvLoaiPhong;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private BindingSource BindingSource1;
        private Label label12;
        private Label label9;
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trangThai1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
    }
}