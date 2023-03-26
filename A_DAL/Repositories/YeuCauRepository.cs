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
        private NhaNghiDbContext _DbContext = new NhaNghiDbContext();
        public bool Add(YeuCau obj)
        {
            if (obj == null) return false;
            _DbContext.yeuCaus.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(YeuCau obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<YeuCau> GetAll()
        {
            return _DbContext.yeuCaus.ToList();
        }

        public YeuCau? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.yeuCaus.FirstOrDefault(c => c.IdYeuCau == id);
        }

        public bool Update(YeuCau obj)
        {
            if (obj == null) return false;
            _DbContext.yeuCaus.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
