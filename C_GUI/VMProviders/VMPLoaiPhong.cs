using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GUI.VMProviders
{
    public class VMPLoaiPhong : BaseVMP
    {
        private static VMPLoaiPhong? _ins;
        public static VMPLoaiPhong Ins
        {
            get { if (_ins == null) _ins = new VMPLoaiPhong(); return _ins; }
            set { _ins = value; }
        }

        private List<LoaiPhongViewModel> _loaiphongs;
        public List<LoaiPhongViewModel> LoaiPhongs { get => _loaiphongs; set => _loaiphongs = value; }

        public LoaiPhongService service { get; set; }
        public LoaiPhongViewModel VM { get; set; }

        public VMPLoaiPhong()
        {
            service = new LoaiPhongService();
            VM = new LoaiPhongViewModel() { Ten = "Tất Cả"};
            _loaiphongs = service.GetAllActive() ?? new List<LoaiPhongViewModel>();
            _loaiphongs.Add(VM);
        }
    }
}
