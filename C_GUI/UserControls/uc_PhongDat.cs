using C_GUI.Views;

namespace C_GUI.UserControls
{
    public partial class uc_PhongDat : UserControl
    {
        public uc_PhongDat()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FrmThongTinPhong frm = new FrmThongTinPhong();
            frm.ShowDialog();
        }
    }
}
