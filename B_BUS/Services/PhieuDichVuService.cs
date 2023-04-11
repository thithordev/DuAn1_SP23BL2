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
            if (obj == null) return false;
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
            var lstVM = lst.ConvertAll(p => PhieuDichVuDataProvider.Ins.convertToVM(p));
            int count = lstVM.Count;
            for (int i = 0; i < count; i++)
            {
                lstVM[i].ChiTietPhieuDichVusVM = ChiTietPhieuDichVuDataProvider.Ins.service.GetAll()?.Where(x => x.PhieuDichVuID == lstVM[i].Id).ToList();
                lstVM[i].NhanVienVM = NhanVienDataProvider.Ins.service.GetByID(lstVM[i].NhanVienId ?? Guid.Empty);
                lstVM[i].PhieuDatPhongVM = PhieuDatPhongDataProvider.Ins.service.GetByID(lstVM[i].PhieuDatPhongId ?? Guid.Empty);
            }
            return lstVM;
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
