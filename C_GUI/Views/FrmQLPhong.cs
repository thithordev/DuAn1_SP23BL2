using B_BUS.IServices;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
using System.Data;

namespace C_GUI.Views
{
    public partial class FrmQLPhong : Form
    {
        IPhongService _phongService;
        List<PhongViewModel> _phongViewModels;
        public FrmQLPhong()
        {
            InitializeComponent();
            _phongViewModels = new List<PhongViewModel>();
            _phongService = VMPPhong.Ins.service;
            LoadFrm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (FrmAddorEditQLPhong frm = new FrmAddorEditQLPhong(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadFrm();
                }
                else { LoadFrm(); }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = PhongViewModelBindingSource.Current as PhongViewModel;
            if (obj == null) return;
            using (FrmAddorEditQLPhong frm = new FrmAddorEditQLPhong(obj))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadFrm();
                }
                else { LoadFrm(); }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = PhongViewModelBindingSource.Current as PhongViewModel;
            if (obj == null) return;
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _phongService.Delete(obj.Id);
                PhongViewModelBindingSource.RemoveCurrent();

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txbSearch.Text = string.Empty;
            LoadFrm();
        }

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var lst = _phongViewModels.Where(x => (x.Ten ?? string.Empty).Contains(txbSearch.Text));
                if (lst == null) return;
                if (lst.Any()) PhongViewModelBindingSource.DataSource = lst;
                else PhongViewModelBindingSource.DataSource = new List<PhongViewModel>();
            }
        }
        public void LoadFrm()
        {
            _phongViewModels = _phongService.GetAll() ?? new List<PhongViewModel>();
            _phongViewModels.ForEach(x => x.loaiPhongViewModel = VMPLoaiPhong.Ins.service.GetByID(x.LoaiPhongId ?? Guid.Empty));
            PhongViewModelBindingSource.DataSource = _phongViewModels;
        }
    }
}
