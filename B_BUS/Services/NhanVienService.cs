﻿using A_DAL.Context;
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
    public class NhanVienService : INhanVienService
    {
        public string Add(NhanVienViewModel obj)
        {
            bool kq = NhanVienDataProvider.Ins.repository.Add(obj);
            if (kq)
            {
                return "Thêm thành công!";
            }
            else
            {
                return "Thêm thất bại!";
            }
        }

        public string Delete(NhanVienViewModel obj)
        {
            var kq = NhanVienDataProvider.Ins.repository.Delete(obj);
            if (kq)
            {
                return "Xóa thành công!";
            }
            else
            {
                return "Xóa thất bại!";
            }
        }

        public List<NhanVienViewModel>? GetAll()
        {
            return NhanVienDataProvider.Ins.repository.GetAll().ConvertAll(x => (NhanVienViewModel)x);
        }

        public NhanVienViewModel? GetByID(Guid id)
        {
            return NhanVienDataProvider.Ins.repository.GetByID(id) as NhanVienViewModel;
        }

        public string Update(NhanVienViewModel obj)
        {
            var kq = NhanVienDataProvider.Ins.repository.Update(obj);
            if (kq)
            {
                return "Cập nhật thành công!";
            }
            else
            {
                return "Cập nhật thất bại!";
            }
        }
    }
}