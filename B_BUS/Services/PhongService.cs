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
        #region CRUD
        public bool Add(PhongViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = PhongDataProvider.Ins.convertToM(obj);
            bool kq = PhongDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = PhongDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<PhongViewModel>? GetAll()
        {
            var lst = PhongDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            //for (int i = 0; i < count; i++)
            //{
            //    lst[i].Phong = PhongDataProvider.Ins.repository.GetByID(lst[i].PhongId ?? Guid.Empty);
            //    lst[i].KhachHang = KhachHangDataProvider.Ins.repository.GetByID(lst[i].KhachHangId ?? Guid.Empty);
            //}
            return lst.ConvertAll(p => PhongDataProvider.Ins.convertToVM(p));
        }

        public PhongViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = PhongDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return PhongDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(PhongViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = PhongDataProvider.Ins.convertToM(obj);
            bool kq = PhongDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion

        public PhongViewModel GetLstPhieuDatPhong(PhongViewModel obj)
        {
            var lst = PhieuDatPhongDataProvider.Ins.repository.GetAll().Where(x => x.PhongId == obj.Id && x.TrangThai == 1).OrderBy(x => x.NgayDat).ToList();
            if(lst == null || lst.Count == 0) { obj.PhieuDatPhongViewModels = null; return obj; }
            obj.PhieuDatPhongViewModels = lst.ConvertAll(p => PhieuDatPhongDataProvider.Ins.convertToVM(p));
            return obj;
        }
    }
}
