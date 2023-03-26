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
    public class PhongRepository : IPhongRepository
    {
        public bool Add(Phong obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.phongs.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Phong obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<Phong>? GetAll()
        {
            return DataProvider.Ins.dbContext.phongs.ToList();
        }

        public Phong? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.phongs.FirstOrDefault(c => c.IdPhong == id);
        }

        public bool Update(Phong obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.phongs.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
