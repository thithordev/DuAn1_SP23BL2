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
            //BindingSource1.DataSource = HoaDonDataProvider.Ins.service.GetAll();

        }
        private void dgv_hoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = BindingSource1.Current as HoaDonViewModel;

            FrmHoaDonChiTiet frmSuaHoaDon = new FrmHoaDonChiTiet(obj);
            frmSuaHoaDon.ShowDialog();
            button1_Click(sender, e);
        }
        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    var obj = BindingSource1.Current as HoaDonViewModel;
        //    FrmSuaHoaDon frmSuaHoaDon = new FrmSuaHoaDon(obj);
        //    frmSuaHoaDon.ShowDialog();
        //}

        public void button1_Click(object sender, EventArgs e)
        {
            BindingSource1.DataSource = HoaDonDataProvider.Ins.service.GetAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = BindingSource1.Current as HoaDonViewModel;

            DialogResult result = MessageBox.Show("Bạn có muốn đã xóa không ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                HoaDonDataProvider.Ins.service.Delete(obj.Id);
            }
            button1_Click(sender, e);
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
            button1_Click(sender, e);

        }



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    BindingSource1.DataSource = _Ihd.GetAll();
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var hd = (from x in HoaDonDataProvider.Ins.service.GetAll()
                      where x.SDT.StartsWith(txb_timkiem.Text)
                      select x).ToList();
            BindingSource1.DataSource = hd;
        }
    }
}
