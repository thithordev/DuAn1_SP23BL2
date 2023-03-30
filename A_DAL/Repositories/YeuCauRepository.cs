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

    public class YeuCauRepository:IYeuCauRepository

    {
        public bool Add(YeuCau obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.yeuCaus.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(YeuCau obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<YeuCau> GetAll()
        {
            return DataProvider.Ins.dbContext.yeuCaus.ToList();
        }

        public YeuCau GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.yeuCaus.FirstOrDefault(c => c.IdYeuCau == id) ?? new YeuCau();
        }

        public bool Update(YeuCau obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.yeuCaus.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
