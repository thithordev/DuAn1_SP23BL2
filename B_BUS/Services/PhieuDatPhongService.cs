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
    public class PhieuDatPhongService : IPhieuDatPhongService
    {
        public string Add(PhieuDatPhongViewModel obj)
        {
            bool kq = PhieuDatPhongDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(PhieuDatPhongViewModel obj)
        {
            var kq = PhieuDatPhongDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<PhieuDatPhongViewModel> GetAll()
        {
            return PhieuDatPhongDataProvider.Ins.repository.GetAll().ConvertAll(x => PhieuDatPhongDataProvider.Ins.convertToVM(x));
        }

        public PhieuDatPhongViewModel GetByID(Guid id)
        {
            if (id == Guid.Empty) return new PhieuDatPhongViewModel();
            return PhieuDatPhongDataProvider.Ins.convertToVM(PhieuDatPhongDataProvider.Ins.repository.GetByID(id));
        }

        public string Update(PhieuDatPhongViewModel obj)
        {
            var kq = PhieuDatPhongDataProvider.Ins.repository.Update(obj);
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
