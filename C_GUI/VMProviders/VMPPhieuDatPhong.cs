using B_BUS.DataProviders;
using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GUI.VMProviders
{
    public class VMPPhieuDatPhong : BaseVMP
    {
        private static VMPPhieuDatPhong? _ins;
        public static VMPPhieuDatPhong Ins
        {
            get { if (_ins == null) _ins = new VMPPhieuDatPhong(); return _ins; }
            set { _ins = value; }
        }

        public List<PhieuDatPhongViewModel> PhieuDatPhongs { get; set; }

        public List<PhieuDatPhongViewModel> PhieudatphongsTrangThai1 { get; set; }

        public PhieuDatPhongService service { get; set; }
        public PhieuDatPhongViewModel VM { get; set; }


        public List<PhieuDatPhongViewModel?> PhieuDatPhongsDangThue
        {
            get
            {
                return VMPPhong.Ins.Phongs.Where(x => x.intHienTrang == 1).Select(x => x.phieuDatPhongViewModel).ToList();
            }
        }
        public VMPPhieuDatPhong()
        {
            service = new PhieuDatPhongService();
            VM = new PhieuDatPhongViewModel();
            PhieuDatPhongs = new List<PhieuDatPhongViewModel>();
            PhieudatphongsTrangThai1 = new List<PhieuDatPhongViewModel>();
        }

        public void Method_PhieudatphongsTrangThai1()
        {
            // Lấy danh sách phiếu đặt phòng có trạng thái == 1

            PhieudatphongsTrangThai1 = PhieuDatPhongDataProvider.Ins.repository.GetAll()
                .Where(x => x.TrangThai == 1).OrderBy(x => x.NgayDat)
                .ToList()
                .ConvertAll(p => PhieuDatPhongDataProvider.Ins.convertToVM(p));
        }

        public void Method_VMFULL(Guid? KhachHangId, Guid? HoaDonId, Guid? NhanVienId, Guid? PhongId)
        {
            if(KhachHangId != null)
            {
                VM.KhachHangVM = KhachHangDataProvider.Ins.service.GetByID(KhachHangId??Guid.Empty);
            }

            if (HoaDonId != null)
            {
                VM.HoaDonVM = HoaDonDataProvider.Ins.service.GetByID(HoaDonId ?? Guid.Empty);
            }

            if (NhanVienId != null)
            {
                VM.NhanVienVM = NhanVienDataProvider.Ins.service.GetByID(NhanVienId?? Guid.Empty);
            }

            if (PhongId != null)
            {
                VM.PhongVM = PhongDataProvider.Ins.service.GetByID(PhongId?? Guid.Empty);
            }

        }
    }
}
