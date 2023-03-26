﻿using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class YeuCauDataProvider
    {
        private static YeuCauDataProvider? _ins;
        public static YeuCauDataProvider Ins
        {
            get { if (_ins == null) _ins = new YeuCauDataProvider(); return _ins; }
            set { _ins = value; }
        }
        public YeuCauRepository repository { get; set; }
        public YeuCauDataProvider()
        {
            repository = new YeuCauRepository();
        }
    }
}