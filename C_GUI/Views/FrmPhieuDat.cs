using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
using System.Windows.Controls;

namespace C_GUI.Views
{
    public partial class FrmPhieuDat : Form
    {
        IPhieuDatPhongService _Service;
        public FrmPhieuDat()
        {
            InitializeComponent();
            _Service = VMPPhieuDatPhong.Ins.service;
            BindingSource1.DataSource = _Service.GetAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = BindingSource1.Current as LoaiPhongViewModel;
            if (obj == null) return;
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Service.Delete(obj.Id);
                BindingSource1.RemoveCurrent();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (FrmAddorEditLoaiPhong frm = new FrmAddorEditLoaiPhong(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindingSource1.DataSource = _Service.GetAll();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = BindingSource1.Current as LoaiPhongViewModel;
            if (obj == null) return;
            using (FrmAddorEditLoaiPhong frm = new FrmAddorEditLoaiPhong(obj))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindingSource1.DataSource = _Service.GetAll();
                }
            }
        }

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var lst = _Service.GetAll()?.Where(x => (x.GhiChu ?? string.Empty).Contains(txbSearch.Text));
                if (lst == null) return;
                if (lst.Any()) BindingSource1.DataSource = lst;
                else BindingSource1.DataSource = new List<LoaiPhongViewModel>();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txbSearch.Text = string.Empty;
            BindingSource1.DataSource = _Service.GetAll();
        }
    }
}
