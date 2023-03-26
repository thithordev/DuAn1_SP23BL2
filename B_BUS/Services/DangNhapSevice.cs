
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class DangNhapSevice : ItaiKhoanViewSevice
    {
        INhanVienRepository _NhanVien;
        IChucVuRepository _ChucVu;
        public DangNhapSevice()
        {
            _NhanVien = new NhanVienRepository();
            _ChucVu = new ChucVuRepository();
        }

        public string Create(TaiKhoanView taiKhoanView)
        {
            throw new NotImplementedException();
        }

        public string Delete(TaiKhoanView taiKhoanView)
        {
            throw new NotImplementedException();
        }

        public List<TaiKhoanView> GetAll()
        {
            var ds = from x in _NhanVien.GetAll()
                     join y in _ChucVu.GetAll() on x.ChucVuId equals y.IDChucVu
                     select new TaiKhoanView()
                     {
                         nhanViens = x,
                         ChucVus = y,
                     };
            return ds.ToList();
        }

        public string Update(TaiKhoanView taiKhoanView)
        {
            throw new NotImplementedException();
        }
    }
}
