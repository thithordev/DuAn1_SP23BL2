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
    public class ChucVuService : IChucVuService
    {
        public string Add(ChucVuViewModel obj)
        {
            bool kq = ChucVuDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(ChucVuViewModel obj)
        {
            var kq = ChucVuDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<ChucVuViewModel>? GetAll()
        {
            return ChucVuDataProvider.Ins.repository.GetAll().ConvertAll(x => (ChucVuViewModel)x);
        }

        public ChucVuViewModel? GetByID(Guid id)
        {
            return ChucVuDataProvider.Ins.repository.GetByID(id) as ChucVuViewModel;
        }

        public string Update(ChucVuViewModel obj)
        {
            var kq = ChucVuDataProvider.Ins.repository.Update(obj);
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
