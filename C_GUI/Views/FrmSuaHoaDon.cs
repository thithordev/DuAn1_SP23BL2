using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
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
    public partial class FrmSuaHoaDon : Form
    {
        IHoaDonService _IHD;
        IKhachHangService _IKH;
        public FrmSuaHoaDon(HoaDonViewModel hoaDonViewModels)
        {
            InitializeComponent();
            _IHD = new HoaDonService();
            _IKH = new KhachHangService();
            Cbb_TrangThai();Cbb_KhachHang();
            BindingSource1.DataSource = hoaDonViewModels;
            khachHangViewModelBindingSource.DataSource = _IKH.GetAll();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cbb_TrangThai()
        {
            cbb_Trangthai.Items.Clear();
            cbb_Trangthai.Items.Add("Đã thanh toán");
            cbb_Trangthai.Items.Add("Chưa thanh toán");
            cbb_Trangthai.Items.Add("Hủy");
        }

        private void Cbb_KhachHang()
        {
            cbb_tenkh.Items.Clear();
            foreach (var x in _IKH.GetAll())
            {
                cbb_tenkh.Items.Add(x.Ten);
            }
        }

        private void SuaHoaDon()
        {
            var obj = BindingSource1.Current as HoaDonViewModel;
            //var idKh = 
            //var kh = _IKH.GetAll().FirstOrDefault(c=>c.Id == obj.);
            //obj.KhachHangId = kh.Id;
            //obj.NgayTao = DateTime.Parse(dtpk_bd.Text);
            //obj.NgayThanhToan = DateTime.Parse(dtpk_kt.Text);
            obj.TrangThai = cbb_Trangthai.Text == "Hủy" ? 0 : cbb_Trangthai.Text == "Chưa thanh toán" ? 1 : 2;

            DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //update database
            if (result == DialogResult.OK)
            {
                _IHD.Update(obj);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            SuaHoaDon();
        }

        private void khachHangViewModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
