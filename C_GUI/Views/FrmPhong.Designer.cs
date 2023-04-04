namespace C_GUI.Views
{
    partial class FrmPhong
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
            this.button1 = new System.Windows.Forms.Button();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.metroComboBox4 = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbLoaiPhong = new MetroFramework.Controls.MetroComboBox();
            this.loaiPhongViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnGoiDichVu = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnThuePhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongViewModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 796);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(15, 56);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(201, 32);
            this.txbTimKiem.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoc);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(1427, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 865);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy (HH:mm)";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 32);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy (HH:mm)";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(15, 66);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(192, 32);
            this.dtFrom.TabIndex = 12;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(32, 796);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(106, 50);
            this.btnLoc.TabIndex = 11;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.metroComboBox4);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(21, 405);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 109);
            this.panel5.TabIndex = 1;
            // 
            // metroComboBox4
            // 
            this.metroComboBox4.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBox4.FormattingEnabled = true;
            this.metroComboBox4.ItemHeight = 29;
            this.metroComboBox4.Items.AddRange(new object[] {
            "Phòng Đơn",
            "Phòng Đôi",
            "Tất Cả"});
            this.metroComboBox4.Location = new System.Drawing.Point(15, 58);
            this.metroComboBox4.Name = "metroComboBox4";
            this.metroComboBox4.Size = new System.Drawing.Size(201, 35);
            this.metroComboBox4.TabIndex = 1;
            this.metroComboBox4.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tầng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroComboBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(21, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 109);
            this.panel3.TabIndex = 1;
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 29;
            this.metroComboBox3.Items.AddRange(new object[] {
            "Phòng Đơn",
            "Phòng Đôi",
            "Tất Cả"});
            this.metroComboBox3.Location = new System.Drawing.Point(15, 58);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(201, 35);
            this.metroComboBox3.TabIndex = 1;
            this.metroComboBox3.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tình Trạng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbLoaiPhong);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(21, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 102);
            this.panel2.TabIndex = 1;
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.DataSource = this.loaiPhongViewModelBindingSource;
            this.cbbLoaiPhong.DisplayMember = "Ten";
            this.cbbLoaiPhong.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.ItemHeight = 29;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(15, 57);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(201, 35);
            this.cbbLoaiPhong.TabIndex = 1;
            this.cbbLoaiPhong.UseSelectable = true;
            // 
            // loaiPhongViewModelBindingSource
            // 
            this.loaiPhongViewModelBindingSource.DataSource = typeof(B_BUS.ViewModels.LoaiPhongViewModel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Phòng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 809);
            this.panel4.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1409, 809);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTraPhong.FlatAppearance.BorderSize = 0;
            this.btnTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTraPhong.ForeColor = System.Drawing.Color.White;
            this.btnTraPhong.Location = new System.Drawing.Point(914, 817);
            this.btnTraPhong.Margin = new System.Windows.Forms.Padding(5);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(182, 60);
            this.btnTraPhong.TabIndex = 15;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            // 
            // btnGoiDichVu
            // 
            this.btnGoiDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnGoiDichVu.FlatAppearance.BorderSize = 0;
            this.btnGoiDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoiDichVu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoiDichVu.ForeColor = System.Drawing.Color.White;
            this.btnGoiDichVu.Location = new System.Drawing.Point(689, 817);
            this.btnGoiDichVu.Margin = new System.Windows.Forms.Padding(5);
            this.btnGoiDichVu.Name = "btnGoiDichVu";
            this.btnGoiDichVu.Size = new System.Drawing.Size(182, 60);
            this.btnGoiDichVu.TabIndex = 16;
            this.btnGoiDichVu.Text = "Gọi Dịch Vụ";
            this.btnGoiDichVu.UseVisualStyleBackColor = false;
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnNhanPhong.FlatAppearance.BorderSize = 0;
            this.btnNhanPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanPhong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhanPhong.ForeColor = System.Drawing.Color.White;
            this.btnNhanPhong.Location = new System.Drawing.Point(239, 817);
            this.btnNhanPhong.Margin = new System.Windows.Forms.Padding(5);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(182, 60);
            this.btnNhanPhong.TabIndex = 17;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = false;
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnThuePhong.FlatAppearance.BorderSize = 0;
            this.btnThuePhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuePhong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThuePhong.ForeColor = System.Drawing.Color.White;
            this.btnThuePhong.Location = new System.Drawing.Point(464, 817);
            this.btnThuePhong.Margin = new System.Windows.Forms.Padding(5);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.Size = new System.Drawing.Size(182, 60);
            this.btnThuePhong.TabIndex = 18;
            this.btnThuePhong.Text = "Thuê phòng";
            this.btnThuePhong.UseVisualStyleBackColor = false;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Location = new System.Drawing.Point(14, 817);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(5);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(182, 60);
            this.btnDatPhong.TabIndex = 19;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 102);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.dtFrom);
            this.panel6.Location = new System.Drawing.Point(21, 535);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(228, 224);
            this.panel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Từ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(15, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đến";
            // 
            // FrmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1705, 956);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnGoiDichVu);
            this.Controls.Add(this.btnNhanPhong);
            this.Controls.Add(this.btnThuePhong);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPhong";
            this.Text = "adm";
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongViewModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private TextBox txbTimKiem;
        private GroupBox groupBox2;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private MetroFramework.Controls.MetroComboBox cbbLoaiPhong;
        private Label label2;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnLoc;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private Panel panel5;
        private MetroFramework.Controls.MetroComboBox metroComboBox4;
        private Label label4;
        private Button btnTraPhong;
        private Button btnGoiDichVu;
        private Button btnNhanPhong;
        private Button btnThuePhong;
        private Button btnDatPhong;
        private DateTimePicker dtFrom;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private BindingSource loaiPhongViewModelBindingSource;
        private Panel panel6;
        private Label label6;
        private Label label5;
        private Panel panel1;
        private Label label1;
    }
}