using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
using System.Windows.Controls;

namespace C_GUI.Views
{
    public partial class FrmKhachHang : Form
    {
        IKhachHangService _khachHangService;
        public FrmKhachHang()
        {
            InitializeComponent();
            _khachHangService = VMPKhachHang.Ins.service;
            khachHangViewModelBindingSource.DataSource = _khachHangService.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (FrmAddorEditKhachHang frm = new FrmAddorEditKhachHang(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    khachHangViewModelBindingSource.DataSource = _khachHangService.GetAll();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = khachHangViewModelBindingSource.Current as KhachHangViewModel;
            if (obj == null) return;
            using (FrmAddorEditKhachHang frm = new FrmAddorEditKhachHang(obj))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    khachHangViewModelBindingSource.DataSource = _khachHangService.GetAll();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = khachHangViewModelBindingSource.Current as KhachHangViewModel;
            if (obj == null) return;
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _khachHangService.Delete(obj.Id);
                khachHangViewModelBindingSource.RemoveCurrent();

            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            txbSearch.Text = string.Empty;
            khachHangViewModelBindingSource.DataSource = _khachHangService.GetAll();
        }


        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var lst = _khachHangService.GetAll()?.Where(x => (x.Ten ?? string.Empty).Contains(txbSearch.Text));
                if (lst == null) return;
                if (lst.Any()) khachHangViewModelBindingSource.DataSource = lst;
                else khachHangViewModelBindingSource.DataSource = new List<KhachHangViewModel>();
            }
        }

    }
}
