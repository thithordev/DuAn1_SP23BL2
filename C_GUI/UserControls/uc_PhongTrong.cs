using C_GUI.Views;

namespace C_GUI.UserControls
{
    public partial class uc_PhongTrong : UserControl
    {
        public uc_PhongTrong()
        {
            InitializeComponent();
        }

        private void uc_PhongTrong_DoubleClick(object sender, EventArgs e)
        {
            FrmDatPhong frmDatPhong = new FrmDatPhong();
            frmDatPhong.ShowDialog();
        }
    }
}
