namespace C_GUI.Views
{
    partial class FrmAddorEditQLPhong
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
            tbTrangThai = new TextBox();
            label3 = new Label();
            tbLoaiPhong = new TextBox();
            label4 = new Label();
            tbTang = new TextBox();
            label5 = new Label();
            tbGhiChu = new TextBox();
            btnLuu = new Button();
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
            bindingSource1.DataSource = typeof(B_BUS.ViewModels.PhongViewModel);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 153);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 32);
            label2.TabIndex = 0;
            label2.Text = "Trạng thái:";
            // 
            // tbTrangThai
            // 
            tbTrangThai.DataBindings.Add(new Binding("Text", bindingSource1, "TrangThai", true));
            tbTrangThai.Location = new Point(146, 150);
            tbTrangThai.Name = "tbTrangThai";
            tbTrangThai.Size = new Size(334, 39);
            tbTrangThai.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 150);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 0;
            label3.Text = "Loại phòng:";
            // 
            // tbLoaiPhong
            // 
            tbLoaiPhong.DataBindings.Add(new Binding("Text", bindingSource1, "LoaiPhongId", true));
            tbLoaiPhong.Location = new Point(625, 153);
            tbLoaiPhong.Name = "tbLoaiPhong";
            tbLoaiPhong.Size = new Size(268, 39);
            tbLoaiPhong.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(522, 87);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 32);
            label4.TabIndex = 0;
            label4.Text = "Tầng:";
            // 
            // tbTang
            // 
            tbTang.DataBindings.Add(new Binding("Text", bindingSource1, "Tang", true));
            tbTang.Location = new Point(625, 84);
            tbTang.Name = "tbTang";
            tbTang.Size = new Size(266, 39);
            tbTang.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 218);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 0;
            label5.Text = "Ghi chú:";
            // 
            // tbGhiChu
            // 
            tbGhiChu.DataBindings.Add(new Binding("Text", bindingSource1, "GhiChu", true));
            tbGhiChu.Location = new Point(146, 214);
            tbGhiChu.Multiline = true;
            tbGhiChu.Name = "tbGhiChu";
            tbGhiChu.Size = new Size(334, 134);
            tbGhiChu.TabIndex = 1;
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
            btnLuu.Click += btnLuu_Click;
            // 
            // FrmAddorEditQLPhong
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 388);
            Controls.Add(btnLuu);
            Controls.Add(tbGhiChu);
            Controls.Add(label5);
            Controls.Add(tbTang);
            Controls.Add(label4);
            Controls.Add(tbLoaiPhong);
            Controls.Add(label3);
            Controls.Add(tbTrangThai);
            Controls.Add(label2);
            Controls.Add(tbTen);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "FrmAddorEditQLPhong";
            Text = "Quản Lý Phòng";
            FormClosing += FrmAddorEditLoaiPhong_FormClosing;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbTen;
        private Label label2;
        private TextBox tbTrangThai;
        private Label label3;
        private TextBox tbGiaNgay;
        private Label label4;
        private TextBox tbGiaGio;
        private Label label5;
        private TextBox tbMoTa;
        private Button btnLuu;
        private BindingSource bindingSource1;
        private TextBox tbTang;
        private TextBox tbGhiChu;
        private TextBox tbLoaiPhong;
    }
}