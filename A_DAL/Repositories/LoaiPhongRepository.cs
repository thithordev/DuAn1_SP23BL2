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
        public bool Add(LoaiPhong obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.loaiPhongs.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiPhong obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.Remove(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public List<LoaiPhong> GetAll()
        {
            try
            {
                return DataProvider.Ins.dbContext.loaiPhongs.ToList();
            }
            catch (Exception)
            {

                return new List<LoaiPhong>();
            }
        }

        public LoaiPhong GetByID(Guid id)
        {
            if (id == Guid.Empty) return new LoaiPhong();
            return DataProvider.Ins.dbContext.loaiPhongs.FirstOrDefault(c => c.IdLoaiPhong == id) ?? new LoaiPhong();
        }

        public bool Update(LoaiPhong obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.loaiPhongs.Update(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }
    }
}
