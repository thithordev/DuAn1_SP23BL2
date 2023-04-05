using C_GUI.VMProviders;
using System.Windows.Input;

namespace C_GUI.ViewModels
{
    public class DangNhapViewModel : BaseViewModel
    {
        public bool IsLogin { get; set; }
        public bool IsClose { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand CloseCommad { get; set; }

        private string _UserName = String.Empty;
        private string _Password = String.Empty;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        public DangNhapViewModel()
        {
            VMPNhanVien.Ins.PropertyChanged += PhanQuyen;
            IsLogin = false;
            IsClose = false;
            LoginCommand = new RelayCommand<Form>((p) => { return true; }, (p) => { Login(p); });
            CloseCommad = new RelayCommand<Form>((p) => { return true; }, (p) => { p.Close(); VMPNhanVien.Ins.PropertyChanged -= PhanQuyen; IsClose = true; });
        }

        private void Login(Form form)
        {
            if (form == null) { return; }
            var nv = VMPNhanVien.Ins.service.GetLogin(UserName,Password);
            if (nv == null) {
                IsLogin = false;
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!"); return; }
            if (nv.Id != Guid.Empty)
            {
                IsLogin = true;
                VMPNhanVien.Ins.NhanVienLogin = nv;
                form.Close();
                VMPNhanVien.Ins.PropertyChanged -= PhanQuyen;
                IsClose = true;
            }
            else
            {
                IsLogin = false;
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }
        public void PhanQuyen(object? sender, EventArgs e)
        {
            if (VMPNhanVien.Ins.NhanVienLogin.ChucVuViewModel != null)
            {
                VMPNhanVien.Ins.quyenTruyCap.Chuc = VMPNhanVien.Ins.NhanVienLogin.ChucVuViewModel.Ten?? "Unknown";
            }
            if (VMPNhanVien.Ins.NhanVienLogin.ChucVuViewModel == null) return;
            List<QuyenNameValue> nameValues = new List<QuyenNameValue>();
            if (VMPNhanVien.Ins.NhanVienLogin.ChucVuViewModel.QuyenTruyCap != null)
            {
                var arrquyen = VMPNhanVien.Ins.NhanVienLogin.ChucVuViewModel.QuyenTruyCap.Split(";");
                foreach (var v in arrquyen)
                {
                    var namevalue = v.Split("=");
                    if (namevalue.Length == 2)
                    {
                        if (namevalue[1].Trim() == "1" || namevalue[1].Trim() == "0")
                        {
                            QuyenNameValue qnv = new QuyenNameValue();
                            qnv.Name = namevalue[0].Trim();
                            if (namevalue[1].Trim() == "1") qnv.Value = true; else qnv.Value = false;
                            nameValues.Add(qnv);
                        }
                    }
                }
            }
            foreach (var v in nameValues)
            {
                if (v.Name != null)
                {
                    var proinfo = VMPNhanVien.Ins.quyenTruyCap.GetType().GetProperty(v.Name);
                    if (proinfo != null)
                    {
                        proinfo.SetValue(VMPNhanVien.Ins.quyenTruyCap, v.Value);
                    }
                }
            }
        }
    }
}
