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
            InitialControlHandlers();
        }

        private void InitialControlHandlers()
        {
            DangNhapVM = new DangNhapViewModel();

            btnDangNhap.Click += (sender, e) => btnDangNhap_Click();
            btnDangNhap.Tag = DangNhapVM.LoginCommand;

            txtDangNhap.DataBindings.Add(new Binding("Text", DangNhapVM, "UserName"));
            txtMatKhau.DataBindings.Add(new Binding("Text", DangNhapVM, "Password"));
        }

        private void btnDangNhap_Click()
        {
            DangNhapVM.Execute(btnDangNhap.Tag, this);
        }

    }
}
