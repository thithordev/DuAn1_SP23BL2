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
        public FrmSuaHoaDon(HoaDonViewModel hoaDonViewModels)
        {
            InitializeComponent();
            Cbb_all();
            BindingSource1.DataSource = hoaDonViewModels;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            var obj = BindingSource1.Current as HoaDonViewModel;
            var kh = cbb_tenkh.SelectedItem as KhachHangViewModel;

            obj.KhachHangId = kh.Id;
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            SuaHoaDon();
        }

        private void khachHangViewModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbb_tenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kh = cbb_tenkh.SelectedItem as KhachHangViewModel;
            if (kh != null)
            {
                cbb_tenkh.Text = kh.Ten;
                txb_sdt.Text = kh.SDT;
                txb_cmnd.Text = kh.CCCD;
            }
        }

        private void FrmSuaHoaDon_Load(object sender, EventArgs e)
        {
        }
    }
}
