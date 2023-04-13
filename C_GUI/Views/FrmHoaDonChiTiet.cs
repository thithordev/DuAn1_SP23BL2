using B_BUS.DataProviders;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
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
    public partial class FrmHoaDonChiTiet : Form
    {
        public FrmHoaDonChiTiet(HoaDonViewModel hoaDonViewModel)
        {
            InitializeComponent();
            Cbb_all();
            var obj = bindingSource1.Current as HoaDonViewModel;
            hoaDonViewModelBindingSource.DataSource = hoaDonViewModel;
            //lb_nhanvien.Text = obj.TenDayDu_NV;
        }

        private void Cbb_all()
        {
            cbb_Trangthai.Items.Clear();
            cbb_Trangthai.Items.Add("Đã thanh toán");
            cbb_Trangthai.Items.Add("Chờ thanh toán");
            cbb_Trangthai.Items.Add("Hủy");

            cbb_tenkh.DataSource = KhachHangDataProvider.Ins.service.GetAll();
            cbb_tenkh.DisplayMember = "Ten";
        }

        private void SuaHoaDon()
        {
            var obj = bindingSource1.Current as HoaDonViewModel;
            var kh = cbb_tenkh.SelectedItem as KhachHangViewModel;

            obj.KhachHangId = kh.Id;
            obj.NhanVienId = VMPNhanVien.Ins.NhanVienLogin.Id;
            obj.TrangThai = cbb_Trangthai.Text == "Hủy" ? 0 : cbb_Trangthai.Text == "Chờ thanh toán" ? 1 : 2;
            obj.NgayTao = dtpk_bd.Value;
            obj.NgayThanhToan = dtpk_kt.Value;

            DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //update database
            if (result == DialogResult.OK)
            {
                HoaDonDataProvider.Ins.service.Update(obj);
            }
        }

        private void TinhGioAndTongTienPhong()
        {
            
        }


    }
}
