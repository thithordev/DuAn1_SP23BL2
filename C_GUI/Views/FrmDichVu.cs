using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace C_GUI.Views
{
    public partial class FrmDichVu : Form
    {
        IDichVuService _dichVu;
        public FrmDichVu()
        {
            InitializeComponent();
            _dichVu = new DichVuService();
            load();
        }
        void load()
        {
            DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn();
            btnSua.UseColumnTextForButtonValue = true;
            btnSua.Text = "Sửa";
            DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
            btnXoa.UseColumnTextForButtonValue= true;
            btnXoa.Text = "Xóa";
            var ds = from x in _dichVu.GetAll()
                     where x.IsDeleted == false
                     select new 
                     {
                     Id = x.Id,
                     Ten = x.Ten,
                     Gia = x.Gia,
                     };
            dgvDichVu.DataSource = ds.ToList();
            dgvDichVu.Columns.Insert(3, btnSua);
            dgvDichVu.Columns.Insert(4, btnXoa);
        }

        public void txtTimKiem_TextChanged (object sender, EventArgs e)
        {

        }

        public void dgvDichVu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

        }

        public void txtTimKiem_Enter(object sender, EventArgs e)
        {

        }

        public void btnThemDV_Click (object sender, EventArgs e)
        {

        }

        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
