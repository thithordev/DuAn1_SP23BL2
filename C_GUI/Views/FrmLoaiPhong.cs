using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
using Catel;
using System.Windows.Controls;

namespace C_GUI.Views
{
    public partial class FrmLoaiPhong : Form
    {
        ILoaiPhongService _loaiPhongService;
        public FrmLoaiPhong()
        {
            InitializeComponent();
            _loaiPhongService = VMPLoaiPhong.Ins.service;
            loaiPhongViewModelBindingSource.DataSource = _loaiPhongService.GetAll();
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
                    loaiPhongViewModelBindingSource.DataSource = _loaiPhongService.GetAll();
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
                    loaiPhongViewModelBindingSource.DataSource = _loaiPhongService.GetAll();
                }
            }
        }

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                var lst = _loaiPhongService.GetAll()?.Where(x => (x.Ten ?? string.Empty).Contains(txbSearch.Text));
                if (lst == null) return;
                if (lst.Any()) loaiPhongViewModelBindingSource.DataSource = lst;
                else loaiPhongViewModelBindingSource.DataSource = new List<LoaiPhongViewModel>();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txbSearch.Text = string.Empty;
            loaiPhongViewModelBindingSource.DataSource = _loaiPhongService.GetAll();
        }
    }
}
