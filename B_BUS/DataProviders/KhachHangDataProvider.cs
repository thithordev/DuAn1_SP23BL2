using A_DAL.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class KhachHangDataProvider
    {
        private static KhachHangDataProvider? _ins;
        public static KhachHangDataProvider Ins
        {
            get { if (_ins == null) _ins = new KhachHangDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public KhachHangRepository repository { get; set; }
        public KhachHangDataProvider()
        {
            repository = new KhachHangRepository();
        }
    }
}
