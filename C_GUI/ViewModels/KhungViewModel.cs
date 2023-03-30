using C_GUI.Views;
using C_GUI.VMProviders;
using System.Windows;
using System.Windows.Input;

namespace C_GUI.ViewModels
{
    public class KhungViewModel : BaseViewModel
    {
        private FrmDangNhap frmDangNhap;
        public bool IsLoaded { get; set; }
        public ICommand LoadedCommand { get; set; }
        public KhungViewModel()
        {
            IsLoaded = false;
            LoadedCommand = new RelayCommand<Form>((p) => { return true; }, (p) =>
            {
                IsLoaded = true;
                if (p == null)
                {
                    return;
                }
                p.Hide();
                frmDangNhap = new FrmDangNhap();
                frmDangNhap.ShowDialog();
                if (frmDangNhap.DangNhapVM == null)
                {
                    return;
                }
                if (frmDangNhap.DangNhapVM.IsClose)
                {
                    if (frmDangNhap.DangNhapVM.IsLogin)
                    {
                        p.Show();
                        //p.TopMost = true;
                        p.BringToFront();
                        //p.Activate();
                        frmDangNhap.Dispose();
                    }
                    else
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
                else
                {

                }
            });
        }
    }
}
