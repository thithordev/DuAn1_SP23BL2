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
        IHoaDonService Ihd;
         List<HoaDonViewModel> _lstHoadon;

        public FrmHoaDon()
        {
            InitializeComponent();
            Ihd = new HoaDonService();
            _lstHoadon = new List<HoaDonViewModel>();
        }
        
        private void GetHoaDonFromData()
        {
            _lstHoadon = Ihd.GetAll();
            dgv_hoadon.DataSource = _lstHoadon;
        }

        private void GetTrangThai()
        {


        }

    }
}
