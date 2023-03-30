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
    public class KhachHangRepository : IKhachHangRepository
    {
        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.khachHangs.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return DataProvider.Ins.dbContext.khachHangs.ToList();
        }

        public KhachHang GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.khachHangs.FirstOrDefault(c => c.IdKhachHang == id) ?? new KhachHang();
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.khachHangs.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
