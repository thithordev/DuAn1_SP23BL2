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
        #region CRUD
        public bool Add(PhieuDatPhongViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = PhieuDatPhongDataProvider.Ins.convertToM(obj);
            bool kq = PhieuDatPhongDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = PhieuDatPhongDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<PhieuDatPhongViewModel>? GetAll()
        {
            var lst = PhieuDatPhongDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            int count = lst.Count;
            for (int i = 0; i < count; i++)
            {
                lst[i].Phong = PhongDataProvider.Ins.repository.GetByID(lst[i].PhongId??Guid.Empty);
                lst[i].KhachHang = KhachHangDataProvider.Ins.repository.GetByID(lst[i].KhachHangId??Guid.Empty);
            }
            return lst.ConvertAll(p => PhieuDatPhongDataProvider.Ins.convertToVM(p));
        }

        public PhieuDatPhongViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = PhieuDatPhongDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return PhieuDatPhongDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(PhieuDatPhongViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = PhieuDatPhongDataProvider.Ins.convertToM(obj);
            bool kq = PhieuDatPhongDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}
