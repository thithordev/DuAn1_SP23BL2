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
        public int? TrangThai { get => _TrangThai; set { _TrangThai = value; OnPropertyChanged(); } }
        public int? Tang { get; set; }
        public string? GhiChu { get; set; }

        public LoaiPhongViewModel? LoaiPhongViewModel { get; set; } = null;

        public List<PhieuDatPhongViewModel> PhieuDatPhongViewModels { get; set; } = new List<PhieuDatPhongViewModel>();

        //private string? _status;
        //public string? status { get => _status; set { _status = value; OnPropertyChanged(); } }
        public string? status { get; set; }
        //Conf
        private DateTime _fromTime = DateTime.Now;
        public DateTime fromTime
        {
            set
            {
                _fromTime = value;

                ChangeTrangThai();

                OnPropertyChanged();
            }
        }

        private DateTime _toTime = DateTime.MaxValue;

        public DateTime toTime
        {
            set
            {
                _toTime = value;

                ChangeTrangThai();

                OnPropertyChanged();
            }
        }

        void ChangeTrangThai()
        {
            PhieuDatPhongViewModel? obj = PhieuDatPhongViewModels?.OrderBy(x => x.NgayDat).FirstOrDefault();
            if (obj == null)
            {
                Random rd = new Random();
                string abc = rd.Next(1, 100).ToString();
                status = "abcd" + abc;
                TrangThai = 0;
            }
            else
            {

                DateTime ngayDat = obj.NgayDat ?? DateTime.MinValue;
                DateTime ngayNhan = obj.NgayNhan ?? DateTime.MinValue;
                DateTime ngayDatTra = obj.NgayDatTra ?? DateTime.MinValue;
                DateTime ngayTra = obj.NgayTra ?? DateTime.MinValue;
                if (_fromTime < ngayDat)
                {
                    if (_toTime < ngayDat)
                    {
                        TrangThai = 0;
                        TimeSpan sp = ngayDat - _fromTime;
                        status = string.Format("Trống {0} ngày, {1} giờ kể từ mốc tìm.", sp.Days, sp.Hours);
                    }
                    else
                    {
                        TrangThai = 0;

                    }
                }
                else
                {

                }
            }
        }
        public Color ucBackColor
        {
            get
            {
                if (TrangThai == -1) return Color.FromArgb(149, 165, 166);
                if (TrangThai == 0) return Color.FromArgb(46, 204, 113);
                if (TrangThai == 1) return Color.FromArgb(52, 152, 219);
                if (TrangThai == 2) return Color.FromArgb(230, 126, 34);
                return Color.FromArgb(149, 165, 166);
            }
        }

        public Color pnlBackColor
        {
            get
            {
                if (TrangThai == -1) return Color.FromArgb(127, 140, 141);
                if (TrangThai == 0) return Color.FromArgb(39, 174, 96);
                if (TrangThai == 1) return Color.FromArgb(41, 128, 185);
                if (TrangThai == 2) return Color.FromArgb(211, 84, 0);
                return Color.FromArgb(127, 140, 141);
            }
        }
    }
}
