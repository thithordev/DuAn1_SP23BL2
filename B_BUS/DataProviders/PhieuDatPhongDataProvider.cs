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
        public PhieuDatPhongRepository repository { get; set; }
        public PhieuDatPhongDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<PhieuDatPhong, PhieuDatPhongViewModel>());
            _mapper = new Mapper(_config);
            repository = new PhieuDatPhongRepository();
        }
        public PhieuDatPhongViewModel convertToVM(PhieuDatPhong obj)
        {
            return _mapper.Map<PhieuDatPhongViewModel>(obj);
        }
    }
}