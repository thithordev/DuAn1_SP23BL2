using B_BUS.IServices;
using B_BUS.Services;
using C_GUI.VMProviders;

namespace C_GUI.Views
{
    public partial class FrmThongKe : Form
    {
        private IHoaDonService _hoaDonService;
        private IThuChiKhacService _thuChiKhacService;

        public FrmThongKe()
        {
            _hoaDonService = new HoaDonService();
            _thuChiKhacService = VMPThuChiKhac.Ins.service;
            InitializeComponent();
            LoadHoaDon();
            LoadThuChiKhac();
        }

        private void LoadHoaDon()
        {
            decimal? tong = 0;
            if (_hoaDonService.GetAll().Count > 0)
            {
                foreach (var item in _hoaDonService.GetAll())
                {
                    dgvTongThu.Rows.Add(item.NgayTao, item.GhiChu, item.TongTien);
                }
                foreach (var item in _hoaDonService.GetAll())
                {

                    tong += item.TongTien;
                }
            }
            tong = 10000; // test
            lbTongThu.Text = tong.ToString();
        }

        private void LoadThuChiKhac()
        {
            decimal? tong = 0;
            if (_thuChiKhacService.GetAll().Count > 0)
            {
                foreach (var item in _thuChiKhacService.GetAll())
                {
                    dgvTongChi.Rows.Add(item.NgayTao, item.NoiDung, item.SoTien);
                }
                foreach (var item in _thuChiKhacService.GetAll())
                {
                    tong += item.SoTien;
                }
            }
            lbTongChi.Text = tong.ToString();
        }
    }
}