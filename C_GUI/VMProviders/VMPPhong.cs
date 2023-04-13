using B_BUS.DataProviders;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GUI.VMProviders
{
    public class VMPPhong : BaseVMP
    {
        private static VMPPhong? _ins;
        public static VMPPhong Ins
        {
            get { if (_ins == null) _ins = new VMPPhong(); return _ins; }
            set { _ins = value; }
        }
        public List<PhongViewModel> Phongs { get; set; }

        private int _oldChecked = 0;

        private int _indexChecked = 1;
        public int indexChecked { get => _indexChecked; 
            set { _oldChecked = _indexChecked; _indexChecked = value; OnPropertyChanged(); } }

        private uc_Phong? ucPhong;
        public List<uc_Phong> ucPhongs { get; set; }

        private ObservableCollection<PhongViewModel> _phongsChecked;
        public ObservableCollection<PhongViewModel> phongsChecked { get => _phongsChecked; set => _phongsChecked = value; }

        public PhongService service { get; set; }
        public PhongViewModel VM { get; set; }

        public VMPPhong()
        {
            service = new PhongService();
            VM = new PhongViewModel();
            Phongs = new List<PhongViewModel>();
            _phongsChecked = new ObservableCollection<PhongViewModel> ();
            ucPhongs = new List<uc_Phong>();
        }

        public void Method_Phongs()
        {
            // Lấy danh sách phòng

            Phongs = PhongDataProvider.Ins.repository.GetAll()
                .OrderBy(x => x.Tang)
                .ToList()
                .ConvertAll(p => PhongDataProvider.Ins.convertToVM(p));
        }

        public void Method_PhongsFULL()
        {
            // Lấy danh sách phòng

            VMPPhong.Ins.Method_Phongs();

            // Lấy danh sách phiếu đặt phòng có trạng thái == 1

            VMPPhieuDatPhong.Ins.Method_PhieudatphongsTrangThai1();

            // Lấy danh sách loại phòng

            VMPLoaiPhong.Ins.Method_LoaiPhongs();

            int count = Phongs.Count();
            for (int i = 0; i < count; i++)
            {
                Phongs[i].PhieuDatPhongViewModels = VMPPhieuDatPhong.Ins.PhieudatphongsTrangThai1.Where(x => x.PhongId == Phongs[i].Id).ToList();
                Phongs[i].loaiPhongViewModel = VMPLoaiPhong.Ins.LoaiPhongs.FirstOrDefault(x => x.Id == Phongs[i].LoaiPhongId);
            }

        }


        public void Method_ucPhongs()
        {
            ucPhongs.Clear();
            int count = Phongs.Count;
            for (int i = 0; i < count; i++)
            {
                ucPhong = new uc_Phong(i);
                ucPhongs.Add(ucPhong);
            }
        }

        public void Method_ucPhongsClick()
        {
            ucPhongs[_oldChecked].btnChecked_Click(null,null);
        }

        public void Method_VM()
        {
            try
            {
                VM = Phongs[indexChecked];
            }
            catch (Exception)
            {

            }
        }
    }
}
