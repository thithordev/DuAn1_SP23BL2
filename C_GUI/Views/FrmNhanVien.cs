using B_BUS.IServices;
using C_GUI.VMProviders;
using Catel.Services;

namespace C_GUI.Views
{
    public partial class FrmNhanVien : Form
    {
        INhanVienService _Service;
        public FrmNhanVien()
        {
            InitializeComponent();
            _Service = VMPNhanVien.Ins.service;
            BindingSource1.DataSource = _Service.GetAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
