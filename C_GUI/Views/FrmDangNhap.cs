using B_BUS.IServices;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI.Views
{
    public partial class FrmDangNhap : Form
    {
        ItaiKhoanViewSevice _taiKhoan;
        public FrmDangNhap()
        {
            InitializeComponent();
            _taiKhoan = new DangNhapSevice();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var dt = (from x in _taiKhoan.GetAll()
                      where x.nhanViens.TenTaiKhoan == txtDangNhap.Text
                      select x).ToList();
            if (dt.Count > 0 && dt.FirstOrDefault().nhanViens.MatKhau == txtMatKhau.Text)
            {
               FrmTrangChu frmTrangChu = new FrmTrangChu();
                this.Hide();
                frmTrangChu.ShowDialog();
                this.Show();
            }
            else
            {
                lbThongBao.Text = "Sai tên đăng nhập hoặc mật khẩu";
            }
        }
    }
}
