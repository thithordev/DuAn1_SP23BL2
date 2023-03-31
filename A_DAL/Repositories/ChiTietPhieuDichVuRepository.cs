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
    public class ChiTietPhieuDichVuRepository : IChiTietPhieuDichVuRepository
    {
        NhaNghiDbContext db;
        public ChiTietPhieuDichVuRepository()
        {
            db = new NhaNghiDbContext();
        }
        public bool Add(ChiTietPhieuDichVu obj)
        {
            if (obj == null) return false;
            DataProvider.Ins.dbContext.chiTietPhieuDichVus.Add(obj);
            DataProvider.Ins.dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietPhieuDichVu obj)
        {
            if (obj == null) return false;
            var dt = db.chiTietPhieuDichVus.FirstOrDefault(p => p.IDChiTietPhieuDichVu == obj.IDChiTietPhieuDichVu);
            db.chiTietPhieuDichVus.Remove(obj);
            db.SaveChanges();
            return true;
        }

        public List<ChiTietPhieuDichVu> GetAll()
        {
            return DataProvider.Ins.dbContext.chiTietPhieuDichVus.ToList();
        }

        public ChiTietPhieuDichVu GetByID(Guid id)
        {
            if (id == Guid.Empty) return new ChiTietPhieuDichVu();
            return DataProvider.Ins.dbContext.chiTietPhieuDichVus.FirstOrDefault(c => c.IDChiTietPhieuDichVu == id) ?? new ChiTietPhieuDichVu();
        }

        public bool Update(ChiTietPhieuDichVu obj)
        {
            if (obj == null) return false;
            var dt = db.chiTietPhieuDichVus.FirstOrDefault(p => p.IDChiTietPhieuDichVu == obj.IDChiTietPhieuDichVu);
            dt.SoLuong = dt.SoLuong;
            dt.DonGia = dt.DonGia;
            db.chiTietPhieuDichVus.Update(dt);
            db.SaveChanges();
            return true;
        }
    }
}
