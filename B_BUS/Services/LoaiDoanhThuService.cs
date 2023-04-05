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
    public class LoaiDoanhThuService : ILoaiDoanhThuService
    {
        #region CRUD
        public bool Add(LoaiDoanhThuViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = LoaiDoanhThuDataProvider.Ins.convertToM(obj);
            bool kq = LoaiDoanhThuDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = LoaiDoanhThuDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<LoaiDoanhThuViewModel>? GetAll()
        {
            var lst = LoaiDoanhThuDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => LoaiDoanhThuDataProvider.Ins.convertToVM(p));
        }

        public List<LoaiDoanhThuViewModel>? GetAllActive()
        {
            var lst = LoaiDoanhThuDataProvider.Ins.repository.GetAllActive().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => LoaiDoanhThuDataProvider.Ins.convertToVM(p));
        }

        public LoaiDoanhThuViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = LoaiDoanhThuDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return LoaiDoanhThuDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(LoaiDoanhThuViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = LoaiDoanhThuDataProvider.Ins.convertToM(obj);
            bool kq = LoaiDoanhThuDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}
