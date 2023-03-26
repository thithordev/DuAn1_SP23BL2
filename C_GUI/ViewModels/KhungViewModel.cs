using C_GUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_GUI.ViewModels
{
    public class KhungViewModel : BaseViewModel
    {
        public bool IsLoaded { get; set; }
        public KhungViewModel()
        {
            if (!IsLoaded)
            {
                IsLoaded = true;
                FrmDangNhap frmDangNhap = new FrmDangNhap();
                frmDangNhap.ShowDialog();
                if (frmDangNhap.DangNhapVM.IsLogin)
                {
                    frmDangNhap.Close();
                }
            }
        }
    }
}
