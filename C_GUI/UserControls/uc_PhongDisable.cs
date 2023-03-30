using C_GUI.Views;

namespace C_GUI.UserControls
{
    public partial class uc_PhongDisable : UserControl
    {
        public uc_PhongDisable()
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
