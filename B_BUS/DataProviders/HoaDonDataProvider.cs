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
    public class HoaDonDataProvider
    {
        private static HoaDonDataProvider? _ins;
        public static HoaDonDataProvider Ins
        {
            get { if (_ins == null) _ins = new HoaDonDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        private NhaNghiRepository<HoaDon> _repository;
        public NhaNghiRepository<HoaDon> repository { get => _repository; }
        private HoaDonService _service;
        public HoaDonService service { get => _service; }
        public HoaDonDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<HoaDon, HoaDonViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<HoaDon>();
            _service = new HoaDonService();
        }
        public HoaDonViewModel convertToVM(HoaDon obj)
        {
            return _mapper.Map<HoaDonViewModel>(obj);
        }

        public HoaDon convertToM(HoaDonViewModel obj)
        {
            return _mapper.Map<HoaDon>(obj);
        }
    }
}
