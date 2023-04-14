using B_BUS.DataProviders;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;

namespace C_GUI.Views
{
    public partial class FrmThongKe : Form
    {
        private IHoaDonService _hoaDonService;
        private IThuChiKhacService _thuChiKhacService;

        public FrmThongKe()
        {
            _hoaDonService = HoaDonDataProvider.Ins.service;
            _thuChiKhacService = VMPThuChiKhac.Ins.service;
            InitializeComponent();
            Load(null, null);
        }

        private void Load(DateTime? tuNgay, DateTime? denNgay)
        {
            if (tuNgay > denNgay) 
            {
                lbTongChi.Text = lbTongThu.Text = lbTongDoanhThu.Text = "0 ₫";
                return; 
            }
            List<ThuChiKhacViewModel> thuChiKhacs = (_thuChiKhacService.GetAll() ?? new List<ThuChiKhacViewModel>());
            List<HoaDonViewModel> hoaDons = _hoaDonService.GetAll() ?? new List<HoaDonViewModel>();
            if (tuNgay == null || denNgay == null)
            {
                decimal? chi = 0;
                decimal? thu = 0;
                foreach (var item in thuChiKhacs)
                {
                    dgvTongThu.Rows.Add(item.NgayTao, item.strTrangThai, item.NoiDung, string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.SoTien));
                }
                foreach (var item in hoaDons)
                {
                    dgvTongThu.Rows.Add(item.NgayTao, "Hóa đơn", item.strNoiDung, string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.TongTien));
                }
                foreach (var item in thuChiKhacs.Where(p => p.isThu == false))
                {
                    if (item.SoTien != null)
                    {
                        chi += item.SoTien.Value;
                    }
                }
                foreach (var item in thuChiKhacs.Where(p => p.isThu == true))
                {
                    if (item.SoTien != null)
                    {
                        thu += item.SoTien.Value;
                    }
                }
                foreach (var item in hoaDons)
                {
                    if (item.TongTien != null)
                    {
                        thu += item.TongTien.Value;
                    }
                }
                decimal? ds = thu.Value - chi.Value;
                lbTongChi.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", chi);
                lbTongThu.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", thu);
                lbTongDoanhThu.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", ds);
            }
            else
            {
                decimal? chi = 0;
                decimal? thu = 0;
                thuChiKhacs = thuChiKhacs.Where(p => p.NgayTao >= tuNgay && p.NgayTao <= denNgay).ToList();
                hoaDons = hoaDons.Where(p => p.NgayTao >= tuNgay && p.NgayTao <= denNgay).ToList();

                foreach (var item in thuChiKhacs)
                {
                    dgvTongThu.Rows.Add(item.NgayTao, item.strTrangThai, item.NoiDung, string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.SoTien));
                }
                foreach (var item in hoaDons)
                {
                    dgvTongThu.Rows.Add(item.NgayTao, "Hóa đơn", item.strNoiDung, string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.TongTien));
                }
                foreach (var item in thuChiKhacs.Where(p => p.isThu == false))
                {
                    if (item.SoTien != null)
                    {
                        chi += item.SoTien.Value;
                    }
                }
                foreach (var item in thuChiKhacs.Where(p => p.isThu == true))
                {
                    if (item.SoTien != null)
                    {
                        thu += item.SoTien.Value;
                    }
                }
                foreach (var item in hoaDons)
                {
                    if (item.TongTien != null)
                    {
                        thu += item.TongTien.Value;
                    }
                }
                decimal? ds = thu.Value - chi.Value;
                lbTongChi.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", chi);
                lbTongThu.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", thu);
                lbTongDoanhThu.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", ds);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvTongThu.Rows.Clear();
            Load(null, null);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            dgvTongThu.Rows.Clear();
            Load(dtpk_TuNgay.Value, dtpk_DenNgay.Value);

        }
    }
}