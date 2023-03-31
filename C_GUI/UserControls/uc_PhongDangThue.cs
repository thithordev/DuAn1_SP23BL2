using C_GUI.Views;

namespace C_GUI.UserControls
{
    public partial class uc_PhongDangThue : UserControl
    {
        public uc_PhongDangThue()
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