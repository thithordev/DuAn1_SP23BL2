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
    public class DichVuService : IDichVuService
    {
        #region CRUD
        public bool Add(DichVuViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = DichVuDataProvider.Ins.convertToM(obj);
            bool kq = DichVuDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = DichVuDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<DichVuViewModel>? GetAll()
        {
            var lst = DichVuDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => DichVuDataProvider.Ins.convertToVM(p));
        }

        public List<DichVuViewModel>? GetAllActive()
        {
            var lst = DichVuDataProvider.Ins.repository.GetAllActive().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => DichVuDataProvider.Ins.convertToVM(p));
        }

        public DichVuViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = DichVuDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return DichVuDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(DichVuViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = DichVuDataProvider.Ins.convertToM(obj);
            bool kq = DichVuDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}
