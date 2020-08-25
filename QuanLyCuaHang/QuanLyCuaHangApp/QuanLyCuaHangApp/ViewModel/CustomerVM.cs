using QuanLyCuaHangApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyCuaHangApp.ViewModel
{
    public class CustomerVM : BaseViewModel
    {
        private ObservableCollection<Customer> _ListCustomer;
        public ObservableCollection<Customer> ListCustomer { get { return _ListCustomer; } set { _ListCustomer = value; OnPropertyChanged(); } }
        private Customer _SelectedItem;
        public Customer SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    ID = SelectedItem.Id;
                    Customer1 = SelectedItem.Customer1;
                    NameCus = SelectedItem.NameCus;
                    AddressCus = SelectedItem.Adress;
                    Phone = SelectedItem.Phone;
                    Email = SelectedItem.Email;
                }
            }
        }

        private int _id;
        public int ID { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private string _Customer1;
        public string Customer1 { get { return _Customer1; } set { _Customer1 = value; OnPropertyChanged(); } }
        private string _NameCus;
        public string NameCus { get { return _NameCus; } set { _NameCus = value; OnPropertyChanged(); } }
        private string _AddressCus;
        public string AddressCus { get { return _AddressCus; } set { _AddressCus = value; OnPropertyChanged(); } }
        private string _Phone;
        public string Phone { get { return _Phone; } set { _Phone = value; OnPropertyChanged(); } }
        private string _Email;
        public string Email { get { return _Email; } set { _Email = value; OnPropertyChanged(); } }
        public CustomerVM()
        {
            ListCustomer = new ObservableCollection<Customer>(DataProvider.Ins.DB.Customers);

            AddCommand = new RelayCommand<Object>((p) =>
            {
                if (string.IsNullOrEmpty(Customer1) || string.IsNullOrEmpty(NameCus) || string.IsNullOrEmpty(AddressCus)) return false;
                var suplierList = DataProvider.Ins.DB.Customers.Where(x => x.Customer1 == Customer1);
                if (suplierList == null || suplierList.Count() != 0) return false;
                return true;
            }, (p) => {
                var customer = new Customer() { Customer1 = Customer1, NameCus = NameCus, Adress = AddressCus, Phone = Phone, Email = Email };
                DataProvider.Ins.DB.Customers.Add(customer);
                DataProvider.Ins.DB.SaveChanges();
                ListCustomer.Add(customer);
            });
            EditCommand = new RelayCommand<Object>((p) =>
            {
                if (SelectedItem == null) return false;
                return true;
            }, (p) => {
                var editCus = DataProvider.Ins.DB.Customers.Where(t => t.Id == SelectedItem.Id).SingleOrDefault();
                editCus.Customer1 = Customer1;
                editCus.NameCus = NameCus;
                editCus.Phone = Phone;
                editCus.Email = Email;
                editCus.Id = ID;
                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.Id = ID;
            });
            //Command Detele IS OK
            DeleteCommand = new RelayCommand<Object>((p) =>
            {
                if (SelectedItem == null) return false;
                return true;
            }, (p) =>
            {
                var checkOK = MessageBox.Show("Bạn có chắc muốn xoá", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.OK);
                if ((int)checkOK == 1)
                {
                    DataProvider.Ins.DB.Sp_Delete_Customer(SelectedItem.Id);
                    DataProvider.Ins.DB.SaveChanges();
                    ListCustomer.Remove(SelectedItem);
                }
            });
            ResetCommand = new RelayCommand<Object>((p) =>
            {
                return true;
            }, (p) =>
            {
                Customer1 = "";
                NameCus = "";
                AddressCus = "";
                Phone = "";
                Email = "";

            });
        }

        #region command
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand ResetCommand { get; set; }


        #endregion
    }
}
