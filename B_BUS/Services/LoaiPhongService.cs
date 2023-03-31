using A_DAL.Context;
using A_DAL.Models;
using B_BUS.DataProviders;
using B_BUS.IServices;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class LoaiPhongService : ILoaiPhongService
    {
        ILoaiPhongService _loaiPhongService;
        public LoaiPhongService()
        {
            _loaiPhongService = new LoaiPhongService();
        }
        public string Add(LoaiPhongViewModel obj)
        {
            bool kq = LoaiPhongDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(LoaiPhongViewModel obj)
        {
            if (obj == null) return "Delete thất bại";
            var dt = _loaiPhongService.GetAll().FirstOrDefault(p => p.IdLoaiPhong == obj.IdLoaiPhong);
            if (dt != null)
            {
                _loaiPhongService.Delete(dt);
                return "Delete thành công";
            }
            return "Delete thất bại";
        }

        public List<LoaiPhongViewModel> GetAll()
        {
            return LoaiPhongDataProvider.Ins.repository.GetAll().ConvertAll(x => LoaiPhongDataProvider.Ins.convertToVM(x));
        }

        public LoaiPhongViewModel GetByID(Guid id)
        {
            if (id == Guid.Empty) return new LoaiPhongViewModel();
            return LoaiPhongDataProvider.Ins.convertToVM(LoaiPhongDataProvider.Ins.repository.GetByID(id));
        }

        public string Update(LoaiPhongViewModel obj)
        {
            if (obj == null) return "update thất bại";
            var dt = _loaiPhongService.GetAll().FirstOrDefault(p => p.IdLoaiPhong == obj.IdLoaiPhong);
            if (dt != null)
            {
                dt.Ten = obj.Ten;
                dt.SoGiuong= obj.SoGiuong;
                dt.GiaGio = obj.GiaGio;
                dt.GiaNgay = obj.GiaNgay;
                dt.Mota = obj.Mota;
                _loaiPhongService.Update(dt);
                return "update thành công";
            }
            return "update thất bại";
        }
    }
}

