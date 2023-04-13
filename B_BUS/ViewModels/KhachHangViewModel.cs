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
    public class KhachHangViewModel : BaseVM
    {
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
        public string? GhiChu { get; set; }

        public string? HoTenKhach { get { return string.Format("{0} {1}", TenDem, Ten); } }

        //public string strGioiTinh
        //{
        //    get
        //    {
        //        if (GioiTinh) return "Nam";
        //        else return "Nữ";
        //    }
        //    set
        //    {
        //        if (value == "Nam") GioiTinh = true;
        //        else GioiTinh = false;
        //    }
        //}
    }
}
