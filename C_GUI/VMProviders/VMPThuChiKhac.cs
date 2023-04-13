using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GUI.VMProviders
{
    public class VMPThuChiKhac : BaseVMP
    {
        private static VMPThuChiKhac? _ins;
        public static VMPThuChiKhac Ins
        {
            get { if (_ins == null) _ins = new VMPThuChiKhac(); return _ins; }
            set { _ins = value; }
        }

        private List<ThuChiKhacViewModel> _thuChiKhacs;
        public List<ThuChiKhacViewModel> ThuChiKhacs { get => _thuChiKhacs; set => _thuChiKhacs = value; }

        public ThuChiKhacService service { get; set; }
        public ThuChiKhacViewModel VM { get; set; }

        public VMPThuChiKhac()
        {
            service = new ThuChiKhacService();
            VM = new ThuChiKhacViewModel() { NoiDung = "Tất cả" };
            _thuChiKhacs = service.GetAll() ?? new List<ThuChiKhacViewModel>();
            _thuChiKhacs.Add(VM);
        }
    }
}
