using QuanLyCuaHangApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyCuaHangApp.ViewModel
{
    public class UserViewModel : BaseViewModel
    {
        public UserViewModel()
        {
            ChangePasswordCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                PasswordChangeView temp = new PasswordChangeView();
                p.Hide();
                temp.ShowDialog();
                p.Show();
            });
        }
        #region Command
        public ICommand ChangePasswordCommand { get; set; }
        #endregion
    }
}
