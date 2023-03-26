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
    public class HoaDonRepository:IHoaDonRepository
    {
        private NhaNghiDbContext _DbContext = new NhaNghiDbContext();
        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
            _DbContext.hoaDons.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _DbContext.hoaDons.ToList();
        }

        public HoaDon? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.hoaDons.FirstOrDefault(c => c.IdHoaDon == id);
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            _DbContext.hoaDons.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
