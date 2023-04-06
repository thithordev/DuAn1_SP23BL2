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
    public class ThuChiKhacDataProvider
    {
        private static ThuChiKhacDataProvider? _ins;
        public static ThuChiKhacDataProvider Ins
        {
            get { if (_ins == null) _ins = new ThuChiKhacDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        private NhaNghiRepository<ThuChiKhac> _repository;
        public NhaNghiRepository<ThuChiKhac> repository { get => _repository; }
        private ThuChiKhacService _service;
        public ThuChiKhacService service { get => _service; }
        public ThuChiKhacDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<ThuChiKhac, ThuChiKhacViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<ThuChiKhac>();
            _service = new ThuChiKhacService();
        }
        public ThuChiKhacViewModel convertToVM(ThuChiKhac obj)
        {
            return _mapper.Map<ThuChiKhacViewModel>(obj);
        }

        public ThuChiKhac convertToM(ThuChiKhacViewModel obj)
        {
            return _mapper.Map<ThuChiKhac>(obj);
        }
    }
}
