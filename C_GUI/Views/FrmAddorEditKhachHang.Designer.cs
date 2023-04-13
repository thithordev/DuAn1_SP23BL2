namespace C_GUI.Views
{
    partial class FrmAddorEditKhachHang
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
            bindingSource1 = new BindingSource(components);
            btnLuu = new Button();
            tbMoTa = new TextBox();
            khachHangViewModelBindingSource = new BindingSource(components);
            tbGiaGio = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            tbGiaNgay = new TextBox();
            textBox5 = new TextBox();
            label13 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            tbTen = new Label();
            tbSoGiuong = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khachHangViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(B_BUS.ViewModels.LoaiPhongViewModel);
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(26, 188, 156);
            btnLuu.DialogResult = DialogResult.OK;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(707, 399);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(184, 73);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // tbMoTa
            // 
            tbMoTa.DataBindings.Add(new Binding("Text", khachHangViewModelBindingSource, "GhiChu", true));
            tbMoTa.Location = new Point(146, 338);
            tbMoTa.Multiline = true;
            tbMoTa.Name = "tbMoTa";
            tbMoTa.Size = new Size(334, 134);
            tbMoTa.TabIndex = 21;
            // 
            // khachHangViewModelBindingSource
            // 
            khachHangViewModelBindingSource.DataSource = typeof(B_BUS.ViewModels.KhachHangViewModel);
            // 
            // tbGiaGio
            // 
            tbGiaGio.DataBindings.Add(new Binding("Text", khachHangViewModelBindingSource, "CCCD", true));
            tbGiaGio.Location = new Point(625, 61);
            tbGiaGio.Name = "tbGiaGio";
            tbGiaGio.Size = new Size(266, 39);
            tbGiaGio.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(522, 64);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 32);
            label4.TabIndex = 12;
            label4.Text = "CCCD:";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", khachHangViewModelBindingSource, "DiaChi", true));
            textBox4.Location = new Point(625, 256);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 39);
            textBox4.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(506, 259);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(92, 32);
            label9.TabIndex = 11;
            label9.Text = "Địa chỉ:";
            // 
            // tbGiaNgay
            // 
            tbGiaNgay.DataBindings.Add(new Binding("Text", khachHangViewModelBindingSource, "SDT", true));
            tbGiaNgay.Location = new Point(623, 127);
            tbGiaNgay.Name = "tbGiaNgay";
            tbGiaNgay.Size = new Size(268, 39);
            tbGiaNgay.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", khachHangViewModelBindingSource, "TrangThai", true));
            textBox5.Location = new Point(146, 252);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(334, 39);
            textBox5.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 338);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(101, 32);
            label13.TabIndex = 4;
            label13.Text = "Ghi chú:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(506, 191);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 32);
            label6.TabIndex = 9;
            label6.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 259);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 32);
            label5.TabIndex = 8;
            label5.Text = "Trạng thái:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(522, 127);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 32);
            label3.TabIndex = 7;
            label3.Text = "SĐT:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 191);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(126, 32);
            label8.TabIndex = 6;
            label8.Text = "Ngày sinh:";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", khachHangViewModelBindingSource, "Ten", true));
            textBox2.Location = new Point(146, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 39);
            textBox2.TabIndex = 18;
            // 
            // tbTen
            // 
            tbTen.AutoSize = true;
            tbTen.Location = new Point(26, 128);
            tbTen.Margin = new Padding(6, 0, 6, 0);
            tbTen.Name = "tbTen";
            tbTen.Size = new Size(57, 32);
            tbTen.TabIndex = 5;
            tbTen.Text = "Tên:";
            // 
            // tbSoGiuong
            // 
            tbSoGiuong.DataBindings.Add(new Binding("Text", khachHangViewModelBindingSource, "TenDem", true));
            tbSoGiuong.Location = new Point(146, 64);
            tbSoGiuong.Name = "tbSoGiuong";
            tbSoGiuong.Size = new Size(334, 39);
            tbSoGiuong.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 67);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 10;
            label2.Text = "Tên đệm:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.DataBindings.Add(new Binding("Value", khachHangViewModelBindingSource, "NgaySinh", true));
            dateTimePicker1.Location = new Point(146, 186);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(334, 39);
            dateTimePicker1.TabIndex = 22;
            dateTimePicker1.Value = new DateTime(2023, 4, 11, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedItem", khachHangViewModelBindingSource, "strGioiTinh", true));
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Chưa chọn giới tính", "Nam", "Nữ" });
            comboBox1.Location = new Point(625, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 40);
            comboBox1.TabIndex = 23;
            // 
            // FrmAddorEditKhachHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 509);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbMoTa);
            Controls.Add(tbGiaGio);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(tbGiaNgay);
            Controls.Add(textBox5);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(tbTen);
            Controls.Add(tbSoGiuong);
            Controls.Add(label2);
            Controls.Add(btnLuu);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "FrmAddorEditKhachHang";
            Text = "Khách hàng";
            FormClosing += FrmAddorEditKhachHang_FormClosing;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)khachHangViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLuu;
        private BindingSource bindingSource1;
        private TextBox tbMoTa;
        private TextBox tbGiaGio;
        private Label label4;
        private TextBox textBox4;
        private Label label9;
        private TextBox tbGiaNgay;
        private TextBox textBox5;
        private Label label13;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label8;
        private TextBox textBox2;
        private Label tbTen;
        private TextBox tbSoGiuong;
        private Label label2;
        private BindingSource khachHangViewModelBindingSource;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
    }
}