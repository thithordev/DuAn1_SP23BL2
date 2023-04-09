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

        public FrmSuaHoaDon(HoaDonViewModel hoaDonViewModels)
        {
            InitializeComponent();
            BindingSource1.DataSource = hoaDonViewModels;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
