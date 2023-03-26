using A_DAL.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class DichVuDataProvider
    {
        private static DichVuDataProvider? _ins;
        public static DichVuDataProvider Ins
        {
            get { if (_ins == null) _ins = new DichVuDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public DichVuRepository repository { get; set; }
        public DichVuDataProvider()
        {
            repository = new DichVuRepository();
        }
    }
}
