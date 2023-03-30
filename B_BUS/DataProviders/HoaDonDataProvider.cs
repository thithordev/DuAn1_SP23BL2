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
        public HoaDonRepository repository { get; set; }
        public HoaDonDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<HoaDon, HoaDonViewModel>());
            _mapper = new Mapper(_config);
            repository = new HoaDonRepository();
        }
        public HoaDonViewModel convertToVM(HoaDon obj)
        {
            return _mapper.Map<HoaDonViewModel>(obj);
        }
    }
}
