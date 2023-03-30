using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GUI.VMProviders
{
    public class VMPChucVu
    {
        private static VMPChucVu? _ins;
        public static VMPChucVu Ins
        {
            get { if (_ins == null) _ins = new VMPChucVu(); return _ins; }
            set { _ins = value; }
        }
        public ChucVuService service { get; set; }
        public ChucVuViewModel VM { get; set; }
        public VMPChucVu()
        {
            service= new ChucVuService();
            VM = new ChucVuViewModel();
        }
    }
}
