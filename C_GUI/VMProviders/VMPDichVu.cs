using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GUI.VMProviders
{
    public class VMPDichVu
    {
        private static VMPDichVu? _ins;
        public static VMPDichVu Ins
        {
            get { if (_ins == null) _ins = new VMPDichVu(); return _ins; }
            set { _ins = value; }
        }
        private List<DichVuViewModel> _DVviews;
        public List<DichVuViewModel> DVviews { get => _DVviews; set => _DVviews = value; }
        public DichVuService service { get; set; }
        public DichVuViewModel VM { get; set; }
        public VMPDichVu()
        {
            service = new DichVuService();
            VM = new DichVuViewModel();
            _DVviews = (service.GetAll()??new List<DichVuViewModel>()).OrderBy(x => x.Ten).Where(x => x.TrangThai == true).ToList();
        }
    }
}
