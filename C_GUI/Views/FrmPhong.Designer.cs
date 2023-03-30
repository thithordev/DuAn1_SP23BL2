namespace C_GUI.Views
{
    partial class FrmPhong
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            panel3 = new Panel();
            radioButton9 = new RadioButton();
            label3 = new Label();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            panel2 = new Panel();
            metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            label2 = new Label();
            panel1 = new Panel();
            radioButton4 = new RadioButton();
            label1 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(140, 557);
            button1.Name = "button1";
            button1.Size = new Size(107, 50);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(991, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 145);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // button2
            // 
            button2.Location = new Point(47, 90);
            button2.Name = "button2";
            button2.Size = new Size(181, 41);
            button2.TabIndex = 1;
            button2.Text = "Tìm";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 32);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(991, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 634);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lọc";
            // 
            // button3
            // 
            button3.Location = new Point(19, 557);
            button3.Name = "button3";
            button3.Size = new Size(106, 50);
            button3.TabIndex = 11;
            button3.Text = "Lọc";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(radioButton9);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(radioButton10);
            panel3.Controls.Add(radioButton11);
            panel3.Controls.Add(radioButton12);
            panel3.Location = new Point(21, 353);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 198);
            panel3.TabIndex = 1;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(40, 158);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(80, 29);
            radioButton9.TabIndex = 0;
            radioButton9.TabStop = true;
            radioButton9.Text = "Tất cả";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(15, 5);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 0;
            label3.Text = "Dọn Dẹp";
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(40, 122);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(107, 29);
            radioButton10.TabIndex = 0;
            radioButton10.TabStop = true;
            radioButton10.Text = "Sửa chữa";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(40, 86);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(149, 29);
            radioButton11.TabIndex = 0;
            radioButton11.TabStop = true;
            radioButton11.Text = "Chưa dọn dẹp";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(40, 50);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(128, 29);
            radioButton12.TabIndex = 0;
            radioButton12.TabStop = true;
            radioButton12.Text = "Đã dọn dẹp";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(metroComboBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(21, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 102);
            panel2.TabIndex = 1;
            // 
            // metroComboBox1
            // 
            metroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            metroComboBox1.FormattingEnabled = true;
            metroComboBox1.ItemHeight = 29;
            metroComboBox1.Items.AddRange(new object[] { "Phòng Đơn", "Phòng Đôi", "Tất Cả" });
            metroComboBox1.Location = new Point(15, 57);
            metroComboBox1.Name = "metroComboBox1";
            metroComboBox1.Size = new Size(201, 35);
            metroComboBox1.TabIndex = 1;
            metroComboBox1.UseSelectable = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(15, 10);
            label2.Name = "label2";
            label2.Size = new Size(128, 30);
            label2.TabIndex = 0;
            label2.Text = "Loại Phòng";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(21, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 198);
            panel1.TabIndex = 1;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(40, 158);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(140, 29);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Tất cả phòng";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(15, 5);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 0;
            label1.Text = "Trạng thái";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(40, 122);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(176, 29);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Phòng đang thuê";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(40, 86);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(143, 29);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Phòng đã đặt";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(40, 50);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(136, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Phòng trống";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(12, 809);
            panel4.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Gainsboro;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(12, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(967, 809);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // FrmPhong
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1269, 809);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmPhong";
            Text = "adm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Panel panel1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel3;
        private RadioButton radioButton9;
        private Label label3;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private Panel panel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private Label label2;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Button button3;
    }
}