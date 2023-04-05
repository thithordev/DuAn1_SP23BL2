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
    public class YeuCauService : IYeuCauService
    {
        #region CRUD
        public bool Add(YeuCauViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = YeuCauDataProvider.Ins.convertToM(obj);
            bool kq = YeuCauDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = YeuCauDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<YeuCauViewModel>? GetAll()
        {
            var lst = YeuCauDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => YeuCauDataProvider.Ins.convertToVM(p));
        }

        public List<YeuCauViewModel>? GetAllActive()
        {
            var lst = YeuCauDataProvider.Ins.repository.GetAllActive().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => YeuCauDataProvider.Ins.convertToVM(p));
        }

        public YeuCauViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = YeuCauDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return YeuCauDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(YeuCauViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = YeuCauDataProvider.Ins.convertToM(obj);
            bool kq = YeuCauDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}
