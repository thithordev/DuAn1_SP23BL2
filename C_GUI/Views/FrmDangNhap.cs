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
        public DangNhapViewModel DangNhapVM { set; get; }
        public FrmDangNhap()
        {
            InitializeComponent();

            //Khởi tạo Dang Nhap VM
            DangNhapVM = new DangNhapViewModel();
            this.btnDangNhap.Tag = DangNhapVM.LoginCommand;
        }
    }
}
