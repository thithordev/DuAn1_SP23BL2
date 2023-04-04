using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using System.Text;
using System.Text.RegularExpressions;

namespace C_GUI.Views
{
    public partial class FrmPhieuDichVu : Form
    {
        IDichVuService _ichVuService;
        public FrmPhieuDichVu()
        {
            InitializeComponent();
            _ichVuService = new DichVuService();
        }

        private void dgvDVChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthoat_click(object sender, EventArgs e)
        {

        }

        private void btnluu_click(object sender, EventArgs e)
        {

        }

        private void txttimkiem_enter_1(object sender, EventArgs e)
        {
            
        }

        private void txttimkiem_textchanged(object sender, EventArgs e)
        {

        }
    }
}

