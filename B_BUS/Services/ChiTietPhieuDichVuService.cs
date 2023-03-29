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
    public class ChiTietPhieuDichVuService : IChiTietPhieuDichVuService
    {
        public string Add(ChiTietPhieuDichVuViewModel obj)
        {
            bool kq = ChiTietPhieuDichVuDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(ChiTietPhieuDichVuViewModel obj)
        {
            var kq = ChiTietPhieuDichVuDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<ChiTietPhieuDichVuViewModel> GetAll()
        {
            return ChiTietPhieuDichVuDataProvider.Ins.repository.GetAll().ConvertAll( x => ChiTietPhieuDichVuDataProvider.Ins.convertToVM(x));
        }

        public ChiTietPhieuDichVuViewModel GetByID(Guid id)
        {
            if (id == Guid.Empty) return new ChiTietPhieuDichVuViewModel();
            return ChiTietPhieuDichVuDataProvider.Ins.convertToVM(ChiTietPhieuDichVuDataProvider.Ins.repository.GetByID(id));
        }

        public string Update(ChiTietPhieuDichVuViewModel obj)
        {
            var kq = ChiTietPhieuDichVuDataProvider.Ins.repository.Update(obj);
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
