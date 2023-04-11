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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            nhanVienViewModelBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            tbSoGiuong = new TextBox();
            label3 = new Label();
            tbGiaNgay = new TextBox();
            label4 = new Label();
            tbGiaGio = new TextBox();
            btnLuu = new Button();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tbMoTa = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            nhanVienViewModelBindingSource1 = new BindingSource(components);
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nhanVienViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nhanVienViewModelBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 91);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 0;
            label1.Text = "Chức vụ:";
            // 
            // nhanVienViewModelBindingSource
            // 
            nhanVienViewModelBindingSource.DataSource = typeof(B_BUS.ViewModels.NhanVienViewModel);
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(B_BUS.ViewModels.LoaiPhongViewModel);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 157);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 0;
            label2.Text = "Tên đệm:";
            // 
            // tbSoGiuong
            // 
            tbSoGiuong.DataBindings.Add(new Binding("Text", nhanVienViewModelBindingSource, "TenDem", true));
            tbSoGiuong.Location = new Point(146, 150);
            tbSoGiuong.Name = "tbSoGiuong";
            tbSoGiuong.Size = new Size(334, 39);
            tbSoGiuong.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 150);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 32);
            label3.TabIndex = 0;
            label3.Text = "SĐT:";
            // 
            // tbGiaNgay
            // 
            tbGiaNgay.DataBindings.Add(new Binding("Text", nhanVienViewModelBindingSource, "SDT", true));
            tbGiaNgay.Location = new Point(623, 150);
            tbGiaNgay.Name = "tbGiaNgay";
            tbGiaNgay.Size = new Size(268, 39);
            tbGiaNgay.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 87);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 32);
            label4.TabIndex = 0;
            label4.Text = "CCCD:";
            // 
            // tbGiaGio
            // 
            tbGiaGio.DataBindings.Add(new Binding("Text", nhanVienViewModelBindingSource, "CCCD", true));
            tbGiaGio.Location = new Point(625, 84);
            tbGiaGio.Name = "tbGiaGio";
            tbGiaGio.Size = new Size(266, 39);
            tbGiaGio.TabIndex = 1;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(26, 188, 156);
            btnLuu.DialogResult = DialogResult.OK;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(709, 562);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(184, 73);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(506, 214);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 32);
            label6.TabIndex = 0;
            label6.Text = "Giới tính:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 214);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 32);
            label7.TabIndex = 0;
            label7.Text = "Tên:";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", nhanVienViewModelBindingSource, "Ten", true));
            textBox2.Location = new Point(146, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 39);
            textBox2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 282);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(126, 32);
            label8.TabIndex = 0;
            label8.Text = "Ngày sinh:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(522, 282);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(92, 32);
            label9.TabIndex = 0;
            label9.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 357);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 32);
            label5.TabIndex = 0;
            label5.Text = "Trạng thái:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(522, 357);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(86, 32);
            label10.TabIndex = 0;
            label10.Text = "Lương:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 429);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 32);
            label11.TabIndex = 0;
            label11.Text = "Tài khoản:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(488, 425);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(120, 32);
            label12.TabIndex = 0;
            label12.Text = "Mật khẩu:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(26, 501);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(101, 32);
            label13.TabIndex = 0;
            label13.Text = "Ghi chú:";
            // 
            // tbMoTa
            // 
            tbMoTa.DataBindings.Add(new Binding("Text", nhanVienViewModelBindingSource, "GhiChu", true));
            tbMoTa.Location = new Point(146, 501);
            tbMoTa.Multiline = true;
            tbMoTa.Name = "tbMoTa";
            tbMoTa.Size = new Size(537, 134);
            tbMoTa.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", nhanVienViewModelBindingSource, "DiaChi", true));
            textBox4.Location = new Point(625, 275);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 39);
            textBox4.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", nhanVienViewModelBindingSource, "Luong", true));
            textBox6.Location = new Point(625, 350);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(268, 39);
            textBox6.TabIndex = 1;
            // 
            // nhanVienViewModelBindingSource1
            // 
            nhanVienViewModelBindingSource1.DataSource = typeof(B_BUS.ViewModels.NhanVienViewModel);
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", nhanVienViewModelBindingSource, "TenTaiKhoan", true));
            textBox7.Location = new Point(146, 422);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(334, 39);
            textBox7.TabIndex = 1;
            // 
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", nhanVienViewModelBindingSource, "MatKhau", true));
            textBox8.Location = new Point(625, 422);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(268, 39);
            textBox8.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedItem", nhanVienViewModelBindingSource, "strGioiTinh", true));
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Chọn giới tính", "Nam", "Nữ" });
            comboBox1.Location = new Point(625, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 40);
            comboBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Value", nhanVienViewModelBindingSource, "NgaySinh", true));
            dateTimePicker1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(147, 278);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(333, 33);
            dateTimePicker1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.DataBindings.Add(new Binding("SelectedItem", nhanVienViewModelBindingSource, "strTrangThai", true));
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Thử việc", "Chính thức", "Đã nghỉ việc" });
            comboBox2.Location = new Point(147, 349);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(333, 40);
            comboBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", nhanVienViewModelBindingSource, "TenChucVu", true));
            textBox1.Location = new Point(147, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 39);
            textBox1.TabIndex = 1;
            // 
            // FrmAddorEditNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 653);
            Controls.Add(comboBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(tbMoTa);
            Controls.Add(btnLuu);
            Controls.Add(tbGiaGio);
            Controls.Add(label4);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(textBox8);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(tbGiaNgay);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(tbSoGiuong);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "FrmAddorEditNhanVien";
            Text = "Nhân Viên";
            FormClosing += FrmAddorEditNhanVien_FormClosing;
            ((System.ComponentModel.ISupportInitialize)nhanVienViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nhanVienViewModelBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbSoGiuong;
        private Label label3;
        private TextBox tbGiaNgay;
        private Label label4;
        private TextBox tbGiaGio;
        private Button btnLuu;
        private BindingSource bindingSource1;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private Label label9;
        private Label label5;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox tbMoTa;
        private BindingSource nhanVienViewModelBindingSource;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private BindingSource nhanVienViewModelBindingSource1;
        private ComboBox comboBox2;
        private TextBox textBox1;
    }
}