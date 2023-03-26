using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class LoaiDoanhThuDataProvider
    {
        private static LoaiDoanhThuDataProvider? _ins;
        public static LoaiDoanhThuDataProvider Ins
        {
            get { if (_ins == null) _ins = new LoaiDoanhThuDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public LoaiDoanhThuRepository repository { get; set; }
        public LoaiDoanhThuDataProvider()
        {
            repository = new LoaiDoanhThuRepository();
        }
    }
}
