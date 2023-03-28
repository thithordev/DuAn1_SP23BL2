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
    public class ChucVuRepository : IChucVuRepository
    {
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.chucVus.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return DataProvider.Ins.dbContext.chucVus.ToList();
        }

        public ChucVu GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.chucVus.FirstOrDefault(c => c.IDChucVu == id);
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.chucVus.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
