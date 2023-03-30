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
    public class PhongService : IPhongService
    {
        public string Add(PhongViewModel obj)
        {
            bool kq = PhongDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(PhongViewModel obj)
        {
            var kq = PhongDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<PhongViewModel> GetAll()
        {
            return PhongDataProvider.Ins.repository.GetAll().ConvertAll(x => PhongDataProvider.Ins.convertToVM(x));
        }

        public PhongViewModel GetByID(Guid id)
        {
            if (id == Guid.Empty) return new PhongViewModel();
            return PhongDataProvider.Ins.convertToVM(PhongDataProvider.Ins.repository.GetByID(id));
        }

        public string Update(PhongViewModel obj)
        {
            var kq = PhongDataProvider.Ins.repository.Update(obj);
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
