using A_DAL.Models;
using B_BUS.DataProviders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class LoaiPhongViewModel : BaseVM
    {
        public string? Ten { get; set; }
        public string? Mota { get; set; }
        public int? OToiDa { get; set; }
        public decimal GiaNgay { get; set; }
        public decimal GiaGio { get; set; }
        public decimal GiaDem { get; set; }

        public string StrGiaDem { get { return string.Format(
            System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", GiaDem); } }
        public string StrGiaNgay { get { return string.Format(
            System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", GiaNgay); } }
        public string StrGiaGio { get { return string.Format(
            System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", GiaGio); } }
    }
}
