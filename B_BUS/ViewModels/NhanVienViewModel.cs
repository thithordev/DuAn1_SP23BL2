using A_DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class NhanVienViewModel : BaseVM
    {
        public Guid? ChucVuId { get; set; }
        public string? TenDem { get; set; }
        public string? Ten { get; set; }
        public string? CCCD { get; set; }
        public string? SDT { get; set; }
        public bool? GioiTinh { get; set; }
        /* 1 - Nữ
         * 2 - Nam
        */
        public string strGioiTinh
        {
            get
            {
                if (GioiTinh == null) return "Chọn giới tính";
                if (GioiTinh == true) return "Nữ";
                if (GioiTinh == false) return "Nam";
                return "Chọn giới tính";
            }
            set
            {
                if (value == "Chọn giới tính") GioiTinh = null;
                if (value == "Nữ") GioiTinh = true;
                if (value == "Nam") GioiTinh = false;

            }
        }
        
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public int? TrangThai { get; set; }
        /* 0 - Thử việc
         * 1 - Đang làm
         * 2 - Đã nghỉ việc
        */
        public string strTrangThai
        {
            get
            {
                if (TrangThai == 0) return "Thử việc";
                if (TrangThai == 1) return "Chính thức";
                if (TrangThai == 2) return "Đã nghỉ việc";
                return "Đã nghỉ việc";
            }
            set
            {
                if (value == "Đã nghỉ việc") TrangThai = 2;
                if (value == "Thử việc") TrangThai = 0;
                if (value == "Chính thức") TrangThai = 1;
                if (value == null) TrangThai = 2;
            }
        }
        public decimal? Luong { get; set; }
        public string? TenTaiKhoan { get; set; }
        public string? MatKhau { get; set; }
        public string? GhiChu { get; set; }

        public virtual ChucVuViewModel? chucVuViewModel { get; set; }

        public string? TenChucVu { get => chucVuViewModel?.Ten;}
        public string? QuyenTruyCap { get => chucVuViewModel?.QuyenTruyCap;}
        public string HotenNV { get { return string.Format("{0} {1}", TenDem, Ten); }  }
    }
}
