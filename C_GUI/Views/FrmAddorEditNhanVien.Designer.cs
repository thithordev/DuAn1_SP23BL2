namespace C_GUI.Views
{
    partial class FrmAddorEditNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.nhanVienViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenDem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCCCD = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMoTa = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbLuong = new System.Windows.Forms.TextBox();
            this.nhanVienViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienViewModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chức vụ:";
            // 
            // nhanVienViewModelBindingSource
            // 
            this.nhanVienViewModelBindingSource.DataSource = typeof(B_BUS.ViewModels.NhanVienViewModel);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(B_BUS.ViewModels.LoaiPhongViewModel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đệm:";
            // 
            // tbTenDem
            // 
            this.tbTenDem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienViewModelBindingSource, "TenDem", true));
            this.tbTenDem.Location = new System.Drawing.Point(146, 150);
            this.tbTenDem.Name = "tbTenDem";
            this.tbTenDem.Size = new System.Drawing.Size(334, 39);
            this.tbTenDem.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "SĐT:";
            // 
            // tbSDT
            // 
            this.tbSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienViewModelBindingSource, "SDT", true));
            this.tbSDT.Location = new System.Drawing.Point(623, 221);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(268, 39);
            this.tbSDT.TabIndex = 1;
            this.tbSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSDT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "CCCD:";
            // 
            // tbCCCD
            // 
            this.tbCCCD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienViewModelBindingSource, "CCCD", true));
            this.tbCCCD.Location = new System.Drawing.Point(623, 149);
            this.tbCCCD.Name = "tbCCCD";
            this.tbCCCD.Size = new System.Drawing.Size(266, 39);
            this.tbCCCD.TabIndex = 1;
            this.tbCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCCCD_KeyPress);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(709, 562);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(184, 73);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên:";
            // 
            // tbTen
            // 
            this.tbTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienViewModelBindingSource, "Ten", true));
            this.tbTen.Location = new System.Drawing.Point(146, 218);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(334, 39);
            this.tbTen.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 360);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 431);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng thái:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 426);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Lương:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 503);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tài khoản:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(489, 499);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mật khẩu:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 562);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ghi chú:";
            // 
            // tbMoTa
            // 
            this.tbMoTa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienViewModelBindingSource, "GhiChu", true));
            this.tbMoTa.Location = new System.Drawing.Point(146, 562);
            this.tbMoTa.Multiline = true;
            this.tbMoTa.Name = "tbMoTa";
            this.tbMoTa.Size = new System.Drawing.Size(537, 73);
            this.tbMoTa.TabIndex = 3;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienViewModelBindingSource, "DiaChi", true));
            this.tbDiaChi.Location = new System.Drawing.Point(147, 357);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(744, 39);
            this.tbDiaChi.TabIndex = 1;
            // 
            // tbLuong
            // 
            this.tbLuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienViewModelBindingSource, "Luong", true));
            this.tbLuong.Location = new System.Drawing.Point(626, 424);
            this.tbLuong.Name = "tbLuong";
            this.tbLuong.Size = new System.Drawing.Size(268, 39);
            this.tbLuong.TabIndex = 1;
            this.tbLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // nhanVienViewModelBindingSource1
            // 
            this.nhanVienViewModelBindingSource1.DataSource = typeof(B_BUS.ViewModels.NhanVienViewModel);
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienViewModelBindingSource, "TenTaiKhoan", true));
            this.tbTaiKhoan.Location = new System.Drawing.Point(147, 496);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(334, 39);
            this.tbTaiKhoan.TabIndex = 1;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienViewModelBindingSource, "MatKhau", true));
            this.tbMatKhau.Location = new System.Drawing.Point(626, 496);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(268, 39);
            this.tbMatKhau.TabIndex = 1;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.nhanVienViewModelBindingSource, "strGioiTinh", true));
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(625, 284);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(266, 40);
            this.cbbGioiTinh.TabIndex = 4;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienViewModelBindingSource, "NgaySinh", true));
            this.dtpkNgaySinh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkNgaySinh.Location = new System.Drawing.Point(147, 288);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(334, 33);
            this.dtpkNgaySinh.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.nhanVienViewModelBindingSource, "strTrangThai", true));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Thử việc",
            "Chính thức",
            "Đã nghỉ việc"});
            this.comboBox2.Location = new System.Drawing.Point(148, 426);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(333, 40);
            this.comboBox2.TabIndex = 7;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.nhanVienViewModelBindingSource, "chucVuViewModel", true));
            this.cbbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(147, 87);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(334, 40);
            this.cbbChucVu.TabIndex = 8;
            // 
            // FrmAddorEditNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 653);
            this.Controls.Add(this.cbbChucVu);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dtpkNgaySinh);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.tbMoTa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbCCCD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbLuong);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTaiKhoan);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTenDem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAddorEditNhanVien";
            this.Text = "Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddorEditNhanVien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienViewModelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbTenDem;
        private Label label3;
        private TextBox tbSDT;
        private Label label4;
        private TextBox tbCCCD;
        private Button btnLuu;
        private BindingSource bindingSource1;
        private Label label6;
        private Label label7;
        private TextBox tbTen;
        private Label label8;
        private Label label9;
        private Label label5;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox tbMoTa;
        private BindingSource nhanVienViewModelBindingSource;
        private TextBox tbDiaChi;
        private TextBox tbLuong;
        private TextBox tbTaiKhoan;
        private TextBox tbMatKhau;
        private ComboBox cbbGioiTinh;
        private DateTimePicker dtpkNgaySinh;
        private BindingSource nhanVienViewModelBindingSource1;
        private ComboBox comboBox2;
        private ComboBox cbbChucVu;
    }
}