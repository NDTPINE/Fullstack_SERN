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

namespace QuanLyCuaHangApp.ViewModel
{
    public class PasswordChangeVM : BaseViewModel 
    {
        private string _OldPass;
        public string OldPass { get { return _OldPass; } set { _OldPass = value; OnPropertyChanged(); } }
        private string _NewPass;
        public string NewPass { get { return _NewPass; } set { _NewPass = value; OnPropertyChanged(); } }
        private string _RepeatPass;
        public string RepeatPass { get { return _RepeatPass; } set { _RepeatPass = value; OnPropertyChanged(); } }
        public ICommand OldPassCommand { get; set; }
        public ICommand NewPassCommand { get; set; }
        public ICommand RepeatPassCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand btnChangePassword { get; set; }


        public PasswordChangeVM()
        {

            btnChangePassword = new RelayCommand<Window>((p) => { return true; }, (p) => { LoginLoad(p); });
            OldPassCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { OldPass = p.Password; });
            NewPassCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { NewPass = p.Password; });
            RepeatPassCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { RepeatPass = p.Password; });
            CloseCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { p.Close(); });
        }
        void LoginLoad(Window p)
        {
            if (p == null) return;
            string oldPassEncode = MD5Hash(Base64Encode(OldPass));
            string newPassEncode = MD5Hash(Base64Encode(NewPass));
            string repeatPassEncode = MD5Hash(Base64Encode(RepeatPass));
            string passEncode = MD5Hash(Base64Encode(LoginVM.Password));
            if (oldPassEncode == passEncode && newPassEncode == repeatPassEncode)
            {
                DataProvider.Ins.DB.Sp_ChangePass_User(oldPassEncode, newPassEncode, repeatPassEncode, LoginVM.UserName);
                DataProvider.Ins.DB.SaveChanges();
                MessageBoxResult msgResult = MessageBox.Show("Đổi mật khẩu thành công !!!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
                if ((int)msgResult == 1) p.Close();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu !!!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK);
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
