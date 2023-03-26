using A_DAL.Context;
using A_DAL.Repositories;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class ChiTietPhieuDichVuDataProvider
    {
        private static ChiTietPhieuDichVuDataProvider? _ins;
        public static ChiTietPhieuDichVuDataProvider Ins
        {
            get { if (_ins == null) _ins = new ChiTietPhieuDichVuDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public ChiTietPhieuDichVuRepository repository { get; set; }
        public ChiTietPhieuDichVuDataProvider()
        {
            repository = new ChiTietPhieuDichVuRepository();
        }
    }
}
