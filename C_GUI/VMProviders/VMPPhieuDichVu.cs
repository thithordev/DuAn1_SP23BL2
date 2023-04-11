using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GUI.VMProviders
{
    public class VMPPhieuDichVu
    {
        private static VMPPhieuDichVu? _ins;
        public static VMPPhieuDichVu Ins
        {
            get { if (_ins == null) _ins = new VMPPhieuDichVu(); return _ins; }
            set { _ins = value; }
        }

        private List<PhieuDichVuViewModel> _phieudichvus;
        public List<PhieuDichVuViewModel> Phieudichvus { get => _phieudichvus; set => _phieudichvus = value; }

        public PhieuDichVuService service { get; set; }
        public PhieuDichVuViewModel VM { get; set; }

        public VMPPhieuDichVu()
        {
            service = new PhieuDichVuService();
            VM = new PhieuDichVuViewModel();
            _phieudichvus = (service.GetAll()??new List<PhieuDichVuViewModel> ()).Where(x => x.TrangThai == 1).OrderByDescending(x => x.NgayTao).ToList();
        }
    }
}
