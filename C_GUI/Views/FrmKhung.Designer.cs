namespace C_GUI.Views
{
    partial class FrmKhung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhung));
            panel1 = new Panel();
            btnPhong = new Button();
            panel7 = new Panel();
            panel4 = new Panel();
            btnChuc = new Button();
            btn_DangXuat = new Button();
            pictureBox1 = new PictureBox();
            btnPhieuDat = new Button();
            btnGioiThieu = new Button();
            btnThongKe = new Button();
            btnNhanVien = new Button();
            btnQLPhong = new Button();
            btnLoaiPhong = new Button();
            btnDichVu = new Button();
            btnKhachHang = new Button();
            btnPhieuDichVu = new Button();
            btnHoaDon = new Button();
            label1 = new Label();
            panel2 = new Panel();
            pnlNoiDungTab = new Panel();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(btnPhong);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnChuc);
            panel1.Controls.Add(btn_DangXuat);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnPhieuDat);
            panel1.Controls.Add(btnGioiThieu);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(btnNhanVien);
            panel1.Controls.Add(btnQLPhong);
            panel1.Controls.Add(btnLoaiPhong);
            panel1.Controls.Add(btnDichVu);
            panel1.Controls.Add(btnKhachHang);
            panel1.Controls.Add(btnPhieuDichVu);
            panel1.Controls.Add(btnHoaDon);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 950);
            panel1.TabIndex = 0;
            // 
            // btnPhong
            // 
            btnPhong.BackColor = Color.FromArgb(52, 73, 94);
            btnPhong.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnPhong.FlatAppearance.BorderSize = 0;
            btnPhong.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnPhong.FlatStyle = FlatStyle.Flat;
            btnPhong.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPhong.ForeColor = Color.White;
            btnPhong.Location = new Point(0, 90);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(245, 62);
            btnPhong.TabIndex = 1;
            btnPhong.Text = "Phòng";
            btnPhong.TextAlign = ContentAlignment.MiddleLeft;
            btnPhong.UseVisualStyleBackColor = false;
            btnPhong.Click += button1_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(9, 78);
            panel7.Name = "panel7";
            panel7.Size = new Size(185, 3);
            panel7.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(9, 864);
            panel4.Name = "panel4";
            panel4.Size = new Size(185, 3);
            panel4.TabIndex = 5;
            // 
            // btnChuc
            // 
            btnChuc.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnChuc.FlatAppearance.BorderSize = 0;
            btnChuc.FlatStyle = FlatStyle.Flat;
            btnChuc.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnChuc.ForeColor = Color.White;
            btnChuc.Location = new Point(67, 873);
            btnChuc.Name = "btnChuc";
            btnChuc.Size = new Size(150, 34);
            btnChuc.TabIndex = 8;
            btnChuc.Text = "Nhân viên";
            btnChuc.TextAlign = ContentAlignment.MiddleLeft;
            btnChuc.UseVisualStyleBackColor = true;
            // 
            // btn_DangXuat
            // 
            btn_DangXuat.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btn_DangXuat.FlatAppearance.BorderSize = 0;
            btn_DangXuat.FlatStyle = FlatStyle.Flat;
            btn_DangXuat.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btn_DangXuat.ForeColor = Color.White;
            btn_DangXuat.Location = new Point(67, 909);
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.Size = new Size(150, 34);
            btn_DangXuat.TabIndex = 9;
            btn_DangXuat.Text = "Đăng xuất";
            btn_DangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btn_DangXuat.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icon_avatar_1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(9, 876);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 62);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnPhieuDat
            // 
            btnPhieuDat.BackColor = Color.FromArgb(52, 73, 94);
            btnPhieuDat.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnPhieuDat.FlatAppearance.BorderSize = 0;
            btnPhieuDat.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnPhieuDat.FlatStyle = FlatStyle.Flat;
            btnPhieuDat.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPhieuDat.ForeColor = Color.White;
            btnPhieuDat.Location = new Point(1, 160);
            btnPhieuDat.Name = "btnPhieuDat";
            btnPhieuDat.Size = new Size(245, 62);
            btnPhieuDat.TabIndex = 0;
            btnPhieuDat.Text = "Phiếu Đặt";
            btnPhieuDat.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuDat.UseVisualStyleBackColor = false;
            btnPhieuDat.Click += button1_Click;
            // 
            // btnGioiThieu
            // 
            btnGioiThieu.BackColor = Color.FromArgb(52, 73, 94);
            btnGioiThieu.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnGioiThieu.FlatAppearance.BorderSize = 0;
            btnGioiThieu.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnGioiThieu.FlatStyle = FlatStyle.Flat;
            btnGioiThieu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnGioiThieu.ForeColor = Color.White;
            btnGioiThieu.Location = new Point(0, 790);
            btnGioiThieu.Name = "btnGioiThieu";
            btnGioiThieu.Size = new Size(245, 62);
            btnGioiThieu.TabIndex = 7;
            btnGioiThieu.Text = "Thu Chi Khác";
            btnGioiThieu.TextAlign = ContentAlignment.MiddleLeft;
            btnGioiThieu.UseVisualStyleBackColor = false;
            btnGioiThieu.Click += button1_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(52, 73, 94);
            btnThongKe.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(1, 720);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(245, 62);
            btnThongKe.TabIndex = 7;
            btnThongKe.Text = "Thống kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += button1_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(52, 73, 94);
            btnNhanVien.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Location = new Point(1, 650);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(245, 62);
            btnNhanVien.TabIndex = 7;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += button1_Click;
            // 
            // btnQLPhong
            // 
            btnQLPhong.BackColor = Color.FromArgb(52, 73, 94);
            btnQLPhong.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnQLPhong.FlatAppearance.BorderSize = 0;
            btnQLPhong.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnQLPhong.FlatStyle = FlatStyle.Flat;
            btnQLPhong.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLPhong.ForeColor = Color.White;
            btnQLPhong.Location = new Point(0, 510);
            btnQLPhong.Name = "btnQLPhong";
            btnQLPhong.Size = new Size(245, 62);
            btnQLPhong.TabIndex = 6;
            btnQLPhong.Text = "QL Phòng";
            btnQLPhong.TextAlign = ContentAlignment.MiddleLeft;
            btnQLPhong.UseVisualStyleBackColor = false;
            btnQLPhong.Click += button1_Click;
            // 
            // btnLoaiPhong
            // 
            btnLoaiPhong.BackColor = Color.FromArgb(52, 73, 94);
            btnLoaiPhong.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnLoaiPhong.FlatAppearance.BorderSize = 0;
            btnLoaiPhong.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnLoaiPhong.FlatStyle = FlatStyle.Flat;
            btnLoaiPhong.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoaiPhong.ForeColor = Color.White;
            btnLoaiPhong.Location = new Point(0, 580);
            btnLoaiPhong.Name = "btnLoaiPhong";
            btnLoaiPhong.Size = new Size(245, 62);
            btnLoaiPhong.TabIndex = 6;
            btnLoaiPhong.Text = "Loại Phòng";
            btnLoaiPhong.TextAlign = ContentAlignment.MiddleLeft;
            btnLoaiPhong.UseVisualStyleBackColor = false;
            btnLoaiPhong.Click += button1_Click;
            // 
            // btnDichVu
            // 
            btnDichVu.BackColor = Color.FromArgb(52, 73, 94);
            btnDichVu.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnDichVu.FlatAppearance.BorderSize = 0;
            btnDichVu.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnDichVu.FlatStyle = FlatStyle.Flat;
            btnDichVu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDichVu.ForeColor = Color.White;
            btnDichVu.Location = new Point(0, 440);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Size = new Size(245, 62);
            btnDichVu.TabIndex = 5;
            btnDichVu.Text = "Dịch vụ";
            btnDichVu.TextAlign = ContentAlignment.MiddleLeft;
            btnDichVu.UseVisualStyleBackColor = false;
            btnDichVu.Click += button1_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.FromArgb(52, 73, 94);
            btnKhachHang.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Location = new Point(0, 370);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(245, 62);
            btnKhachHang.TabIndex = 4;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += button1_Click;
            // 
            // btnPhieuDichVu
            // 
            btnPhieuDichVu.BackColor = Color.FromArgb(52, 73, 94);
            btnPhieuDichVu.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnPhieuDichVu.FlatAppearance.BorderSize = 0;
            btnPhieuDichVu.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnPhieuDichVu.FlatStyle = FlatStyle.Flat;
            btnPhieuDichVu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnPhieuDichVu.ForeColor = Color.White;
            btnPhieuDichVu.Location = new Point(0, 300);
            btnPhieuDichVu.Name = "btnPhieuDichVu";
            btnPhieuDichVu.Size = new Size(245, 62);
            btnPhieuDichVu.TabIndex = 3;
            btnPhieuDichVu.Text = "Phiếu dịch vụ";
            btnPhieuDichVu.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuDichVu.UseVisualStyleBackColor = false;
            btnPhieuDichVu.Click += button1_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.FromArgb(52, 73, 94);
            btnHoaDon.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatAppearance.CheckedBackColor = SystemColors.Control;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.Location = new Point(0, 230);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(245, 62);
            btnHoaDon.TabIndex = 2;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(52, 73, 94);
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 60);
            label1.TabIndex = 100;
            label1.Text = "NHÀ NGHỈ\r\nABC";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pnlNoiDungTab);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(203, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(1517, 950);
            panel2.TabIndex = 1;
            // 
            // pnlNoiDungTab
            // 
            pnlNoiDungTab.BackColor = Color.AliceBlue;
            pnlNoiDungTab.Dock = DockStyle.Fill;
            pnlNoiDungTab.Location = new Point(0, 0);
            pnlNoiDungTab.Name = "pnlNoiDungTab";
            pnlNoiDungTab.Size = new Size(1517, 950);
            pnlNoiDungTab.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hotel_logo;
            pictureBox2.Location = new Point(11, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(52, 73, 94);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(203, 78);
            panel3.TabIndex = 1;
            // 
            // FrmKhung
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(1720, 980);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DisplayHeader = false;
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmKhung";
            Padding = new Padding(0, 30, 0, 0);
            Resizable = false;
            ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            Style = MetroFramework.MetroColorStyle.Brown;
            Text = "Quản Lý Nhà Nghỉ";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPhieuDat;
        private Panel panel2;
        private Button btnDichVu;
        private Button btnKhachHang;
        private Button btnPhieuDichVu;
        private Button btnHoaDon;
        private Button btnPhong;
        private Label label1;
        private Button btn_DangXuat;
        private Button btnChuc;
        private Panel panel4;
        private Button btnNhanVien;
        private Button btnLoaiPhong;
        private Panel pnlNoiDungTab;
        private PictureBox pictureBox2;
        private Button btnThongKe;
        private System.Windows.Forms.Timer timer1;
        private Button btnGioiThieu;
        private Button btnQLPhong;
        private Panel panel3;
        private Panel panel7;
        private PictureBox pictureBox1;
    }
}