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
    public class KhachHangService : IKhachHangService
    {
        public string Add(KhachHangViewModel obj)
        {
            bool kq = KhachHangDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(KhachHangViewModel obj)
        {
            var kq = KhachHangDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<KhachHangViewModel> GetAll()
        {
            return KhachHangDataProvider.Ins.repository.GetAll().ConvertAll(x => KhachHangDataProvider.Ins.convertToVM(x));
        }

        public KhachHangViewModel GetByID(Guid id)
        {
            if (id == Guid.Empty) return new KhachHangViewModel();
            return KhachHangDataProvider.Ins.convertToVM(KhachHangDataProvider.Ins.repository.GetByID(id));
        }

        public string Update(KhachHangViewModel obj)
        {
            var kq = KhachHangDataProvider.Ins.repository.Update(obj);
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
