using B_BUS.Services;
using B_BUS.ViewModels;
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
        private List<PhongViewModel> _phongsLoc;
        public List<PhongViewModel> PhongsLoc { get => _phongsLoc; set => _phongsLoc = value; }
        private List<PhongViewModel> _phongs;
        public List<PhongViewModel> Phongs { get => _phongs; set => _phongs = value; }

        private ObservableCollection<PhongViewModel> _phongsChecked;
        public ObservableCollection<PhongViewModel> phongsChecked { get => _phongsChecked; set => _phongsChecked = value; }

        public PhongService service { get; set; }
        public PhongViewModel VM { get; set; }

        public VMPPhong()
        {
            service = new PhongService();
            VM = new PhongViewModel();
            _phongs = new List<PhongViewModel>();
            _phongsLoc = new List<PhongViewModel>();
            _phongsChecked = new ObservableCollection<PhongViewModel> ();
        }
    }
}
