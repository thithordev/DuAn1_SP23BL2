﻿namespace C_GUI.Views
{
    partial class FrmAddorEditLoaiPhong
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoGiuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGiaNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGiaGio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMoTa = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // tbTen
            // 
            this.tbTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Ten", true));
            this.tbTen.Location = new System.Drawing.Point(114, 103);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(347, 39);
            this.tbTen.TabIndex = 1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(B_BUS.ViewModels.LoaiPhongViewModel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ở tối đa:";
            // 
            // tbSoGiuong
            // 
            this.tbSoGiuong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "OToiDa", true));
            this.tbSoGiuong.Location = new System.Drawing.Point(173, 184);
            this.tbSoGiuong.Name = "tbSoGiuong";
            this.tbSoGiuong.Size = new System.Drawing.Size(288, 39);
            this.tbSoGiuong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá ngày:";
            // 
            // tbGiaNgay
            // 
            this.tbGiaNgay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "GiaNgay", true));
            this.tbGiaNgay.Location = new System.Drawing.Point(613, 103);
            this.tbGiaNgay.Name = "tbGiaNgay";
            this.tbGiaNgay.Size = new System.Drawing.Size(288, 39);
            this.tbGiaNgay.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá giờ:";
            // 
            // tbGiaGio
            // 
            this.tbGiaGio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "GiaGio", true));
            this.tbGiaGio.Location = new System.Drawing.Point(613, 184);
            this.tbGiaGio.Name = "tbGiaGio";
            this.tbGiaGio.Size = new System.Drawing.Size(288, 39);
            this.tbGiaGio.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mô tả:";
            // 
            // tbMoTa
            // 
            this.tbMoTa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Mota", true));
            this.tbMoTa.Location = new System.Drawing.Point(146, 272);
            this.tbMoTa.Multiline = true;
            this.tbMoTa.Name = "tbMoTa";
            this.tbMoTa.Size = new System.Drawing.Size(492, 73);
            this.tbMoTa.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(675, 268);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(184, 73);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // FrmAddorEditLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 388);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbMoTa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbGiaGio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGiaNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSoGiuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAddorEditLoaiPhong";
            this.Text = "Loại Phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddorEditLoaiPhong_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbTen;
        private Label label2;
        private TextBox tbSoGiuong;
        private Label label3;
        private TextBox tbGiaNgay;
        private Label label4;
        private TextBox tbGiaGio;
        private Label label5;
        private TextBox tbMoTa;
        private Button btnLuu;
        private BindingSource bindingSource1;
    }
}