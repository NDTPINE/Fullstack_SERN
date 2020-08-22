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
    
    public class MainViewModel: BaseViewModel
    {
        private bool isLoaded;
        public bool IsLoaded { get { return false; } set { isLoaded = value; } }
        public ICommand LoadedWindowCommand { get; set; }
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                IsLoaded = true;
                Login log = new Login();
                log.ShowDialog();
            });
        }

    }
}
