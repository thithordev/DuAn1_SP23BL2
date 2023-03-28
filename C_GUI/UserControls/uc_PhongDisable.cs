using C_GUI.Views;

namespace C_GUI.UserControls
{
    public partial class uc_PhongDisable : UserControl
    {
        public uc_PhongDisable()
        {
            InitializeComponent();
        }

        private void uc_PhongDisable_DoubleClick(object sender, EventArgs e)
        {
            FrmDatPhong frmDatPhong = new FrmDatPhong();
            frmDatPhong.ShowDialog();
        }
    }
}
