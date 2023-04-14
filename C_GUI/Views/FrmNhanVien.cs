using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
using System.Windows.Controls;

namespace C_GUI.Views
{
    public partial class FrmNhanVien : Form
    {
        INhanVienService _nhanVienService;
        public FrmNhanVien()
        {
            InitializeComponent();
            _nhanVienService = VMPNhanVien.Ins.service;
            BindingSource1.DataSource = _nhanVienService.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (FrmAddorEditNhanVien frm = new FrmAddorEditNhanVien(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindingSource1.DataSource = _nhanVienService.GetAll();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = BindingSource1.Current as NhanVienViewModel;
            if (obj == null) return;
            using (FrmAddorEditNhanVien frm = new FrmAddorEditNhanVien(obj))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindingSource1.DataSource = _nhanVienService.GetAll();
                }
                else
                {
                    BindingSource1.DataSource = _nhanVienService.GetAll();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = BindingSource1.Current as NhanVienViewModel;
            if (obj == null) return;
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _nhanVienService.Delete(obj.Id);
                BindingSource1.RemoveCurrent();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            _nhanVienService = VMPNhanVien.Ins.service;
            BindingSource1.DataSource = _nhanVienService.GetAll();
        }

        private void txt_TimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var lst = _nhanVienService.GetAll()?.Where(x => (x.Ten ?? string.Empty).Contains(txt_TimKiem.Text));
                if (lst == null) return;
                if (lst.Any()) BindingSource1.DataSource = lst;
                else BindingSource1.DataSource = new List<NhanVienViewModel>();
            }
        }
    }
}
