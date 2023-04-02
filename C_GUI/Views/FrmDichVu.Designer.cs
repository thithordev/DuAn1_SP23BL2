namespace C_GUI.Views
{
    partial class FrmDichVu
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
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.elitsercontrols1 = new C_GUI.ViewModels.Elitsercontrols();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(228, 190);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowTemplate.Height = 28;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(766, 508);
            this.dgvDichVu.TabIndex = 1;
            this.dgvDichVu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDichVu_CellMouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtTimKiem);
            this.panel3.Location = new System.Drawing.Point(22, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 55);
            this.panel3.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(16, 7);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(221, 33);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "Tìm dịch vụ";
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = " QL DỊCH VỤ";
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThemDV.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemDV.ForeColor = System.Drawing.Color.White;
            this.btnThemDV.Location = new System.Drawing.Point(943, 86);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(190, 40);
            this.btnThemDV.TabIndex = 7;
            this.btnThemDV.Text = "Thêm dịch vụ";
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(896, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // elitsercontrols1
            // 
            this.elitsercontrols1.CornerRadius = 40;
            this.elitsercontrols1.TargetControl = this.txtTimKiem;
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 809);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvDichVu);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDichVu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvDichVu;
        private Panel panel3;
        private TextBox txtTimKiem;
        private Label label4;
        private Button btnThemDV;
        private Button button1;
        private ViewModels.Elitsercontrols elitsercontrols1;
    }
}