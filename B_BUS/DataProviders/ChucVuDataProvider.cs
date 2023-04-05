using A_DAL.Models;
using A_DAL.Repositories;
using AutoMapper;
using B_BUS.Services;
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
        private NhaNghiRepository<ChucVu> _repository;
        public NhaNghiRepository<ChucVu> repository { get => _repository; }
        private ChucVuService _service ;
        public ChucVuService service { get => _service; }
        public ChucVuDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<ChucVu, ChucVuViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<ChucVu>();
            _service = new ChucVuService();
        }

        public ChucVuViewModel convertToVM(ChucVu obj)
        {
            return _mapper.Map<ChucVuViewModel>(obj);
        }

        public ChucVu convertToM(ChucVuViewModel obj)
        {
            return _mapper.Map<ChucVu>(obj);
        }
    }
}
