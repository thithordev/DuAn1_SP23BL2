using System;
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

        public List<NhanVienViewModel> GetAll()
        {
            return NhanVienDataProvider.Ins.repository.GetAll().ConvertAll(x => NhanVienDataProvider.Ins.convertToVM(x));
        }

        public NhanVienViewModel GetByID(Guid id)
        {
            return NhanVienDataProvider.Ins.convertToVM(NhanVienDataProvider.Ins.repository.GetByID(id));
        }

        public NhanVienViewModel GetLogin(string username, string password)
        {
            return NhanVienDataProvider.Ins.convertToVM(NhanVienDataProvider.Ins.repository.GetLogin(username,password));
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
