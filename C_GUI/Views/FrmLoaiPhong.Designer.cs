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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            metroGridLoaiPhong = new MetroFramework.Controls.MetroGrid();
            button2 = new Button();
            Ten = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            SoGiuong = new DataGridViewTextBoxColumn();
            GiaNgay = new DataGridViewTextBoxColumn();
            GiaGio = new DataGridViewTextBoxColumn();
            Sua = new DataGridViewTextBoxColumn();
            Xoa = new DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            metroGridLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            metroGridLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            metroGridLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { Ten, MoTa, SoGiuong, GiaNgay, GiaGio, Sua, Xoa });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            metroGridLoaiPhong.DefaultCellStyle = dataGridViewCellStyle5;
            metroGridLoaiPhong.EnableHeadersVisualStyles = false;
            metroGridLoaiPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            metroGridLoaiPhong.GridColor = Color.FromArgb(255, 255, 255);
            metroGridLoaiPhong.Location = new Point(146, 154);
            metroGridLoaiPhong.Name = "metroGridLoaiPhong";
            metroGridLoaiPhong.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            metroGridLoaiPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            metroGridLoaiPhong.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            metroGridLoaiPhong.RowTemplate.Height = 25;
            metroGridLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            metroGridLoaiPhong.Size = new Size(941, 531);
            metroGridLoaiPhong.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(877, 74);
            button2.Name = "button2";
            button2.Size = new Size(210, 40);
            button2.TabIndex = 2;
            button2.Text = "Thêm loại phòng";
            button2.UseVisualStyleBackColor = true;
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