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
    public class PhieuDichVuService : IDichVuService
    {
        public string Add(PhieuDichVuViewModel obj)
        {
            bool kq = PhieuDichVuDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(PhieuDichVuViewModel obj)
        {
            var kq = PhieuDichVuDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<PhieuDichVuViewModel>? GetAll()
        {
            return PhieuDichVuDataProvider.Ins.repository.GetAll().ConvertAll(x => (PhieuDichVuViewModel)x);
        }

        public PhieuDichVuViewModel? GetByID(Guid id)
        {
            return PhieuDichVuDataProvider.Ins.repository.GetByID(id) as PhieuDichVuViewModel;
        }

        public string Update(PhieuDichVuViewModel obj)
        {
            var kq = PhieuDichVuDataProvider.Ins.repository.Update(obj);
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
