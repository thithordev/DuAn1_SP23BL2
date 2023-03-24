using A_DAL.Context;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class PhieuDichVuRepository
    {
        private NhaNghiDbContext _DbContext = new NhaNghiDbContext();
        public bool Add(PhieuDichVu obj)
        {
            if (obj == null) return false;
            _DbContext.phieuDichVus.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(PhieuDichVu obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<PhieuDichVu> GetAll()
        {
            return _DbContext.phieuDichVus.ToList();
        }

        public PhieuDichVu? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.phieuDichVus.FirstOrDefault(c => c.IdPhieuDichVu == id);
        }

        public bool Update(PhieuDichVu obj)
        {
            if (obj == null) return false;
            _DbContext.phieuDichVus.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
