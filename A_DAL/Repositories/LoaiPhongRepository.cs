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
        NhaNghiDbContext db;
        public LoaiPhongRepository()
        {
            db = new NhaNghiDbContext();
        }
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
            var dt = db.loaiPhongs.FirstOrDefault(p => p.IdLoaiPhong == obj.IdLoaiPhong);
            db.loaiPhongs.Remove(obj);
            db.SaveChanges();
            return true;
        }

        public List<LoaiPhong> GetAll()
        {
            return DataProvider.Ins.dbContext.loaiPhongs.ToList();
        }

        public LoaiPhong GetByID(Guid id)
        {
            if (id == Guid.Empty) return null;
            return DataProvider.Ins.dbContext.loaiPhongs.FirstOrDefault(c => c.IdLoaiPhong == id) ?? new LoaiPhong();
        }

        public bool Update(LoaiPhong obj)
        {
            if (obj == null) return false;
            var dt = db.loaiPhongs.FirstOrDefault(p => p.IdLoaiPhong == obj.IdLoaiPhong);
            dt.Ten = obj.Ten;
            dt.SoGiuong = obj.SoGiuong;
            dt.GiaGio = obj.GiaGio;
            dt.GiaNgay = obj.GiaNgay;
            dt.Mota = obj.Mota;
            db.loaiPhongs.Update(dt);
            db.SaveChanges();
            return true;
        }
    }
}
