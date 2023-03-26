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

        public NhanVien? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.nhanViens.FirstOrDefault(c => c.IdNhanVien == id);
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
