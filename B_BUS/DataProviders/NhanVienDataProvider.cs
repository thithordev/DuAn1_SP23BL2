using A_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using A_DAL.Models;
using B_BUS.ViewModels;
using B_BUS.Services;

namespace B_BUS.DataProviders
{
    public class NhanVienDataProvider
    {
        private static NhanVienDataProvider? _ins;
        public static NhanVienDataProvider Ins
        {
            get { if (_ins == null) _ins = new NhanVienDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        private NhaNghiRepository<NhanVien> _repository;
        public NhaNghiRepository<NhanVien> repository { get => _repository; }
        private NhanVienService _service;
        public NhanVienService service { get => _service; }
        public NhanVienDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<NhanVien>();
            _service = new NhanVienService();
        }

        public NhanVienViewModel convertToVM(NhanVien nv)
        {
            return _mapper.Map<NhanVienViewModel>(nv);
        }

        public NhanVien convertToM(NhanVienViewModel obj)
        {
            return _mapper.Map<NhanVien>(obj);
        }

    }
}
