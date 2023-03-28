using C_GUI.UserControls;

namespace C_GUI.Views
{
    public partial class FrmPhong : Form
    {
        public FrmPhong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int rd = random.Next(0, 4);
            var uc_1 = new uc_PhongTrong();
            var uc_2 = new uc_PhongDat();
            var uc_3 = new uc_PhongDangThue();
            var uc_4 = new uc_PhongDisable();
            List<UserControl> ucs = new List<UserControl> { uc_1, uc_2, uc_3, uc_4 };
            flowLayoutPanel1.Controls.Add(ucs[rd]);
        }
    }
}
