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
    public class PhieuDatPhongDataProvider
    {
        private static PhieuDatPhongDataProvider? _ins;
        public static PhieuDatPhongDataProvider Ins
        {
            get { if (_ins == null) _ins = new PhieuDatPhongDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        private NhaNghiRepository<PhieuDatPhong> _repository;
        public NhaNghiRepository<PhieuDatPhong> repository { get => _repository; }
        private PhieuDatPhongService _service;
        public PhieuDatPhongService service { get => _service; }
        public PhieuDatPhongDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuDatPhong, PhieuDatPhongViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<PhieuDatPhong>();
            _service= new PhieuDatPhongService();
        }
        public PhieuDatPhongViewModel convertToVM(PhieuDatPhong obj)
        {
            return _mapper.Map<PhieuDatPhongViewModel>(obj);
        }

        public PhieuDatPhong convertToM(PhieuDatPhongViewModel obj)
        {
            return _mapper.Map<PhieuDatPhong>(obj);
        }
    }
}