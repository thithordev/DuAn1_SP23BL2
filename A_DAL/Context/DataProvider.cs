using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Context
{
    public class DataProvider
    {
        private static DataProvider? _ins;
        public static DataProvider Ins
        {
            get { if (_ins == null) _ins = new DataProvider(); return _ins; }
            set { _ins = value; }
        }
        public NhaNghiDbContext dbContext { get; set; }
        public DataProvider()
        {
            dbContext = new NhaNghiDbContext();
        }
    }
}
