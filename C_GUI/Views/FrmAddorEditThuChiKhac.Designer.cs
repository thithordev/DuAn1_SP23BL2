namespace C_GUI.Views
{
    partial class FrmAddorEditThuChiKhac
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
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            tbSoTien = new TextBox();
            label5 = new Label();
            tbMoTa = new TextBox();
            btnLuu = new Button();
            label3 = new Label();
            cbbLoai = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(B_BUS.ViewModels.ThuChiKhacViewModel);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 84);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 0;
            label2.Text = "Số tiền:";
            // 
            // tbSoTien
            // 
            tbSoTien.DataBindings.Add(new Binding("Text", bindingSource1, "SoTien", true));
            tbSoTien.Location = new Point(147, 81);
            tbSoTien.Name = "tbSoTien";
            tbSoTien.Size = new Size(334, 39);
            tbSoTien.TabIndex = 1;
            tbSoTien.KeyPress += tbSoTien_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 148);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 0;
            label5.Text = "Nội dung:";
            // 
            // tbMoTa
            // 
            tbMoTa.DataBindings.Add(new Binding("Text", bindingSource1, "NoiDung", true));
            tbMoTa.Location = new Point(147, 145);
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
            btnLuu.Location = new Point(525, 196);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(184, 73);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 84);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 32);
            label3.TabIndex = 4;
            label3.Text = "Loại:";
            // 
            // cbbLoai
            // 
            cbbLoai.DataBindings.Add(new Binding("SelectedItem", bindingSource1, "strTrangThai", true));
            cbbLoai.FormattingEnabled = true;
            cbbLoai.Items.AddRange(new object[] { "Thu", "Chi" });
            cbbLoai.Location = new Point(579, 81);
            cbbLoai.Name = "cbbLoai";
            cbbLoai.Size = new Size(134, 40);
            cbbLoai.TabIndex = 5;
            // 
            // FrmAddorEditThuChiKhac
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 302);
            Controls.Add(cbbLoai);
            Controls.Add(label3);
            Controls.Add(btnLuu);
            Controls.Add(tbMoTa);
            Controls.Add(label5);
            Controls.Add(tbSoTien);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "FrmAddorEditThuChiKhac";
            Text = "Thu Chi Khác";
            FormClosing += FrmAddorEditLoaiPhong_FormClosing;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox tbSoTien;
        private Label label5;
        private TextBox tbMoTa;
        private Button btnLuu;
        private BindingSource bindingSource1;
        private Label label3;
        private ComboBox cbbLoai;
    }
}