namespace C_GUI.Views
{
    partial class FrmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plFormDangNhap = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plFormDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(376, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 32);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật Khẩu:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 32);
            this.textBox2.TabIndex = 2;
            // 
            // plFormDangNhap
            // 
            this.plFormDangNhap.Controls.Add(this.button1);
            this.plFormDangNhap.Controls.Add(this.textBox2);
            this.plFormDangNhap.Controls.Add(this.textBox1);
            this.plFormDangNhap.Controls.Add(this.label3);
            this.plFormDangNhap.Controls.Add(this.label5);
            this.plFormDangNhap.Controls.Add(this.label2);
            this.plFormDangNhap.Location = new System.Drawing.Point(277, 110);
            this.plFormDangNhap.Name = "plFormDangNhap";
            this.plFormDangNhap.Size = new System.Drawing.Size(398, 229);
            this.plFormDangNhap.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(10, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "error message";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_GUI.Properties.Resources.login_lock_icon;
            this.pictureBox1.Location = new System.Drawing.Point(29, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plFormDangNhap);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDangNhap";
            this.Text = "Hệ Thống Quản Lý Nhà Nghỉ";
            this.plFormDangNhap.ResumeLayout(false);
            this.plFormDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Panel plFormDangNhap;
        private Button button1;
        private Label label5;
        private PictureBox pictureBox1;
    }
}