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
    public class LoaiDoanhThuRepository : ILoaiDoanhThuRepository
    {
        public bool Add(LoaiDoanhThu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.loaiDoanhThus.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiDoanhThu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<LoaiDoanhThu>? GetAll()
        {
            return DataProvider.Ins.dbContext.loaiDoanhThus.ToList();
        }

        public LoaiDoanhThu? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.loaiDoanhThus.FirstOrDefault(c => c.IDLoaiDoanhThu == id);
        }

        public bool Update(LoaiDoanhThu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.loaiDoanhThus.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
