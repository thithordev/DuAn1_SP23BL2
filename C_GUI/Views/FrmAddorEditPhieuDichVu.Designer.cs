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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbGiaNgay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGiaGio = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCTPhieuDichVu = new MetroFramework.Controls.MetroGrid();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveSL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddSL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cbbPhieuDat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(B_BUS.ViewModels.PhieuDichVuViewModel);
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
            this.tbGiaNgay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "HoTen_NhanVienVM", true));
            this.tbGiaNgay.Enabled = false;
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
            this.tbGiaGio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "NgayTao", true));
            this.tbGiaGio.Enabled = false;
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
            this.btnLuu.Location = new System.Drawing.Point(476, 20);
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
            // dgvCTPhieuDichVu
            // 
            this.dgvCTPhieuDichVu.AllowUserToAddRows = false;
            this.dgvCTPhieuDichVu.AllowUserToDeleteRows = false;
            this.dgvCTPhieuDichVu.AllowUserToResizeRows = false;
            this.dgvCTPhieuDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCTPhieuDichVu.AutoGenerateColumns = false;
            this.dgvCTPhieuDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPhieuDichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCTPhieuDichVu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCTPhieuDichVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCTPhieuDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCTPhieuDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTPhieuDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTPhieuDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPhieuDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Tendichvu,
            this.RemoveSL,
            this.SL,
            this.AddSL,
            this.donGia,
            this.thanhTien,
            this.idDataGridViewTextBoxColumn});
            this.dgvCTPhieuDichVu.DataSource = this.bindingSource2;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTPhieuDichVu.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCTPhieuDichVu.EnableHeadersVisualStyles = false;
            this.dgvCTPhieuDichVu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCTPhieuDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCTPhieuDichVu.Location = new System.Drawing.Point(23, 223);
            this.dgvCTPhieuDichVu.Name = "dgvCTPhieuDichVu";
            this.dgvCTPhieuDichVu.ReadOnly = true;
            this.dgvCTPhieuDichVu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTPhieuDichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCTPhieuDichVu.RowHeadersVisible = false;
            this.dgvCTPhieuDichVu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCTPhieuDichVu.RowTemplate.Height = 25;
            this.dgvCTPhieuDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPhieuDichVu.Size = new System.Drawing.Size(832, 444);
            this.dgvCTPhieuDichVu.TabIndex = 11;
            this.dgvCTPhieuDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPhieuDichVu_CellContentClick);
            this.dgvCTPhieuDichVu.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCTPhieuDichVu_RowPostPaint);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 66;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 73;
            // 
            // Tendichvu
            // 
            this.Tendichvu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Tendichvu.DataPropertyName = "Ten_DichVuVM";
            this.Tendichvu.HeaderText = "Tên dịch vụ";
            this.Tendichvu.Name = "Tendichvu";
            this.Tendichvu.ReadOnly = true;
            this.Tendichvu.Width = 200;
            // 
            // RemoveSL
            // 
            this.RemoveSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RemoveSL.DataPropertyName = "strRemovebtn";
            this.RemoveSL.HeaderText = "";
            this.RemoveSL.MinimumWidth = 60;
            this.RemoveSL.Name = "RemoveSL";
            this.RemoveSL.ReadOnly = true;
            this.RemoveSL.Text = "-";
            this.RemoveSL.Width = 60;
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SL.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SL.DefaultCellStyle = dataGridViewCellStyle2;
            this.SL.HeaderText = "SL";
            this.SL.MinimumWidth = 60;
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SL.Width = 60;
            // 
            // AddSL
            // 
            this.AddSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AddSL.DataPropertyName = "strAddbtn";
            this.AddSL.HeaderText = "";
            this.AddSL.MinimumWidth = 60;
            this.AddSL.Name = "AddSL";
            this.AddSL.ReadOnly = true;
            this.AddSL.Text = "+";
            this.AddSL.Width = 60;
            // 
            // donGia
            // 
            this.donGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.donGia.DataPropertyName = "strDonGia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.donGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 180;
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            this.donGia.Width = 180;
            // 
            // thanhTien
            // 
            this.thanhTien.DataPropertyName = "strThanhTien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.thanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(B_BUS.ViewModels.ChiTietPhieuDichVuViewModel);
            // 
            // cbbPhieuDat
            // 
            this.cbbPhieuDat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSource1, "PhieuDatPhongVM", true));
            this.cbbPhieuDat.Enabled = false;
            this.cbbPhieuDat.FormattingEnabled = true;
            this.cbbPhieuDat.Location = new System.Drawing.Point(147, 94);
            this.cbbPhieuDat.Name = "cbbPhieuDat";
            this.cbbPhieuDat.Size = new System.Drawing.Size(708, 40);
            this.cbbPhieuDat.TabIndex = 12;
            this.cbbPhieuDat.SelectedIndexChanged += new System.EventHandler(this.cbbPhieuDat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng tiền:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTongTien.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTongTien.Location = new System.Drawing.Point(619, 681);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(236, 35);
            this.lbTongTien.TabIndex = 14;
            this.lbTongTien.Text = "label2";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(657, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmAddorEditPhieuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 734);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbPhieuDat);
            this.Controls.Add(this.dgvCTPhieuDichVu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbGiaGio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGiaNgay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmAddorEditPhieuDichVu";
            this.Resizable = false;
            this.Text = "Phiếu Dịch Vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddorEditPhieuDichVu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
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
        private MetroFramework.Controls.MetroGrid dgvCTPhieuDichVu;
        private ComboBox cbbPhieuDat;
        private BindingSource bindingSource2;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn Tendichvu;
        private DataGridViewButtonColumn RemoveSL;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewButtonColumn AddSL;
        private DataGridViewTextBoxColumn donGia;
        private DataGridViewTextBoxColumn thanhTien;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private Label label1;
        private Label lbTongTien;
        private Button button1;
    }
}