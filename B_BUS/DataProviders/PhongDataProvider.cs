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
    public class PhongDataProvider
    {
        private static PhongDataProvider? _ins;
        public static PhongDataProvider Ins
        {
            get { if (_ins == null) _ins = new PhongDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        private NhaNghiRepository<Phong> _repository;
        public NhaNghiRepository<Phong> repository { get => _repository; }
        private PhongService _service;
        public PhongService service { get => _service; }
        public PhongDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<Phong, PhongViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<Phong>();
            _service = new PhongService();
        }
        public PhongViewModel convertToVM(Phong obj)
        {
            return _mapper.Map<PhongViewModel>(obj);
        }

        public Phong convertToM(PhongViewModel obj)
        {
            return _mapper.Map<Phong>(obj);
        }
    }
}
