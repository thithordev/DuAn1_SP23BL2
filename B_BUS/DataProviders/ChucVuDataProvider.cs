using A_DAL.Models;
using A_DAL.Repositories;
using AutoMapper;
using B_BUS.ViewModels;
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
        private MapperConfiguration _config;
        private Mapper _mapper;
        public ChucVuRepository repository { get; set; }
        public ChucVuDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<ChucVu, ChucVuViewModel>());
            _mapper = new Mapper(_config);
            repository = new ChucVuRepository();
        }

        public ChucVuViewModel convertToVM(ChucVu cv)
        {
            return _mapper.Map<ChucVuViewModel>(cv);
        }
    }
}
