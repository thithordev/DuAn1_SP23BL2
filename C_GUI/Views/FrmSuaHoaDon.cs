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
        HoaDonViewModel _lst_HoaDon;

        public FrmSuaHoaDon(HoaDonViewModel hoaDonViewModels)
        {
            InitializeComponent();
            _lst_HoaDon = new HoaDonViewModel();
            _lst_HoaDon = hoaDonViewModels;
            BindingSource1.DataSource = _lst_HoaDon;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
