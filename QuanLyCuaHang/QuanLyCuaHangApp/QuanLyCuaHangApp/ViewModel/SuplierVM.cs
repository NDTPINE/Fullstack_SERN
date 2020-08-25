using QuanLyCuaHangApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyCuaHangApp.ViewModel
{
     public class SuplierVM : BaseViewModel
     {
        private ObservableCollection<Suplier> _ListSuplier;
        public ObservableCollection<Suplier> ListSuplier { get { return _ListSuplier; } set { _ListSuplier = value; OnPropertyChanged(); } }
        private Suplier _SelectedItemSup;
        public Suplier SelectedItemSup { 
            get { return _SelectedItemSup; } 
            set { 
                _SelectedItemSup = value; 
                OnPropertyChanged(); 
                if (SelectedItemSup != null) {
                    ID = SelectedItemSup.Id;
                    Suplier1 = SelectedItemSup.Suplier1 ;
                    NameSup =  SelectedItemSup.NameSup;
                    AddressSup = SelectedItemSup.AddressSup;
                    Phone = SelectedItemSup.Phone;
                    Email = SelectedItemSup.Email;
                } 
            } 
        }

        private int _id;
        public int ID { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private string _Suplier1;
        public string Suplier1 { get { return _Suplier1; } set { _Suplier1 = value; OnPropertyChanged(); } }
        private string _NameSup;
        public string NameSup { get { return _NameSup; } set { _NameSup = value; OnPropertyChanged(); } }
        private string _AddressSup;
        public string AddressSup { get { return _AddressSup; } set { _AddressSup = value; OnPropertyChanged(); } }
        private string _Phone;
        public  string Phone { get { return _Phone; } set { _Phone = value; OnPropertyChanged(); } }
        private string _Email;
        public string Email { get { return _Email; } set { _Email = value; OnPropertyChanged(); } }
        public SuplierVM()
        {
            ListSuplier = new ObservableCollection<Suplier>(DataProvider.Ins.DB.Supliers);

            AddCommand = new RelayCommand<Object>((p) =>
            {
                if (string.IsNullOrEmpty(Suplier1) || string.IsNullOrEmpty(NameSup) || string.IsNullOrEmpty(AddressSup)) return false;
                var suplierList = DataProvider.Ins.DB.Supliers.Where(x => x.Suplier1 == Suplier1);
                if (suplierList == null || suplierList.Count() != 0) return false;
                return true;
            }, (p) => {
                var suplier = new Suplier() { Suplier1 = Suplier1, NameSup = NameSup, AddressSup = AddressSup, Phone = Phone, Email = Email };
                DataProvider.Ins.DB.Supliers.Add(suplier);
                DataProvider.Ins.DB.SaveChanges();
                ListSuplier.Add(suplier);
            });
            EditCommand = new RelayCommand<Object>((p) =>
            {
                if (SelectedItemSup == null) return false;
                return true;
            }, (p) => {
                var editSuplier = DataProvider.Ins.DB.Supliers.Where(t => t.Id == SelectedItemSup.Id).SingleOrDefault();
                editSuplier.Suplier1 = Suplier1;
                editSuplier.NameSup = NameSup;
                editSuplier.Phone = Phone;
                editSuplier.Email = Email;
                editSuplier.Id = ID;
                DataProvider.Ins.DB.SaveChanges();
                SelectedItemSup.Id = ID;
            });
            //Command Detele IS OK
            DeleteCommand = new RelayCommand<Object>((p) =>
            {
                if (SelectedItemSup == null) return false;
                return true;
            }, (p) =>
            {
            var checkOK = MessageBox.Show("Bạn có chắc muốn xoá", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.OK);
                if ((int)checkOK == 1)
                {
                    DataProvider.Ins.DB.Sp_Delete_Suplier(SelectedItemSup.Id);
                    DataProvider.Ins.DB.SaveChanges();
                    ListSuplier.Remove(SelectedItemSup);
                }
            });
            ResetCommand = new RelayCommand<Object>((p) =>
            {
                return true;
            }, (p) =>
            {
                Suplier1 = "";
                NameSup ="";
                AddressSup = "";
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
