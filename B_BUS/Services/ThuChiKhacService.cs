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
    public class ThuChiKhacService : IThuChiKhacService
    {
        #region CRUD
        public bool Add(ThuChiKhacViewModel obj)
        {
            if (obj == null) return false;
            var objIsModel = ThuChiKhacDataProvider.Ins.convertToM(obj);
            bool kq = ThuChiKhacDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = ThuChiKhacDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<ThuChiKhacViewModel>? GetAll()
        {
            var lst = ThuChiKhacDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => ThuChiKhacDataProvider.Ins.convertToVM(p));
        }

        public ThuChiKhacViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = ThuChiKhacDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return ThuChiKhacDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(ThuChiKhacViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = ThuChiKhacDataProvider.Ins.convertToM(obj);
            bool kq = ThuChiKhacDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}
