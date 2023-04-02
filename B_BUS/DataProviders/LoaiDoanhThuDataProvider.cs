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
    public class LoaiDoanhThuDataProvider
    {
        private static LoaiDoanhThuDataProvider? _ins;
        public static LoaiDoanhThuDataProvider Ins
        {
            get { if (_ins == null) _ins = new LoaiDoanhThuDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        private NhaNghiRepository<LoaiDoanhThu> _repository;
        public NhaNghiRepository<LoaiDoanhThu> repository { get => _repository; }
        private LoaiDoanhThuService _service;
        public LoaiDoanhThuService service { get => _service; }
        public LoaiDoanhThuDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiDoanhThu, LoaiDoanhThuViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<LoaiDoanhThu>();
            _service = new LoaiDoanhThuService();
        }
        public LoaiDoanhThuViewModel convertToVM(LoaiDoanhThu obj)
        {
            return _mapper.Map<LoaiDoanhThuViewModel>(obj);
        }

        public LoaiDoanhThu convertToM(LoaiDoanhThuViewModel obj)
        {
            return _mapper.Map<LoaiDoanhThu>(obj);
        }
    }
}
