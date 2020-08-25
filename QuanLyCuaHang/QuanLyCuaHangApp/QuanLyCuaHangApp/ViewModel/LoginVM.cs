using QuanLyCuaHangApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;

namespace QuanLyCuaHangApp.ViewModel
{
    public class LoginVM : BaseViewModel
    {
        private static string _UserName;
        public static string UserName { get { return _UserName;} set { _UserName = value;} }
        private static string _Password;
        public static string Password { get { return _Password; } set { _Password = value;} }
        public ICommand LoginCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }

        public bool IsLogin { get; set; }
        public LoginVM()
        {
            IsLogin = false;
            LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>{ LoginLoad(p);});
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
            CloseCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { p.Close(); });
        }
        void LoginLoad(Window p)
        {
            if (p == null) return;
            string passEncode = MD5Hash(Base64Encode(Password));
            int count = DataProvider.Ins.DB.Users.Where(x => x.Account == UserName && x.Passwords == passEncode).Count();
            if ((int)count > 0)
            {
                IsLogin = true;
                p.Close();
            }
            else
            {
                MessageBoxResult msgResult = MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập, bạn có muốn thoát không?", "Thông báo", MessageBoxButton.OKCancel,MessageBoxImage.Warning,MessageBoxResult.OK);
                if ((int)msgResult == 1) p.Close();
                IsLogin = false;
            }
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }



        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
