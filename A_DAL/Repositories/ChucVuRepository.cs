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
        private NhaNghiDbContext _DbContext = new NhaNghiDbContext();
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            _DbContext.chucVus.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _DbContext.chucVus.ToList();
        }

        public ChucVu? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.chucVus.FirstOrDefault(c => c.IDChucVu == id);
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            _DbContext.chucVus.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
