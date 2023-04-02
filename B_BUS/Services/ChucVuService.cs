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
    public class ChucVuService : IChucVuService
    {
        #region CRUD
        public bool Add(ChucVuViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = ChucVuDataProvider.Ins.convertToM(obj);
            bool kq = ChucVuDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = ChucVuDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<ChucVuViewModel>? GetAll()
        {
            var lst = ChucVuDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => ChucVuDataProvider.Ins.convertToVM(p));
        }

        public List<ChucVuViewModel>? GetAllActive()
        {
            var lst = ChucVuDataProvider.Ins.repository.GetAllActive().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => ChucVuDataProvider.Ins.convertToVM(p));
        }

        public ChucVuViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = ChucVuDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return ChucVuDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(ChucVuViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = ChucVuDataProvider.Ins.convertToM(obj);
            bool kq = ChucVuDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}
