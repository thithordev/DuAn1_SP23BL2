namespace C_GUI.UserControls
{
    partial class uc_Phong
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
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.btnChecked = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.lbHienTrang = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTang = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTen
            // 
            this.lbTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTen.ForeColor = System.Drawing.Color.White;
            this.lbTen.Location = new System.Drawing.Point(66, 0);
            this.lbTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(84, 32);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "P101";
            this.lbTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.lbTrangThai);
            this.panel1.Controls.Add(this.btnChecked);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 39);
            this.panel1.TabIndex = 1;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTrangThai.ForeColor = System.Drawing.Color.White;
            this.lbTrangThai.Location = new System.Drawing.Point(200, 10);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(75, 22);
            this.lbTrangThai.TabIndex = 5;
            this.lbTrangThai.Text = "Đã dọn dẹp";
            this.lbTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnChecked
            // 
            this.btnChecked.BackColor = System.Drawing.Color.Transparent;
            this.btnChecked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChecked.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChecked.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChecked.Location = new System.Drawing.Point(14, 8);
            this.btnChecked.Name = "btnChecked";
            this.btnChecked.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChecked.Size = new System.Drawing.Size(28, 25);
            this.btnChecked.TabIndex = 4;
            this.btnChecked.UseVisualStyleBackColor = false;
            this.btnChecked.Click += new System.EventHandler(this.btnChecked_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(47, 11);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(158, 21);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "0 Giờ";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.lbLoaiPhong.Location = new System.Drawing.Point(145, 5);
            this.lbLoaiPhong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(129, 25);
            this.lbLoaiPhong.TabIndex = 0;
            this.lbLoaiPhong.Text = "Phòng Đôi";
            this.lbLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHienTrang
            // 
            this.lbHienTrang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbHienTrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHienTrang.ForeColor = System.Drawing.Color.White;
            this.lbHienTrang.Location = new System.Drawing.Point(69, 42);
            this.lbHienTrang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbHienTrang.Name = "lbHienTrang";
            this.lbHienTrang.Size = new System.Drawing.Size(188, 25);
            this.lbHienTrang.TabIndex = 0;
            this.lbHienTrang.Text = "Phòng Trống";
            this.lbHienTrang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(60, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 100);
            this.panel2.TabIndex = 5;
            // 
            // lbTang
            // 
            this.lbTang.AutoSize = true;
            this.lbTang.BackColor = System.Drawing.Color.Transparent;
            this.lbTang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTang.ForeColor = System.Drawing.Color.White;
            this.lbTang.Location = new System.Drawing.Point(38, 43);
            this.lbTang.Name = "lbTang";
            this.lbTang.Size = new System.Drawing.Size(19, 21);
            this.lbTang.TabIndex = 6;
            this.lbTang.Text = "1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::C_GUI.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(16, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tầng";
            // 
            // uc_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Controls.Add(this.lbLoaiPhong);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbHienTrang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTang);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_Phong";
            this.Size = new System.Drawing.Size(278, 106);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTen;
        private Panel panel1;
        private Label lbStatus;
        private Label lbLoaiPhong;
        private Label lbHienTrang;
        private Button btnChecked;
        private Panel panel2;
        private Label lbTang;
        private PictureBox pictureBox2;
        private Label lbTrangThai;
        private Label label1;
    }
}
