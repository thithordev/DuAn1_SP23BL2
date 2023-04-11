using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GUI.VMProviders
{
    public class VMPKhachHang : BaseVMP
    {
        private static VMPKhachHang? _ins;
        public static VMPKhachHang Ins
        {
            get { if (_ins == null) _ins = new VMPKhachHang(); return _ins; }
            set { _ins = value; }
        }

        private List<KhachHangViewModel> _loaiphongs;
        public List<KhachHangViewModel> LoaiPhongs { get => _loaiphongs; set => _loaiphongs = value; }

        public KhachHangService service { get; set; }
        public KhachHangViewModel VM { get; set; }

        public VMPKhachHang()
        {
            service = new KhachHangService();
            VM = new KhachHangViewModel() { Ten = "Tất Cả"};
            _loaiphongs = service.GetAll() ?? new List<KhachHangViewModel>();
            _loaiphongs.Add(VM);
        }
    }
}
