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
    public class ThuChiKhacViewModel : BaseVM
    {
        public DateTime? NgayTao { get; set; }
        public bool isThu { get; set; }
        public string? NoiDung { get; set; }
        public decimal? SoTien { get; set; }
        public string? strTrangThai
        {
            get
            {
                if (isThu) return "Thu";
                if (!isThu) return "Chi";
                return "Chưa chọn";
            }
            set
            {
                if (value == "Thu")  isThu = true;
                if (value == "Chi")  isThu = false;
                if (value == string.Empty) isThu = false;
            }
        }
        public string? strSoTien
        {
            get
            {
                return string.Format(
            System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", SoTien);
            }
        }
    }
}
