namespace C_GUI.Views
{
    partial class FrmAddorEditPhieuDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbGiaNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGiaGio = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLoaiPhong = new MetroFramework.Controls.MetroGrid();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(B_BUS.ViewModels.DichVuViewModel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhân viên tạo:";
            // 
            // tbGiaNgay
            // 
            this.tbGiaNgay.Location = new System.Drawing.Point(587, 157);
            this.tbGiaNgay.Name = "tbGiaNgay";
            this.tbGiaNgay.Size = new System.Drawing.Size(268, 39);
            this.tbGiaNgay.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày tạo:";
            // 
            // tbGiaGio
            // 
            this.tbGiaGio.Location = new System.Drawing.Point(147, 157);
            this.tbGiaGio.Name = "tbGiaGio";
            this.tbGiaGio.Size = new System.Drawing.Size(218, 39);
            this.tbGiaGio.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(706, 20);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(149, 49);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phiếu đặt:";
            // 
            // dgvLoaiPhong
            // 
            this.dgvLoaiPhong.AllowUserToAddRows = false;
            this.dgvLoaiPhong.AllowUserToDeleteRows = false;
            this.dgvLoaiPhong.AllowUserToResizeRows = false;
            this.dgvLoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLoaiPhong.AutoGenerateColumns = false;
            this.dgvLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoaiPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLoaiPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLoaiPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Tendichvu,
            this.SL,
            this.donGia,
            this.thanhTien,
            this.tenDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dgvLoaiPhong.DataSource = this.bindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiPhong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiPhong.EnableHeadersVisualStyles = false;
            this.dgvLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvLoaiPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLoaiPhong.Location = new System.Drawing.Point(23, 221);
            this.dgvLoaiPhong.Name = "dgvLoaiPhong";
            this.dgvLoaiPhong.ReadOnly = true;
            this.dgvLoaiPhong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoaiPhong.RowHeadersVisible = false;
            this.dgvLoaiPhong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLoaiPhong.RowTemplate.Height = 25;
            this.dgvLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiPhong.Size = new System.Drawing.Size(832, 446);
            this.dgvLoaiPhong.TabIndex = 11;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 73;
            // 
            // Tendichvu
            // 
            this.Tendichvu.HeaderText = "Tên dịch vụ";
            this.Tendichvu.Name = "Tendichvu";
            this.Tendichvu.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.Width = 59;
            // 
            // donGia
            // 
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            // 
            // thanhTien
            // 
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(708, 40);
            this.comboBox1.TabIndex = 12;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmAddorEditPhieuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 693);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvLoaiPhong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbGiaGio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGiaNgay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAddorEditPhieuDichVu";
            this.Text = "Phiếu Dịch Vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddorEditPhieuDichVu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private TextBox tbGiaNgay;
        private Label label4;
        private TextBox tbGiaGio;
        private Button btnLuu;
        private BindingSource bindingSource1;
        private Label label6;
        private MetroFramework.Controls.MetroGrid dgvLoaiPhong;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Tendichvu;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn donGia;
        private DataGridViewTextBoxColumn thanhTien;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}