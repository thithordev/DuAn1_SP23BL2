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
    public class PhieuDichVuDataProvider
    {
        private static PhieuDichVuDataProvider? _ins;
        public static PhieuDichVuDataProvider Ins
        {
            get { if (_ins == null) _ins = new PhieuDichVuDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        private NhaNghiRepository<PhieuDichVu> _repository;
        public NhaNghiRepository<PhieuDichVu> repository { get => _repository; }
        private PhieuDichVuService _service;
        public PhieuDichVuService service { get => _service; }
        public PhieuDichVuDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuDichVu, PhieuDichVuViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<PhieuDichVu>();
            _service= new PhieuDichVuService();
        }
        public PhieuDichVuViewModel convertToVM(PhieuDichVu obj)
        {
            return _mapper.Map<PhieuDichVuViewModel>(obj);
        }

        public PhieuDichVu convertToM(PhieuDichVuViewModel obj)
        {
            return _mapper.Map<PhieuDichVu>(obj);
        }
    }
}
