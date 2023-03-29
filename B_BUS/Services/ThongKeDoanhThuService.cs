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
    public class ThongKeDoanhThuService : IThongKeDoanhThuService
    {
        public string Add(ThongKeDoanhThuViewModel obj)
        {
            bool kq = ThongKeDoanhThuDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(ThongKeDoanhThuViewModel obj)
        {
            var kq = ThongKeDoanhThuDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<ThongKeDoanhThuViewModel>? GetAll()
        {
            return ThongKeDoanhThuDataProvider.Ins.repository.GetAll().ConvertAll(x => (ThongKeDoanhThuViewModel)x);
        }

        public ThongKeDoanhThuViewModel? GetByID(Guid id)
        {
            return ThongKeDoanhThuDataProvider.Ins.repository.GetByID(id) as ThongKeDoanhThuViewModel;
        }

        public string Update(ThongKeDoanhThuViewModel obj)
        {
            var kq = ThongKeDoanhThuDataProvider.Ins.repository.Update(obj);
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
