using C_GUI.VMProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace C_GUI.ViewModels
{
    public class DangNhapViewModel : BaseViewModel
    {
        public bool IsLogin { get; set; }
        public ICommand LoginCommand { get; set; }

        private string _UserName;
        private string _Password;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        public DangNhapViewModel()
        {
            IsLogin = false;
            LoginCommand = new RelayCommand<Form>((p) => { return true; }, (p) => { Login(p); });
        }

        private void Login(Form form)
        {
            if (form == null) { return; }

            var kq = VMPNhanVien.Ins.service.GetAll().Where(x => x.TenTaiKhoan == _UserName && x.MatKhau == _Password).Count();

            if (kq > 0)
            {
                IsLogin = true;
                form.Close();
            }
            else
            {
                IsLogin = false;
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }
    }
}
