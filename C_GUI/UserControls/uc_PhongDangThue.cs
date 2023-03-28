using C_GUI.Views;

namespace C_GUI.UserControls
{
    public partial class uc_PhongDangThue : UserControl
    {
        public uc_PhongDangThue()
        {
            InitializeComponent();
        }

        private void uc_PhongDangThue_DoubleClick(object sender, EventArgs e)
        {
            FrmDatPhong frmDatPhong = new FrmDatPhong();
            frmDatPhong.ShowDialog();
        }
    }
}
