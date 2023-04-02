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
    public class YeuCauDataProvider
    {
        private static YeuCauDataProvider? _ins;
        public static YeuCauDataProvider Ins
        {
            get { if (_ins == null) _ins = new YeuCauDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        private NhaNghiRepository<YeuCau> _repository;
        public NhaNghiRepository<YeuCau> repository { get => _repository; }
        private YeuCauService _service;
        public YeuCauService service { get => _service; }
        public YeuCauDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<YeuCau, YeuCauViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<YeuCau>();
            _service = new YeuCauService();
        }
        public YeuCauViewModel convertToVM(YeuCau obj)
        {
            return _mapper.Map<YeuCauViewModel>(obj);
        }

        public YeuCau convertToM(YeuCauViewModel obj)
        {
            return _mapper.Map<YeuCau>(obj);
        }
    }
}
