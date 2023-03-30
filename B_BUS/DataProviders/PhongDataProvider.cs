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
        public PhongRepository repository { get; set; }
        public PhongDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<Phong, PhongViewModel>());
            _mapper = new Mapper(_config);
            repository = new PhongRepository();
        }
        public PhongViewModel convertToVM(Phong obj)
        {
            return _mapper.Map<PhongViewModel>(obj);
        }
    }
}
