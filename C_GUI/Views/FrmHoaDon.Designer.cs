namespace C_GUI.Views
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.cl_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_hd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_phuongthucthanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_dichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpk_bd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_loc = new System.Windows.Forms.Button();
            this.cbb_trangthai = new System.Windows.Forms.ComboBox();
            this.txb_idhd = new System.Windows.Forms.TextBox();
            this.txb_khachhang = new System.Windows.Forms.TextBox();
            this.txb_phong = new System.Windows.Forms.TextBox();
            this.dtbk_kt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh sách hóa đơn";
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hoadon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_hoadon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_hoadon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_stt,
            this.cl_hd,
            this.cl_kh,
            this.cl_sdt,
            this.cl_date,
            this.cl_phuongthucthanhtoan,
            this.cl_dichvu,
            this.cl_tt});
            this.dgv_hoadon.Location = new System.Drawing.Point(0, 64);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowHeadersVisible = false;
            this.dgv_hoadon.RowTemplate.Height = 25;
            this.dgv_hoadon.Size = new System.Drawing.Size(1226, 482);
            this.dgv_hoadon.TabIndex = 1;
            this.dgv_hoadon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellDoubleClick);
            // 
            // cl_stt
            // 
            this.cl_stt.HeaderText = "STT";
            this.cl_stt.Name = "cl_stt";
            this.cl_stt.Width = 50;
            // 
            // cl_hd
            // 
            this.cl_hd.HeaderText = "Hóa đơn";
            this.cl_hd.Name = "cl_hd";
            this.cl_hd.Width = 110;
            // 
            // cl_kh
            // 
            this.cl_kh.HeaderText = "Khách hàng";
            this.cl_kh.Name = "cl_kh";
            this.cl_kh.Width = 200;
            // 
            // cl_sdt
            // 
            this.cl_sdt.HeaderText = "Số điện thoại";
            this.cl_sdt.Name = "cl_sdt";
            this.cl_sdt.Width = 200;
            // 
            // cl_date
            // 
            this.cl_date.HeaderText = "Ngày tạo";
            this.cl_date.Name = "cl_date";
            this.cl_date.Width = 190;
            // 
            // cl_phuongthucthanhtoan
            // 
            this.cl_phuongthucthanhtoan.HeaderText = "Phương thức thanh toán";
            this.cl_phuongthucthanhtoan.Name = "cl_phuongthucthanhtoan";
            this.cl_phuongthucthanhtoan.Width = 150;
            // 
            // cl_dichvu
            // 
            this.cl_dichvu.HeaderText = "Tổng số tiền";
            this.cl_dichvu.Name = "cl_dichvu";
            this.cl_dichvu.Width = 170;
            // 
            // cl_tt
            // 
            this.cl_tt.HeaderText = "Trạng thái";
            this.cl_tt.Name = "cl_tt";
            this.cl_tt.Width = 150;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dgv_hoadon);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(12, 212);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1229, 546);
            this.panel6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(936, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày tạo :";
            // 
            // dtpk_bd
            // 
            this.dtpk_bd.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpk_bd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpk_bd.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpk_bd.CustomFormat = " dd / MM / yyyy";
            this.dtpk_bd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_bd.Location = new System.Drawing.Point(1047, 14);
            this.dtpk_bd.Name = "dtpk_bd";
            this.dtpk_bd.Size = new System.Drawing.Size(173, 33);
            this.dtpk_bd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê hóa đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_loc);
            this.panel1.Controls.Add(this.cbb_trangthai);
            this.panel1.Controls.Add(this.txb_idhd);
            this.panel1.Controls.Add(this.txb_khachhang);
            this.panel1.Controls.Add(this.txb_phong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtbk_kt);
            this.panel1.Controls.Add(this.dtpk_bd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 179);
            this.panel1.TabIndex = 4;
            // 
            // btn_loc
            // 
            this.btn_loc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_loc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loc.ForeColor = System.Drawing.Color.White;
            this.btn_loc.Location = new System.Drawing.Point(993, 116);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(133, 34);
            this.btn_loc.TabIndex = 4;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = false;
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.BackColor = System.Drawing.SystemColors.Window;
            this.cbb_trangthai.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbb_trangthai.FormattingEnabled = true;
            this.cbb_trangthai.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Hủy thanh toán"});
            this.cbb_trangthai.Location = new System.Drawing.Point(300, 117);
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Size = new System.Drawing.Size(222, 33);
            this.cbb_trangthai.TabIndex = 3;
            this.cbb_trangthai.Text = " Trạng thái";
            // 
            // txb_idhd
            // 
            this.txb_idhd.Location = new System.Drawing.Point(125, 117);
            this.txb_idhd.Name = "txb_idhd";
            this.txb_idhd.PlaceholderText = " ID hóa đơn";
            this.txb_idhd.Size = new System.Drawing.Size(144, 33);
            this.txb_idhd.TabIndex = 2;
            // 
            // txb_khachhang
            // 
            this.txb_khachhang.Location = new System.Drawing.Point(553, 117);
            this.txb_khachhang.Name = "txb_khachhang";
            this.txb_khachhang.PlaceholderText = " Khách hàng";
            this.txb_khachhang.Size = new System.Drawing.Size(222, 33);
            this.txb_khachhang.TabIndex = 2;
            // 
            // txb_phong
            // 
            this.txb_phong.Location = new System.Drawing.Point(806, 116);
            this.txb_phong.Name = "txb_phong";
            this.txb_phong.PlaceholderText = " Phòng";
            this.txb_phong.Size = new System.Drawing.Size(156, 33);
            this.txb_phong.TabIndex = 2;
            // 
            // dtbk_kt
            // 
            this.dtbk_kt.CalendarForeColor = System.Drawing.Color.Black;
            this.dtbk_kt.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtbk_kt.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtbk_kt.CustomFormat = " dd / MM / yyyy";
            this.dtbk_kt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbk_kt.Location = new System.Drawing.Point(1048, 53);
            this.dtbk_kt.Name = "dtbk_kt";
            this.dtbk_kt.Size = new System.Drawing.Size(173, 33);
            this.dtbk_kt.TabIndex = 1;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 770);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmHoaDon";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Panel panel1;
        private TextBox textBox5;
        private Label label5;
        private TextBox txb_phong;
        private Label label4;
        private TextBox txb_khachhang;
        private TextBox txb_idhd;
        private Label label2;
        private TextBox textBox6;
        private Label label6;
        private Label label13;
        private Label label26;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Button btn_loc;
        private DataGridView dgv_hoadon;
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
        private Panel panel6;
        private DateTimePicker dtpk_bd;
        private ComboBox cbb_trangthai;
        private DateTimePicker dtbk_kt;
        private DataGridViewTextBoxColumn cl_stt;
        private DataGridViewTextBoxColumn cl_hd;
        private DataGridViewTextBoxColumn cl_kh;
        private DataGridViewTextBoxColumn cl_sdt;
        private DataGridViewTextBoxColumn cl_date;
        private DataGridViewTextBoxColumn cl_phuongthucthanhtoan;
        private DataGridViewTextBoxColumn cl_dichvu;
        private DataGridViewTextBoxColumn cl_tt;
    }
}