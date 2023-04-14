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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuu = new System.Windows.Forms.Button();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.khachHangViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCCCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTen1 = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.Label();
            this.tbTenDem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(B_BUS.ViewModels.LoaiPhongViewModel);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(709, 323);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(184, 73);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangViewModelBindingSource, "GhiChu", true));
            this.tbGhiChu.Location = new System.Drawing.Point(146, 320);
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(520, 84);
            this.tbGhiChu.TabIndex = 21;
            // 
            // khachHangViewModelBindingSource
            // 
            this.khachHangViewModelBindingSource.DataSource = typeof(B_BUS.ViewModels.KhachHangViewModel);
            // 
            // tbCCCD
            // 
            this.tbCCCD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangViewModelBindingSource, "CCCD", true));
            this.tbCCCD.Location = new System.Drawing.Point(625, 61);
            this.tbCCCD.Name = "tbCCCD";
            this.tbCCCD.Size = new System.Drawing.Size(266, 39);
            this.tbCCCD.TabIndex = 19;
            this.tbCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGiaGio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "CCCD:";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangViewModelBindingSource, "DiaChi", true));
            this.tbDiaChi.Location = new System.Drawing.Point(146, 256);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(747, 39);
            this.tbDiaChi.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 259);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "Địa chỉ:";
            // 
            // tbSDT
            // 
            this.tbSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangViewModelBindingSource, "SDT", true));
            this.tbSDT.Location = new System.Drawing.Point(623, 127);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(268, 39);
            this.tbSDT.TabIndex = 20;
            this.tbSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGiaNgay_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 323);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 32);
            this.label13.TabIndex = 4;
            this.label13.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "SĐT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày sinh:";
            // 
            // tbTen1
            // 
            this.tbTen1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangViewModelBindingSource, "Ten", true));
            this.tbTen1.Location = new System.Drawing.Point(146, 125);
            this.tbTen1.Name = "tbTen1";
            this.tbTen1.Size = new System.Drawing.Size(334, 39);
            this.tbTen1.TabIndex = 18;
            // 
            // tbTen
            // 
            this.tbTen.AutoSize = true;
            this.tbTen.Location = new System.Drawing.Point(26, 128);
            this.tbTen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(57, 32);
            this.tbTen.TabIndex = 5;
            this.tbTen.Text = "Tên:";
            // 
            // tbTenDem
            // 
            this.tbTenDem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangViewModelBindingSource, "TenDem", true));
            this.tbTenDem.Location = new System.Drawing.Point(146, 64);
            this.tbTenDem.Name = "tbTenDem";
            this.tbTenDem.Size = new System.Drawing.Size(334, 39);
            this.tbTenDem.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên đệm:";
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.khachHangViewModelBindingSource, "NgaySinh", true));
            this.dtpkNgaySinh.Location = new System.Drawing.Point(146, 186);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(334, 39);
            this.dtpkNgaySinh.TabIndex = 22;
            this.dtpkNgaySinh.Value = new System.DateTime(2023, 4, 11, 0, 0, 0, 0);
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.khachHangViewModelBindingSource, "strGioiTinh", true));
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(625, 183);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(266, 40);
            this.cbbGioiTinh.TabIndex = 23;
            // 
            // FrmAddorEditKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 438);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.dtpkNgaySinh);
            this.Controls.Add(this.tbGhiChu);
            this.Controls.Add(this.tbCCCD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTen1);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbTenDem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAddorEditKhachHang";
            this.Text = "Khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddorEditKhachHang_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnLuu;
        private BindingSource bindingSource1;
        private TextBox tbGhiChu;
        private TextBox tbCCCD;
        private Label label4;
        private TextBox tbDiaChi;
        private Label label9;
        private TextBox tbSDT;
        private Label label13;
        private Label label6;
        private Label label3;
        private Label label8;
        private TextBox tbTen1;
        private Label tbTen;
        private TextBox tbTenDem;
        private Label label2;
        private BindingSource khachHangViewModelBindingSource;
        private DateTimePicker dtpkNgaySinh;
        private ComboBox cbbGioiTinh;
    }
}