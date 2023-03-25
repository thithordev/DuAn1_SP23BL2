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
    public class PhieuDatPhongRepository : IPhieuDatPhongRepository
    {
        private NhaNghiDbContext _DbContext = new NhaNghiDbContext();
        public bool Add(PhieuDatPhong obj)
        {
            if (obj == null) return false;
            _DbContext.phieuDatPhongs.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(PhieuDatPhong obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<PhieuDatPhong> GetAll()
        {
            return _DbContext.phieuDatPhongs.ToList();
        }

        public PhieuDatPhong GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.phieuDatPhongs.FirstOrDefault(c => c.IdPhieuDatPhong == id);
        }

        public bool Update(PhieuDatPhong obj)
        {
            if (obj == null) return false;
            _DbContext.phieuDatPhongs.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
