using A_DAL.Models;
using A_DAL.Repositories;
using AutoMapper;
using B_BUS.Services;
using B_BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.DataProviders
{
    public class KhachHangDataProvider
    {
        private static KhachHangDataProvider? _ins;
        public static KhachHangDataProvider Ins
        {
            get { if (_ins == null) _ins = new KhachHangDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        private NhaNghiRepository<KhachHang> _repository;
        public NhaNghiRepository<KhachHang> repository { get => _repository; }
        private KhachHangService _service;
        public KhachHangService service { get => _service; }
        public KhachHangDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<KhachHang, KhachHangViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<KhachHang>();
            _service= new KhachHangService();
        }
        public KhachHangViewModel convertToVM(KhachHang obj)
        {
            return _mapper.Map<KhachHangViewModel>(obj);
        }

        public KhachHang convertToM(KhachHangViewModel obj)
        {
            return _mapper.Map<KhachHang>(obj);
        }
    }
}
