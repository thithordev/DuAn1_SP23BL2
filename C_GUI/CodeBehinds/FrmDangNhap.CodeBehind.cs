using C_GUI.ViewModels;

namespace C_GUI.Views
{
    partial class FrmDangNhap
    {
        public DangNhapViewModel DangNhapVM { get; set; }
        public FrmDangNhap()
        {
            InitializeComponent();
            InitialControlHandlers();
        }

        private void InitialControlHandlers()
        {
            // Con trỏ về txb tài khoản khi khởi động
            this.ActiveControl = txb_taikhoan;

            DangNhapVM = new DangNhapViewModel();

            btn_dangnhap.Tag = DangNhapVM.LoginCommand;
            btn_dangnhap.Click += (sender, e) => { IsLogin(); };
            txb_taikhoan.KeyPress += (sender, e) => { if (e.KeyChar == (char)13) IsLogin(); };
            txb_matkhau.KeyPress += (sender, e) => { if (e.KeyChar == (char)13) IsLogin(); };
            txb_taikhoan.TextChanged += (sender, e) => { var abc = sender as TextBox; if (abc == null) return; DangNhapVM.UserName = abc.Text; };
            txb_matkhau.TextChanged += (sender, e) => { var abc = sender as TextBox; if (abc == null) return; DangNhapVM.Password = abc.Text; };
            txb_taikhoan.GotFocus += (sender, e) => { var abc = sender as TextBox; if (abc == null) return; abc.SelectAll(); };
            txb_matkhau.GotFocus += (sender, e) => { var abc = sender as TextBox; if (abc == null) return; abc.SelectAll(); };


            btn_Thoat.Tag = DangNhapVM.CloseCommad;
            btn_Thoat.Click += (sender, e) => { IsClose(); };

        }

        // IsLogin xử lý việc đăng nhập được không.
        private void IsLogin()
        {
            DangNhapVM.Execute(btn_dangnhap.Tag, this);
            txb_taikhoan.Focus();
        }

        private void IsClose()
        {
            DangNhapVM.Execute(btn_Thoat.Tag, this);
        }
    }
}