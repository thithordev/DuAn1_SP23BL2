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
    public class PhieuDatPhongRepository : IPhieuDatPhongRepository
    {
        public bool Add(PhieuDatPhong obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.phieuDatPhongs.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(PhieuDatPhong obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<PhieuDatPhong> GetAll()
        {
            return DataProvider.Ins.dbContext.phieuDatPhongs.ToList();
        }

        public PhieuDatPhong GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.phieuDatPhongs.FirstOrDefault(c => c.IdPhieuDatPhong == id);
        }

        public bool Update(PhieuDatPhong obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.phieuDatPhongs.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
