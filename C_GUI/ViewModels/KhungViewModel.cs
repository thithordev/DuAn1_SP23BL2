using C_GUI.Views;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace C_GUI.ViewModels
{
    public class KhungViewModel : BaseViewModel
    {
        public bool IsLoaded { get; set; }
        public ICommand LoadedCommand { get; set; }
        public KhungViewModel()
        {
            IsLoaded = false;
            LoadedCommand = new RelayCommand<Form>( (p) => { return true; }, (p) =>
            {
                IsLoaded = true;
                if (p == null)
                {
                    return;
                }
                p.Hide();
                FrmDangNhap frmDangNhap = new FrmDangNhap();
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
                        //p.Activate();
                        frmDangNhap.Dispose();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    
                }
            });
        }
    }
}
