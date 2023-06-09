﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using B_BUS.DataProviders;
using B_BUS.IServices;
using B_BUS.ViewModels;

namespace B_BUS.Services
{
    public class NhanVienService : INhanVienService
    {
        #region CRUD
        public bool Add(NhanVienViewModel obj)
        {
            if (obj == null || obj.Id != Guid.Empty) return false;
            var objIsModel = NhanVienDataProvider.Ins.convertToM(obj);
            bool kq = NhanVienDataProvider.Ins.repository.Add(objIsModel);
            if (kq) return true;
            return false;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            bool kq = NhanVienDataProvider.Ins.repository.Delete(id);
            if (kq) return true;
            return false;
        }

        public List<NhanVienViewModel>? GetAll()
        {
            var lst = NhanVienDataProvider.Ins.repository.GetAll().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => NhanVienDataProvider.Ins.convertToVM(p));
        }

        public List<NhanVienViewModel>? GetAllActive()
        {
            var lst = NhanVienDataProvider.Ins.repository.GetAllActive().ToList();
            if (lst == null) return null;
            return lst.ConvertAll(p => NhanVienDataProvider.Ins.convertToVM(p));
        }

        public NhanVienViewModel? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            var obj = NhanVienDataProvider.Ins.repository.GetByID(id);
            if (obj == null) return null;
            return NhanVienDataProvider.Ins.convertToVM(obj);
        }
        public bool Update(NhanVienViewModel obj)
        {
            if (obj.Id == Guid.Empty || obj == null) return false;
            var objIsModel = NhanVienDataProvider.Ins.convertToM(obj);
            bool kq = NhanVienDataProvider.Ins.repository.Update(objIsModel);
            if (kq) return true;
            return false;
        }
        #endregion

        public NhanVienViewModel? GetLogin(string username, string password)
        {
            var lst = GetAll();
            if (lst == null) return null;
            var obj = lst.Where(x => x.TenTaiKhoan == username && x.MatKhau == password).FirstOrDefault();
            // Tìm chức vụ:
            if(obj == null) return null;
            var idChucVu = obj.ChucVuId ?? Guid.Empty;
            obj.ChucVuViewModel = ChucVuDataProvider.Ins.service.GetByID(idChucVu);
            return obj;
        }

    }
}
