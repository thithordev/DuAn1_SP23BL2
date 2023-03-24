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
        private NhaNghiDbContext _DbContext;
        public bool Add(Phong phong)
        {
            if (phong == null) return false;
            _DbContext.phongs.Add(phong);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(Phong phong)
        {
            if (phong == null) return false;
            _DbContext.Remove(phong);
            _DbContext.SaveChanges();
            return true;
        }

        public List<Phong> GetAll()
        {
            return _DbContext.phongs.ToList();
        }

        public Phong GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.phongs.FirstOrDefault(c => c.IdPhong == id);
        }

        public bool Update(Phong phong)
        {
            if (phong == null) return false;
            _DbContext.phongs.Update(phong);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
