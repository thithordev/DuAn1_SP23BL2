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
    public class ThongKeDoanhThuRepository : IThongKeDoanhThuRepository
    {
        private NhaNghiDbContext _DbContext = new NhaNghiDbContext();
        public bool Add(ThongKeDoanhThu obj)
        {
            if (obj == null) return false;
            _DbContext.thongKeDoanhThus.Add(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(ThongKeDoanhThu obj)
        {
            if (obj == null) return false;
            _DbContext.Remove(obj);
            _DbContext.SaveChanges();
            return true;
        }

        public List<ThongKeDoanhThu> GetAll()
        {
            return _DbContext.thongKeDoanhThus.ToList();
        }

        public ThongKeDoanhThu? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _DbContext.thongKeDoanhThus.FirstOrDefault(c => c.IDThongKeDoanhThu == id);
        }

        public bool Update(ThongKeDoanhThu obj)
        {
            if (obj == null) return false;
            _DbContext.thongKeDoanhThus.Update(obj);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
