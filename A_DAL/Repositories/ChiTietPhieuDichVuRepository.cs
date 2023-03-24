using A_DAL.Context;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class ChiTietPhieuDichVuRepository
    {
        private NhaNghiDbContext _DbContext = new NhaNghiDbContext();
        public bool Add(ChiTietPhieuDichVu obj)
        {
            if (obj == null) return false;
            _DbContext.chiTietPhieuDichVus.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietPhieuDichVu obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<ChiTietPhieuDichVu> GetAll()
        {
            return _DbContext.chiTietPhieuDichVus.ToList();
        }

        public ChiTietPhieuDichVu? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.chiTietPhieuDichVus.FirstOrDefault(c => c.IDChiTietPhieuDichVu == id);
        }

        public bool Update(ChiTietPhieuDichVu obj)
        {
            if (obj == null) return false;
            _DbContext.chiTietPhieuDichVus.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
