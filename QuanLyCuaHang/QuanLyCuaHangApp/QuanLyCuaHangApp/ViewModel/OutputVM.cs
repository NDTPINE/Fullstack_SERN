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
    public class OutputVM: BaseViewModel
    {
        
        private ObservableCollection<Output> _ListOutput;
        public ObservableCollection<Output> ListOutput { get { return _ListOutput; } set { _ListOutput = value; OnPropertyChanged(); } }
        private ObservableCollection<OutputInfo> _ListOutputInfo;
        public ObservableCollection<OutputInfo> ListOutputInfo { get { return _ListOutputInfo; } set { _ListOutputInfo = value; OnPropertyChanged(); } }
        private ObservableCollection<Good> _ListGood;
        public ObservableCollection<Good> ListGood { get { return _ListGood; } set { _ListGood = value; OnPropertyChanged(); } }
        private ObservableCollection<Staff> _ListStaff;
        public ObservableCollection<Staff> ListStaff { get { return _ListStaff; } set { _ListStaff = value; OnPropertyChanged(); } }
        private ObservableCollection<Customer> _ListCustomer;
        public ObservableCollection<Customer> ListCustomer { get { return _ListCustomer; } set { _ListCustomer = value; OnPropertyChanged(); } }
        private ObservableCollection<OutputDetail> _ListOutputDetail;
        public ObservableCollection<OutputDetail> ListOutputDetail { get { return _ListOutputDetail; } set { _ListOutputDetail = value; OnPropertyChanged(); } }

        private OutputDetail _SelectedItem;
        public OutputDetail SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    SelectedGood = SelectedItem.Goods;
                    SelectedStaff = SelectedItem.Staffs;
                    SelectedCustomer = SelectedItem.Customers;
                    Tax = SelectedItem.OutputInfos.Tax;
                    NumberOutput = SelectedItem.OutputInfos.NumberOutput;
                    PriceOutput = SelectedItem.OutputInfos.PricesOutput;
                    Id = SelectedItem.OutputInfos.Id;
                    OutputCode = SelectedItem.Outputs.OutputCode;
                    DateOut = SelectedItem.Outputs.DateOut;
                }
            }
        }
        private Good _SelectedGood;
        public Good SelectedGood
        {
            get { return _SelectedGood; }
            set
            {
                _SelectedGood = value;
                OnPropertyChanged();
            }
        }
        private Staff _SelectedStaff;
        public Staff SelectedStaff
        {
            get { return _SelectedStaff; }
            set
            {
                _SelectedStaff = value;
                OnPropertyChanged();
            }
        }
        private Customer _SelectedCustomer;
        public Customer SelectedCustomer
        {
            get { return _SelectedCustomer; }
            set
            {
                _SelectedCustomer = value;
                OnPropertyChanged();
            }
        }
        private int _id;
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private string _OutputCode;
        public string OutputCode { get { return _OutputCode; } set { _OutputCode = value; OnPropertyChanged(); } }
        private System.DateTime _DateOut = DateTime.Today;
        public System.DateTime DateOut { get { return _DateOut; } set { _DateOut = value; OnPropertyChanged(); } }
        private int _NumberOutput;
        public int NumberOutput { get { return _NumberOutput; } set { _NumberOutput = value; OnPropertyChanged(); } }
        private float _PriceOutput;
        public float PriceOutput { get { return _PriceOutput; } set { _PriceOutput = value; OnPropertyChanged(); } }
        private float? _Tax;
        public float? Tax { get { return _Tax; } set { _Tax = value; OnPropertyChanged(); } }

        public OutputVM()
        {
            LoadListOutputDetail();
            AddCommand = new RelayCommand<object>((p) =>
            {
                if (OutputCode == null || DateOut < DateTime.Today || SelectedCustomer == null || SelectedStaff == null || SelectedGood == null)
                    return false;
                var checkOutputCode = DataProvider.Ins.DB.Outputs.Where(t => t.OutputCode == OutputCode);
                if (checkOutputCode.Count() != 0 && checkOutputCode != null) return false;
                return true;
            }, (p) =>
            {
                var listOutputDetail = new OutputDetail();
                var tempOutput = new Output();
                var tempOutputInfo = new OutputInfo();

                tempOutput.DateOut = DateOut;
                tempOutput.IdStaffs = SelectedStaff.Id;
                tempOutput.IdCustomers = SelectedCustomer.Id;
                tempOutput.OutputCode = OutputCode;

                DataProvider.Ins.DB.Outputs.Add(tempOutput);

                tempOutputInfo.NumberOutput = NumberOutput;
                tempOutputInfo.Tax = Tax;
                tempOutputInfo.PricesOutput = PriceOutput;
                tempOutputInfo.IdGood = SelectedGood.Id;
                tempOutputInfo.IdOutput = tempOutput.Id;
                DataProvider.Ins.DB.OutputInfoes.Add(tempOutputInfo);
                DataProvider.Ins.DB.SaveChanges();
                listOutputDetail.Outputs = tempOutput;
                listOutputDetail.OutputInfos = tempOutputInfo;
                listOutputDetail.Goods = SelectedGood;
                listOutputDetail.Staffs = SelectedStaff;
                listOutputDetail.Customers = SelectedCustomer;
                ListOutputDetail.Add(listOutputDetail);
            });
            EditCommand = new RelayCommand<Object>((p) =>
            {
                if (SelectedItem == null || SelectedCustomer == null || SelectedStaff == null || SelectedGood == null) return false;
                var checkOutput = DataProvider.Ins.DB.Outputs.Where(t => t.OutputCode == OutputCode);
                if (checkOutput.Count() != 0 && checkOutput != null) return false;
                return true;
            }, (p) =>
            {
                var editOutputInfoDetail = DataProvider.Ins.DB.OutputInfoes.Where(t => t.Id == SelectedItem.OutputInfos.Id).SingleOrDefault();
                editOutputInfoDetail.NumberOutput = NumberOutput;
                editOutputInfoDetail.Tax = Tax;
                editOutputInfoDetail.PricesOutput = PriceOutput;
                editOutputInfoDetail.IdGood = SelectedGood.Id;

                var editOutputDetail = DataProvider.Ins.DB.Outputs.Where(t => t.Id == SelectedItem.Outputs.Id && t.OutputCode == SelectedItem.Outputs.OutputCode).SingleOrDefault();
                editOutputDetail.IdStaffs = SelectedStaff.Id;
                editOutputDetail.IdCustomers = SelectedCustomer.Id;
                editOutputDetail.OutputCode = OutputCode;
                editOutputDetail.DateOut = DateOut;
                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.OutputInfos.Id = Id;
                LoadListOutputDetail();
            });
            //Command Detele IS OK
            DeleteCommand = new RelayCommand<Object>((p) =>
            {
                if (SelectedItem == null) return false;
                return true;
            }, (p) =>
            {
                var checkOK = System.Windows.MessageBox.Show("Bạn có chắc muốn xoá", "Thông báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.OK);
                if ((int)checkOK == 1)
                {
                    DataProvider.Ins.DB.Sp_Delete_OutputInfo(SelectedItem.OutputInfos.Id);
                    DataProvider.Ins.DB.Sp_Delete_Output(SelectedItem.Outputs.Id);
                    DataProvider.Ins.DB.SaveChanges();
                    LoadListOutputDetail();
                }
            });
            ResetCommand = new RelayCommand<Object>((p) =>
            {
                return true;
            }, (p) =>
            {
                SelectedStaff = null;
                SelectedCustomer = null;
                SelectedGood = null;
                Tax = 0;
                NumberOutput = 0;
                OutputCode = "";
                PriceOutput = 0;
                DateOut = DateTime.Now;
            });
        }
        void LoadListOutputDetail()
        {
            ListOutput = new ObservableCollection<Output>(DataProvider.Ins.DB.Outputs);
            ListOutputInfo = new ObservableCollection<OutputInfo>(DataProvider.Ins.DB.OutputInfoes);
            ListGood = new ObservableCollection<Good>(DataProvider.Ins.DB.Goods);
            ListStaff = new ObservableCollection<Staff>(DataProvider.Ins.DB.Staffs);
            ListCustomer = new ObservableCollection<Customer>(DataProvider.Ins.DB.Customers);
            ListOutputDetail = new ObservableCollection<OutputDetail>();
            foreach (var temp in ListOutputInfo)
            {
                var loadOutput = DataProvider.Ins.DB.Outputs.Where(t => t.Id == temp.IdOutput).SingleOrDefault();
                var loadGood = DataProvider.Ins.DB.Goods.Where(t => t.Id == temp.IdGood).SingleOrDefault();
                var loadStaff = DataProvider.Ins.DB.Staffs.Where(t => t.Id == loadOutput.IdStaffs).SingleOrDefault();
                var loadCustomer = DataProvider.Ins.DB.Customers.Where(t => t.Id == loadOutput.IdCustomers).SingleOrDefault();
                var loadlist = new OutputDetail();
                loadlist.OutputInfos = temp;
                loadlist.Outputs = loadOutput;
                loadlist.Goods = loadGood;
                loadlist.Staffs = loadStaff;
                loadlist.Customers = loadCustomer;
                ListOutputDetail.Add(loadlist);
            }
        }
        #region Command
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand ResetCommand { get; set; }

        #endregion
    }
}
