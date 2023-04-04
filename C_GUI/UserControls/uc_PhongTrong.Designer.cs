namespace C_GUI.UserControls
{
    partial class uc_PhongTrong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnChecked = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTang = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTen
            // 
            this.lbTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTen.ForeColor = System.Drawing.Color.White;
            this.lbTen.Location = new System.Drawing.Point(87, 15);
            this.lbTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(93, 32);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "P101";
            this.lbTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.btnChiTiet);
            this.panel1.Controls.Add(this.btnChecked);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 46);
            this.panel1.TabIndex = 1;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChiTiet.FlatAppearance.BorderSize = 0;
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.Location = new System.Drawing.Point(258, 0);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(74, 46);
            this.btnChiTiet.TabIndex = 5;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnChecked
            // 
            this.btnChecked.BackColor = System.Drawing.Color.Transparent;
            this.btnChecked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChecked.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChecked.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChecked.Location = new System.Drawing.Point(15, 9);
            this.btnChecked.Name = "btnChecked";
            this.btnChecked.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChecked.Size = new System.Drawing.Size(35, 30);
            this.btnChecked.TabIndex = 4;
            this.btnChecked.UseVisualStyleBackColor = false;
            this.btnChecked.Click += new System.EventHandler(this.btnChecked_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(62, 13);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(47, 21);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "0 Giờ";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 32);
            this.textBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_GUI.Properties.Resources.membership;
            this.pictureBox1.Location = new System.Drawing.Point(9, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.lbLoaiPhong.Location = new System.Drawing.Point(173, 18);
            this.lbLoaiPhong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(152, 25);
            this.lbLoaiPhong.TabIndex = 0;
            this.lbLoaiPhong.Text = "Phòng Đôi";
            this.lbLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTrangThai.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTrangThai.ForeColor = System.Drawing.Color.White;
            this.lbTrangThai.Location = new System.Drawing.Point(85, 75);
            this.lbTrangThai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(188, 25);
            this.lbTrangThai.TabIndex = 0;
            this.lbTrangThai.Text = "Phòng Trống";
            this.lbTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(64, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 100);
            this.panel2.TabIndex = 5;
            // 
            // lbTang
            // 
            this.lbTang.AutoSize = true;
            this.lbTang.BackColor = System.Drawing.Color.Transparent;
            this.lbTang.ForeColor = System.Drawing.Color.White;
            this.lbTang.Location = new System.Drawing.Point(56, 4);
            this.lbTang.Name = "lbTang";
            this.lbTang.Size = new System.Drawing.Size(23, 25);
            this.lbTang.TabIndex = 6;
            this.lbTang.Text = "1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::C_GUI.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(10, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // uc_PhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTang);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.lbLoaiPhong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "uc_PhongTrong";
            this.Size = new System.Drawing.Size(332, 162);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTen;
        private Panel panel1;
        private Label lbStatus;
        private PictureBox pictureBox1;
        private Label lbLoaiPhong;
        private Label lbTrangThai;
        private Button btnChecked;
        private TextBox textBox1;
        private Panel panel2;
        private Label lbTang;
        private PictureBox pictureBox2;
        private Button btnChiTiet;
    }
}
