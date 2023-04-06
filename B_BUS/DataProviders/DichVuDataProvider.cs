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
    public class DichVuDataProvider
    {
        private static DichVuDataProvider? _ins;
        public static DichVuDataProvider Ins
        {
            get { if (_ins == null) _ins = new DichVuDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        private NhaNghiRepository<DichVu> _repository;
        public NhaNghiRepository<DichVu> repository { get => _repository; }
        private DichVuService _service;
        public DichVuService service { get => _service; }
        public DichVuDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<DichVu, DichVuViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<DichVu>();
            _service = new DichVuService();
        }
        public DichVuViewModel convertToVM(DichVu obj)
        {
            return _mapper.Map<DichVuViewModel>(obj);
        }
        public DichVu convertToM(DichVuViewModel obj)
        {
            return _mapper.Map<DichVu>(obj);
        }
    }
}
