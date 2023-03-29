using A_DAL.Context;
using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL
{
    public class Program
    {
        static void TaoDatabase()
        {
            using var dbcontext = new NhaNghiDbContext();

            // dbName là tên của db gọi ra bằng phương thức trong dbcontext
            string dbName = dbcontext.Database.GetDbConnection().Database;
            //Console.WriteLine(dbName);

            // Phương thức tạo ra db trong SQLserver
            var kq = dbcontext.Database.EnsureCreated();

            if (kq)
            {
                Console.WriteLine($"Tao db {dbName} thanh cong!");
            }
            else
            {
                Console.WriteLine($"Tao db {dbName} that bai!");
            }
            
        }

        static void XoaDatabase()
        {
            using var dbcontext = new NhaNghiDbContext();

            // dbName là tên của db gọi ra bằng phương thức trong dbcontext
            string dbName = dbcontext.Database.GetDbConnection().Database;
            //Console.WriteLine(dbName);

            // Phương thức tạo ra db trong SQLserver
            var kq = dbcontext.Database.EnsureDeleted();

            if (kq)
            {
                Console.WriteLine($"Xoa db {dbName} thanh cong!");
            }
            else
            {
                Console.WriteLine($"Xoa db {dbName} that bai!");
            }

        }

        static void ThemDichVu()
        {
            using var dbcontext = new NhaNghiDbContext();

            // Them 1 hang dich vu
                //var dv1 = new DichVu();
                //dv1.id = Guid.NewGuid();
                //dv1.tenDV = "Cola";
                //dv1.giaDV = 12000;
                //dbcontext.Add(dv1);

            //Them 1 mang dichvus
            var arrDichVus = new Object[]
            {
                new DichVu(){Ten = "Pepsi", Gia = 12000},
                new DichVu(){Ten = "Aqua", Gia = 7000},
                new DichVu(){Ten = "DoctorThanh", Gia = 10000},
            };
            dbcontext.AddRange(arrDichVus);

            int soHang = dbcontext.SaveChanges();
            Console.WriteLine($"Da them {soHang} hang du lieu!");
        }


        static void DocDichVu()
        {
            using var dbcontext = new NhaNghiDbContext();
            var dichVus = dbcontext.dichVus.ToList();
            dichVus.ForEach(x => x.InRaManHinh());
        }
        static void SuaTenDichVu(Guid id, string newTenDichVu)
        {
            using var dbcontext = new NhaNghiDbContext();
            DichVu? dichVu = (from dv in dbcontext.dichVus
                             where dv.IdDichVu == id
                             select dv).FirstOrDefault();
            if (dichVu != null) 
            { 
                // Entry tach dichvu ra khoi dbcontext, khi sua dichvu se khong duoc
                // sua tren db nua soHang = 0
                EntityEntry<DichVu> entry = dbcontext.Entry(dichVu);
                entry.State= EntityState.Detached;
                
                dichVu.Ten = newTenDichVu;
                int soHang = dbcontext.SaveChanges();
                Console.WriteLine($"Da cap nhat {soHang} hang du lieu!");
            }
        }

        static void XoaDichVu(Guid id)
        {
            using var dbcontext = new NhaNghiDbContext();
            DichVu? dichVu = (from dv in dbcontext.dichVus
                              where dv.IdDichVu == id
                              select dv).FirstOrDefault();
            if (dichVu != null)
            { 
                dbcontext.Remove(dichVu);
                int soHang = dbcontext.SaveChanges();
                Console.WriteLine($"Da xoa {soHang} hang du lieu!");
            }
        }

        static Guid LayIDDichVuDauTien()
        {
            using var dbcontext = new NhaNghiDbContext();
            return (dbcontext.dichVus.OrderBy(dv => dv.Ten).FirstOrDefault()??new DichVu()).IdDichVu;
        }

        static void Main(string[] args)
        {
            //TaoDatabase();
            //XoaDatabase();
            //ThemDichVu();
            //DocDichVu();
            //SuaTenDichVu(LayIDDichVuDauTien(), "Aqua 1");
            //XoaDichVu(LayIDDichVuDauTien());

            //Logging
            //DocDichVu();

            /* DichVu co trong nhieu phieu dich vu
             *  goi var e = dbcontext.Entry(dichVu)
             *      e.Collection( c => c.ChiTietPhieuDichVus).Load();
             *  thi luc nay DichVu.ChiTietPhieuDichDus moi duoc truy xuat tu db
             * 
             * ChiTietPhieuDichDu chi co dich vu
             *  goi var e = dbcontext.Entry(chiTietPhieuDichDu)
             *      e.Reference( c => c.DichVu).Load();
             *  thi luc nay ChiTietPhieuDichDu.DichVu moi duoc truy xuat tu db
             * 
            */
            //XoaDatabase();
            //TaoDatabase();
        }
    }
}
