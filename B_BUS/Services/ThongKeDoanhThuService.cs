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
    public class ThongKeDoanhThuService : IThongKeDoanhThuService
    {
        #region CRUD
        public bool Add(ThongKeDoanhThuViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = ThongKeDoanhThuDataProvider.Ins.convertToM(obj);
            bool kq = ThongKeDoanhThuDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = ThongKeDoanhThuDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<ThongKeDoanhThuViewModel>? GetAll()
        {
            var lst = ThongKeDoanhThuDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => ThongKeDoanhThuDataProvider.Ins.convertToVM(p));
        }

        public List<ThongKeDoanhThuViewModel>? GetAllActive()
        {
            var lst = ThongKeDoanhThuDataProvider.Ins.repository.GetAllActive().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => ThongKeDoanhThuDataProvider.Ins.convertToVM(p));
        }

        public ThongKeDoanhThuViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = ThongKeDoanhThuDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return ThongKeDoanhThuDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(ThongKeDoanhThuViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = ThongKeDoanhThuDataProvider.Ins.convertToM(obj);
            bool kq = ThongKeDoanhThuDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}
