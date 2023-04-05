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
    public class ThongKeDoanhThuDataProvider
    {
        private static ThongKeDoanhThuDataProvider? _ins;
        public static ThongKeDoanhThuDataProvider Ins
        {
            get { if (_ins == null) _ins = new ThongKeDoanhThuDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        private NhaNghiRepository<ThongKeDoanhThu> _repository;
        public NhaNghiRepository<ThongKeDoanhThu> repository { get => _repository; }
        private ThongKeDoanhThuService _service;
        public ThongKeDoanhThuService service { get => _service; }
        public ThongKeDoanhThuDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<ThongKeDoanhThu, ThongKeDoanhThuViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<ThongKeDoanhThu>();
            _service = new ThongKeDoanhThuService();
        }
        public ThongKeDoanhThuViewModel convertToVM(ThongKeDoanhThu obj)
        {
            return _mapper.Map<ThongKeDoanhThuViewModel>(obj);
        }

        public ThongKeDoanhThu convertToM(ThongKeDoanhThuViewModel obj)
        {
            return _mapper.Map<ThongKeDoanhThu>(obj);
        }
    }
}
