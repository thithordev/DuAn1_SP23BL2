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
    public class PhieuDatPhongService : IPhieuDatPhongService
    {
        #region CRUD
        public bool Add(PhieuDatPhongViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = PhieuDatPhongDataProvider.Ins.convertToM(obj);
            bool kq = PhieuDatPhongDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = PhieuDatPhongDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<PhieuDatPhongViewModel>? GetAll()
        {
            var lst = PhieuDatPhongDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            var lstVM = lst.ConvertAll(p => PhieuDatPhongDataProvider.Ins.convertToVM(p));
            int count = lstVM.Count;
            for (int i = 0; i < count; i++)
            {
                lstVM[i].PhongVM = PhongDataProvider.Ins.service.GetByID(lstVM[i].PhongId??Guid.Empty);
                lstVM[i].KhachHangVM = KhachHangDataProvider.Ins.service.GetByID(lstVM[i].KhachHangId ?? Guid.Empty);
                lstVM[i].NhanVienVM = NhanVienDataProvider.Ins.service.GetByID(lstVM[i].NhanVienId ?? Guid.Empty);
                lstVM[i].HoaDonVM = HoaDonDataProvider.Ins.service.GetByID(lstVM[i].HoaDonId ?? Guid.Empty);
                lstVM[i].PhieuDichVusVM = PhieuDichVuDataProvider.Ins.service.GetAll()?.Where(x => x.PhieuDatPhongId == lstVM[i].Id).ToList();
            }
            return lstVM;
        }

        public PhieuDatPhongViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = PhieuDatPhongDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return PhieuDatPhongDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(PhieuDatPhongViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = PhieuDatPhongDataProvider.Ins.convertToM(obj);
            bool kq = PhieuDatPhongDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}
