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
        public int? TrangThai { get; set; }
        // 0 : hủy
        // 1 : chờ thanh toán
        // 2 : đã thanh toán
        public DateTime? NgayThanhToan { get { return DateTime.Now; } set { value = null; } }
        public decimal? TongTien { get; set; }
        public int? PhuongThucThanhToan { get; set; }
        public string? GhiChu { get; set; }

        //public virtual KhachHangViewModel? KhachHangVM { get; set; }
        //public virtual NhanVienViewModel? NhanVienVM { get; set; }

        public virtual KhachHangViewModel? KhachHangMV { get; set; }
        public virtual NhanVienViewModel? NhanVienMV { get; set; }
        public string? SDT { get { return KhachHangMV == null ? null : KhachHangMV.SDT; } }
        public string? CCCD { get { return KhachHangMV == null ? null : KhachHangMV.CCCD; } }
        public string? TenDayDu_KH { get { return KhachHangMV == null ? null : KhachHangMV.Ten; } }
        public string? TenDayDu_NV { get { return NhanVienMV == null ? null : NhanVienMV.Ten; } }
        public string? TrangThai1 { get { return TrangThai == 0 ? "Hủy" : TrangThai == 1 ? "Chờ thanh toán" : "Đã thanh toán"; } }
        public DateTime? NgayTao1 { get { return DateTime.Parse(NgayTao.Value.ToString("dd/MM/yyyy HH:mm:ss")); } }
        public DateTime? NgayThanhToan1 { get { return DateTime.Parse(NgayThanhToan.Value.ToString("dd/MM/yyyy HH:mm:ss")); } }
        public string? StrTongTien
        {
            get
            {
                return string.Format(
            System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", TongTien);
            }
        }

    }
}
