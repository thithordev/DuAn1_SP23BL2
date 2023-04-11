using B_BUS.DataProviders;
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
    public partial class FrmHoaDon : Form
    {
        IHoaDonService _Ihd;

        public FrmHoaDon()
        {
            InitializeComponent();
            _Ihd = new HoaDonService();
            BindingSource1.DataSource = _Ihd.GetAll();
        }
        private void dgv_hoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = BindingSource1.Current as HoaDonViewModel;
            FrmSuaHoaDon frmSuaHoaDon = new FrmSuaHoaDon(obj);
            frmSuaHoaDon.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource1.DataSource = _Ihd.GetAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var hd = (from x in HoaDonDataProvider.Ins.service.GetAll()
                     where x.SDT.StartsWith(txb_timkiem.Text)
                     select x).ToList();
            BindingSource1.DataSource = hd;
        }
    }
}
