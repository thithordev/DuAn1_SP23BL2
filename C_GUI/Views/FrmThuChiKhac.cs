using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
using Catel;
using System.Windows.Controls;

namespace C_GUI.Views
{
    public partial class FrmThuChiKhac : Form
    {
        IThuChiKhacService _thuChiKhacService;
        public FrmThuChiKhac()
        {
            InitializeComponent();
            _thuChiKhacService = VMPThuChiKhac.Ins.service;
            thuChiKhacViewModelBindingSource.DataSource = _thuChiKhacService.GetAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = thuChiKhacViewModelBindingSource.Current as ThuChiKhacViewModel;
            if (obj == null) return;
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _thuChiKhacService.Delete(obj.Id);
                thuChiKhacViewModelBindingSource.RemoveCurrent();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (FrmAddorEditThuChiKhac frm = new FrmAddorEditThuChiKhac(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    thuChiKhacViewModelBindingSource.DataSource = _thuChiKhacService.GetAll();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = thuChiKhacViewModelBindingSource.Current as ThuChiKhacViewModel;
            if (obj == null) return;
            using (FrmAddorEditThuChiKhac frm = new FrmAddorEditThuChiKhac(obj))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    thuChiKhacViewModelBindingSource.DataSource = _thuChiKhacService.GetAll();
                }
            }
        }

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var lst = _thuChiKhacService.GetAll()?.Where(x => (x.NoiDung ?? string.Empty).Contains(txbSearch.Text));
                if (lst == null) return;
                if (lst.Any()) thuChiKhacViewModelBindingSource.DataSource = lst;
                else thuChiKhacViewModelBindingSource.DataSource = new List<LoaiPhongViewModel>();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txbSearch.Text = string.Empty;
            thuChiKhacViewModelBindingSource.DataSource = _thuChiKhacService.GetAll();
        }

    }
}
