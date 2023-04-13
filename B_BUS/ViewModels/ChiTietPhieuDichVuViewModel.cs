using A_DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class ChiTietPhieuDichVuViewModel : BaseVM
    {
        public Guid? PhieuDichVuID { get; set; }
        public Guid? DichVuID { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public virtual DichVuViewModel? DichVuVM { get; set; }
        public string? Ten_DichVuVM { get { return DichVuVM==null? "Unknown" : DichVuVM.Ten; } set {  } }
        //public decimal? Gia_DichVuVM { get { return DichVuVM == null ? null : DichVuVM.Gia; } set { } }
        //public bool? TrangThai_DichVuVM { get { return DichVuVM == null ? null : DichVuVM.TrangThai; } set { } }

        public virtual PhieuDichVuViewModel? PhieuDichVuVM { get; set; }
        //public DateTime? NgayTao_PhieuDichVuVM { get; set; }
        //public int? TrangThai_PhieuDichVuVM { get; set; }
        //public string? GhiChu_PhieuDichVuVM { get; set; }

        public string strDonGia { get { return string.Format("{0:C0}", DonGia); } }
        public string strThanhTien { get { return string.Format("{0:C0}", SoLuong*DonGia); } }

        public string strAddbtn { get => "+"; }
        public string strRemovebtn { get => "-"; }

    }
}
