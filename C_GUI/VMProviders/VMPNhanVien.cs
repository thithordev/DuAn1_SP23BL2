using B_BUS.Services;
using B_BUS.ViewModels;
using System.ComponentModel;

namespace C_GUI.VMProviders
{
    public class VMPNhanVien : BaseVMP
    {
        private static VMPNhanVien? _ins;
        public static VMPNhanVien Ins
        {
            get { if (_ins == null) _ins = new VMPNhanVien(); return _ins; }
            set { _ins = value; }
        }
        public NhanVienService service { get; set; }
        public NhanVienViewModel VM { get; set; }
        
        private NhanVienViewModel _NhanVienLogin;
        public NhanVienViewModel NhanVienLogin { get => _NhanVienLogin; set { _NhanVienLogin = value; OnPropertyChanged(); } }
        public QuyenTruyCap quyenTruyCap { get; set; }
        public VMPNhanVien()
        {
            service = new NhanVienService();
            VM = new NhanVienViewModel();
            _NhanVienLogin = new NhanVienViewModel();
            quyenTruyCap = new QuyenTruyCap();
        }
    }
    public class QuyenNameValue
    {
        public string? Name { get; set; }
        public bool Value { get; set; }
    }

    public class QuyenTruyCap : BaseVMP
    {
        private string _chuc = "Unknown";
        public string Chuc { get => _chuc; set { _chuc = value; OnPropertyChanged(); } }
        private bool _TrangChu = true;
        public bool TrangChu { get => _TrangChu; set { _TrangChu = value; OnPropertyChanged(); } }
        private bool _Phong;
        public bool Phong { get => _Phong; set { _Phong = value; OnPropertyChanged(); } }
        private bool _HoaDon;
        public bool HoaDon { get => _HoaDon; set { _HoaDon = value; OnPropertyChanged(); } }
        private bool _PhieuDichVu;
        public bool PhieuDichVu { get => _PhieuDichVu; set { _PhieuDichVu = value; OnPropertyChanged(); } }
        private bool _KhachHang;
        public bool KhachHang { get => _KhachHang; set { _KhachHang = value; OnPropertyChanged(); } }
        private bool _DichVu;
        public bool DichVu { get => _DichVu; set { _DichVu = value; OnPropertyChanged(); } }
        private bool _LoaiPhong;
        public bool LoaiPhong { get => _LoaiPhong; set { _LoaiPhong = value; OnPropertyChanged(); } }
        private bool _NhanVien;
        public bool NhanVien { get => _NhanVien; set { _NhanVien = value; OnPropertyChanged(); } }
        private bool _ThongKe;
        public bool ThongKe { get => _ThongKe; set { _ThongKe = value; OnPropertyChanged(); } }
    }
}
