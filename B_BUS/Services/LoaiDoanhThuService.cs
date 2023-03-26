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
    public class LoaiDoanhThuService : ILoaiDoanhThuService
    {
        public string Add(LoaiDoanhThuViewModel obj)
        {
            bool kq = LoaiDoanhThuDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(LoaiDoanhThuViewModel obj)
        {
            var kq = LoaiDoanhThuDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<LoaiDoanhThuViewModel>? GetAll()
        {
            return LoaiDoanhThuDataProvider.Ins.repository.GetAll().ConvertAll(x => (LoaiDoanhThuViewModel)x);
        }

        public LoaiDoanhThuViewModel? GetByID(Guid id)
        {
            return LoaiDoanhThuDataProvider.Ins.repository.GetByID(id) as LoaiDoanhThuViewModel;
        }

        public string Update(LoaiDoanhThuViewModel obj)
        {
            var kq = LoaiDoanhThuDataProvider.Ins.repository.Update(obj);
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
