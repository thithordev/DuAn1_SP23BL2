namespace C_GUI.UserControls
{
    partial class uc_PhongDangThue
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
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            btnInfo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 12);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 0;
            label1.Text = "P301";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 41);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 9);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 0;
            label3.Text = "2 Ngày";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(150, 9);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 0;
            label2.Text = "Phòng đang thuê";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.membership;
            pictureBox1.Location = new Point(20, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(173, 18);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 0;
            label4.Text = "Phòng Đôi";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(74, 61);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 0;
            label5.Text = "Phòng đang thuê";
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Transparent;
            btnInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnInfo.ForeColor = SystemColors.ControlText;
            btnInfo.Location = new Point(249, 52);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(42, 40);
            btnInfo.TabIndex = 3;
            btnInfo.Text = "🔎";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // uc_PhongDangThue
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 152, 219);
            Controls.Add(btnInfo);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(10);
            Name = "uc_PhongDangThue";
            Size = new Size(294, 134);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Button btnInfo;
    }
}
