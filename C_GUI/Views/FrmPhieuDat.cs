namespace C_GUI.Views
{
    public partial class FrmPhieuDat : Form
    {
        public FrmPhieuDat()
        {
            InitializeComponent();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            FrmDatPhong frm = new FrmDatPhong();
            frm.ShowDialog();
        }
    }
}
