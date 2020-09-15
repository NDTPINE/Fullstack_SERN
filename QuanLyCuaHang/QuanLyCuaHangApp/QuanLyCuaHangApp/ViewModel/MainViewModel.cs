using Microsoft.VisualStudio.Services.Commerce;
using Microsoft.VisualStudio.Services.Location;
using Microsoft.VisualStudio.Services.Users.Client;
using QuanLyCuaHangApp.Model;
using QuanLyCuaHangApp.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyCuaHangApp.ViewModel
{
    
    public class MainViewModel: BaseViewModel
    {
        private bool isLoaded;
        public bool IsLoaded { get { return false; } set { isLoaded = value; } }
        private DateTime dateTo = DateTime.Now;
        public DateTime DateTo { get { return dateTo; } set { dateTo = value; OnPropertyChanged(); } }
        private DateTime dateFrom = DateTime.Now;
        public DateTime DateFrom { get { return dateFrom; } set { dateFrom = value; OnPropertyChanged(); } }

        private ObservableCollection<ListMain> listmainwindow;
        public ObservableCollection<ListMain> ListMainWindow { get { return listmainwindow; } set { listmainwindow = value; OnPropertyChanged(); } }
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand UserCommand { get; set; }
        public ICommand InputCommand { get; set; }
        public ICommand OutputCommand { get; set; }
        public ICommand StaffCommand { get; set; }
        public ICommand CustomerCommand { get; set; }
        public ICommand SuplierCommand { get; set; }
        public ICommand GoodCommand { get; set; }
        public ICommand InputMainCommand { get; set; }
        public ICommand OutputMainCommand { get; set; }
        public ICommand ReportCommand { get; set; }

        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                IsLoaded = true;
                if (p == null) return;

                p.Hide();
                Login log = new Login();
                log.ShowDialog();

                if (log.DataContext == null)
                {
                    return;
                }
                var loginVM = log.DataContext as LoginVM;
                if (loginVM.IsLogin)
                {
                    p.Show();
                }
                else p.Close();
            });
            UserCommand = new RelayCommand<Object>((p) => { return true; }, (p) => { 
                UserView temp = new UserView();
                temp.ShowDialog();
            });
            InputCommand = new RelayCommand<Object>((p) => { return true; }, (p) => {
                View.Input temp = new View.Input();
                temp.ShowDialog();
            });
            OutputCommand = new RelayCommand<Object>((p) => { return true; }, (p) => {
                View.Output temp = new View.Output();
                temp.ShowDialog();
            });
            StaffCommand = new RelayCommand<Object>((p) => { return true; }, (p) => {
                View.Staff temp = new View.Staff();
                temp.ShowDialog();
            });
            CustomerCommand = new RelayCommand<Object>((p) => { return true; }, (p) => {
                View.Customer temp = new View.Customer();
                temp.ShowDialog();
            });
            SuplierCommand = new RelayCommand<Object>((p) => { return true; }, (p) => {
                View.Suplier temp = new View.Suplier();
                temp.ShowDialog();
            });
            GoodCommand = new RelayCommand<Object>((p) => { return true; }, (p) => {
                View.Good temp = new View.Good();
                temp.ShowDialog();
            });
            InputMainCommand = new RelayCommand<Button>((p) => { return true; }, (p) => {
                ListMainWindow = new ObservableCollection<ListMain>();
                var listmain = DataProvider.Ins.DB.v_ListInput.Where(x => x.Ngaynhap >= DateTo && x.Ngaynhap <= DateFrom);
                foreach (var item in listmain)
                {
                    ListMain lm = new ListMain();
                    lm.Maphieu = item.Maphieunhap;
                    lm.Tenhang = item.Tenhang;
                    lm.Gia = item.Dongianhap;
                    lm.Soluong = item.Soluongnhap;
                    lm.Thue = item.Thue;
                    lm.Thanhtien = item.Thanhtien;
                    ListMainWindow.Add(lm);
                }
            });
            OutputMainCommand = new RelayCommand<Button>((p) => { return true; }, (p) => {
                ListMainWindow = new ObservableCollection<ListMain>();
                var listmain = DataProvider.Ins.DB.v_ListOutput.Where(x => x.Ngayxuat >= DateTo && x.Ngayxuat <= DateFrom);
                foreach (var item2 in listmain)
                {
                    ListMain lm = new ListMain();
                    lm.Maphieu = item2.Maphieuxuat;
                    lm.Tenhang = item2.Tenhang;
                    lm.Gia = item2.Giaxuat;
                    lm.Soluong = item2.Soluongxuat;
                    lm.Thue = item2.Thue;
                    lm.Thanhtien = item2.Thanhtien;
                    ListMainWindow.Add(lm);
                }
            });
            ReportCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                ReportView tempReport = new ReportView();
                tempReport.Show();
            });

        }
    }
}
