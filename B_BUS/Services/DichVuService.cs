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
    public class DichVuService : IDichVuService
    {
        public string Add(DichVuViewModel obj)
        {
            bool kq = DichVuDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(DichVuViewModel obj)
        {
            var kq = DichVuDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<DichVuViewModel> GetAll()
        {
            return DichVuDataProvider.Ins.repository.GetAll().ConvertAll(x => DichVuDataProvider.Ins.convertToVM(x));
        }

        public DichVuViewModel GetByID(Guid id)
        {
            if (id == Guid.Empty) return new DichVuViewModel();
            return DichVuDataProvider.Ins.convertToVM(DichVuDataProvider.Ins.repository.GetByID(id));
        }

        public string Update(DichVuViewModel obj)
        {
            var kq = DichVuDataProvider.Ins.repository.Update(obj);
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
