namespace C_GUI.Views
{
    partial class FrmPhieuDichVu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDVChon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.elitsercontrols1 = new C_GUI.ViewModels.Elitsercontrols();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVChon)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.dgvDV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 476);
            this.panel1.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(245, 74);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(221, 33);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.Text = "Tìm dịch vụ";
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter_1);
            // 
            // dgvDV
            // 
            this.dgvDV.AllowUserToAddRows = false;
            this.dgvDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(16, 158);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowTemplate.Height = 25;
            this.dgvDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDV.Size = new System.Drawing.Size(497, 298);
            this.dgvDV.TabIndex = 6;
            this.dgvDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDV_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách dịch vụ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDVChon);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(582, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 476);
            this.panel2.TabIndex = 1;
            // 
            // dgvDVChon
            // 
            this.dgvDVChon.AllowUserToAddRows = false;
            this.dgvDVChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvDVChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVChon.Location = new System.Drawing.Point(17, 158);
            this.dgvDVChon.Name = "dgvDVChon";
            this.dgvDVChon.RowTemplate.Height = 25;
            this.dgvDVChon.Size = new System.Drawing.Size(497, 298);
            this.dgvDVChon.TabIndex = 7;
            this.dgvDVChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDVChon_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dịch vụ đã chọn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(519, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thêm dịch vụ";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Lime;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(769, 682);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(179, 45);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(993, 682);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(179, 45);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(76, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1112, 537);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(558, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 476);
            this.panel4.TabIndex = 2;
            // 
            // elitsercontrols1
            // 
            this.elitsercontrols1.CornerRadius = 40;
            this.elitsercontrols1.TargetControl = this.txtTimKiem;
            // 
            // FrmPhieuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 809);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPhieuDichVu";
            this.Text = "FormPhieuDichVu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVChon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private DataGridView dgvDV;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private Button btnLuu;
        private Button btnThoat;
        private TextBox txtTimKiem;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgvDVChon;
        private ViewModels.Elitsercontrols elitsercontrols1;
    }
}