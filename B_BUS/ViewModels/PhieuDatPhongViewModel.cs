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
    public class PhieuDatPhongViewModel : BaseVM
    {
        public Guid? KhachHangId { get; set; }
        public Guid? HoaDonId { get; set; }
        public Guid? NhanVienId { get; set; }
        public Guid? PhongId { get; set; }
        public DateTime? NgayTao { get; set; }
        private DateTime? _NgayDat;
        public DateTime? NgayDat { get => _NgayDat; set { _NgayDat = value; OnPropertyChanged(); } }
        private DateTime? _NgayNhan;
        public DateTime? NgayNhan { get => _NgayNhan; set { _NgayNhan = value; OnPropertyChanged(); } }
        public DateTime? NgayDatTra { get; set; }
        public DateTime? NgayTra { get; set; }
        public int? KieuDat { get; set; }
        private decimal? _PhiPhong = 0;
        public decimal? PhiPhong { get => _PhiPhong; set { _PhiPhong = value; OnPropertyChanged(); } }
        public int? TrangThai { get; set; }

        /*
         * 0 : Hủy
         * 1 : hoạt động
         * 2 : hoàn thành chờ tạo hóa đơn
         * 3 : Đã tạo hóa đơn
         */
        public string? GhiChu { get; set; }

        private PhongViewModel? _PhongVM;
        public PhongViewModel? PhongVM { get => _PhongVM; set { 
                _PhongVM = value;
                if(_PhongVM != null)
                {
                    var ngaydattra = NgayDatTra;
                    var ngaytra = NgayDat;
                    if (ngaytra != null && ngaydattra != null)
                    {
                        var loaiphong = _PhongVM.loaiPhongViewModel;
                        if (loaiphong != null)
                        {
                            if (KieuDat == null || KieuDat == 0)
                            {
                                int timesp = ngaydattra.Value.Hour - ngaytra.Value.Hour;
                                PhiPhong = timesp * loaiphong.GiaGio;
                            }
                            else if (KieuDat == 1)
                            {
                                int timesp = ngaydattra.Value.Day - ngaytra.Value.Day;
                                PhiPhong = timesp * loaiphong.GiaNgay;
                            }
                            else
                            {
                                int timesp = ngaydattra.Value.Day - ngaytra.Value.Day;
                                PhiPhong = timesp * loaiphong.GiaDem;
                            }
                        }
                    }
                }
                OnPropertyChanged();
            } }
        public string TenPhong { get { return PhongVM == null ? "Unknown" : PhongVM.Ten ?? ""; } }

        public virtual NhanVienViewModel? NhanVienVM { get; set; }
        public string HoTenNhanVien { get { return NhanVienVM == null ? "Unknown" : NhanVienVM.HotenNV ?? ""; } }

        public virtual KhachHangViewModel? KhachHangVM { get; set; }
        public string HoTenKhach { get { return KhachHangVM == null ? "Unknown" : KhachHangVM.HoTenKhach ?? ""; } }

        public virtual HoaDonViewModel? HoaDonVM { get; set; }


        public virtual List<PhieuDichVuViewModel>? PhieuDichVusVM { get; set; }


        public string status { get { return string.Format("{0} - {1} - {2} - {3}", TenPhong, HoTenKhach, NgayNhan, NgayTra); } }

        public string strGioDat
        {
            get { return (NgayDat ?? DateTime.Today).ToString("HH:mm"); }
        }

        public string strGioDatTra
        {
            get
            {
                return (NgayDatTra ?? DateTime.Today).ToString("HH:mm");
            }

        }

        public string? StrPhiPhong { get { return string.Format("{0:C0}", PhiPhong); } }
    }
}