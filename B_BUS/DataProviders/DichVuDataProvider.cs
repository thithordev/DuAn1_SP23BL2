using A_DAL.Models;
using A_DAL.Repositories;
using AutoMapper;
using B_BUS.ViewModels;
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
        private MapperConfiguration _config;
        private Mapper _mapper;
        public DichVuRepository repository { get; set; }
        public DichVuDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<DichVu, DichVuViewModel>());
            _mapper = new Mapper(_config);
            repository = new DichVuRepository();
        }
        public DichVuViewModel convertToVM(DichVu obj)
        {
            return _mapper.Map<DichVuViewModel>(obj);
        }
    }
}
