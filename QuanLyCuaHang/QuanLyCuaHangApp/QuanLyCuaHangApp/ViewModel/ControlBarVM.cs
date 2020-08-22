using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyCuaHangApp.ViewModel
{
    public class ControlBarVM:BaseViewModel
    {
        #region command
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand MaximizeWindowCommand { get; set; }
        public ICommand MousemoveWindowCommand { get; set; }
        #endregion
        public ControlBarVM()
        {
            CloseWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => { 
                FrameworkElement window =  getWindowParent(p);
                var w = window as Window;
                if (w != null) w.Close(); 
            }) ;
            MinimizeWindowCommand = new RelayCommand<UserControl>((m) => { return m == null ? false : true; }, (m) => {
                FrameworkElement window = getWindowParent(m);
                var w = window as Window;
                if (w != null) w.WindowState = WindowState.Minimized;
            });
            MaximizeWindowCommand = new RelayCommand<UserControl>((c) => { return c == null ? false : true; }, (c) => {
            FrameworkElement window = getWindowParent(c);
            var w = window as Window;
                if (w != null)
                {
                    if (w.WindowState == WindowState.Maximized)
                    {
                        w.WindowState = WindowState.Normal;
                    }
                    else w.WindowState = WindowState.Maximized;
                }
            });
            MousemoveWindowCommand = new RelayCommand<UserControl>((m) => { return m == null ? false : true; }, (m) => {
                FrameworkElement window = getWindowParent(m);
                var w = window as Window;
                if (w != null) w.DragMove();
            });
        }
        FrameworkElement getWindowParent(UserControl x)
        {
            FrameworkElement parents = x ;
            while (parents.Parent != null)
            {
                parents = parents.Parent as FrameworkElement;
            }
            return parents;
        }
    }
}
