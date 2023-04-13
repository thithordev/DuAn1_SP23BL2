namespace C_GUI.Views
{
    partial class FrmThemDV
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Chocolate;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(114, 433);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 66);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHuyBo.FlatAppearance.BorderSize = 0;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuyBo.ForeColor = System.Drawing.Color.White;
            this.btnHuyBo.Location = new System.Drawing.Point(509, 433);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(165, 66);
            this.btnHuyBo.TabIndex = 3;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Tomato;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(315, 433);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(165, 66);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(55, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 79);
            this.panel2.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTen.Location = new System.Drawing.Point(10, 35);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(456, 39);
            this.txtTen.TabIndex = 1;
            this.txtTen.Leave += new System.EventHandler(this.txtTen_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên dịch vụ:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtGia);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(55, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 85);
            this.panel3.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGia.Location = new System.Drawing.Point(8, 29);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(456, 39);
            this.txtGia.TabIndex = 1;
            this.txtGia.Leave += new System.EventHandler(this.txtGia_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(55, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(496, 70);
            this.panel4.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Items.AddRange(new object[] {
            "Cung Cấp",
            "Ngưng Cung Cấp"});
            this.comboBox1.Location = new System.Drawing.Point(149, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 32);
            this.comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "TrangThai:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(88, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 343);
            this.panel1.TabIndex = 1;
            // 
            // FrmThemDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(809, 547);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Name = "FrmThemDV";
            this.Text = "Dịch Vụ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnThem;
        private Button btnHuyBo;
        private Button btnSua;
        private Panel panel2;
        private TextBox txtTen;
        private Label label2;
        private Panel panel3;
        private TextBox txtGia;
        private Label label3;
        private Panel panel4;
        private ComboBox comboBox1;
        private Label label4;
        private Panel panel1;
    }
}