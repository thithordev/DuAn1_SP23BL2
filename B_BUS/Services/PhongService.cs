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

        public List<PhongViewModel>? GetAllActiveRef()
        {
            var lst = GetAll();
            if (lst == null) return null;
            int count = lst.Count;
            for (int i = 0; i < count; i++)
            {
                lst[i].LoaiPhongViewModel = LoaiPhongDataProvider.Ins.service.GetByID(lst[i].LoaiPhongId ?? Guid.Empty);
            }
            return lst;
        }

        public List<PhongViewModel>? CheckPhongRealTime()
        {
            List<PhieuDatPhongViewModel> lstCol = PhieuDatPhongDataProvider.Ins.service.GetAll() ?? new List<PhieuDatPhongViewModel>();
            var lst = GetAll();
            if (lst == null) return null;
            int count = lst.Count;
            for (int i = 0; i < count; i++)
            {
                lst[i].PhieuDatPhongViewModels = lstCol.Where(x => x.PhongId == lst[i].Id && (x.NgayDat??DateTime.MinValue) >= DateTime.Now).OrderBy(x => x.NgayDat).ToList();
                lst[i].LoaiPhongViewModel = LoaiPhongDataProvider.Ins.service.GetByID(lst[i].LoaiPhongId ?? Guid.Empty);
            }
            return lst;
        }

        public List<PhongViewModel> CheckKhoang(List<PhongViewModel> lst, DateTime fromTime, DateTime toTime)
        {
            if (fromTime < toTime) return lst;
            if(fromTime < DateTime.Now.AddMinutes(-5)) return lst;
            int count = lst.Count;
            var newlst = new List<PhongViewModel>();
            for (int i = 0; i < count; i++)
            {
                PhieuDatPhongViewModel phieuDat = lst[i].PhieuDatPhongViewModels.Where( x => x.NgayDat > fromTime).OrderBy(x => x.NgayDat).FirstOrDefault()?? new PhieuDatPhongViewModel();
                
            }
            return newlst;
        }
    }
}
