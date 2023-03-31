using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GUI.VMProviders
{
    public class VMPPhong : BaseVMP
    {
        private static VMPPhong? _ins;
        public static VMPPhong Ins
        {
            get { if (_ins == null) _ins = new VMPPhong(); return _ins; }
            set { _ins = value; }
        }

        public PhongService service { get; set; }
        public PhongViewModel VM { get; set; }

        public VMPPhong()
        {
            service = new PhongService();
            VM = new PhongViewModel();
        }
    }
}
