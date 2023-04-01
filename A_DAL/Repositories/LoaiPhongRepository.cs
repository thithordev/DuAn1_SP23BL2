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
            if(obj.Id != Guid.Empty) return false;
            DataProvider.Ins.dbContext.loaiPhongs.Add(obj);
            var count = DataProvider.Ins.dbContext.SaveChanges();
            if(count == 0) return false;
            return true;
        }

        public bool Delete(Guid id)
        {
            if (id == Guid.Empty) return false;
            LoaiPhong? objInDB = GetByID(id);
            if (objInDB == null) return false;
            return true;
        }

        public List<LoaiPhong>? GetAllActive()
        {
            try
            {
                var lst = DataProvider.Ins.dbContext.loaiPhongs.ToList();
                if (lst.Count == 0) return null;
                return lst;
            }
            catch (Exception)
            {

                return new List<LoaiPhong>();
            }
        }

        public List<LoaiPhong>? GetAll()
        {
            try
            {
                var lst = DataProvider.Ins.dbContext.loaiPhongs.ToList();
                if(lst.Count == 0) return null;
                return lst;
            }
            catch (Exception)
            {

                return new List<LoaiPhong>();
            }
        }

        public LoaiPhong? GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.loaiPhongs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(LoaiPhong obj)
        {
            return true;
        }
    }
}
