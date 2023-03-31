using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI.Views
{
    public partial class FrmThemDV : Form
    {
        IDichVuService _dichVu;
        public FrmThemDV()
        {
            InitializeComponent();
            _dichVu = new DichVuService();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DichVuViewModel DuLieu()
        {
            DichVuViewModel dt = new DichVuViewModel();
            dt.IdDichVu = Guid.NewGuid();
            dt.Ten = txtTen.Text;
            dt.Gia = decimal.Parse(txtGia.Text);
            return dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_dichVu.Add(DuLieu()));
        }
    }
}
