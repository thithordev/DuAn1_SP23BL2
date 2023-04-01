﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_DAL.Models
{
    [Table("LoaiDoanhThu")]
    public class LoaiDoanhThu
    {
        [Key]
        public Guid IDLoaiDoanhThu { get;set; }
        public string? Ten { get;set; }
        public bool? Kieu { get;set; }
        public virtual List<ThongKeDoanhThu>? ThongKeDoanhThus { get; set; }
    }
}
