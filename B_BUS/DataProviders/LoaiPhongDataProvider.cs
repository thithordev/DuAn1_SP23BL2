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
    public class LoaiPhongDataProvider
    {
        private static LoaiPhongDataProvider? _ins;
        public static LoaiPhongDataProvider Ins
        {
            get { if (_ins == null) _ins = new LoaiPhongDataProvider(); return _ins; }
            set { _ins = value; }
        }
        private MapperConfiguration _config;
        private Mapper _mapper;
        public LoaiPhongRepository repository { get; set; }
        public LoaiPhongDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiPhong, LoaiPhongViewModel>());
            _mapper = new Mapper(_config);
            repository = new LoaiPhongRepository();
        }
        public LoaiPhongViewModel convertToVM(LoaiPhong obj)
        {
            return _mapper.Map<LoaiPhongViewModel>(obj);
        }
    }
}
