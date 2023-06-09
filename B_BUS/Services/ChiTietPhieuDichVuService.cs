﻿using A_DAL.Repositories;
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
    public class ChiTietPhieuDichVuService : IChiTietPhieuDichVuService
    {
        #region CRUD
        public bool Add(ChiTietPhieuDichVuViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = ChiTietPhieuDichVuDataProvider.Ins.convertToM(obj);
            bool kq = ChiTietPhieuDichVuDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = ChiTietPhieuDichVuDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<ChiTietPhieuDichVuViewModel>? GetAll()
        {
            var lst = ChiTietPhieuDichVuDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => ChiTietPhieuDichVuDataProvider.Ins.convertToVM(p));
        }

        public List<ChiTietPhieuDichVuViewModel>? GetAllActive()
        {
            var lst = ChiTietPhieuDichVuDataProvider.Ins.repository.GetAllActive().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => ChiTietPhieuDichVuDataProvider.Ins.convertToVM(p));
        }

        public ChiTietPhieuDichVuViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = ChiTietPhieuDichVuDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return ChiTietPhieuDichVuDataProvider.Ins.convertToVM(obj);
        }

        public bool Update(ChiTietPhieuDichVuViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = ChiTietPhieuDichVuDataProvider.Ins.convertToM(obj);
            bool kq = ChiTietPhieuDichVuDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion
    }
}
