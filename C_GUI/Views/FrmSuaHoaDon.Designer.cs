namespace C_GUI.Views
{
    partial class FrmSuaHoaDon
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
            this.cbb_loaiphong = new System.Windows.Forms.ComboBox();
            this.cbb_phong = new System.Windows.Forms.ComboBox();
            this.dtpk_kt = new System.Windows.Forms.DateTimePicker();
            this.dtpk_bd = new System.Windows.Forms.DateTimePicker();
            this.txb_tiencoc = new System.Windows.Forms.TextBox();
            this.txb_songuoi = new System.Windows.Forms.TextBox();
            this.txb_sdt = new System.Windows.Forms.TextBox();
            this.txb_cmnd = new System.Windows.Forms.TextBox();
            this.cbb_tenkh = new System.Windows.Forms.ComboBox();
            this.dgv_dichvu = new System.Windows.Forms.DataGridView();
            this.cl_dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbb_loaiphong);
            this.panel1.Controls.Add(this.cbb_phong);
            this.panel1.Controls.Add(this.dtpk_kt);
            this.panel1.Controls.Add(this.dtpk_bd);
            this.panel1.Controls.Add(this.txb_tiencoc);
            this.panel1.Controls.Add(this.txb_songuoi);
            this.panel1.Controls.Add(this.txb_sdt);
            this.panel1.Controls.Add(this.txb_cmnd);
            this.panel1.Controls.Add(this.cbb_tenkh);
            this.panel1.Controls.Add(this.dgv_dichvu);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 723);
            this.panel1.TabIndex = 2;
            // 
            // cbb_loaiphong
            // 
            this.cbb_loaiphong.FormattingEnabled = true;
            this.cbb_loaiphong.Location = new System.Drawing.Point(177, 432);
            this.cbb_loaiphong.Name = "cbb_loaiphong";
            this.cbb_loaiphong.Size = new System.Drawing.Size(99, 33);
            this.cbb_loaiphong.TabIndex = 16;
            // 
            // cbb_phong
            // 
            this.cbb_phong.FormattingEnabled = true;
            this.cbb_phong.Location = new System.Drawing.Point(177, 393);
            this.cbb_phong.Name = "cbb_phong";
            this.cbb_phong.Size = new System.Drawing.Size(99, 33);
            this.cbb_phong.TabIndex = 15;
            // 
            // dtpk_kt
            // 
            this.dtpk_kt.CustomFormat = " dd / MM /yyyy hh-mm-ss";
            this.dtpk_kt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_kt.Location = new System.Drawing.Point(177, 276);
            this.dtpk_kt.Name = "dtpk_kt";
            this.dtpk_kt.Size = new System.Drawing.Size(249, 33);
            this.dtpk_kt.TabIndex = 14;
            // 
            // dtpk_bd
            // 
            this.dtpk_bd.CustomFormat = " dd / MM /yyyy hh-mm-ss";
            this.dtpk_bd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_bd.Location = new System.Drawing.Point(177, 237);
            this.dtpk_bd.Name = "dtpk_bd";
            this.dtpk_bd.Size = new System.Drawing.Size(249, 33);
            this.dtpk_bd.TabIndex = 14;
            // 
            // txb_tiencoc
            // 
            this.txb_tiencoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_tiencoc.Location = new System.Drawing.Point(177, 354);
            this.txb_tiencoc.Name = "txb_tiencoc";
            this.txb_tiencoc.Size = new System.Drawing.Size(195, 33);
            this.txb_tiencoc.TabIndex = 12;
            // 
            // txb_songuoi
            // 
            this.txb_songuoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_songuoi.Location = new System.Drawing.Point(177, 315);
            this.txb_songuoi.Name = "txb_songuoi";
            this.txb_songuoi.Size = new System.Drawing.Size(99, 33);
            this.txb_songuoi.TabIndex = 13;
            // 
            // txb_sdt
            // 
            this.txb_sdt.BackColor = System.Drawing.Color.Yellow;
            this.txb_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_sdt.Enabled = false;
            this.txb_sdt.Location = new System.Drawing.Point(177, 137);
            this.txb_sdt.Name = "txb_sdt";
            this.txb_sdt.Size = new System.Drawing.Size(195, 33);
            this.txb_sdt.TabIndex = 11;
            // 
            // txb_cmnd
            // 
            this.txb_cmnd.BackColor = System.Drawing.Color.Yellow;
            this.txb_cmnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_cmnd.Enabled = false;
            this.txb_cmnd.Location = new System.Drawing.Point(177, 98);
            this.txb_cmnd.Name = "txb_cmnd";
            this.txb_cmnd.Size = new System.Drawing.Size(249, 33);
            this.txb_cmnd.TabIndex = 11;
            // 
            // cbb_tenkh
            // 
            this.cbb_tenkh.FormattingEnabled = true;
            this.cbb_tenkh.Location = new System.Drawing.Point(177, 59);
            this.cbb_tenkh.Name = "cbb_tenkh";
            this.cbb_tenkh.Size = new System.Drawing.Size(195, 33);
            this.cbb_tenkh.TabIndex = 10;
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
            this.cl_soluong,
            this.cl_thanhtien});
            this.dgv_dichvu.Location = new System.Drawing.Point(4, 535);
            this.dgv_dichvu.Name = "dgv_dichvu";
            this.dgv_dichvu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_dichvu.RowHeadersVisible = false;
            this.dgv_dichvu.RowTemplate.Height = 25;
            this.dgv_dichvu.Size = new System.Drawing.Size(538, 183);
            this.dgv_dichvu.TabIndex = 9;
            // 
            // cl_dv
            // 
            this.cl_dv.HeaderText = "Dịch vụ";
            this.cl_dv.Name = "cl_dv";
            this.cl_dv.Width = 125;
            // 
            // cl_giatien
            // 
            this.cl_giatien.HeaderText = "Giá tiền";
            this.cl_giatien.Name = "cl_giatien";
            this.cl_giatien.Width = 150;
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label18.Location = new System.Drawing.Point(1, 478);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(537, 37);
            this.label18.TabIndex = 8;
            this.label18.Text = " Dịch vụ  -------------------------------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Loại phòng :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Phòng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tiền cọc :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số người :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày đi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày đến :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(1, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(534, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = " ĐẶT PHÒNG  -------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "CMND/CCCD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = " KHÁCH HÀNG  -----------------------------";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.groupBox1.Location = new System.Drawing.Point(568, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 339);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(6, 225);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(244, 47);
            this.btn_thoat.TabIndex = 0;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(6, 172);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(244, 47);
            this.btn_luu.TabIndex = 0;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(6, 119);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(244, 47);
            this.btn_reset.TabIndex = 0;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(6, 66);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(244, 47);
            this.btn_sua.TabIndex = 0;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // FrmSuaHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 743);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSuaHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSuaHoaDon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label18;
        private DataGridView dgv_dichvu;
        private DataGridViewTextBoxColumn cl_dv;
        private DataGridViewTextBoxColumn cl_giatien;
        private DataGridViewTextBoxColumn cl_soluong;
        private DataGridViewTextBoxColumn cl_thanhtien;
        private Label label2;
        private ComboBox cbb_loaiphong;
        private ComboBox cbb_phong;
        private DateTimePicker dtpk_kt;
        private DateTimePicker dtpk_bd;
        private TextBox txb_tiencoc;
        private TextBox txb_songuoi;
        private TextBox txb_sdt;
        private TextBox txb_cmnd;
        private ComboBox cbb_tenkh;
        private GroupBox groupBox1;
        private Button btn_thoat;
        private Button btn_luu;
        private Button btn_reset;
        private Button btn_sua;
    }
}