using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GUI.VMProviders
{
    public class VMPPhieuDatPhong : BaseVMP
    {
        private static VMPPhieuDatPhong? _ins;
        public static VMPPhieuDatPhong Ins
        {
            get { if (_ins == null) _ins = new VMPPhieuDatPhong(); return _ins; }
            set { _ins = value; }
        }

        private List<PhieuDatPhongViewModel> _phieudatphongs;
        public List<PhieuDatPhongViewModel> PhieuDatPhongs { get => _phieudatphongs; set => _phieudatphongs = value; }

        public PhieuDatPhongService service { get; set; }
        public PhieuDatPhongViewModel VM { get; set; }

        public VMPPhieuDatPhong()
        {
            service = new PhieuDatPhongService();
            VM = new PhieuDatPhongViewModel();
            _phieudatphongs = service.GetAll() ?? new List<PhieuDatPhongViewModel>();
        }
    }
}
