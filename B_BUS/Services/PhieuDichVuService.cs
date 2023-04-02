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
    public class PhieuDichVuService : IPhieuDichVuService
    {
        #region CRUD
        public bool Add(PhieuDichVuViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = PhieuDichVuDataProvider.Ins.convertToM(obj);
            bool kq = PhieuDichVuDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = PhieuDichVuDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<PhieuDichVuViewModel>? GetAll()
        {
            var lst = PhieuDichVuDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => PhieuDichVuDataProvider.Ins.convertToVM(p));
        }

        public List<PhieuDichVuViewModel>? GetAllActive()
        {
            var lst = PhieuDichVuDataProvider.Ins.repository.GetAllActive().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => PhieuDichVuDataProvider.Ins.convertToVM(p));
        }

        public PhieuDichVuViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = PhieuDichVuDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return PhieuDichVuDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(PhieuDichVuViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = PhieuDichVuDataProvider.Ins.convertToM(obj);
            bool kq = PhieuDichVuDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}
