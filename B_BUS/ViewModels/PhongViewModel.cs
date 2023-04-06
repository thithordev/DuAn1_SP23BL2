using B_BUS.DataProviders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.ViewModels
{
    public class PhongViewModel : BaseVM
    {
        public Guid? LoaiPhongId { get; set; }
        public string? Ten { get; set; }
        private int? _TrangThai;
        public int? TrangThai { get => _TrangThai; set { _TrangThai = value; PhongDataProvider.Ins.service.Update(this); OnPropertyChanged(); } }
        public int? Tang { get; set; }
        public string? GhiChu { get; set; }


        public LoaiPhongViewModel? LoaiPhongViewModel { get; set; } = null;

        public List<PhieuDatPhongViewModel>? PhieuDatPhongViewModels { get; set; }

        public PhieuDatPhongViewModel? phieuDatPhongViewModel { get => (PhieuDatPhongViewModels == null) ? null : PhieuDatPhongViewModels[0]; }

        //private string? _status;
        //public string? status { get => _status; set { _status = value; OnPropertyChanged(); } }


        //Conf
        public NhanVienViewModel? curNhanVien { get; set; }

        private DateTime _realTime = DateTime.Now;
        public DateTime realTime
        {
            set
            {
                _realTime = value;

                ChangeHienTrang();
            }
        }
        void ChangeHienTrang()
        {
            if (phieuDatPhongViewModel == null) { intHienTrang = 0; status = string.Empty; return; }

            if ((phieuDatPhongViewModel.TrangThai ?? 0) == 0) { intHienTrang = 0; status = string.Empty; return; }

            if (phieuDatPhongViewModel.NgayNhan == null)
            {
                if (_realTime < phieuDatPhongViewModel.NgayDat)
                {
                    intHienTrang = 0;
                    TimeSpan sp = (phieuDatPhongViewModel.NgayDat ?? DateTime.MaxValue) - _realTime;
                    status = string.Format("{0} ngày và {1} giờ", sp.Days, sp.Hours);
                    return;
                }

                if (_realTime >= phieuDatPhongViewModel.NgayDat && _realTime <= phieuDatPhongViewModel.NgayDatTra)
                {
                    intHienTrang = 2;
                    TimeSpan sp = (phieuDatPhongViewModel.NgayDatTra ?? DateTime.MaxValue) - _realTime;
                    status = string.Format("{0} ngày và {1} giờ", sp.Days, sp.Hours);
                    return;
                }

                // Quá hạn đặt --> Tự hủy phiếu
                if (_realTime > phieuDatPhongViewModel.NgayDatTra)
                {
                    intHienTrang = 0;
                    phieuDatPhongViewModel.TrangThai = 0;
                    PhieuDatPhongDataProvider.Ins.service.Update(phieuDatPhongViewModel);

                    PhongDataProvider.Ins.service.GetLstPhieuDatPhong(this);
                    return;
                }

            }
            else
            {
                if (_realTime < phieuDatPhongViewModel.NgayNhan)
                {
                    intHienTrang = 0;
                    TimeSpan sp = (phieuDatPhongViewModel.NgayNhan ?? DateTime.MaxValue) - _realTime;
                    status = string.Format("{0} ngày và {1} giờ", sp.Days, sp.Hours);
                    return;
                }

                if (_realTime >= phieuDatPhongViewModel.NgayNhan && _realTime <= phieuDatPhongViewModel.NgayDatTra)
                {
                    intHienTrang = 1;
                    TimeSpan sp = (phieuDatPhongViewModel.NgayDatTra ?? DateTime.MaxValue) - _realTime;
                    status = string.Format("{0} ngày và {1} giờ", sp.Days, sp.Hours);
                    return;
                }

                if (_realTime > phieuDatPhongViewModel.NgayDatTra)
                {

                    intHienTrang = 1;
                    TimeSpan sp = _realTime - (phieuDatPhongViewModel.NgayDatTra ?? DateTime.MinValue) ;
                    status = string.Format("Ở quá {0} ngày và {1} giờ", sp.Days, sp.Hours);
                    return;
                }

                if (_realTime > phieuDatPhongViewModel.NgayTra)
                {

                    intHienTrang = 0;
                    TrangThai = 0;

                    // Tạo Hóa Đơn
                    //var newHoaDonVM = new HoaDonViewModel() { KhachHangId = phieuDatPhongViewModel.KhachHangId,}
                    //HoaDonDataProvider.Ins.service.Add()

                    // Hoàn thành phiếu đặt
                    phieuDatPhongViewModel.TrangThai = 2;
                    PhieuDatPhongDataProvider.Ins.service.Update(phieuDatPhongViewModel);

                    PhongDataProvider.Ins.service.GetLstPhieuDatPhong(this);
                    return;
                }
            }

        }
        public int intHienTrang { get; set; } = 0;
        public string status { get; set; } = string.Empty;


        public string strTrangThai
        {
            get
            {
                if (TrangThai == null) return "Chờ dọn dẹp";

                if (TrangThai == 0) return "Chờ dọn dẹp";
                if (TrangThai == 1) return "Đã dọn dẹp";
                return "Chờ dọn dẹp";
            }
        }

        public Color ucBackColor
        {
            get
            {
                if (TrangThai == null) return Color.FromArgb(149, 165, 166);

                if (TrangThai == 1)
                {

                    if (intHienTrang == 0) return Color.FromArgb(46, 204, 113);
                    if (intHienTrang == 1) return Color.FromArgb(52, 152, 219);
                    if (intHienTrang == 2) return Color.FromArgb(230, 126, 34);

                }
                return Color.FromArgb(149, 165, 166);
            }
        }

        public Color pnlBackColor
        {
            get
            {
                if (intHienTrang == 0) return Color.FromArgb(127, 140, 141);
                if (TrangThai == -1) return Color.FromArgb(127, 140, 141);
                if (TrangThai == 0) return Color.FromArgb(39, 174, 96);
                if (TrangThai == 1) return Color.FromArgb(41, 128, 185);
                if (TrangThai == 2) return Color.FromArgb(211, 84, 0);
                return Color.FromArgb(127, 140, 141);
            }
        }
    }
}
