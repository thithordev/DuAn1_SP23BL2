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
        public NhanVienRepository repository { get; set; }
        public NhanVienDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVien, NhanVienViewModel>());
            _mapper = new Mapper(_config);
            repository = new NhanVienRepository();
        }

        public NhanVienViewModel convertToVM(NhanVien nv)
        {
            return _mapper.Map<NhanVienViewModel>(nv);
        }

    }
}
