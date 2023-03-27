namespace C_GUI.Views
{
    partial class FrmLoaiPhong
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
            label15 = new Label();
            label16 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Gold;
            label15.Location = new Point(370, 21);
            label15.Name = "label15";
            label15.Size = new Size(61, 37);
            label15.TabIndex = 30;
            label15.Text = "VIP";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(253, 31);
            label16.Name = "label16";
            label16.Size = new Size(111, 25);
            label16.TabIndex = 29;
            label16.Text = "Loại phòng:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(134, 135);
            label14.Name = "label14";
            label14.Size = new Size(140, 37);
            label14.TabIndex = 28;
            label14.Text = "50.000đ/h";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(134, 93);
            label13.Name = "label13";
            label13.Size = new Size(129, 37);
            label13.TabIndex = 27;
            label13.Text = "100.000đ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(134, 45);
            label12.Name = "label12";
            label12.Size = new Size(32, 37);
            label12.TabIndex = 26;
            label12.Text = "2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(134, 11);
            label11.Name = "label11";
            label11.Size = new Size(62, 37);
            label11.TabIndex = 25;
            label11.Text = "101";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 145);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 24;
            label7.Text = "Giá giờ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 103);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 23;
            label8.Text = "Giá ngày: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 55);
            label9.Name = "label9";
            label9.Size = new Size(102, 25);
            label9.TabIndex = 22;
            label9.Text = "Số giường:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 21);
            label10.Name = "label10";
            label10.Size = new Size(102, 25);
            label10.TabIndex = 21;
            label10.Text = "Số phòng: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 191);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 31;
            label1.Text = "Mô tả:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(115, 188);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(343, 118);
            richTextBox1.TabIndex = 32;
            richTextBox1.Text = "Phòng siêu víp pro";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(343, 312);
            button1.Name = "button1";
            button1.Size = new Size(115, 45);
            button1.TabIndex = 33;
            button1.Text = "ĐÓNG";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 369);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmLoaiPhong";
            Text = "Loại Phòng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label15;
        private Label label16;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}