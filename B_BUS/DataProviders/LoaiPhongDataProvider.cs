using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class LoaiPhongDataProvider
    {
        private static LoaiPhongDataProvider? _ins;
        public static LoaiPhongDataProvider Ins
        {
            get { if (_ins == null) _ins = new LoaiPhongDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public LoaiPhongRepository repository { get; set; }
        public LoaiPhongDataProvider()
        {
            repository = new LoaiPhongRepository();
        }
    }
}
