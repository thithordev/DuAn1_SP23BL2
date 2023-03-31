namespace C_GUI.Views
{
    partial class FrmHoaDonChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonChiTiet));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_dichvu = new System.Windows.Forms.DataGridView();
            this.cl_dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_tiencoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_khachhang = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_nhanvien = new System.Windows.Forms.Label();
            this.lb_mahd = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_songay = new System.Windows.Forms.Label();
            this.lb_songuoi = new System.Windows.Forms.Label();
            this.lb_maphong = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pcb_in = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_in)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(224, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày tạo hóa đơn :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã hóa đơn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhân viên :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số ngày :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số người :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số phòng :";
            // 
            // dgv_dichvu
            // 
            this.dgv_dichvu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dichvu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_dichvu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_dichvu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_dv,
            this.cl_giatien,
            this.cl_tiencoc,
            this.cl_soluong,
            this.cl_thanhtien});
            this.dgv_dichvu.Location = new System.Drawing.Point(19, 424);
            this.dgv_dichvu.Name = "dgv_dichvu";
            this.dgv_dichvu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_dichvu.RowHeadersVisible = false;
            this.dgv_dichvu.RowTemplate.Height = 25;
            this.dgv_dichvu.Size = new System.Drawing.Size(681, 169);
            this.dgv_dichvu.TabIndex = 8;
            // 
            // cl_dv
            // 
            this.cl_dv.HeaderText = "Dịch vụ";
            this.cl_dv.Name = "cl_dv";
            this.cl_dv.Width = 130;
            // 
            // cl_giatien
            // 
            this.cl_giatien.HeaderText = "Giá tiền";
            this.cl_giatien.Name = "cl_giatien";
            this.cl_giatien.Width = 150;
            // 
            // cl_tiencoc
            // 
            this.cl_tiencoc.HeaderText = "Tiền cọc";
            this.cl_tiencoc.Name = "cl_tiencoc";
            this.cl_tiencoc.Width = 140;
            // 
            // cl_soluong
            // 
            this.cl_soluong.HeaderText = "số lượng";
            this.cl_soluong.Name = "cl_soluong";
            this.cl_soluong.Width = 110;
            // 
            // cl_thanhtien
            // 
            this.cl_thanhtien.HeaderText = "Thành tiền";
            this.cl_thanhtien.Name = "cl_thanhtien";
            this.cl_thanhtien.Width = 150;
            // 
            // lb_khachhang
            // 
            this.lb_khachhang.AutoSize = true;
            this.lb_khachhang.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_khachhang.Location = new System.Drawing.Point(19, 174);
            this.lb_khachhang.Name = "lb_khachhang";
            this.lb_khachhang.Size = new System.Drawing.Size(222, 37);
            this.lb_khachhang.TabIndex = 3;
            this.lb_khachhang.Text = "Dương Đức Hiếu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(250, 599);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 37);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tổng tiền :";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb_tongtien.Location = new System.Drawing.Point(401, 591);
            this.lb_tongtien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(280, 50);
            this.lb_tongtien.TabIndex = 10;
            this.lb_tongtien.Text = "9.000.000 VND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(24, 692);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 37);
            this.label12.TabIndex = 12;
            this.label12.Text = "Cảm ơn quý khách";
            // 
            // lb_nhanvien
            // 
            this.lb_nhanvien.AutoSize = true;
            this.lb_nhanvien.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nhanvien.Location = new System.Drawing.Point(135, 295);
            this.lb_nhanvien.Name = "lb_nhanvien";
            this.lb_nhanvien.Size = new System.Drawing.Size(117, 25);
            this.lb_nhanvien.TabIndex = 14;
            this.lb_nhanvien.Text = "Dương Hiếu";
            // 
            // lb_mahd
            // 
            this.lb_mahd.AutoSize = true;
            this.lb_mahd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_mahd.Location = new System.Drawing.Point(151, 260);
            this.lb_mahd.Name = "lb_mahd";
            this.lb_mahd.Size = new System.Drawing.Size(48, 25);
            this.lb_mahd.TabIndex = 15;
            this.lb_mahd.Text = "HD1";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_time.ForeColor = System.Drawing.Color.Blue;
            this.lb_time.Location = new System.Drawing.Point(200, 226);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(233, 25);
            this.lb_time.TabIndex = 4;
            this.lb_time.Text = "30/03/2003 09:30:24 AM";
            // 
            // lb_songay
            // 
            this.lb_songay.AutoSize = true;
            this.lb_songay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_songay.Location = new System.Drawing.Point(595, 330);
            this.lb_songay.Name = "lb_songay";
            this.lb_songay.Size = new System.Drawing.Size(23, 25);
            this.lb_songay.TabIndex = 16;
            this.lb_songay.Text = "3";
            // 
            // lb_songuoi
            // 
            this.lb_songuoi.AutoSize = true;
            this.lb_songuoi.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_songuoi.Location = new System.Drawing.Point(595, 295);
            this.lb_songuoi.Name = "lb_songuoi";
            this.lb_songuoi.Size = new System.Drawing.Size(23, 25);
            this.lb_songuoi.TabIndex = 17;
            this.lb_songuoi.Text = "2";
            // 
            // lb_maphong
            // 
            this.lb_maphong.AutoSize = true;
            this.lb_maphong.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_maphong.Location = new System.Drawing.Point(595, 226);
            this.lb_maphong.Name = "lb_maphong";
            this.lb_maphong.Size = new System.Drawing.Size(45, 25);
            this.lb_maphong.TabIndex = 18;
            this.lb_maphong.Text = "PH1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 383);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(684, 25);
            this.label19.TabIndex = 19;
            this.label19.Text = "---------------------------------------------------------------------------------" +
    "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 642);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(684, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "---------------------------------------------------------------------------------" +
    "---";
            // 
            // pictureBox2
            // 
<<<<<<< HEAD
            //this.pictureBox2.Image = global::C_GUI.Properties.Resources.tim1;
=======
            this.pictureBox2.Image = global::C_GUI.Properties.Resources.tim;
>>>>>>> d07cbce237c15e2d8128c3fbce0972f52fd03b87
            this.pictureBox2.Location = new System.Drawing.Point(267, 693);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pcb_in
            // 
            this.pcb_in.Image = ((System.Drawing.Image)(resources.GetObject("pcb_in.Image")));
            this.pcb_in.Location = new System.Drawing.Point(595, 57);
            this.pcb_in.Name = "pcb_in";
            this.pcb_in.Size = new System.Drawing.Size(43, 46);
            this.pcb_in.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_in.TabIndex = 21;
            this.pcb_in.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(609, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "VIP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Loại phòng :";
            // 
            // FrmHoaDonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 787);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pcb_in);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lb_songay);
            this.Controls.Add(this.lb_songuoi);
            this.Controls.Add(this.lb_maphong);
            this.Controls.Add(this.lb_nhanvien);
            this.Controls.Add(this.lb_mahd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_tongtien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv_dichvu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_khachhang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmHoaDonChiTiet";
            this.Text = "FrmHoaDonChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_in)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PrintPreviewDialog printPreviewDialog1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dgv_dichvu;
        private Label lb_khachhang;
        private Label label9;
        private Label lb_tongtien;
        private Label label12;
        private Label lb_nhanvien;
        private Label lb_mahd;
        private Label lb_time;
        private Label lb_songay;
        private Label lb_songuoi;
        private Label lb_maphong;
        private Label label19;
        private Label label11;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pcb_in;
        private DataGridViewTextBoxColumn cl_dv;
        private DataGridViewTextBoxColumn cl_giatien;
        private DataGridViewTextBoxColumn cl_tiencoc;
        private DataGridViewTextBoxColumn cl_soluong;
        private DataGridViewTextBoxColumn cl_thanhtien;
        private Label label2;
        private Label label10;
    }
}