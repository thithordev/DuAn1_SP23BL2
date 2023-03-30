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
        public bool Add(ThongKeDoanhThu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.thongKeDoanhThus.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ThongKeDoanhThu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<ThongKeDoanhThu> GetAll()
        {
            return DataProvider.Ins.dbContext.thongKeDoanhThus.ToList();
        }

        public ThongKeDoanhThu GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.thongKeDoanhThus.FirstOrDefault(c => c.IDThongKeDoanhThu == id) ?? new ThongKeDoanhThu();
        }

        public bool Update(ThongKeDoanhThu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.thongKeDoanhThus.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
