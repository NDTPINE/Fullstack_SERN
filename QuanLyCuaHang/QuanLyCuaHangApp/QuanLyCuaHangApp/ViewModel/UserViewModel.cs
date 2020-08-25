using Microsoft.VisualStudio.Services.Users;
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
using User = QuanLyCuaHangApp.Model.User;

namespace QuanLyCuaHangApp.ViewModel
{
    public class UserViewModel : BaseViewModel
    {
        private ObservableCollection<User> _ListUser;
        public ObservableCollection<User> ListUser { get { return _ListUser; } set { _ListUser = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get { return _Password; } set { _Password = value; } }
        private string _Account ="a";
        public string Account { get { return _Account; } set { _Account = value; } }
        private string _Phone;
        public string Phone { get { return _Phone; } set { _Phone = value; } }
        private string _AddressUser;
        public string AddressUser { get { return _AddressUser; } set { _AddressUser = value; } }
        private string _Email;
        public string Email { get { return _Email; } set { _Email = value; } }
        private string _Permission;
        public string Permission { get { return _Permission; } set { _Permission = value; } }
        private User _SelectedItem;
        public User SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    Account = SelectedItem.Account;
                    Permission = SelectedItem.Permission;
                    Phone = SelectedItem.Phone;
                    Email = SelectedItem.Email;
                    AddressUser = SelectedItem.AddressUser;
                }
            }
        }

        public UserViewModel()
        {
            ListUser = new ObservableCollection<User>(DataProvider.Ins.DB.Users);

            ChangePasswordCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                PasswordChangeView temp = new PasswordChangeView();
                p.Hide();
                temp.ShowDialog();
                p.Show();
            });
            PasswordChangeUserCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
            AddCommand = new RelayCommand<Object>((p) =>
            {
                if (LoginVM.MD5Hash(LoginVM.Base64Encode(LoginVM.Password)) != LoginVM.MD5Hash(LoginVM.Base64Encode("admin"))) return false; if (string.IsNullOrEmpty(Account) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Permission)) return false;
                var userList = DataProvider.Ins.DB.Users.Where(x => x.Account == Account);
                if (userList == null || userList.Count() != 0) return false;
                return true;
            }, (p) => {
                var user = new User() { Account = Account, Passwords = LoginVM.MD5Hash(LoginVM.Base64Encode(Password)), Phone = Phone, AddressUser = AddressUser, Email = Email,Permission = Permission };
                DataProvider.Ins.DB.Users.Add(user);
                DataProvider.Ins.DB.SaveChanges();
                ListUser.Add(user);
            });
            EditCommand = new RelayCommand<Object>((p) =>
            {
                if (LoginVM.MD5Hash(LoginVM.Base64Encode(LoginVM.Password)) != LoginVM.MD5Hash(LoginVM.Base64Encode("admin"))) return false;
                if (SelectedItem == null) return false;
                return true;
            }, (p) => {
                var editUser = DataProvider.Ins.DB.Users.Where(t => t.Account == SelectedItem.Account).SingleOrDefault();
                editUser.Account = Account;
                editUser.Phone = Phone;
                editUser.AddressUser = AddressUser;
                editUser.Email = Email;
                editUser.Permission = Permission;
                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.Account = Account;
            });
            //Command Detele IS OK
            DeleteCommand = new RelayCommand<Object>((p) =>
            {
                if (LoginVM.MD5Hash(LoginVM.Base64Encode(LoginVM.Password)) != LoginVM.MD5Hash(LoginVM.Base64Encode("admin"))) return false; 
                //if (SelectedItem.Account != LoginVM.UserName) return true;
                if (SelectedItem == null) return false;
                return true;
            }, (p) =>
            {
                var checkOK = MessageBox.Show("Bạn có chắc muốn xoá", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.OK);
                if ((int)checkOK == 1)
                {
                    DataProvider.Ins.DB.Users.Remove(SelectedItem);
                    DataProvider.Ins.DB.SaveChanges();
                    ListUser.Remove(SelectedItem);
                }
            });
        }
        #region Command
        public ICommand ChangePasswordCommand { get; set; }
        public ICommand PasswordChangeUserCommand { get;set; }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        #endregion
    }
}
