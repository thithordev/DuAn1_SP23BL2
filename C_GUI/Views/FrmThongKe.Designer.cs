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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpk_time = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_tongdoanhthu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_tongdichvu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_tongsophong = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgv_thongke = new System.Windows.Forms.DataGridView();
            this.cl_thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_tongsophong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_hoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_phuongthucthanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_dichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpk_time);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 88);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(1171, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian";
            // 
            // dtpk_time
            // 
            this.dtpk_time.CustomFormat = " yyyy";
            this.dtpk_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_time.Location = new System.Drawing.Point(1147, 38);
            this.dtpk_time.Name = "dtpk_time";
            this.dtpk_time.Size = new System.Drawing.Size(99, 32);
            this.dtpk_time.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê doanh thu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel3.Controls.Add(this.lb_tongdoanhthu);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(77, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 152);
            this.panel3.TabIndex = 1;
            // 
            // lb_tongdoanhthu
            // 
            this.lb_tongdoanhthu.AutoSize = true;
            this.lb_tongdoanhthu.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tongdoanhthu.ForeColor = System.Drawing.Color.White;
            this.lb_tongdoanhthu.Location = new System.Drawing.Point(37, 54);
            this.lb_tongdoanhthu.Name = "lb_tongdoanhthu";
            this.lb_tongdoanhthu.Size = new System.Drawing.Size(278, 65);
            this.lb_tongdoanhthu.TabIndex = 1;
            this.lb_tongdoanhthu.Text = "28,000,000";
            this.lb_tongdoanhthu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(103, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng doanh thu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel4.Controls.Add(this.lb_tongdichvu);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(462, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 152);
            this.panel4.TabIndex = 2;
            // 
            // lb_tongdichvu
            // 
            this.lb_tongdichvu.AutoSize = true;
            this.lb_tongdichvu.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tongdichvu.ForeColor = System.Drawing.Color.White;
            this.lb_tongdichvu.Location = new System.Drawing.Point(55, 54);
            this.lb_tongdichvu.Name = "lb_tongdichvu";
            this.lb_tongdichvu.Size = new System.Drawing.Size(250, 65);
            this.lb_tongdichvu.TabIndex = 3;
            this.lb_tongdichvu.Text = "1,000,000";
            this.lb_tongdichvu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(119, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tổng dịch vụ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel5.Controls.Add(this.lb_tongsophong);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(852, 133);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 152);
            this.panel5.TabIndex = 3;
            // 
            // lb_tongsophong
            // 
            this.lb_tongsophong.AutoSize = true;
            this.lb_tongsophong.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tongsophong.ForeColor = System.Drawing.Color.White;
            this.lb_tongsophong.Location = new System.Drawing.Point(113, 54);
            this.lb_tongsophong.Name = "lb_tongsophong";
            this.lb_tongsophong.Size = new System.Drawing.Size(112, 65);
            this.lb_tongsophong.TabIndex = 5;
            this.lb_tongsophong.Text = "100";
            this.lb_tongsophong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(95, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tổng đặt phòng";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dgv_thongke);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(77, 317);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1114, 469);
            this.panel6.TabIndex = 2;
            // 
            // dgv_thongke
            // 
            this.dgv_thongke.BackgroundColor = System.Drawing.Color.White;
            this.dgv_thongke.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_thongke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_thang,
            this.cl_tongsophong,
            this.cl_kh,
            this.cl_hoadon,
            this.cl_phuongthucthanhtoan,
            this.cl_dichvu});
            this.dgv_thongke.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_thongke.Location = new System.Drawing.Point(0, 56);
            this.dgv_thongke.Name = "dgv_thongke";
            this.dgv_thongke.RowHeadersVisible = false;
            this.dgv_thongke.RowTemplate.Height = 25;
            this.dgv_thongke.Size = new System.Drawing.Size(1114, 413);
            this.dgv_thongke.TabIndex = 1;
            // 
            // cl_thang
            // 
            this.cl_thang.HeaderText = "Tháng ";
            this.cl_thang.Name = "cl_thang";
            this.cl_thang.Width = 110;
            // 
            // cl_tongsophong
            // 
            this.cl_tongsophong.HeaderText = "Tổng số phòng";
            this.cl_tongsophong.Name = "cl_tongsophong";
            this.cl_tongsophong.Width = 200;
            // 
            // cl_kh
            // 
            this.cl_kh.HeaderText = "Tổng khách hàng";
            this.cl_kh.Name = "cl_kh";
            this.cl_kh.Width = 200;
            // 
            // cl_hoadon
            // 
            this.cl_hoadon.HeaderText = "Tổng hóa đơn";
            this.cl_hoadon.Name = "cl_hoadon";
            this.cl_hoadon.Width = 200;
            // 
            // cl_phuongthucthanhtoan
            // 
            this.cl_phuongthucthanhtoan.HeaderText = "Tổng đã thanh toán";
            this.cl_phuongthucthanhtoan.Name = "cl_phuongthucthanhtoan";
            this.cl_phuongthucthanhtoan.Width = 200;
            // 
            // cl_dichvu
            // 
            this.cl_dichvu.HeaderText = "tổng hủy thanh toán";
            this.cl_dichvu.Name = "cl_dichvu";
            this.cl_dichvu.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thống kê theo tháng";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 809);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongke)).EndInit();
            this.ResumeLayout(false);

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
    }
}