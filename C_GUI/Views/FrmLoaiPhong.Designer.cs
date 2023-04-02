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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvLoaiPhong = new MetroFramework.Controls.MetroGrid();
            STT = new DataGridViewTextBoxColumn();
            tenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soGiuongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaNgayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaGioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            motaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            loaiPhongViewModelBindingSource = new BindingSource(components);
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaiPhongViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.AllowUserToResizeRows = false;
            dgvLoaiPhong.AutoGenerateColumns = false;
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
            dgvLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { STT, tenDataGridViewTextBoxColumn, soGiuongDataGridViewTextBoxColumn, giaNgayDataGridViewTextBoxColumn, giaGioDataGridViewTextBoxColumn, motaDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn });
            dgvLoaiPhong.DataSource = loaiPhongViewModelBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLoaiPhong.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLoaiPhong.EnableHeadersVisualStyles = false;
            dgvLoaiPhong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvLoaiPhong.GridColor = Color.FromArgb(255, 255, 255);
            dgvLoaiPhong.Location = new Point(37, 132);
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
            dgvLoaiPhong.Size = new Size(1194, 454);
            dgvLoaiPhong.TabIndex = 4;
            // 
            // STT
            // 
            STT.HeaderText = "STT";
            STT.Name = "STT";
            // 
            // tenDataGridViewTextBoxColumn
            // 
            tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            tenDataGridViewTextBoxColumn.HeaderText = "Tên";
            tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // soGiuongDataGridViewTextBoxColumn
            // 
            soGiuongDataGridViewTextBoxColumn.DataPropertyName = "SoGiuong";
            soGiuongDataGridViewTextBoxColumn.HeaderText = "Số Giường";
            soGiuongDataGridViewTextBoxColumn.Name = "soGiuongDataGridViewTextBoxColumn";
            // 
            // giaNgayDataGridViewTextBoxColumn
            // 
            giaNgayDataGridViewTextBoxColumn.DataPropertyName = "GiaNgay";
            giaNgayDataGridViewTextBoxColumn.HeaderText = "Giá Ngày";
            giaNgayDataGridViewTextBoxColumn.Name = "giaNgayDataGridViewTextBoxColumn";
            // 
            // giaGioDataGridViewTextBoxColumn
            // 
            giaGioDataGridViewTextBoxColumn.DataPropertyName = "GiaGio";
            giaGioDataGridViewTextBoxColumn.HeaderText = "Giá Giờ";
            giaGioDataGridViewTextBoxColumn.Name = "giaGioDataGridViewTextBoxColumn";
            // 
            // motaDataGridViewTextBoxColumn
            // 
            motaDataGridViewTextBoxColumn.DataPropertyName = "Mota";
            motaDataGridViewTextBoxColumn.HeaderText = "Mô Tả";
            motaDataGridViewTextBoxColumn.Name = "motaDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // loaiPhongViewModelBindingSource
            // 
            loaiPhongViewModelBindingSource.DataSource = typeof(B_BUS.ViewModels.LoaiPhongViewModel);
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(46, 204, 113);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(652, 48);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(173, 59);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(52, 152, 219);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(859, 48);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(173, 59);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(230, 126, 34);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(1058, 48);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(173, 59);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // FrmLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 809);
            Controls.Add(dgvLoaiPhong);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmLoaiPhong";
            Text = "Loại Phòng";
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaiPhongViewModelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvLoaiPhong;
        private Button btnThem;
        private BindingSource loaiPhongViewModelBindingSource;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soGiuongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaNgayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaGioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private Button btnSua;
        private Button btnXoa;
    }
}