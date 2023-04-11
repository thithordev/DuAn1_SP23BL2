namespace C_GUI.Views
{
    partial class FrmAddorEditPhieuDat
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
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTenDem = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.dtpNgayDatTra = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbPhiPhong = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbGioDat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbGioDatTra = new System.Windows.Forms.ComboBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnTimPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ:";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(B_BUS.ViewModels.PhieuDatPhongViewModel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đến:";
            // 
            // tbTenDem
            // 
            this.tbTenDem.Location = new System.Drawing.Point(132, 46);
            this.tbTenDem.Name = "tbTenDem";
            this.tbTenDem.Size = new System.Drawing.Size(199, 39);
            this.tbTenDem.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(717, 22);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(182, 56);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.CustomFormat = "dd/MM/yyyy  HH:mm";
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDat.Location = new System.Drawing.Point(88, 164);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(163, 39);
            this.dtpNgayDat.TabIndex = 3;
            this.dtpNgayDat.ValueChanged += new System.EventHandler(this.dtpNgayDat_ValueChanged);
            // 
            // cbbPhong
            // 
            this.cbbPhong.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSource1, "PhongVM", true));
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(206, 238);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(328, 40);
            this.cbbPhong.TabIndex = 4;
            this.cbbPhong.SelectedIndexChanged += new System.EventHandler(this.cbbPhong_SelectedIndexChanged);
            // 
            // dtpNgayDatTra
            // 
            this.dtpNgayDatTra.CustomFormat = "dd/MM/yyyy  HH:mm";
            this.dtpNgayDatTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDatTra.Location = new System.Drawing.Point(566, 164);
            this.dtpNgayDatTra.Name = "dtpNgayDatTra";
            this.dtpNgayDatTra.Size = new System.Drawing.Size(163, 39);
            this.dtpNgayDatTra.TabIndex = 3;
            this.dtpNgayDatTra.ValueChanged += new System.EventHandler(this.dtpNgayDatTra_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "CCCD/CMTND:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 39);
            this.textBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên đệm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.tbTenDem);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(23, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 246);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(736, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 40);
            this.comboBox2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(411, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 39);
            this.textBox2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giới tính:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 120);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "SDT:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(625, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(251, 39);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(751, 39);
            this.textBox3.TabIndex = 1;
            // 
            // lbPhiPhong
            // 
            this.lbPhiPhong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbPhiPhong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "StrPhiPhong", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbPhiPhong.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPhiPhong.ForeColor = System.Drawing.Color.Brown;
            this.lbPhiPhong.Location = new System.Drawing.Point(674, 225);
            this.lbPhiPhong.Name = "lbPhiPhong";
            this.lbPhiPhong.Size = new System.Drawing.Size(225, 60);
            this.lbPhiPhong.TabIndex = 11;
            this.lbPhiPhong.Text = "0 đ";
            this.lbPhiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(40, 98);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(166, 36);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Đặt theo giờ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(237, 97);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(184, 36);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "Đặt theo ngày";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(459, 97);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(180, 36);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.Text = "Đặt theo đêm";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "-";
            // 
            // cbbGioDat
            // 
            this.cbbGioDat.FormattingEnabled = true;
            this.cbbGioDat.Location = new System.Drawing.Point(335, 163);
            this.cbbGioDat.Name = "cbbGioDat";
            this.cbbGioDat.Size = new System.Drawing.Size(121, 40);
            this.cbbGioDat.TabIndex = 13;
            this.cbbGioDat.SelectedIndexChanged += new System.EventHandler(this.cbbGioDat_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(742, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "-";
            // 
            // cbbGioDatTra
            // 
            this.cbbGioDatTra.FormattingEnabled = true;
            this.cbbGioDatTra.Location = new System.Drawing.Point(778, 163);
            this.cbbGioDatTra.Name = "cbbGioDatTra";
            this.cbbGioDatTra.Size = new System.Drawing.Size(121, 40);
            this.cbbGioDatTra.TabIndex = 13;
            this.cbbGioDatTra.SelectedIndexChanged += new System.EventHandler(this.cbbGioDatTra_SelectedIndexChanged);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(B_BUS.ViewModels.PhongViewModel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTimPhong
            // 
            this.btnTimPhong.Location = new System.Drawing.Point(28, 237);
            this.btnTimPhong.Name = "btnTimPhong";
            this.btnTimPhong.Size = new System.Drawing.Size(167, 43);
            this.btnTimPhong.TabIndex = 15;
            this.btnTimPhong.Text = "Tìm phòng:";
            this.btnTimPhong.UseVisualStyleBackColor = true;
            this.btnTimPhong.Click += new System.EventHandler(this.btnTimPhong_Click);
            // 
            // FrmAddorEditPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 568);
            this.Controls.Add(this.btnTimPhong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbGioDatTra);
            this.Controls.Add(this.cbbGioDat);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lbPhiPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbPhong);
            this.Controls.Add(this.dtpNgayDatTra);
            this.Controls.Add(this.dtpNgayDat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmAddorEditPhieuDat";
            this.Resizable = false;
            this.Text = "Phiếu đặt phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddorEditLoaiPhong_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox tbTenDem;
        private Button btnLuu;
        private BindingSource bindingSource1;
        private DateTimePicker dtpNgayDat;
        private ComboBox cbbPhong;
        private DateTimePicker dtpNgayDatTra;
        private Label label9;
        private TextBox textBox1;
        private Label label6;
        private Label label10;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private Label label11;
        private Label label2;
        private Label label12;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label lbPhiPhong;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label7;
        private ComboBox cbbGioDat;
        private Label label8;
        private ComboBox cbbGioDatTra;
        private BindingSource bindingSource2;
        private Button button1;
        private Button btnTimPhong;
    }
}