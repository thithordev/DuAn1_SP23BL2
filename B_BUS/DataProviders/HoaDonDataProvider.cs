using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class HoaDonDataProvider
    {
        private static HoaDonDataProvider? _ins;
        public static HoaDonDataProvider Ins
        {
            get { if (_ins == null) _ins = new HoaDonDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public HoaDonRepository repository { get; set; }
        public HoaDonDataProvider()
        {
            repository = new HoaDonRepository();
        }
    }
}
