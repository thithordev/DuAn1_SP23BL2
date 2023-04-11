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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            dtpk_time = new DateTimePicker();
            label1 = new Label();
            panel3 = new Panel();
            lb_tongdoanhthu = new Label();
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
            panel3.Controls.Add(lb_tongdoanhthu);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(591, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 152);
            panel3.TabIndex = 1;
            // 
            // lb_tongdoanhthu
            // 
            lb_tongdoanhthu.AutoSize = true;
            lb_tongdoanhthu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lb_tongdoanhthu.ForeColor = Color.White;
            lb_tongdoanhthu.Location = new Point(48, 54);
            lb_tongdoanhthu.Name = "lb_tongdoanhthu";
            lb_tongdoanhthu.Size = new Size(278, 65);
            lb_tongdoanhthu.TabIndex = 1;
            lb_tongdoanhthu.Text = "28,000,000";
            lb_tongdoanhthu.TextAlign = ContentAlignment.MiddleCenter;
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
            lbTongThu.Size = new Size(250, 65);
            lbTongThu.TabIndex = 3;
            lbTongThu.Text = "1,000,000";
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
            lbTongChi.Location = new Point(113, 54);
            lbTongChi.Name = "lbTongChi";
            lbTongChi.Size = new Size(112, 65);
            lbTongChi.TabIndex = 5;
            lbTongChi.Text = "100";
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle13.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvTongThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvTongThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTongThu.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, NoiDung, dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewCellStyle14.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvTongThu.DefaultCellStyle = dataGridViewCellStyle14;
            dgvTongThu.Dock = DockStyle.Fill;
            dgvTongThu.EnableHeadersVisualStyles = false;
            dgvTongThu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvTongThu.GridColor = Color.FromArgb(255, 255, 255);
            dgvTongThu.Location = new Point(0, 0);
            dgvTongThu.Name = "dgvTongThu";
            dgvTongThu.ReadOnly = true;
            dgvTongThu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvTongThu.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle16.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { NgayTao, SoTien });
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.Control;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = Color.Black;
            dataGridViewCellStyle17.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle17.SelectionForeColor = Color.White;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dgvLoaiPhong.DefaultCellStyle = dataGridViewCellStyle17;
            dgvLoaiPhong.Dock = DockStyle.Fill;
            dgvLoaiPhong.EnableHeadersVisualStyles = false;
            dgvLoaiPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvLoaiPhong.GridColor = Color.FromArgb(255, 255, 255);
            dgvLoaiPhong.Location = new Point(0, 0);
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.ReadOnly = true;
            dgvLoaiPhong.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Control;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dgvLoaiPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
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
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle19.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle19.SelectionForeColor = Color.White;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgvTongChi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgvTongChi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTongChi.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn7 });
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Control;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = Color.Black;
            dataGridViewCellStyle20.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle20.SelectionForeColor = Color.White;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            dgvTongChi.DefaultCellStyle = dataGridViewCellStyle20;
            dgvTongChi.Dock = DockStyle.Fill;
            dgvTongChi.EnableHeadersVisualStyles = false;
            dgvTongChi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvTongChi.GridColor = Color.FromArgb(255, 255, 255);
            dgvTongChi.Location = new Point(0, 0);
            dgvTongChi.Name = "dgvTongChi";
            dgvTongChi.ReadOnly = true;
            dgvTongChi.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = SystemColors.Control;
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle21.SelectionForeColor = Color.White;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dgvTongChi.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
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
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle22.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle22.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle22.SelectionForeColor = Color.White;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            metroGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            metroGrid3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            metroGrid3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = SystemColors.Control;
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = Color.Black;
            dataGridViewCellStyle23.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle23.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle23.SelectionForeColor = Color.White;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            metroGrid3.DefaultCellStyle = dataGridViewCellStyle23;
            metroGrid3.Dock = DockStyle.Fill;
            metroGrid3.EnableHeadersVisualStyles = false;
            metroGrid3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            metroGrid3.GridColor = Color.FromArgb(255, 255, 255);
            metroGrid3.Location = new Point(0, 0);
            metroGrid3.Name = "metroGrid3";
            metroGrid3.ReadOnly = true;
            metroGrid3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = SystemColors.Control;
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle24.ForeColor = Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle24.SelectionForeColor = Color.White;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            metroGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
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
        private Label lb_tongdoanhthu;
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