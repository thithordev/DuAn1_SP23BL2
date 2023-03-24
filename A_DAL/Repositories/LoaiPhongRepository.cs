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
        private NhaNghiDbContext _DbContext = new NhaNghiDbContext();
        public bool Add(LoaiPhong obj)
        {
            if (obj == null) return false;
            _DbContext.loaiPhongs.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiPhong obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
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

        public bool Update(LoaiPhong obj)
        {
            if (obj == null) return false;
            _DbContext.loaiPhongs.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
