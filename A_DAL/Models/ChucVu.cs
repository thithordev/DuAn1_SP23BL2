using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    internal class ChucVu
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public virtual List<NhanVien> NhanViens { get; set; }
    }
}
