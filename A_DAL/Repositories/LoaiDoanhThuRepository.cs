using A_DAL.Context;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class LoaiDoanhThuRepository
    {
        private NhaNghiDbContext _DbContext = new NhaNghiDbContext();
        public bool Add(LoaiDoanhThu obj)
        {
            if (obj == null) return false;
            _DbContext.loaiDoanhThus.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiDoanhThu obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<LoaiDoanhThu> GetAll()
        {
            return _DbContext.loaiDoanhThus.ToList();
        }

        public LoaiDoanhThu? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.loaiDoanhThus.FirstOrDefault(c => c.IDLoaiDoanhThu == id);
        }

        public bool Update(LoaiDoanhThu obj)
        {
            if (obj == null) return false;
            _DbContext.loaiDoanhThus.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
