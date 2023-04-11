using B_BUS.DataProviders;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI.Views
{
    public partial class FrmSuaHoaDon : Form
    {
 
        public FrmSuaHoaDon(HoaDonViewModel hoaDonViewModel)
        {
            InitializeComponent();

            bindingSource1.DataSource = hoaDonViewModel;
            Cbb_all();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cbb_all()
        {
            cbb_tenkh.Items.Clear();
            cbb_trangthai.Items.Clear();

            cbb_tenkh.DataSource = KhachHangDataProvider.Ins.service.GetAll();
            cbb_tenkh.DisplayMember = "Ten";

            cbb_trangthai.Items.Add("Hủy");
            cbb_trangthai.Items.Add("Chờ thanh toán");
            cbb_trangthai.Items.Add("Đã thanh toán");

        }

        private void cbb_tenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kh = cbb_tenkh.SelectedItem as KhachHangViewModel;
            txb_cmnd.Text = kh.CCCD;
            txb_sdt.Text = kh.SDT;
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var hd = bindingSource1.Current as HoaDonViewModel;
            var kh = cbb_tenkh.SelectedItem as KhachHangViewModel;

            hd.KhachHangId = kh.Id;
            hd.TrangThai = cbb_trangthai.Text == "Hủy" ? 0 : cbb_trangthai.Text == "Chờ thanh toán" ? 1 : 2;

            hd.NgayTao = dtpk_bd.Value;
            hd.NgayThanhToan = dtpk_kt.Value;

            DialogResult result = MessageBox.Show("Bạn có muốn sửa hóa đơn không ?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                HoaDonDataProvider.Ins.service.Update(hd);
            }

        }
    }
}
