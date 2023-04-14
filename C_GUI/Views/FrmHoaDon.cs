using A_DAL.Models;
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
    public partial class FrmHoaDon : Form
    {
        IHoaDonService _Ihd;

        public FrmHoaDon()
        {
            InitializeComponent();
            BindingSource1.DataSource = HoaDonDataProvider.Ins.service.GetAll().OrderBy(c=>c.TrangThai); 

        }
        private void dgv_hoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            BindingSource1.DataSource = HoaDonDataProvider.Ins.service.GetAll().OrderBy(c => c.TrangThai);
        }


        private void ThemHoaDon()
        {
            HoaDonViewModel hd = new HoaDonViewModel()
            {
                Id = Guid.NewGuid(),
                KhachHangId = null,
                NhanVienId = null,
                TongTien = 1000,
                TrangThai = 1,
            };

            DialogResult result = MessageBox.Show("Bạn có muốn đã thêm không ?", "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bool a = HoaDonDataProvider.Ins.service.Add(hd);
                MessageBox.Show(a.ToString());
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHoaDon();
            button1_Click_1(sender, e);

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            var obj = BindingSource1.Current as HoaDonViewModel;

            FrmHoaDonChiTiet frmSuaHoaDon = new FrmHoaDonChiTiet(obj);
            frmSuaHoaDon.ShowDialog();
            button1_Click_1(sender, e);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            var obj = BindingSource1.Current as HoaDonViewModel;

            DialogResult result = MessageBox.Show("Bạn có muốn xóa không ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                HoaDonDataProvider.Ins.service.Delete(obj.Id);
            }
            button1_Click_1(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BindingSource1.DataSource = HoaDonDataProvider.Ins.service.GetAll().OrderBy(c => c.TrangThai);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            var obj = BindingSource1.Current as HoaDonViewModel;
            
            DialogResult result = MessageBox.Show("Bạn có muốn hủy không ?", "Hủy", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                obj.TrangThai = 0;
                HoaDonDataProvider.Ins.service.Update(obj);
            }
            button1_Click_1(sender, e);
        }

        private void txb_timkiem_TextChanged(object sender, EventArgs e)
        {
            BindingSource1.DataSource = HoaDonDataProvider.Ins.service.GetAll().Where(c => c.SDT.Contains(txb_timkiem.Text)).OrderBy(c => c.TrangThai).ToList();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
