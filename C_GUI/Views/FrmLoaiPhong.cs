using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using Catel;

namespace C_GUI.Views
{
    public partial class FrmLoaiPhong : Form
    {
        ILoaiPhongService _loaiPhongService;
        public FrmLoaiPhong()
        {
            InitializeComponent();
            _loaiPhongService = new LoaiPhongService();
            loaiPhongViewModelBindingSource.DataSource = _loaiPhongService.GetAllActive();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = loaiPhongViewModelBindingSource.Current as LoaiPhongViewModel;
            if (obj == null) return;
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _loaiPhongService.Delete(obj.Id);
                loaiPhongViewModelBindingSource.RemoveCurrent();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (FrmAddorEditLoaiPhong frm = new FrmAddorEditLoaiPhong(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loaiPhongViewModelBindingSource.DataSource = _loaiPhongService.GetAllActive();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = loaiPhongViewModelBindingSource.Current as LoaiPhongViewModel;
            if (obj == null) return;
            using (FrmAddorEditLoaiPhong frm = new FrmAddorEditLoaiPhong(obj))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loaiPhongViewModelBindingSource.DataSource = _loaiPhongService.GetAllActive();
                }
            }
        }
    }
}
