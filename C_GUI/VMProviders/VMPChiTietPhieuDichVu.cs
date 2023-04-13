using B_BUS.DataProviders;
using B_BUS.Services;
using B_BUS.ViewModels;
using System.Net.WebSockets;

namespace C_GUI.VMProviders
{
    public class VMPChiTietPhieuDichVu
    {
        private static VMPChiTietPhieuDichVu? _ins;
        public static VMPChiTietPhieuDichVu Ins
        {
            get { if (_ins == null) _ins = new VMPChiTietPhieuDichVu(); return _ins; }
            set { _ins = value; }
        }
        private List<ChiTietPhieuDichVuViewModel> _basectPhieuDichVu;
        public List<ChiTietPhieuDichVuViewModel> BasectPhieuDichVu { get => _basectPhieuDichVu; set => _basectPhieuDichVu = value; }
        public ChiTietPhieuDichVuService service { get; set; }
        public ChiTietPhieuDichVuViewModel VM { get; set; }
        public VMPChiTietPhieuDichVu()
        {
            service = new ChiTietPhieuDichVuService();
            VM = new ChiTietPhieuDichVuViewModel();
            _basectPhieuDichVu = new List<ChiTietPhieuDichVuViewModel>();
        }

        public void GetbasectPhieuDichVu(PhieuDichVuViewModel pDVVM)
        {
            _basectPhieuDichVu = new List<ChiTietPhieuDichVuViewModel>();
            Guid idpDV = pDVVM.Id;
            List<DichVuViewModel> lstDV = DichVuDataProvider.Ins.repository.GetAll()
                .Where(x => x.TrangThai == true).OrderBy(x => x.Ten)
                .ToList().ConvertAll(x => DichVuDataProvider.Ins.convertToVM(x));
                //(VMPDichVu.Ins.service.GetAll() ?? new List<DichVuViewModel>())
                //.Where(x => x.TrangThai == true).OrderBy(x => x.Ten).ToList();
            int countDV = lstDV.Count;
            if(countDV > 0)
            {
                for (int i = 0; i < countDV; i++)
                {
                    VM = new ChiTietPhieuDichVuViewModel() { PhieuDichVuID = idpDV, DichVuID = lstDV[i].Id, SoLuong = 0, DonGia = lstDV[i].Gia, DichVuVM = lstDV[i], PhieuDichVuVM = pDVVM };
                    _basectPhieuDichVu.Add(VM);
                }
            }
            else
            {
                _basectPhieuDichVu = new List<ChiTietPhieuDichVuViewModel>();
            }
        }

        public void AddbasectPhieuDichVu(PhieuDichVuViewModel pDDVM)
        {
            Guid idpDV = pDDVM.Id;
            //List<ChiTietPhieuDichVuViewModel> lstctPDV = (service.GetAll() ?? new List<ChiTietPhieuDichVuViewModel>()).Where(x => x.PhieuDichVuID == idpDV).ToList();
            List<ChiTietPhieuDichVuViewModel> lstctPDV =
                ChiTietPhieuDichVuDataProvider.Ins.repository.GetAll().Where(x => x.PhieuDichVuID == idpDV)
                .ToList().ConvertAll(x => ChiTietPhieuDichVuDataProvider.Ins.convertToVM(x));
            lstctPDV.ForEach(x => x.DichVuVM = DichVuDataProvider.Ins.service.GetByID(x.DichVuID ?? Guid.Empty));
                //(service.GetAll() ?? new List<ChiTietPhieuDichVuViewModel>()).Where(x => x.PhieuDichVuID == idpDV).ToList();
            int countDV = lstctPDV.Count;
            int countBase = _basectPhieuDichVu.Count;
            if(countBase > 0)
            {
                if(countDV > 0)
                {
                    for (int i = 0; i < countBase; i++)
                    {
                        var ctpDV = lstctPDV.Where( x => x.DichVuID == _basectPhieuDichVu[i].DichVuID && x.DonGia == _basectPhieuDichVu[i].DonGia ).FirstOrDefault();
                        if (ctpDV != null)
                        {
                            var oldSL = _basectPhieuDichVu[i].SoLuong;
                            _basectPhieuDichVu[i] = ctpDV;
                            _basectPhieuDichVu[i].SoLuong += oldSL;
                            lstctPDV.Remove(ctpDV);
                        }
                    }

                    if(lstctPDV.Count > 0)
                    {
                        _basectPhieuDichVu.AddRange(lstctPDV);
                    }
                }
            }
            else
            {
                if(countDV > 0)
                {
                    _basectPhieuDichVu.AddRange(lstctPDV);
                }
            }
        }

        public void AddlstbasectPhieuDichVu(List<PhieuDichVuViewModel> lstPDV)
        {
            int countPDV = lstPDV.Count;
            for (int i = 0; i < countPDV; i++)
            {
                AddbasectPhieuDichVu(lstPDV[i]);
            }
        }

        public void UpdatebasePhieuDichVu()
        {
            int countBase = _basectPhieuDichVu.Count;
            if(countBase > 0)
            {
                for (int i = 0; i < countBase; i++)
                {

                    if(_basectPhieuDichVu[i].Id == Guid.Empty && (_basectPhieuDichVu[i].SoLuong == 0 || _basectPhieuDichVu[i].SoLuong == null))
                    {

                    }

                    // Add
                    if (_basectPhieuDichVu[i].Id == Guid.Empty && !(_basectPhieuDichVu[i].SoLuong == 0 || _basectPhieuDichVu[i].SoLuong == null))
                    {
                        service.Add(_basectPhieuDichVu[i]);
                    }

                    // Delete
                    if (_basectPhieuDichVu[i].Id != Guid.Empty && (_basectPhieuDichVu[i].SoLuong == 0 || _basectPhieuDichVu[i].SoLuong == null))
                    {
                        service.Delete(_basectPhieuDichVu[i].Id);
                    }

                    // Update
                    if (_basectPhieuDichVu[i].Id != Guid.Empty && !(_basectPhieuDichVu[i].SoLuong == 0 || _basectPhieuDichVu[i].SoLuong == null))
                    {
                        service.Update(_basectPhieuDichVu[i]);
                    }
                }
            }
        }
    }
}
