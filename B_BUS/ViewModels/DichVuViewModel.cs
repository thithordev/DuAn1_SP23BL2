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

    public class DichVuViewModel : BaseVM
    {
        public string? Ten { get; set; }
        public decimal Gia { get; set; }
        public bool TrangThai { get; set; }
    }
}
