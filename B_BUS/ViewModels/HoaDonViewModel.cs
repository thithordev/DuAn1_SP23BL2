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
    public class HoaDonViewModel : BaseVM
    {
        public Guid? KhachHangId { get; set; }
        public Guid? NhanVienId { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? TrangThai { get ; set ; }
        // 0 : hủy
        // 1 : chờ thanh toán
        // 2 : đã thanh toán
        public DateTime? NgayThanhToan { get; set ; }
        public decimal? TongTien { get; set; }
        public int? PhuongThucThanhToan { get; set; }
        public string? GhiChu { get; set; }

        //
        public virtual KhachHang? KhachHang { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
        public string? SDT { get { return KhachHang == null ? null : KhachHang.SDT; } }
        public string? TenDayDu_KH { get { return KhachHang == null ? null : KhachHang.Ten; } }
        public string? TenDayDu_NV { get { return NhanVien == null ? null : NhanVien.Ten; } }
        public string? TrangThai1 { get { return TrangThai == 0 ? "Hủy" : TrangThai == 1 ? "Chờ thanh toán" : "Đã thanh toán"; }}

    }
}
