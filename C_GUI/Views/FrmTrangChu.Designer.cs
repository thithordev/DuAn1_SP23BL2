namespace C_GUI.Views
{
    partial class FrmTrangChu
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
            btnDatPhong = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.FromArgb(41, 128, 185);
            btnDatPhong.FlatAppearance.BorderSize = 0;
            btnDatPhong.FlatStyle = FlatStyle.Flat;
            btnDatPhong.ForeColor = Color.White;
            btnDatPhong.Location = new Point(24, 56);
            btnDatPhong.Margin = new Padding(5);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(196, 119);
            btnDatPhong.TabIndex = 0;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnDatPhong);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(35, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1190, 203);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng nhanh";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(52, 152, 219);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(968, 56);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(196, 119);
            button4.TabIndex = 0;
            button4.Text = "Thanh toán";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(142, 68, 173);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(732, 56);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(196, 119);
            button3.TabIndex = 0;
            button3.Text = "Gọi Dịch Vụ";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(22, 160, 133);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(260, 56);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(196, 119);
            button5.TabIndex = 0;
            button5.Text = "Nhận phòng";
            button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 126, 34);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(496, 56);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(196, 119);
            button2.TabIndex = 0;
            button2.Text = "Thuê phòng";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(35, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(575, 515);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông báo";
            // 
            // groupBox4
            // 
            groupBox4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(650, 259);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(575, 515);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Request";
            // 
            // FrmTrangChu
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1269, 809);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmTrangChu";
            Text = "FrmTrangChu";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnDatPhong;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
    }
}