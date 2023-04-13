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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel4 = new Panel();
            lbTongThu = new Label();
            label10 = new Label();
            panel5 = new Panel();
            lbTongChi = new Label();
            label12 = new Label();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            dgvTongThu = new MetroFramework.Controls.MetroGrid();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Loai = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dgvLoaiPhong = new MetroFramework.Controls.MetroGrid();
            NgayTao = new DataGridViewTextBoxColumn();
            SoTien = new DataGridViewTextBoxColumn();
            label7 = new Label();
            lbTongDoanhThu = new Label();
            panel3 = new Panel();
            label3 = new Label();
            btnLoad = new Button();
            label2 = new Label();
            label4 = new Label();
            dtpk_TuNgay = new DateTimePicker();
            dtpk_DenNgay = new DateTimePicker();
            btnLoc = new Button();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTongThu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(230, 126, 34);
            panel4.Controls.Add(lbTongThu);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(160, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(361, 152);
            panel4.TabIndex = 2;
            // 
            // lbTongThu
            // 
            lbTongThu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongThu.ForeColor = Color.White;
            lbTongThu.Location = new Point(0, 55);
            lbTongThu.Name = "lbTongThu";
            lbTongThu.Size = new Size(358, 65);
            lbTongThu.TabIndex = 3;
            lbTongThu.Text = "0";
            lbTongThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(137, 18);
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
            panel5.Location = new Point(604, 40);
            panel5.Name = "panel5";
            panel5.Size = new Size(339, 152);
            panel5.TabIndex = 3;
            // 
            // lbTongChi
            // 
            lbTongChi.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongChi.ForeColor = Color.White;
            lbTongChi.Location = new Point(3, 55);
            lbTongChi.Name = "lbTongChi";
            lbTongChi.Size = new Size(339, 65);
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
            label12.Size = new Size(85, 25);
            label12.TabIndex = 4;
            label12.Text = "Tổng chi";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(dgvTongThu);
            metroPanel1.Controls.Add(dgvLoaiPhong);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(43, 301);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(1419, 610);
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
            dgvTongThu.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Loai, NoiDung, dataGridViewTextBoxColumn8 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTongThu.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTongThu.Dock = DockStyle.Fill;
            dgvTongThu.EnableHeadersVisualStyles = false;
            dgvTongThu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvTongThu.GridColor = Color.FromArgb(255, 255, 255);
            dgvTongThu.Location = new Point(0, 0);
            dgvTongThu.Name = "dgvTongThu";
            dgvTongThu.ReadOnly = true;
            dgvTongThu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTongThu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvTongThu.RowHeadersVisible = false;
            dgvTongThu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTongThu.RowTemplate.Height = 25;
            dgvTongThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTongThu.Size = new Size(1419, 610);
            dgvTongThu.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ngày Tạo";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Loai
            // 
            Loai.FillWeight = 40F;
            Loai.HeaderText = "Loại";
            Loai.Name = "Loai";
            Loai.ReadOnly = true;
            // 
            // NoiDung
            // 
            NoiDung.FillWeight = 200F;
            NoiDung.HeaderText = "Nội Dung";
            NoiDung.Name = "NoiDung";
            NoiDung.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn8.HeaderText = "Số Tiền";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Padding = new Padding(0, 12, 0, 12);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { NgayTao, SoTien });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvLoaiPhong.DefaultCellStyle = dataGridViewCellStyle6;
            dgvLoaiPhong.Dock = DockStyle.Fill;
            dgvLoaiPhong.EnableHeadersVisualStyles = false;
            dgvLoaiPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvLoaiPhong.GridColor = Color.FromArgb(255, 255, 255);
            dgvLoaiPhong.Location = new Point(0, 0);
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.ReadOnly = true;
            dgvLoaiPhong.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvLoaiPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvLoaiPhong.RowHeadersVisible = false;
            dgvLoaiPhong.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvLoaiPhong.RowTemplate.Height = 25;
            dgvLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiPhong.Size = new Size(1419, 610);
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
            // lbTongDoanhThu
            // 
            lbTongDoanhThu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongDoanhThu.ForeColor = Color.White;
            lbTongDoanhThu.Location = new Point(3, 55);
            lbTongDoanhThu.Name = "lbTongDoanhThu";
            lbTongDoanhThu.Size = new Size(350, 65);
            lbTongDoanhThu.TabIndex = 1;
            lbTongDoanhThu.Text = "0";
            lbTongDoanhThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(46, 204, 113);
            panel3.Controls.Add(lbTongDoanhThu);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(1026, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 152);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(308, 227);
            label3.Name = "label3";
            label3.Size = new Size(0, 47);
            label3.TabIndex = 14;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(26, 188, 156);
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(1308, 211);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(154, 63);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 214);
            label2.Name = "label2";
            label2.Size = new Size(153, 47);
            label2.TabIndex = 17;
            label2.Text = "Từ ngày:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(445, 214);
            label4.Name = "label4";
            label4.Size = new Size(177, 47);
            label4.TabIndex = 18;
            label4.Text = "Đến ngày:";
            // 
            // dtpk_TuNgay
            // 
            dtpk_TuNgay.CustomFormat = "dd/MM/yyyy";
            dtpk_TuNgay.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpk_TuNgay.Format = DateTimePickerFormat.Custom;
            dtpk_TuNgay.Location = new Point(202, 217);
            dtpk_TuNgay.Name = "dtpk_TuNgay";
            dtpk_TuNgay.Size = new Size(200, 43);
            dtpk_TuNgay.TabIndex = 19;
            // 
            // dtpk_DenNgay
            // 
            dtpk_DenNgay.CustomFormat = "dd/MM/yyyy";
            dtpk_DenNgay.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpk_DenNgay.Format = DateTimePickerFormat.Custom;
            dtpk_DenNgay.Location = new Point(628, 217);
            dtpk_DenNgay.Name = "dtpk_DenNgay";
            dtpk_DenNgay.Size = new Size(200, 43);
            dtpk_DenNgay.TabIndex = 20;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.LightCoral;
            btnLoc.BackgroundImageLayout = ImageLayout.None;
            btnLoc.FlatAppearance.BorderColor = Color.White;
            btnLoc.FlatAppearance.BorderSize = 0;
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoc.ForeColor = SystemColors.ActiveCaption;
            btnLoc.Location = new Point(855, 211);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(154, 63);
            btnLoc.TabIndex = 21;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1517, 950);
            Controls.Add(btnLoad);
            Controls.Add(btnLoc);
            Controls.Add(dtpk_DenNgay);
            Controls.Add(panel3);
            Controls.Add(dtpk_TuNgay);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(metroPanel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmThongKe";
            Text = "FrmThongKe";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTongThu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel4;
        private Panel panel5;
        private Label lbTongThu;
        private Label label10;
        private Label lbTongChi;
        private Label label12;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgvTongThu;
        private MetroFramework.Controls.MetroGrid dgvLoaiPhong;
        private DataGridViewTextBoxColumn NgayTao;
        private DataGridViewTextBoxColumn SoTien;
        private Label label7;
        private Label lbTongDoanhThu;
        private Panel panel3;
        private DataGridViewTextBoxColumn khachHangIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nhanVienIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayThanhToanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phuongThucThanhToanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn khachHangMVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nhanVienMVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDayDuKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDayDuNVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trangThai1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayTao1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayThanhToan1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private BindingSource hoaDonViewModelBindingSource;
        private DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isThuDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn noiDungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soTienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn strTrangThaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private BindingSource thuChiKhacViewModelBindingSource;
        private Label label3;
        private Button btnLoad;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Loai;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Label label2;
        private Label label4;
        private DateTimePicker dtpk_TuNgay;
        private DateTimePicker dtpk_DenNgay;
        private Button btnLoc;
    }
}