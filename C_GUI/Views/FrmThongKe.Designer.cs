namespace C_GUI.Views
{
    partial class FrmThongKe
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            dtpk_time = new DateTimePicker();
            label1 = new Label();
            panel3 = new Panel();
            lbTongDoanhThu = new Label();
            label7 = new Label();
            panel4 = new Panel();
            lbTongThu = new Label();
            label10 = new Label();
            panel5 = new Panel();
            lbTongChi = new Label();
            label12 = new Label();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            dgvTongThu = new MetroFramework.Controls.MetroGrid();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dgvLoaiPhong = new MetroFramework.Controls.MetroGrid();
            NgayTao = new DataGridViewTextBoxColumn();
            SoTien = new DataGridViewTextBoxColumn();
            metroPanel2 = new MetroFramework.Controls.MetroPanel();
            dgvTongChi = new MetroFramework.Controls.MetroGrid();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            metroGrid3 = new MetroFramework.Controls.MetroGrid();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTongThu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTongChi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)metroGrid3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpk_time);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1517, 88);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(1415, 8);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Thời gian";
            // 
            // dtpk_time
            // 
            dtpk_time.CustomFormat = " yyyy";
            dtpk_time.Format = DateTimePickerFormat.Custom;
            dtpk_time.Location = new Point(1396, 39);
            dtpk_time.Name = "dtpk_time";
            dtpk_time.Size = new Size(94, 32);
            dtpk_time.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 1;
            label1.Text = "Thống kê doanh thu";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(46, 204, 113);
            panel3.Controls.Add(lbTongDoanhThu);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(591, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 152);
            panel3.TabIndex = 1;
            // 
            // lbTongDoanhThu
            // 
            lbTongDoanhThu.AutoSize = true;
            lbTongDoanhThu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongDoanhThu.ForeColor = Color.White;
            lbTongDoanhThu.Location = new Point(48, 54);
            lbTongDoanhThu.Name = "lbTongDoanhThu";
            lbTongDoanhThu.Size = new Size(278, 65);
            lbTongDoanhThu.TabIndex = 1;
            lbTongDoanhThu.Text = "28,000,000";
            lbTongDoanhThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(103, 18);
            label7.Name = "label7";
            label7.Size = new Size(148, 25);
            label7.TabIndex = 0;
            label7.Text = "Tổng doanh thu";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(230, 126, 34);
            panel4.Controls.Add(lbTongThu);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(160, 151);
            panel4.Name = "panel4";
            panel4.Size = new Size(361, 152);
            panel4.TabIndex = 2;
            // 
            // lbTongThu
            // 
            lbTongThu.AutoSize = true;
            lbTongThu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongThu.ForeColor = Color.White;
            lbTongThu.Location = new Point(55, 54);
            lbTongThu.Name = "lbTongThu";
            lbTongThu.Size = new Size(56, 65);
            lbTongThu.TabIndex = 3;
            lbTongThu.Text = "0";
            lbTongThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(136, 18);
            label10.Name = "label10";
            label10.Size = new Size(89, 25);
            label10.TabIndex = 2;
            label10.Text = "Tổng thu";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 152, 219);
            panel5.Controls.Add(lbTongChi);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(1017, 151);
            panel5.Name = "panel5";
            panel5.Size = new Size(339, 152);
            panel5.TabIndex = 3;
            // 
            // lbTongChi
            // 
            lbTongChi.AutoSize = true;
            lbTongChi.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongChi.ForeColor = Color.White;
            lbTongChi.Location = new Point(55, 54);
            lbTongChi.Name = "lbTongChi";
            lbTongChi.Size = new Size(56, 65);
            lbTongChi.TabIndex = 5;
            lbTongChi.Text = "0";
            lbTongChi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(128, 18);
            label12.Name = "label12";
            label12.Size = new Size(82, 25);
            label12.TabIndex = 4;
            label12.Text = "tổng chi";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(dgvTongThu);
            metroPanel1.Controls.Add(dgvLoaiPhong);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(160, 350);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(577, 533);
            metroPanel1.TabIndex = 5;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dgvTongThu
            // 
            dgvTongThu.AllowUserToAddRows = false;
            dgvTongThu.AllowUserToDeleteRows = false;
            dgvTongThu.AllowUserToResizeRows = false;
            dgvTongThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTongThu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTongThu.BackgroundColor = SystemColors.Control;
            dgvTongThu.BorderStyle = BorderStyle.Fixed3D;
            dgvTongThu.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTongThu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTongThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTongThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTongThu.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, NoiDung, dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTongThu.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTongThu.Dock = DockStyle.Fill;
            dgvTongThu.EnableHeadersVisualStyles = false;
            dgvTongThu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvTongThu.GridColor = Color.FromArgb(255, 255, 255);
            dgvTongThu.Location = new Point(0, 0);
            dgvTongThu.Name = "dgvTongThu";
            dgvTongThu.ReadOnly = true;
            dgvTongThu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTongThu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTongThu.RowHeadersVisible = false;
            dgvTongThu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTongThu.RowTemplate.Height = 25;
            dgvTongThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTongThu.Size = new Size(577, 533);
            dgvTongThu.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ngày Tạo";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // NoiDung
            // 
            NoiDung.HeaderText = "Nội Dung";
            NoiDung.Name = "NoiDung";
            NoiDung.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Số Tiền";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.AllowUserToAddRows = false;
            dgvLoaiPhong.AllowUserToDeleteRows = false;
            dgvLoaiPhong.AllowUserToResizeRows = false;
            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiPhong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoaiPhong.BackgroundColor = SystemColors.Control;
            dgvLoaiPhong.BorderStyle = BorderStyle.Fixed3D;
            dgvLoaiPhong.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvLoaiPhong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { NgayTao, SoTien });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvLoaiPhong.DefaultCellStyle = dataGridViewCellStyle5;
            dgvLoaiPhong.Dock = DockStyle.Fill;
            dgvLoaiPhong.EnableHeadersVisualStyles = false;
            dgvLoaiPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvLoaiPhong.GridColor = Color.FromArgb(255, 255, 255);
            dgvLoaiPhong.Location = new Point(0, 0);
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.ReadOnly = true;
            dgvLoaiPhong.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvLoaiPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvLoaiPhong.RowHeadersVisible = false;
            dgvLoaiPhong.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvLoaiPhong.RowTemplate.Height = 25;
            dgvLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiPhong.Size = new Size(577, 533);
            dgvLoaiPhong.TabIndex = 11;
            // 
            // NgayTao
            // 
            NgayTao.HeaderText = "Ngày Tạo";
            NgayTao.Name = "NgayTao";
            NgayTao.ReadOnly = true;
            // 
            // SoTien
            // 
            SoTien.HeaderText = "Số Tiền";
            SoTien.Name = "SoTien";
            SoTien.ReadOnly = true;
            // 
            // metroPanel2
            // 
            metroPanel2.Controls.Add(dgvTongChi);
            metroPanel2.Controls.Add(metroGrid3);
            metroPanel2.HorizontalScrollbarBarColor = true;
            metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel2.HorizontalScrollbarSize = 10;
            metroPanel2.Location = new Point(779, 350);
            metroPanel2.Name = "metroPanel2";
            metroPanel2.Size = new Size(577, 533);
            metroPanel2.TabIndex = 13;
            metroPanel2.VerticalScrollbarBarColor = true;
            metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dgvTongChi
            // 
            dgvTongChi.AllowUserToAddRows = false;
            dgvTongChi.AllowUserToDeleteRows = false;
            dgvTongChi.AllowUserToResizeRows = false;
            dgvTongChi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTongChi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTongChi.BackgroundColor = SystemColors.Control;
            dgvTongChi.BorderStyle = BorderStyle.Fixed3D;
            dgvTongChi.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTongChi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvTongChi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvTongChi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTongChi.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn7 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvTongChi.DefaultCellStyle = dataGridViewCellStyle8;
            dgvTongChi.Dock = DockStyle.Fill;
            dgvTongChi.EnableHeadersVisualStyles = false;
            dgvTongChi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvTongChi.GridColor = Color.FromArgb(255, 255, 255);
            dgvTongChi.Location = new Point(0, 0);
            dgvTongChi.Name = "dgvTongChi";
            dgvTongChi.ReadOnly = true;
            dgvTongChi.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvTongChi.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvTongChi.RowHeadersVisible = false;
            dgvTongChi.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTongChi.RowTemplate.Height = 25;
            dgvTongChi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTongChi.Size = new Size(577, 533);
            dgvTongChi.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Ngày Tạo";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Nội Dung";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Số Tiền";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // metroGrid3
            // 
            metroGrid3.AllowUserToAddRows = false;
            metroGrid3.AllowUserToDeleteRows = false;
            metroGrid3.AllowUserToResizeRows = false;
            metroGrid3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            metroGrid3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            metroGrid3.BackgroundColor = SystemColors.Control;
            metroGrid3.BorderStyle = BorderStyle.Fixed3D;
            metroGrid3.CellBorderStyle = DataGridViewCellBorderStyle.None;
            metroGrid3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle10.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            metroGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            metroGrid3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            metroGrid3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            metroGrid3.DefaultCellStyle = dataGridViewCellStyle11;
            metroGrid3.Dock = DockStyle.Fill;
            metroGrid3.EnableHeadersVisualStyles = false;
            metroGrid3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            metroGrid3.GridColor = Color.FromArgb(255, 255, 255);
            metroGrid3.Location = new Point(0, 0);
            metroGrid3.Name = "metroGrid3";
            metroGrid3.ReadOnly = true;
            metroGrid3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            metroGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            metroGrid3.RowHeadersVisible = false;
            metroGrid3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            metroGrid3.RowTemplate.Height = 25;
            metroGrid3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            metroGrid3.Size = new Size(577, 533);
            metroGrid3.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Ngày Tạo";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Số Tiền";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1517, 950);
            Controls.Add(metroPanel2);
            Controls.Add(metroPanel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmThongKe";
            Text = "FrmThongKe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTongThu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTongChi).EndInit();
            ((System.ComponentModel.ISupportInitialize)metroGrid3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label7;
        private Label lbTongDoanhThu;
        private Label lbTongThu;
        private Label label10;
        private Label lbTongChi;
        private Label label12;
        private Label label2;
        private DateTimePicker dtpk_time;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgvTongThu;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MetroFramework.Controls.MetroGrid dgvLoaiPhong;
        private DataGridViewTextBoxColumn NgayTao;
        private DataGridViewTextBoxColumn SoTien;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid dgvTongChi;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private MetroFramework.Controls.MetroGrid metroGrid3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}