﻿using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class LoaiDoanhThuViewModel : BaseVM
    {
        public string? Ten { get; set; }
        public bool? Kieu { get; set; }
    }
}
