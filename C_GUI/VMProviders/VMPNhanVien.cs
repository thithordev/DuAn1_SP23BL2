using B_BUS.Services;
using B_BUS.ViewModels;

namespace C_GUI.VMProviders
{
    public class VMPNhanVien
    {
        private static VMPNhanVien? _ins;
        public static VMPNhanVien Ins
        {
            get { if (_ins == null) _ins = new VMPNhanVien(); return _ins; }
            set { _ins = value; }
        }
        public NhanVienService service { get; set; }
        public NhanVienViewModel VM { get; set; }
        public VMPNhanVien()
        {
            service = new NhanVienService();
            VM = new NhanVienViewModel();
        }
    }
}
