using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class PhongDataProvider
    {
        private static PhongDataProvider? _ins;
        public static PhongDataProvider Ins
        {
            get { if (_ins == null) _ins = new PhongDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public PhongRepository repository { get; set; }
        public PhongDataProvider()
        {
            repository = new PhongRepository();
        }
    }
}
