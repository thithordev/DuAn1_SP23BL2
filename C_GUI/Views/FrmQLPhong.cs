using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
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
    public partial class FrmQLPhong : Form
    {
        IPhongService _phongService;
        public FrmQLPhong()
        {
            InitializeComponent();
            _phongService = VMPPhong.Ins.service;
            PhongViewModelBindingSource.DataSource = _phongService.GetAll();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (FrmAddorEditQLPhong frm = new FrmAddorEditQLPhong(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    PhongViewModelBindingSource.DataSource = _phongService.GetAll();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = PhongViewModelBindingSource.Current as PhongViewModel;
            if (obj == null) return;
            using (FrmAddorEditQLPhong frm = new FrmAddorEditQLPhong(obj))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    PhongViewModelBindingSource.DataSource = _phongService.GetAll();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = PhongViewModelBindingSource.Current as PhongViewModel;
            if (obj == null) return;
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _phongService.Delete(obj.Id);
                PhongViewModelBindingSource.RemoveCurrent();

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txbSearch.Text = string.Empty;
            PhongViewModelBindingSource.DataSource = _phongService.GetAll();
        }

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var lst = _phongService.GetAll()?.Where(x => (x.Ten ?? string.Empty).Contains(txbSearch.Text));
                if (lst == null) return;
                if (lst.Any()) PhongViewModelBindingSource.DataSource = lst;
                else PhongViewModelBindingSource.DataSource = new List<PhongViewModel>();
            }
        }

        private void dgvQLPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
