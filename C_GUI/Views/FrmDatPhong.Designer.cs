namespace C_GUI.Views
{
    partial class FrmDatPhong
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            metroComboBoxGioiTinh = new MetroFramework.Controls.MetroComboBox();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            metroPanel2 = new MetroFramework.Controls.MetroPanel();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            label17 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            dataGridView1 = new DataGridView();
            SoPhong = new DataGridViewTextBoxColumn();
            LoaiPhong = new DataGridViewTextBoxColumn();
            Them = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            NgayBatDau = new DataGridViewTextBoxColumn();
            NgayKetThuc = new DataGridViewTextBoxColumn();
            Huy = new DataGridViewTextBoxColumn();
            metroPanel1.SuspendLayout();
            metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Location = new Point(106, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 32);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Location = new Point(106, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 32);
            textBox2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 293);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 10;
            label5.Text = "Địa chỉ:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Silver;
            textBox4.Location = new Point(106, 290);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 32);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 235);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 8;
            label4.Text = "Giới tính:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Silver;
            textBox3.Location = new Point(106, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 32);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 183);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 5;
            label3.Text = "SĐT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 130);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 4;
            label2.Text = "CMND:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 77);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 3;
            label1.Text = "Tên:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = Color.FromArgb(192, 255, 255);
            dateTimePicker2.Location = new Point(148, 115);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(122, 32);
            dateTimePicker2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(192, 255, 255);
            dateTimePicker1.Location = new Point(148, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(122, 32);
            dateTimePicker1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(715, 504);
            button1.Name = "button1";
            button1.Size = new Size(154, 49);
            button1.TabIndex = 12;
            button1.Text = "ĐẶT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(893, 504);
            button2.Name = "button2";
            button2.Size = new Size(154, 49);
            button2.TabIndex = 13;
            button2.Text = "HỦY";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(303, 504);
            button3.Name = "button3";
            button3.Size = new Size(154, 49);
            button3.TabIndex = 14;
            button3.Text = "RESET";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // metroComboBoxGioiTinh
            // 
            metroComboBoxGioiTinh.FormattingEnabled = true;
            metroComboBoxGioiTinh.ItemHeight = 23;
            metroComboBoxGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Bê Đê" });
            metroComboBoxGioiTinh.Location = new Point(104, 235);
            metroComboBoxGioiTinh.Name = "metroComboBoxGioiTinh";
            metroComboBoxGioiTinh.Size = new Size(121, 29);
            metroComboBoxGioiTinh.TabIndex = 11;
            metroComboBoxGioiTinh.UseSelectable = true;
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(metroLabel1);
            metroPanel1.Controls.Add(metroComboBoxGioiTinh);
            metroPanel1.Controls.Add(textBox4);
            metroPanel1.Controls.Add(label5);
            metroPanel1.Controls.Add(label1);
            metroPanel1.Controls.Add(label4);
            metroPanel1.Controls.Add(textBox2);
            metroPanel1.Controls.Add(textBox3);
            metroPanel1.Controls.Add(textBox1);
            metroPanel1.Controls.Add(label3);
            metroPanel1.Controls.Add(label2);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(34, 77);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(423, 402);
            metroPanel1.TabIndex = 12;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel1.Location = new Point(106, 23);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(208, 25);
            metroLabel1.TabIndex = 12;
            metroLabel1.Text = "Thông Tin Khách Hàng";
            // 
            // metroPanel2
            // 
            metroPanel2.Controls.Add(dataGridView2);
            metroPanel2.Controls.Add(dataGridView1);
            metroPanel2.Controls.Add(metroLabel4);
            metroPanel2.Controls.Add(metroLabel3);
            metroPanel2.Controls.Add(label7);
            metroPanel2.Controls.Add(label8);
            metroPanel2.Controls.Add(dateTimePicker3);
            metroPanel2.Controls.Add(dateTimePicker4);
            metroPanel2.Controls.Add(label17);
            metroPanel2.Controls.Add(label6);
            metroPanel2.Controls.Add(dateTimePicker2);
            metroPanel2.Controls.Add(metroLabel2);
            metroPanel2.Controls.Add(dateTimePicker1);
            metroPanel2.HorizontalScrollbarBarColor = true;
            metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel2.HorizontalScrollbarSize = 10;
            metroPanel2.Location = new Point(479, 77);
            metroPanel2.Name = "metroPanel2";
            metroPanel2.Size = new Size(568, 402);
            metroPanel2.TabIndex = 13;
            metroPanel2.VerticalScrollbarBarColor = true;
            metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel2.Location = new Point(183, 23);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(194, 25);
            metroLabel2.TabIndex = 12;
            metroLabel2.Text = "Thông Tin Phòng Đặt";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 121);
            label17.Name = "label17";
            label17.Size = new Size(132, 25);
            label17.TabIndex = 20;
            label17.Text = "Ngày kết thúc:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 76);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 18;
            label6.Text = "Ngày bắt đầu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(291, 119);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 24;
            label7.Text = "Giờ kết thúc:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(291, 74);
            label8.Name = "label8";
            label8.Size = new Size(114, 25);
            label8.TabIndex = 22;
            label8.Text = "Giờ bắt đầu:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CalendarMonthBackground = Color.FromArgb(192, 255, 255);
            dateTimePicker3.Location = new Point(414, 113);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(122, 32);
            dateTimePicker3.TabIndex = 23;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CalendarMonthBackground = Color.FromArgb(192, 255, 255);
            dateTimePicker4.Location = new Point(414, 69);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(122, 32);
            dateTimePicker4.TabIndex = 21;
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel3.Location = new Point(54, 180);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(212, 25);
            metroLabel3.TabIndex = 25;
            metroLabel3.Text = "Danh sách phòng trống";
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            metroLabel4.Location = new Point(347, 183);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(140, 25);
            metroLabel4.TabIndex = 26;
            metroLabel4.Text = "Phòng đã chọn";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SoPhong, LoaiPhong, Them });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(26, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 27;
            // 
            // SoPhong
            // 
            SoPhong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoPhong.HeaderText = "Số phòng";
            SoPhong.Name = "SoPhong";
            // 
            // LoaiPhong
            // 
            LoaiPhong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoaiPhong.HeaderText = "Loại phòng";
            LoaiPhong.Name = "LoaiPhong";
            // 
            // Them
            // 
            Them.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Them.HeaderText = "Thêm";
            Them.Name = "Them";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, NgayBatDau, NgayKetThuc, Huy });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Location = new Point(296, 220);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(240, 150);
            dataGridView2.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Số phòng";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Số người";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // NgayBatDau
            // 
            NgayBatDau.HeaderText = "Ngày bắt đầu";
            NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayKetThuc
            // 
            NgayKetThuc.HeaderText = "Ngày kết thúc";
            NgayKetThuc.Name = "NgayKetThuc";
            // 
            // Huy
            // 
            Huy.HeaderText = "Hủy";
            Huy.Name = "Huy";
            // 
            // FrmDatPhong
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 589);
            Controls.Add(metroPanel2);
            Controls.Add(metroPanel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "FrmDatPhong";
            Padding = new Padding(31, 100, 31, 33);
            Text = "Đặt Phòng";
            Load += FrmDatPhong_Load;
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            metroPanel2.ResumeLayout(false);
            metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxGioiTinh;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Label label17;
        private Label label6;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayKetThuc;
        private DataGridViewTextBoxColumn Huy;
        private DataGridViewTextBoxColumn SoPhong;
        private DataGridViewTextBoxColumn LoaiPhong;
        private DataGridViewTextBoxColumn Them;
    }
}