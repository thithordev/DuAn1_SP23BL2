using A_DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class PhieuDatPhongViewModel : BaseVM
    {
        public Guid? KhachHangId { get; set; }
        public Guid? HoaDonId { get; set; }
        public Guid? NhanVienId { get; set; }
        public Guid? PhongId { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayDat { get; set; }
        public DateTime? NgayNhan { get; set; }
        public DateTime? NgayDatTra { get; set; }
        public DateTime? NgayTra { get; set; }
        public decimal? PhiCuoc { get; set; }
        public decimal? PhiPhong { get; set; }
        public int? TrangThai { get; set; }

        /*
         * 0 : Hủy
         * 1 : hoạt động
         * 2 : hoàn thành chờ tạo hóa đơn
         * 3 : Đã tạo hóa đơn
         */
        public string? GhiChu { get; set; }


        public virtual Phong? Phong { get; set; }
        public string TenPhong { get { return Phong == null ? "" : Phong.Ten ?? ""; } }

        public virtual NhanVien? NhanVien { get; set; }


        public virtual KhachHang? KhachHang { get; set; }
        public string TenKhach { get { return KhachHang == null ? "" : KhachHang.Ten ?? ""; } }

        public virtual HoaDon? HoaDon { get; set; }


        public virtual List<PhieuDichVu>? PhieuDichVus { get; set; }


        public string status { get { return string.Format("{0} - {1} - {2} - {3}", TenPhong, TenKhach, NgayNhan, NgayTra); } }
    }
}