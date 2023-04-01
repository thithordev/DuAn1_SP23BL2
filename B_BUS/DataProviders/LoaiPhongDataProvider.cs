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
        private NhaNghiRepository<LoaiPhong> _repository;
        public NhaNghiRepository<LoaiPhong> repository { get => _repository; }
        public LoaiPhongDataProvider()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiPhong, LoaiPhongViewModel>().ReverseMap());
            _mapper = new Mapper(_config);
            _repository = new NhaNghiRepository<LoaiPhong>();
        }
        public LoaiPhongViewModel convertToVM(LoaiPhong obj)
        {
            return _mapper.Map<LoaiPhongViewModel>(obj);
        }

        public LoaiPhong convertToM(LoaiPhongViewModel obj)
        {
            return _mapper.Map<LoaiPhong>(obj);
        }
    }
}
