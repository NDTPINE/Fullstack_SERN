using Microsoft.VisualStudio.Services.WebApi;
using QuanLyCuaHangApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyCuaHangApp.ViewModel
{
    public class GoodVM :BaseViewModel
    {
        private ObservableCollection<Good> _ListGood;
        public ObservableCollection<Good> ListGood { get { return _ListGood; } set { _ListGood = value; OnPropertyChanged(); } }
        private Good _SelectedItem;
        public Good SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    Id = SelectedItem.Id;
                    Good1 = SelectedItem.Good1;
                    NameGoo = SelectedItem.NameGoo;
                    Producer = SelectedItem.Producer;
                    Numbers = SelectedItem.Numbers;
                    Warranty = SelectedItem.Warranty;
                    Unit = SelectedItem.Unit;
                    Statuss = SelectedItem.Statuss;
                }
            }
        }

        private int _id;
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private string _Good1;
        public string Good1 { get { return _Good1; } set { _Good1 = value; OnPropertyChanged(); } }
        private string _NameGoo;
        public string NameGoo { get { return _NameGoo; } set { _NameGoo = value; OnPropertyChanged(); } }
        private string _Producer;
        public string Producer { get { return _Producer; } set { _Producer = value; OnPropertyChanged(); } }
        private int _Numbers;
        public int Numbers { get { return _Numbers; } set { _Numbers = value; OnPropertyChanged(); } }
        private string _Warranty;
        public string Warranty { get { return _Warranty; } set { _Warranty = value; OnPropertyChanged(); } }
        private string _Unit;
        public string Unit { get { return _Unit; } set { _Unit = value; OnPropertyChanged(); } }
        private string _Statuss;
        public string Statuss { get { return _Statuss; } set { _Statuss = value; OnPropertyChanged(); } }
        public GoodVM()
        {
            ListGood = new ObservableCollection<Good>(DataProvider.Ins.DB.Goods);

            AddCommand = new RelayCommand<Object>((p) =>
            {
                if (string.IsNullOrEmpty(Good1) || string.IsNullOrEmpty(NameGoo) || string.IsNullOrEmpty(Producer)) return false;
                var goodlist = DataProvider.Ins.DB.Goods.Where(x => x.Good1 == Good1);
                if (goodlist == null || goodlist.Count() != 0) return false;
                return true;
            }, (p) => {
                var good = new Good() { Good1 = Good1, NameGoo = NameGoo, Producer = Producer, Numbers = Numbers,Warranty = Warranty, Unit = Unit, Statuss = Statuss };
                DataProvider.Ins.DB.Goods.Add(good);
                DataProvider.Ins.DB.SaveChanges();
                ListGood.Add(good);
            });
            EditCommand = new RelayCommand<Object>((p) =>
            {
                if (SelectedItem == null) return false;
                return true;
            }, (p) => {
                var editGood = DataProvider.Ins.DB.Goods.Where(t => t.Id == SelectedItem.Id).SingleOrDefault();
                editGood.Good1 = Good1;
                editGood.NameGoo = NameGoo ;
                editGood.Producer = Producer;
                editGood.Numbers = Numbers;
                editGood.Unit = Unit;
                editGood.Warranty = Warranty;
                editGood.Statuss = Statuss;
                editGood.Id = Id;
                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.Id = Id;
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
                    DataProvider.Ins.DB.Sp_Delete_Good(SelectedItem.Id);
                    DataProvider.Ins.DB.SaveChanges();
                    ListGood.Remove(SelectedItem);
                }
            });
            ResetCommand = new RelayCommand<Object>((p) =>
            {
                return true;
            }, (p) =>
            {
                Good1 = "";
                NameGoo = "";
                Producer = "";
                Numbers = 0;
                Warranty = "";
                Unit = "";
                Statuss = "";

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
