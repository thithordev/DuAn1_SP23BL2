namespace C_GUI.Views
{
    partial class FrmThongTinPhong
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
            button1 = new Button();
            btnHuy = new Button();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            label14 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            TenDichVu = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label13 = new Label();
            metroPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 188, 156);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(579, 497);
            button1.Name = "button1";
            button1.Size = new Size(173, 68);
            button1.TabIndex = 12;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(230, 126, 34);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(783, 497);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(173, 68);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // metroPanel1
            // 
            metroPanel1.Controls.Add(label14);
            metroPanel1.Controls.Add(label12);
            metroPanel1.Controls.Add(panel1);
            metroPanel1.Controls.Add(label9);
            metroPanel1.Controls.Add(dataGridView1);
            metroPanel1.Controls.Add(label8);
            metroPanel1.Controls.Add(label7);
            metroPanel1.Controls.Add(label6);
            metroPanel1.Controls.Add(label5);
            metroPanel1.Controls.Add(label4);
            metroPanel1.Controls.Add(label3);
            metroPanel1.Controls.Add(label2);
            metroPanel1.Controls.Add(label1);
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(34, 77);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(922, 402);
            metroPanel1.TabIndex = 12;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(674, 103);
            label14.Name = "label14";
            label14.Size = new Size(97, 25);
            label14.TabIndex = 35;
            label14.Text = "room_type";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(557, 103);
            label12.Name = "label12";
            label12.Size = new Size(111, 25);
            label12.TabIndex = 34;
            label12.Text = "Loại phòng:";
            // 
            // panel1
            // 
            panel1.Controls.Add(metroComboBox2);
            panel1.Controls.Add(metroComboBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(533, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 190);
            panel1.TabIndex = 33;
            // 
            // metroComboBox2
            // 
            metroComboBox2.FormattingEnabled = true;
            metroComboBox2.ItemHeight = 23;
            metroComboBox2.Items.AddRange(new object[] { "Đã dọn dẹp", "Chưa dọn dẹp" });
            metroComboBox2.Location = new Point(152, 142);
            metroComboBox2.Name = "metroComboBox2";
            metroComboBox2.Size = new Size(185, 29);
            metroComboBox2.TabIndex = 37;
            metroComboBox2.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            metroComboBox1.FormattingEnabled = true;
            metroComboBox1.ItemHeight = 23;
            metroComboBox1.Items.AddRange(new object[] { "Phòng đang thuê", "Phòng đặt", "Phòng trống" });
            metroComboBox1.Location = new Point(152, 63);
            metroComboBox1.Name = "metroComboBox1";
            metroComboBox1.Size = new Size(185, 29);
            metroComboBox1.TabIndex = 36;
            metroComboBox1.UseSelectable = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(52, 152, 219);
            label11.Location = new Point(12, 95);
            label11.Name = "label11";
            label11.Size = new Size(235, 32);
            label11.TabIndex = 35;
            label11.Text = "Tình trạng dọn dẹp";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(52, 152, 219);
            label10.Location = new Point(12, 10);
            label10.Name = "label10";
            label10.Size = new Size(214, 32);
            label10.TabIndex = 34;
            label10.Text = "Tình trạng phòng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(52, 152, 219);
            label9.Location = new Point(198, 116);
            label9.Name = "label9";
            label9.Size = new Size(100, 32);
            label9.TabIndex = 32;
            label9.Text = "Dịch vụ";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TenDichVu, SoLuong, ThanhTien });
            dataGridView1.Location = new Point(52, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(427, 190);
            dataGridView1.TabIndex = 10;
            // 
            // TenDichVu
            // 
            TenDichVu.HeaderText = "Tên dịch vụ";
            TenDichVu.Name = "TenDichVu";
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.Name = "ThanhTien";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(812, 38);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 9;
            label8.Text = "count_kh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(715, 38);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 8;
            label7.Text = "Số người:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(612, 38);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 7;
            label6.Text = "time_use";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 38);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 6;
            label5.Text = "Giờ đã qua:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(387, 38);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 5;
            label4.Text = "date_start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 38);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 4;
            label3.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(131, 38);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 3;
            label2.Text = "kh_name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 38);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 2;
            label1.Text = "Khách: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(52, 152, 219);
            label13.Location = new Point(360, 17);
            label13.Name = "label13";
            label13.Size = new Size(261, 40);
            label13.TabIndex = 31;
            label13.Text = "Thông Tin Phòng ";
            // 
            // FrmThongTinPhong
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 581);
            Controls.Add(label13);
            Controls.Add(metroPanel1);
            Controls.Add(btnHuy);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "FrmThongTinPhong";
            Padding = new Padding(31, 100, 31, 33);
            Text = "Đặt Phòng";
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btnHuy;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Panel panel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TenDichVu;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ThanhTien;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label13;
        private Label label14;
        private Label label12;
    }
}