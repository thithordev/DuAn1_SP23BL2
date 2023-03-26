using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace C_GUI.ViewModels
{
    public class DangNhapViewModel : BaseViewModel
    {
        public bool IsLogin { get; set; }
        public ICommand LoginCommand { get; set; }
        public DangNhapViewModel()
        {
            IsLogin= false;
            LoginCommand = new RelayCommand<object>( (p) => { return false; }, (p) => { IsLogin = true; });
        }
    }
}
