using A_DAL.Context;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class ChiTietPhieuDichVuRepository
    {
        public bool Add(ChiTietPhieuDichVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.chiTietPhieuDichVus.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietPhieuDichVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<ChiTietPhieuDichVu> GetAll()
        {
            return DataProvider.Ins.dbContext.chiTietPhieuDichVus.ToList();
        }

        public ChiTietPhieuDichVu? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.chiTietPhieuDichVus.FirstOrDefault(c => c.IDChiTietPhieuDichVu == id);
        }

        public bool Update(ChiTietPhieuDichVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.chiTietPhieuDichVus.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
