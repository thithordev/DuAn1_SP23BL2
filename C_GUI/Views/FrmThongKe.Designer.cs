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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            dtpk_time = new DateTimePicker();
            label1 = new Label();
            panel3 = new Panel();
            lb_tongdoanhthu = new Label();
            label7 = new Label();
            panel4 = new Panel();
            lb_tongdichvu = new Label();
            label10 = new Label();
            panel5 = new Panel();
            lb_tongsophong = new Label();
            label12 = new Label();
            panel6 = new Panel();
            dgv_thongke = new DataGridView();
            cl_thang = new DataGridViewTextBoxColumn();
            cl_tongsophong = new DataGridViewTextBoxColumn();
            cl_kh = new DataGridViewTextBoxColumn();
            cl_hoadon = new DataGridViewTextBoxColumn();
            cl_phuongthucthanhtoan = new DataGridViewTextBoxColumn();
            cl_dichvu = new DataGridViewTextBoxColumn();
            label5 = new Label();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_thongke).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpk_time);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1517, 88);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(1415, 8);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Thời gian";
            // 
            // dtpk_time
            // 
            dtpk_time.CustomFormat = " yyyy";
            dtpk_time.Format = DateTimePickerFormat.Custom;
            dtpk_time.Location = new Point(1396, 39);
            dtpk_time.Name = "dtpk_time";
            dtpk_time.Size = new Size(94, 32);
            dtpk_time.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 1;
            label1.Text = "Thống kê doanh thu";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(46, 204, 113);
            panel3.Controls.Add(lb_tongdoanhthu);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(201, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 152);
            panel3.TabIndex = 1;
            // 
            // lb_tongdoanhthu
            // 
            lb_tongdoanhthu.AutoSize = true;
            lb_tongdoanhthu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lb_tongdoanhthu.ForeColor = Color.White;
            lb_tongdoanhthu.Location = new Point(37, 54);
            lb_tongdoanhthu.Name = "lb_tongdoanhthu";
            lb_tongdoanhthu.Size = new Size(278, 65);
            lb_tongdoanhthu.TabIndex = 1;
            lb_tongdoanhthu.Text = "28,000,000";
            lb_tongdoanhthu.TextAlign = ContentAlignment.MiddleCenter;
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(230, 126, 34);
            panel4.Controls.Add(lb_tongdichvu);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(586, 133);
            panel4.Name = "panel4";
            panel4.Size = new Size(361, 152);
            panel4.TabIndex = 2;
            // 
            // lb_tongdichvu
            // 
            lb_tongdichvu.AutoSize = true;
            lb_tongdichvu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lb_tongdichvu.ForeColor = Color.White;
            lb_tongdichvu.Location = new Point(55, 54);
            lb_tongdichvu.Name = "lb_tongdichvu";
            lb_tongdichvu.Size = new Size(250, 65);
            lb_tongdichvu.TabIndex = 3;
            lb_tongdichvu.Text = "1,000,000";
            lb_tongdichvu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(136, 18);
            label10.Name = "label10";
            label10.Size = new Size(89, 25);
            label10.TabIndex = 2;
            label10.Text = "Tổng thu";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 152, 219);
            panel5.Controls.Add(lb_tongsophong);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(976, 133);
            panel5.Name = "panel5";
            panel5.Size = new Size(339, 152);
            panel5.TabIndex = 3;
            // 
            // lb_tongsophong
            // 
            lb_tongsophong.AutoSize = true;
            lb_tongsophong.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lb_tongsophong.ForeColor = Color.White;
            lb_tongsophong.Location = new Point(113, 54);
            lb_tongsophong.Name = "lb_tongsophong";
            lb_tongsophong.Size = new Size(112, 65);
            lb_tongsophong.TabIndex = 5;
            lb_tongsophong.Text = "100";
            lb_tongsophong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(128, 18);
            label12.Name = "label12";
            label12.Size = new Size(82, 25);
            label12.TabIndex = 4;
            label12.Text = "tổng chi";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dgv_thongke);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(127, 317);
            panel6.Name = "panel6";
            panel6.Size = new Size(1263, 567);
            panel6.TabIndex = 2;
            // 
            // dgv_thongke
            // 
            dgv_thongke.BackgroundColor = Color.White;
            dgv_thongke.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_thongke.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_thongke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_thongke.Columns.AddRange(new DataGridViewColumn[] { cl_thang, cl_tongsophong, cl_kh, cl_hoadon, cl_phuongthucthanhtoan, cl_dichvu });
            dgv_thongke.Dock = DockStyle.Bottom;
            dgv_thongke.Location = new Point(0, 51);
            dgv_thongke.Name = "dgv_thongke";
            dgv_thongke.RowHeadersVisible = false;
            dgv_thongke.RowTemplate.Height = 25;
            dgv_thongke.Size = new Size(1263, 516);
            dgv_thongke.TabIndex = 1;
            // 
            // cl_thang
            // 
            cl_thang.HeaderText = "Tháng ";
            cl_thang.Name = "cl_thang";
            cl_thang.Width = 110;
            // 
            // cl_tongsophong
            // 
            cl_tongsophong.HeaderText = "Tổng số phòng";
            cl_tongsophong.Name = "cl_tongsophong";
            cl_tongsophong.Width = 200;
            // 
            // cl_kh
            // 
            cl_kh.HeaderText = "Tổng khách hàng";
            cl_kh.Name = "cl_kh";
            cl_kh.Width = 200;
            // 
            // cl_hoadon
            // 
            cl_hoadon.HeaderText = "Tổng hóa đơn";
            cl_hoadon.Name = "cl_hoadon";
            cl_hoadon.Width = 200;
            // 
            // cl_phuongthucthanhtoan
            // 
            cl_phuongthucthanhtoan.HeaderText = "Tổng đã thanh toán";
            cl_phuongthucthanhtoan.Name = "cl_phuongthucthanhtoan";
            cl_phuongthucthanhtoan.Width = 200;
            // 
            // cl_dichvu
            // 
            cl_dichvu.HeaderText = "tổng hủy thanh toán";
            cl_dichvu.Name = "cl_dichvu";
            cl_dichvu.Width = 200;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(41, 128, 185);
            label5.Location = new Point(12, 11);
            label5.Name = "label5";
            label5.Size = new Size(190, 25);
            label5.TabIndex = 0;
            label5.Text = "Thống kê theo tháng";
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(B_BUS.ViewModels.HoaDonViewModel);
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1517, 950);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmThongKe";
            Text = "FrmThongKe";
            Load += FrmThongKe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_thongke).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label7;
        private Label lb_tongdoanhthu;
        private Label lb_tongdichvu;
        private Label label10;
        private Label lb_tongsophong;
        private Label label12;
        private Label label2;
        private DateTimePicker dtpk_time;
        private DataGridView dgv_thongke;
        private DataGridViewTextBoxColumn cl_thang;
        private DataGridViewTextBoxColumn cl_tongsophong;
        private DataGridViewTextBoxColumn cl_kh;
        private DataGridViewTextBoxColumn cl_hoadon;
        private DataGridViewTextBoxColumn cl_phuongthucthanhtoan;
        private DataGridViewTextBoxColumn cl_dichvu;
        private Label label5;
        private BindingSource bindingSource1;
    }
}