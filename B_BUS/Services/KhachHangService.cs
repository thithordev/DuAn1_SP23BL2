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
    public class KhachHangService : IKhachHangService
    {
        #region CRUD
        public bool Add(KhachHangViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = KhachHangDataProvider.Ins.convertToM(obj);
            bool kq = KhachHangDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = KhachHangDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<KhachHangViewModel>? GetAll()
        {
            var lst = KhachHangDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => KhachHangDataProvider.Ins.convertToVM(p));
        }

        public List<KhachHangViewModel>? GetAllActive()
        {
            var lst = KhachHangDataProvider.Ins.repository.GetAllActive().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => KhachHangDataProvider.Ins.convertToVM(p));
        }

        public KhachHangViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = KhachHangDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return KhachHangDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(KhachHangViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = KhachHangDataProvider.Ins.convertToM(obj);
            bool kq = KhachHangDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}
