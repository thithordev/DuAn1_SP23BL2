using A_DAL.Repositories;
using B_BUS.DataProviders;
using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GUI.VMProviders
{
    public class VMPChiTietPhieuDichVu
    {
        private static VMPChiTietPhieuDichVu? _ins;
        public static VMPChiTietPhieuDichVu Ins
        {
            get { if (_ins == null) _ins = new VMPChiTietPhieuDichVu(); return _ins; }
            set { _ins = value; }
        }
        public ChiTietPhieuDichVuService service { get; set; }
        public ChiTietPhieuDichVuViewModel VM { get; set; }
        public VMPChiTietPhieuDichVu()
        {
            service = new ChiTietPhieuDichVuService();
            VM = new ChiTietPhieuDichVuViewModel();
        }
    }
}
