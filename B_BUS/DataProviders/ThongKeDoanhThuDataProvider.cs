using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class ThongKeDoanhThuDataProvider
    {
        private static ThongKeDoanhThuDataProvider? _ins;
        public static ThongKeDoanhThuDataProvider Ins
        {
            get { if (_ins == null) _ins = new ThongKeDoanhThuDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public ThongKeDoanhThuRepository repository { get; set; }
        public ThongKeDoanhThuDataProvider()
        {
            repository = new ThongKeDoanhThuRepository();
        }
    }
}
