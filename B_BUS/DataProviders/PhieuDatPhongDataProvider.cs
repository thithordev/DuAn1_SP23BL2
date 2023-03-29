using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class PhieuDatPhongDataProvider
    {
        private static PhieuDatPhongDataProvider? _ins;
        public static PhieuDatPhongDataProvider Ins
        {
            get { if (_ins == null) _ins = new PhieuDatPhongDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public PhieuDatPhongRepository repository { get; set; }
        public PhieuDatPhongDataProvider()
        {
            repository = new PhieuDatPhongRepository();
        }
    }
}