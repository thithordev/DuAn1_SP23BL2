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
            hoaDonViewModelBindingSource.DataSource = hoaDonViewModel;
            var obj = hoaDonViewModelBindingSource.Current as HoaDonViewModel;
        }

        private void Cbb_all()
        {
            cbb_Trangthai.Items.Clear();
            cbb_Trangthai.Items.Add("Đã thanh toán");
            cbb_Trangthai.Items.Add("Chờ thanh toán");
            cbb_Trangthai.Items.Add("Hủy");

            cbb_pttt.Items.Clear();
            cbb_pttt.Items.Add("Tiền mặt");
            cbb_pttt.Items.Add("Chuyển khoản");

            cbb_tenkh.DataSource = KhachHangDataProvider.Ins.service.GetAll();
            cbb_tenkh.DisplayMember = "Ten";
        }

        private void SuaHoaDon()
        {
            var obj = bindingSource1.Current as HoaDonViewModel;
            var kh = cbb_tenkh.SelectedItem as KhachHangViewModel;

            obj.KhachHangId = kh.Id;
            obj.TrangThai = cbb_Trangthai.Text == "Hủy" ? 0 : cbb_Trangthai.Text == "Chờ thanh toán" ? 1 : 2;
            obj.PhuongThucThanhToan = cbb_pttt.Text == "Tiền mặt" ? 0 : 1;

            DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //update database
            if (result == DialogResult.OK)
            {
                HoaDonDataProvider.Ins.service.Update(obj);
            }
        }

        private void TinhGioAndTongTienPhong()
        {
            if (lb_ngaytt.Text == "" || lb_ngaytao.Text == "")
            {
                lb_songay.Text = "0";
                return;
            }
            TimeSpan span = DateTime.Parse(lb_ngaytt.Text) - DateTime.Parse(lb_ngaytao.Text);
            lb_songay.Text = span.Days.ToString() + " - " + span.Hours.ToString() + " - " + span.Minutes.ToString();
        }

        private void FrmHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            TinhGioAndTongTienPhong();

        }
    }
}
