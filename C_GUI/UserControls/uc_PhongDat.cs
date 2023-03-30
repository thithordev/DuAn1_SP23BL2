using C_GUI.Views;

namespace C_GUI.UserControls
{
    public partial class uc_PhongDat : UserControl
    {
        public uc_PhongDat()
        {
            InitializeComponent();
        }

        private void uc_PhongDat_DoubleClick(object sender, EventArgs e)
        {
            FrmDatPhong frmDatPhong = new FrmDatPhong();
            frmDatPhong.ShowDialog();
        }
    }
}
