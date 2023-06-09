﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("NhanVien")]
    public class NhanVien : BaseModel
    {
        public Guid? ChucVuId { get; set; }
        public string? TenDem { get; set; }
        public string? Ten { get; set; }
        public string? CCCD { get; set; }
        public string? SDT { get; set; }
        public bool? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public int? TrangThai { get; set; }
        [Column(TypeName = "money")]
        public decimal? Luong { get; set; }
        public string? TenTaiKhoan { get; set; }
        public string? MatKhau { get; set; }
        [Column(TypeName = "ntext")]
        public string? GhiChu { get; set; }
        public virtual List<PhieuDatPhong>? PhieuDatPhongs { get; set; }
        public virtual List<HoaDon>? HoaDons { get; set; }
        public virtual List<PhieuDichVu>? PhieuDichVus { get; set; }
        public virtual List<YeuCau>? YeuCaus { get; set; }
        [ForeignKey("ChucVuId")]
        public virtual ChucVu? ChucVu { get; set; }

    }
}
