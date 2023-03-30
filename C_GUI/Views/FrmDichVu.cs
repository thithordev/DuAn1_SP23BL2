using B_BUS.IServices;
using B_BUS.Services;

namespace C_GUI.Views
{
    public partial class FrmDichVu : Form
    {
        IDichVuService _dichVu;
        public FrmDichVu()
        {
            InitializeComponent();
            _dichVu = new DichVuService();
        }
        void loadDV()
        {
            dgvDichVu.DataSource = _dichVu.GetAll();
        }
    }
}
