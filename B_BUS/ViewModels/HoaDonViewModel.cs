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
        public DateTime? NgayTao { get; set ; }
        public int? TrangThai { get; set; }
        // 0 : hủy
        // 1 : chờ thanh toán
        // 2 : đã thanh toán
        public DateTime? NgayThanhToan { get; set; }
        public decimal? TongTien { get; set; }
        public int? PhuongThucThanhToan { get; set; }
        public string? GhiChu { get; set; }


        //
        public KhachHangViewModel? KhachHangVM { get; set; }
        public NhanVienViewModel? nhanVienVM { get; set; }
        public string? SDT { get { return KhachHangVM == null ? null : KhachHangVM.SDT; } }
        public string? TenDayDu { get { return KhachHangVM == null ? null : KhachHangVM.Ten; } }
        public string? CMNDD { get { return KhachHangVM == null ? null : KhachHangVM.CCCD; } }
        public string? TenNV { get { return nhanVienVM == null ? null : nhanVienVM.Ten; } }
        public string? TrangThai1 { get { return TrangThai == 0 ? "Hủy" : TrangThai == 1 ? "Chưa thanh toán" : "Đã thanh toán"; } }



    }
}
