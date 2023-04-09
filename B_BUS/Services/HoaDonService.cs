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
        #region CRUD
        public bool Add(HoaDonViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = HoaDonDataProvider.Ins.convertToM(obj);
            bool kq = HoaDonDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = HoaDonDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<HoaDonViewModel>? GetAll()
        {
            var lst = HoaDonDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            int count = lst.Count;
            for (int i = 0; i < count; i++)
            {
                lst[i].NhanVien = NhanVienDataProvider.Ins.repository.GetByID(lst[i].NhanVienId ?? Guid.Empty);
                lst[i].KhachHang = KhachHangDataProvider.Ins.repository.GetByID(lst[i].KhachHangId ?? Guid.Empty);
            }
            return lst.ConvertAll(p => HoaDonDataProvider.Ins.convertToVM(p));
        }

        public HoaDonViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = HoaDonDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return HoaDonDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(HoaDonViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = HoaDonDataProvider.Ins.convertToM(obj);
            bool kq = HoaDonDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}
