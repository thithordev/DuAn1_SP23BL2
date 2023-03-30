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
    public class PhieuDichVuRepository : IPhieuDichVuRepository
    {
        public bool Add(PhieuDichVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.phieuDichVus.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(PhieuDichVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<PhieuDichVu> GetAll()
        {
            return DataProvider.Ins.dbContext.phieuDichVus.ToList();
        }

        public PhieuDichVu GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.phieuDichVus.FirstOrDefault(c => c.IdPhieuDichVu == id) ?? new PhieuDichVu();
        }

        public bool Update(PhieuDichVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.phieuDichVus.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
