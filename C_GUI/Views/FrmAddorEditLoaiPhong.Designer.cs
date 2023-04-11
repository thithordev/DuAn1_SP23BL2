namespace C_GUI.Views
{
    partial class FrmAddorEditLoaiPhong
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
            label1 = new Label();
            tbTen = new TextBox();
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            tbSoGiuong = new TextBox();
            label3 = new Label();
            tbGiaNgay = new TextBox();
            label4 = new Label();
            tbGiaGio = new TextBox();
            label5 = new Label();
            tbMoTa = new TextBox();
            btnLuu = new Button();
            label6 = new Label();
            tbGiaDem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 90);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên:";
            // 
            // tbTen
            // 
            tbTen.DataBindings.Add(new Binding("Text", bindingSource1, "Ten", true));
            tbTen.Location = new Point(93, 87);
            tbTen.Name = "tbTen";
            tbTen.Size = new Size(387, 39);
            tbTen.TabIndex = 1;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(B_BUS.ViewModels.LoaiPhongViewModel);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 153);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 0;
            label2.Text = "Ở tối đa:";
            // 
            // tbSoGiuong
            // 
            tbSoGiuong.DataBindings.Add(new Binding("Text", bindingSource1, "OToiDa", true));
            tbSoGiuong.Location = new Point(146, 150);
            tbSoGiuong.Name = "tbSoGiuong";
            tbSoGiuong.Size = new Size(334, 39);
            tbSoGiuong.TabIndex = 1;
            tbSoGiuong.KeyPress += tbSoGiuong_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 150);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 0;
            label3.Text = "Giá ngày:";
            // 
            // tbGiaNgay
            // 
            tbGiaNgay.DataBindings.Add(new Binding("Text", bindingSource1, "GiaNgay", true));
            tbGiaNgay.Location = new Point(623, 150);
            tbGiaNgay.Name = "tbGiaNgay";
            tbGiaNgay.Size = new Size(268, 39);
            tbGiaNgay.TabIndex = 1;
            tbGiaNgay.KeyPress += tbGiaNgay_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(522, 87);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 32);
            label4.TabIndex = 0;
            label4.Text = "Giá giờ:";
            // 
            // tbGiaGio
            // 
            tbGiaGio.DataBindings.Add(new Binding("Text", bindingSource1, "GiaGio", true));
            tbGiaGio.Location = new Point(625, 84);
            tbGiaGio.Name = "tbGiaGio";
            tbGiaGio.Size = new Size(266, 39);
            tbGiaGio.TabIndex = 1;
            tbGiaGio.KeyPress += tbGiaGio_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 218);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 0;
            label5.Text = "Mô tả:";
            // 
            // tbMoTa
            // 
            tbMoTa.DataBindings.Add(new Binding("Text", bindingSource1, "Mota", true));
            tbMoTa.Location = new Point(146, 214);
            tbMoTa.Multiline = true;
            tbMoTa.Name = "tbMoTa";
            tbMoTa.Size = new Size(334, 134);
            tbMoTa.TabIndex = 1;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(26, 188, 156);
            btnLuu.DialogResult = DialogResult.OK;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(657, 275);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(184, 73);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(506, 214);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(108, 32);
            label6.TabIndex = 0;
            label6.Text = "Giá đêm:";
            // 
            // tbGiaDem
            // 
            tbGiaDem.DataBindings.Add(new Binding("Text", bindingSource1, "GiaDem", true));
            tbGiaDem.Location = new Point(625, 211);
            tbGiaDem.Name = "tbGiaDem";
            tbGiaDem.Size = new Size(268, 39);
            tbGiaDem.TabIndex = 1;
            tbGiaDem.KeyPress += textBox1_KeyPress;
            // 
            // FrmAddorEditLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 388);
            Controls.Add(btnLuu);
            Controls.Add(tbMoTa);
            Controls.Add(label5);
            Controls.Add(tbGiaGio);
            Controls.Add(label4);
            Controls.Add(tbGiaDem);
            Controls.Add(tbGiaNgay);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(tbSoGiuong);
            Controls.Add(label2);
            Controls.Add(tbTen);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "FrmAddorEditLoaiPhong";
            Text = "Loại Phòng";
            FormClosing += FrmAddorEditLoaiPhong_FormClosing;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbTen;
        private Label label2;
        private TextBox tbSoGiuong;
        private Label label3;
        private TextBox tbGiaNgay;
        private Label label4;
        private TextBox tbGiaGio;
        private Label label5;
        private TextBox tbMoTa;
        private Button btnLuu;
        private BindingSource bindingSource1;
        private Label label6;
        private TextBox tbGiaDem;
    }
}