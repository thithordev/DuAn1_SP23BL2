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
        public LoaiDoanhThuRepository repository { get; set; }
        public LoaiDoanhThuDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiDoanhThu, LoaiDoanhThuViewModel>());
            _mapper = new Mapper(_config);
            repository = new LoaiDoanhThuRepository();
        }
        public LoaiDoanhThuViewModel convertToVM(LoaiDoanhThu obj)
        {
            return _mapper.Map<LoaiDoanhThuViewModel>(obj);
        }
    }
}
