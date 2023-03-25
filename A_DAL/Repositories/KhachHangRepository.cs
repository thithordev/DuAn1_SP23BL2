using A_DAL.Context;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class KhachHangRepository
    {
        private NhaNghiDbContext _DbContext = new NhaNghiDbContext();
        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            _DbContext.khachHangs.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _DbContext.khachHangs.ToList();
        }

        public KhachHang? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.khachHangs.FirstOrDefault(c => c.IdKhachHang == id);
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            _DbContext.khachHangs.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
