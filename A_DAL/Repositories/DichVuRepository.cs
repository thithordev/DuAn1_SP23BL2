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
    public class DichVuRepository : IDichVuRepository
    {
        NhaNghiDbContext db;
        public DichVuRepository()
        {
            db = new NhaNghiDbContext();
        }
        public bool Add(DichVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.dichVus.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(DichVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<DichVu> GetAll()
        {
            return DataProvider.Ins.dbContext.dichVus.ToList();
        }

        public DichVu GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.dichVus.FirstOrDefault(c => c.IdDichVu == id) ?? new DichVu();
        }

        public bool Update(DichVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.dichVus.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
