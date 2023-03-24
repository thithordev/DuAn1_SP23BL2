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
        private NhaNghiDbContext _DbContext;
        public bool Add(PhieuDatPhong phieuDatPhong)
        {
            if (phieuDatPhong == null) return false;
            _DbContext.phieuDatPhongs.Add(phieuDatPhong);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(PhieuDatPhong phieuDatPhong)
        {
            if (phieuDatPhong == null) return false;
            _DbContext.Remove(phieuDatPhong);
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

        public bool Update(PhieuDatPhong phieuDatPhong)
        {
            if (phieuDatPhong == null) return false;
            _DbContext.phieuDatPhongs.Update(phieuDatPhong);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
