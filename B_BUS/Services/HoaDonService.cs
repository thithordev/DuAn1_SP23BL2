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
    public class HoaDonService : IHoaDonService
    {
        public string Add(HoaDonViewModel obj)
        {
            bool kq = HoaDonDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(HoaDonViewModel obj)
        {
            var kq = HoaDonDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<HoaDonViewModel>? GetAll()
        {
            return HoaDonDataProvider.Ins.repository.GetAll().ConvertAll(x => (HoaDonViewModel)x);
        }

        public HoaDonViewModel? GetByID(Guid id)
        {
            return HoaDonDataProvider.Ins.repository.GetByID(id) as HoaDonViewModel;
        }

        public string Update(HoaDonViewModel obj)
        {
            var kq = HoaDonDataProvider.Ins.repository.Update(obj);
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
