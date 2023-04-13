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
    public class VMPLoaiPhong : BaseVMP
    {
        private static VMPLoaiPhong? _ins;
        public static VMPLoaiPhong Ins
        {
            get { if (_ins == null) _ins = new VMPLoaiPhong(); return _ins; }
            set { _ins = value; }
        }

        public List<LoaiPhongViewModel> LoaiPhongs { get; set; }

        public LoaiPhongService service { get; set; }
        public LoaiPhongViewModel VM { get; set; }

        public VMPLoaiPhong()
        {
            service = new LoaiPhongService();
            VM = new LoaiPhongViewModel();
            LoaiPhongs = new List<LoaiPhongViewModel>();
        }

        public void Method_LoaiPhongs()
        {
            // Lấy danh sách loại phòng
            LoaiPhongs = LoaiPhongDataProvider.Ins.repository.GetAll()
                    .ToList()
                    .ConvertAll(p => LoaiPhongDataProvider.Ins.convertToVM(p));
        }
    }
}
