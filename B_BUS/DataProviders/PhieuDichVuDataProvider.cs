using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class PhieuDichVuDataProvider
    {
        private static PhieuDichVuDataProvider? _ins;
        public static PhieuDichVuDataProvider Ins
        {
            get { if (_ins == null) _ins = new PhieuDichVuDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public PhieuDichVuRepository repository { get; set; }
        public PhieuDichVuDataProvider()
        {
            repository = new PhieuDichVuRepository();
        }
    }
}
