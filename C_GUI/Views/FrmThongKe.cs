using B_BUS.IServices;
using B_BUS.Services;
using C_GUI.VMProviders;

namespace C_GUI.Views
{
    public partial class FrmThongKe : Form
    {
        IHoaDonService _hoaDonService;
        IThuChiKhacService _thuChiKhacService;
        public FrmThongKe()
        {
            _hoaDonService = new HoaDonService();
            _thuChiKhacService = VMPThuChiKhac.Ins.service;
            InitializeComponent();
            LoadHoaDon();
            LoadThuChiKhac();
        }
        void LoadHoaDon()
        {
            foreach (var item in _hoaDonService.GetAll())
            {
                dgvTongThu.Rows.Add(item.NgayTao, item.GhiChu, item.TongTien);
            }
            for (int i = 0; i < _hoaDonService.GetAll().Count(); i++)
            {
                lbTongThu.Text += dgvTongThu.Rows[i].Cells[2].Value;
            }

        }
        void LoadThuChiKhac()
        {
            foreach (var item in _thuChiKhacService.GetAll())
            {
                dgvTongChi.Rows.Add(item.NgayTao, item.NoiDung, item.SoTien);
            }
            for (int i = 0; i < _hoaDonService.GetAll().Count(); i++)
            {
                lbTongChi.Text += dgvTongChi.Rows[i].Cells[2].Value;
            }
        }

    }
}