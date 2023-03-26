using C_GUI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI.Views
{
    public partial class FrmDangNhap : Form
    {
        public DangNhapViewModel DangNhapVM { get; set; }
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        public void btnDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
