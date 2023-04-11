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
            var lst = PhongDataProvider.Ins.repository.GetAll().ToList().ConvertAll(p => PhongDataProvider.Ins.convertToVM(p));
            if (lst == null) return null;
            int count = lst.Count;
            for (int i = 0; i < count; i++)
            {
                lst[i].loaiPhongViewModel = LoaiPhongDataProvider.Ins.service.GetByID(lst[i].LoaiPhongId ?? Guid.Empty);
                lst[i].PhieuDatPhongViewModels = GetLstPhieuDatPhong(lst[i]);
            }
            return lst;
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

        public List<PhieuDatPhongViewModel>? GetLstPhieuDatPhong(PhongViewModel obj)
        {
            var lst = PhieuDatPhongDataProvider.Ins.repository.GetAll().Where(x => x.PhongId == obj.Id && x.TrangThai == 1).OrderBy(x => x.NgayDat).ToList();
            if(lst == null || lst.Count == 0) { return null; }
            return lst.ConvertAll(p => PhieuDatPhongDataProvider.Ins.convertToVM(p));
        }
    }
}
