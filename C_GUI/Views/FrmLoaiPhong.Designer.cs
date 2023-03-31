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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvLoaiPhong = new MetroFramework.Controls.MetroGrid();
            STT = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            SoGiuong = new DataGridViewTextBoxColumn();
            GiaNgay = new DataGridViewTextBoxColumn();
            GiaGio = new DataGridViewTextBoxColumn();
            button2 = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.AllowUserToResizeRows = false;
            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiPhong.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvLoaiPhong.BorderStyle = BorderStyle.None;
            dgvLoaiPhong.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvLoaiPhong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { STT, Ten, MoTa, SoGiuong, GiaNgay, GiaGio });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLoaiPhong.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLoaiPhong.EnableHeadersVisualStyles = false;
            dgvLoaiPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvLoaiPhong.GridColor = Color.FromArgb(255, 255, 255);
            dgvLoaiPhong.Location = new Point(55, 139);
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLoaiPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLoaiPhong.RowHeadersVisible = false;
            dgvLoaiPhong.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvLoaiPhong.RowTemplate.Height = 25;
            dgvLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiPhong.Size = new Size(1169, 625);
            dgvLoaiPhong.TabIndex = 4;
            dgvLoaiPhong.CellClick += dgvLoaiPhong_CellClick;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.Name = "STT";
            // 
            // Ten
            // 
            Ten.HeaderText = "Tên";
            Ten.Name = "Ten";
            // 
            // MoTa
            // 
            MoTa.HeaderText = "Mô tả";
            MoTa.Name = "MoTa";
            // 
            // SoGiuong
            // 
            SoGiuong.HeaderText = "Số giường";
            SoGiuong.Name = "SoGiuong";
            // 
            // GiaNgay
            // 
            GiaNgay.HeaderText = "Giá ngày";
            GiaNgay.Name = "GiaNgay";
            // 
            // GiaGio
            // 
            GiaGio.HeaderText = "Giá giờ";
            GiaGio.Name = "GiaGio";
            // 
            // button2
            // 
            button2.Location = new Point(1014, 68);
            button2.Name = "button2";
            button2.Size = new Size(210, 40);
            button2.TabIndex = 2;
            button2.Text = "Thêm loại phòng";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(331, 71);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(210, 40);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(55, 76);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(270, 32);
            txtTimKiem.TabIndex = 6;
            // 
            // FrmLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 809);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvLoaiPhong);
            Controls.Add(button2);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmLoaiPhong";
            Text = "Loại Phòng";
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvLoaiPhong;
        private Button button2;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn SoGiuong;
        private DataGridViewTextBoxColumn GiaNgay;
        private DataGridViewTextBoxColumn GiaGio;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
    }
}