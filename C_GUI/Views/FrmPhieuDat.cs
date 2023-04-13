using B_BUS.DataProviders;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
using System.Windows.Controls;

namespace C_GUI.Views
{
    public partial class FrmPhieuDat : Form
    {
        List<PhieuDatPhongViewModel> _lstphieuDatVM;
        IPhieuDatPhongService _Service;
        public FrmPhieuDat()
        {
            InitializeComponent();

            _lstphieuDatVM = new List<PhieuDatPhongViewModel>();

            _Service = VMPPhieuDatPhong.Ins.service;

            LoadFormPhieuDat();

            

        }

        private void LoadFormPhieuDat()
        {
            _lstphieuDatVM = PhieuDatPhongDataProvider.Ins.repository.GetAll()
    .ToList().ConvertAll(x => PhieuDatPhongDataProvider.Ins.convertToVM(x));

            _lstphieuDatVM.ForEach(
                (x) =>
                {
                    x.PhongVM = PhongDataProvider.Ins.service.GetByID(x.PhongId ?? Guid.Empty);
                    x.KhachHangVM = KhachHangDataProvider.Ins.service.GetByID(x.KhachHangId ?? Guid.Empty);
                    x.NhanVienVM = NhanVienDataProvider.Ins.service.GetByID(x.NhanVienId ?? Guid.Empty);
                    x.HoaDonVM = HoaDonDataProvider.Ins.service.GetByID(x.HoaDonId ?? Guid.Empty);
                }
                );

            BindingSource1.DataSource = _lstphieuDatVM;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Xác nhận \"Xóa Phiếu Đặt\":  Chọn  YES  để \"Đồng Ý\"  ,  NO  để \"Hủy Bỏ\".",
    "Yes-No Button",
    MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }

            var obj = BindingSource1.Current as PhieuDatPhongViewModel;
            if (obj == null) return;

            _Service.Delete(obj.Id);
            BindingSource1.RemoveCurrent();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (FrmAddorEditPhieuDat frm = new FrmAddorEditPhieuDat(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadFormPhieuDat();
                }
                else
                {
                    LoadFormPhieuDat();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = BindingSource1.Current as PhieuDatPhongViewModel;
            if (obj == null) return;
            using (FrmAddorEditPhieuDat frm = new FrmAddorEditPhieuDat(obj))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadFormPhieuDat();
                }
                else
                {
                    LoadFormPhieuDat();
                }
            }
        }

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var lst = _Service.GetAll()?.Where(x => (x.GhiChu ?? string.Empty).Contains(txbSearch.Text));
                if (lst == null) return;
                if (lst.Any()) BindingSource1.DataSource = lst;
                else BindingSource1.DataSource = new List<PhieuDatPhongViewModel>();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txbSearch.Text = string.Empty;
            LoadFormPhieuDat();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
