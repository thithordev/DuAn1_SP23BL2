using A_DAL.Context;
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
    public class ChiTietPhieuDichVuDataProvider
    {
        private static ChiTietPhieuDichVuDataProvider? _ins;
        public static ChiTietPhieuDichVuDataProvider Ins
        {
            get { if (_ins == null) _ins = new ChiTietPhieuDichVuDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        private NhaNghiRepository<ChiTietPhieuDichVu> _repository;
        public NhaNghiRepository<ChiTietPhieuDichVu> repository { get => _repository; }
        private ChiTietPhieuDichVuService _service;
        public ChiTietPhieuDichVuService service { get => _service; }
        public ChiTietPhieuDichVuDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<ChiTietPhieuDichVu, ChiTietPhieuDichVuViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<ChiTietPhieuDichVu>();
            _service = new ChiTietPhieuDichVuService();
        }

        public ChiTietPhieuDichVuViewModel convertToVM(ChiTietPhieuDichVu obj)
        {
            return _mapper.Map<ChiTietPhieuDichVuViewModel>(obj);
        }
        public ChiTietPhieuDichVu convertToM(ChiTietPhieuDichVuViewModel obj)
        {
            return _mapper.Map<ChiTietPhieuDichVu>(obj);
        }
    }
}
