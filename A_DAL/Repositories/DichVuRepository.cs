using A_DAL.Context;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class DichVuRepository
    {
        private NhaNghiDbContext _DbContext = new NhaNghiDbContext();
        public bool Add(DichVu obj)
        {
            if (obj == null) return false;
            _DbContext.dichVus.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(DichVu obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<DichVu> GetAll()
        {
            return _DbContext.dichVus.ToList();
        }

        public DichVu? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.dichVus.FirstOrDefault(c => c.IdDichVu == id);
        }

        public bool Update(DichVu obj)
        {
            if (obj == null) return false;
            _DbContext.dichVus.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
