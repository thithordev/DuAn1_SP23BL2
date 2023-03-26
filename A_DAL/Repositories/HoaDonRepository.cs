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
    public class HoaDonRepository : IHoaDonRepository
    {
        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.hoaDons.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<HoaDon>? GetAll()
        {
            return DataProvider.Ins.dbContext.hoaDons.ToList();
        }

        public HoaDon? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.hoaDons.FirstOrDefault(c => c.IdHoaDon == id);
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.hoaDons.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
