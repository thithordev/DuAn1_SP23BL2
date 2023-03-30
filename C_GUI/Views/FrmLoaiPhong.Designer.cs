﻿namespace C_GUI.Views
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            metroGridLoaiPhong = new MetroFramework.Controls.MetroGrid();
            Ten = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            SoGiuong = new DataGridViewTextBoxColumn();
            GiaNgay = new DataGridViewTextBoxColumn();
            GiaGio = new DataGridViewTextBoxColumn();
            Sua = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewTextBoxColumn();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)metroGridLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // metroGridLoaiPhong
            // 
            metroGridLoaiPhong.AllowUserToResizeRows = false;
            metroGridLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            metroGridLoaiPhong.BackgroundColor = Color.FromArgb(255, 255, 255);
            metroGridLoaiPhong.BorderStyle = BorderStyle.None;
            metroGridLoaiPhong.CellBorderStyle = DataGridViewCellBorderStyle.None;
            metroGridLoaiPhong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            metroGridLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            metroGridLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            metroGridLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { Ten, MoTa, SoGiuong, GiaNgay, GiaGio, Sua, Xoa });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            metroGridLoaiPhong.DefaultCellStyle = dataGridViewCellStyle2;
            metroGridLoaiPhong.EnableHeadersVisualStyles = false;
            metroGridLoaiPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            metroGridLoaiPhong.GridColor = Color.FromArgb(255, 255, 255);
            metroGridLoaiPhong.Location = new Point(55, 139);
            metroGridLoaiPhong.Name = "metroGridLoaiPhong";
            metroGridLoaiPhong.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            metroGridLoaiPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            metroGridLoaiPhong.RowHeadersVisible = false;
            metroGridLoaiPhong.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            metroGridLoaiPhong.RowTemplate.Height = 25;
            metroGridLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            metroGridLoaiPhong.Size = new Size(1169, 625);
            metroGridLoaiPhong.TabIndex = 4;
            // 
            // Ten
            // 
            Ten.HeaderText = "Tên";
            Ten.Name = "Ten";
            // 
            // MoTa
            // 
            MoTa.HeaderText = "Mô Tả";
            MoTa.Name = "MoTa";
            // 
            // SoGiuong
            // 
            SoGiuong.HeaderText = "Số Giường";
            SoGiuong.Name = "SoGiuong";
            // 
            // GiaNgay
            // 
            GiaNgay.HeaderText = "Giá Ngày";
            GiaNgay.Name = "GiaNgay";
            // 
            // GiaGio
            // 
            GiaGio.HeaderText = "Giá Giờ";
            GiaGio.Name = "GiaGio";
            // 
            // Sua
            // 
            Sua.HeaderText = "Sửa";
            Sua.Name = "Sua";
            // 
            // Xoa
            // 
            Xoa.HeaderText = "Xoá";
            Xoa.Name = "Xoa";
            // 
            // button2
            // 
            button2.Location = new Point(1014, 67);
            button2.Name = "button2";
            button2.Size = new Size(210, 40);
            button2.TabIndex = 2;
            button2.Text = "Thêm loại phòng";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 809);
            Controls.Add(metroGridLoaiPhong);
            Controls.Add(button2);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmLoaiPhong";
            Text = "Loại Phòng";
            ((System.ComponentModel.ISupportInitialize)metroGridLoaiPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridLoaiPhong;
        private Button button2;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn SoGiuong;
        private DataGridViewTextBoxColumn GiaNgay;
        private DataGridViewTextBoxColumn GiaGio;
        private DataGridViewTextBoxColumn Sua;
        private DataGridViewTextBoxColumn Xoa;
    }
}