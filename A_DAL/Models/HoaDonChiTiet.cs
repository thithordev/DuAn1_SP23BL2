using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class HoaDonChiTiet
    {
        [Key]
        public Guid IdHoaDon { get; set; }
        [Key]
        public Guid IdDatPhong { get; set; }
        public long PhiPhong { get; set; }

        public virtual HoaDon HoaDon { get; set; }
        public virtual DatPhong DatPhong { get; set; }

    }
}
