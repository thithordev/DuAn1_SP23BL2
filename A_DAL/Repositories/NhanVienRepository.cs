using A_DAL.Context;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class NhanVienRepository
    {
        private NhaNghiDbContext _DbContext = new NhaNghiDbContext();
        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            _DbContext.nhanViens.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _DbContext.nhanViens.ToList();
        }

        public NhanVien? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.nhanViens.FirstOrDefault(c => c.IdNhanVien == id);
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            _DbContext.nhanViens.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
