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
    public class LoaiPhongRepository : ILoaiPhongRepository
    {
        private NhaNghiDbContext _DbContext;
        public bool Add(LoaiPhong loaiPhong)
        {
            if (loaiPhong == null) return false;
            _DbContext.loaiPhongs.Add(loaiPhong);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiPhong loaiPhong)
        {
            if (loaiPhong == null) return false;
            _DbContext.Remove(loaiPhong);
            _DbContext.SaveChanges();
            return true;
        }

        public List<LoaiPhong> GetAll()
        {
            return _DbContext.loaiPhongs.ToList();
        }

        public LoaiPhong GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.loaiPhongs.FirstOrDefault(c => c.IdLoaiPhong == id);
        }

        public bool Update(LoaiPhong loaiPhong)
        {
            if (loaiPhong == null) return false;
            _DbContext.loaiPhongs.Update(loaiPhong);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
