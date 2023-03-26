using A_DAL.Context;
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
            var kq = LoaiPhongDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<LoaiPhongViewModel>? GetAll()
        {
            return LoaiPhongDataProvider.Ins.repository.GetAll().ConvertAll(x => (LoaiPhongViewModel)x);
        }

        public LoaiPhongViewModel? GetByID(Guid id)
        {
            return LoaiPhongDataProvider.Ins.repository.GetByID(id) as LoaiPhongViewModel;
        }

        public string Update(LoaiPhongViewModel obj)
        {
            var kq = LoaiPhongDataProvider.Ins.repository.Update(obj);
            if (kq)
            {
                return "Cập nhật thành công!";
            }
            else
            {
                return "Cập nhật thất bại!";
            }
        }
    }
}

