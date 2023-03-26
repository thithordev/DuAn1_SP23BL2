using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class NhanVienDataProvider
    {
        private static NhanVienDataProvider? _ins;
        public static NhanVienDataProvider Ins
        {
            get { if (_ins == null) _ins = new NhanVienDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public NhanVienRepository repository { get; set; }
        public NhanVienDataProvider()
        {
            repository = new NhanVienRepository();
        }

    }
}
