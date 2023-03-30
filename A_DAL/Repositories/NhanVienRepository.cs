using A_DAL.Context;
using A_DAL.IRepositories;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class NhanVienRepository : INhanVienRepository
    {
        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.nhanViens.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return DataProvider.Ins.dbContext.nhanViens.ToList();
        }

        public NhanVien GetByID(Guid id)
        {
            if (id == Guid.Empty) return new NhanVien(); ;
            return DataProvider.Ins.dbContext.nhanViens.FirstOrDefault(c => c.IdNhanVien == id) ?? new NhanVien();
        }

        public NhanVien GetLogin(string username, string password)
        {
            
            var Qrreyable_nv = DataProvider.Ins.dbContext.nhanViens.Where( x => x.TenTaiKhoan == username && x.MatKhau == password );
            if (Qrreyable_nv.Count() != 0)
            {
                var nv = Qrreyable_nv.First();
                DataProvider.Ins.dbContext.Entry(nv).Reference(p => p.ChucVu).Load();
                return nv;
            }
            return new NhanVien();
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.nhanViens.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
