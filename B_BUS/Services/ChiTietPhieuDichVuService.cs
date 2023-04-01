using A_DAL.IRepositories;
using A_DAL.Repositories;
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
        IChiTietPhieuDichVuRepository _chitietphieuDV;
        IDichVuRepository _dichVu;
        IPhieuDichVuRepository _phieuDichVu;
        public ChiTietPhieuDichVuService()
        {
            _chitietphieuDV = new ChiTietPhieuDichVuRepository();
            _dichVu = new DichVuRepository();
            _phieuDichVu = new PhieuDichVuRepository();
        }

        public string Add(ChiTietPhieuDichVuViewModel obj)
        {
            if (obj == null) return "thêm không thành công";
            if (_phieuDichVu.Add(obj.phieuDichVu)) return "thêm thành công";
            return "thêm không thành công";
        }

        public string Add1(ChiTietPhieuDichVuViewModel obj)
        {
            if (obj == null) return "thêm không thành công";
            if (_chitietphieuDV.Add(obj.ChiTietPhieuDichVu)) return "thêm thành công";
            return "thêm không thành công";
        }

        public string Delete(ChiTietPhieuDichVuViewModel obj)
        {
            if (obj == null) return "xóa không thành công";
            var dt = _chitietphieuDV.GetByID(obj.IDChiTietPhieuDichVu);
            if (dt != null)
            {
                _chitietphieuDV.Delete(obj);
            }
            return "xóa thành công";
        }

        public List<ChiTietPhieuDichVuViewModel> GetAll()
        {
            var ds = from x in _chitietphieuDV.GetAll()
                      join y in _dichVu.GetAll() on x.DichVuID equals y.IdDichVu
                      join z in _phieuDichVu.GetAll() on x.PhieuDichVuID equals z.IdPhieuDichVu
                      select new ChiTietPhieuDichVuViewModel
                      {
                          ChiTietPhieuDichVu = x,
                          DichVu = y,
                          phieuDichVu = z,
                      };
            return ds.ToList();
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
