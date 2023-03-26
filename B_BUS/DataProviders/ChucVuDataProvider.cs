using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class ChucVuDataProvider
    {
        private static ChucVuDataProvider? _ins;
        public static ChucVuDataProvider Ins
        {
            get { if (_ins == null) _ins = new ChucVuDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public ChucVuRepository repository { get; set; }
        public ChucVuDataProvider()
        {
            repository = new ChucVuRepository();
        }
    }
}
