using Microsoft.VisualStudio.Services.Common;
using QuanLyCuaHangApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.TextFormatting;

namespace QuanLyCuaHangApp.ViewModel
{
    public class InputVM : BaseViewModel
    {
        
        private ObservableCollection<Input> _ListInput;
        public ObservableCollection<Input> ListInput { get { return _ListInput; } set { _ListInput = value; OnPropertyChanged(); } }
        private ObservableCollection<InputInfo> _ListInputInfo;
        public ObservableCollection<InputInfo> ListInputInfo { get { return _ListInputInfo; } set { _ListInputInfo = value; OnPropertyChanged(); } }
        private ObservableCollection<Good> _ListGood;
        public ObservableCollection<Good> ListGood { get { return _ListGood; } set { _ListGood = value; OnPropertyChanged(); } }
        private ObservableCollection<Staff> _ListStaff;
        public ObservableCollection<Staff> ListStaff { get { return _ListStaff; } set { _ListStaff = value; OnPropertyChanged(); } }
        private ObservableCollection<Suplier> _ListSuplier;
        public ObservableCollection<Suplier> ListSuplier { get { return _ListSuplier; } set { _ListSuplier = value; OnPropertyChanged(); } }
        private ObservableCollection<InputDetail> _ListInputDetail;
        public ObservableCollection<InputDetail> ListInputDetail { get { return _ListInputDetail; } set { _ListInputDetail = value; OnPropertyChanged(); } }

        private InputDetail _SelectedItem;
        public InputDetail SelectedItem
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
                    SelectedSuplier = SelectedItem.Supliers;
                    Tax = SelectedItem.InputInfos.Tax;
                    NumberInput = SelectedItem.InputInfos.NumberInput;
                    PriceInput = SelectedItem.InputInfos.PricesInput;
                    Id = SelectedItem.InputInfos.Id;
                    InputCode = SelectedItem.Inputs.InputCode;
                    DateIn = SelectedItem.Inputs.DateIn;
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
        private Suplier _SelectedSuplier;
        public Suplier SelectedSuplier
        {
            get { return _SelectedSuplier; }
            set
            {
                _SelectedSuplier = value;
                OnPropertyChanged();
            }
        }
        private int _id;
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private string _InputCode;
        public string InputCode { get { return _InputCode; } set { _InputCode = value; OnPropertyChanged(); } }
        private System.DateTime _DateIn = DateTime.Now;
        public System.DateTime DateIn { get { return _DateIn; } set { _DateIn = value; OnPropertyChanged(); } }
        private int _NumberInput;
        public int NumberInput { get { return _NumberInput; } set { _NumberInput = value; OnPropertyChanged(); } }
        private float _PriceInput;
        public float PriceInput { get { return _PriceInput; } set { _PriceInput = value; OnPropertyChanged(); } }
        private float? _Tax;
        public float? Tax { get { return _Tax; } set { _Tax = value; OnPropertyChanged(); } }

        public InputVM()
        {
            LoadListInputDetail();
            AddCommand = new RelayCommand<object>((p) =>
            {
                if (InputCode == null||DateIn < DateTime.Today || SelectedSuplier == null || SelectedStaff == null || SelectedGood == null)
                    return false;
                var checkinputcode = DataProvider.Ins.DB.Inputs.Where(t => t.InputCode == InputCode);
                if (checkinputcode.Count() != 0 && checkinputcode != null) return false;
                return true;
            }, (p) =>
            {
                var listinputdetail = new InputDetail();
                var tempinput = new Input();
                var tempinputinfo = new InputInfo();
                                
                tempinput.DateIn = DateIn;
                tempinput.IdStaffs = SelectedStaff.Id;
                tempinput.IdSupliers = SelectedSuplier.Id;
                tempinput.InputCode = InputCode;
                
                DataProvider.Ins.DB.Inputs.Add(tempinput);
                
                tempinputinfo.NumberInput = NumberInput;
                tempinputinfo.Tax = Tax;
                tempinputinfo.PricesInput = PriceInput;
                tempinputinfo.IdGood = SelectedGood.Id;
                tempinputinfo.IdInput = tempinput.Id;
                DataProvider.Ins.DB.InputInfoes.Add(tempinputinfo);
                DataProvider.Ins.DB.SaveChanges();
                listinputdetail.Inputs = tempinput;
                listinputdetail.InputInfos = tempinputinfo;
                listinputdetail.Goods = SelectedGood;
                listinputdetail.Staffs = SelectedStaff;
                listinputdetail.Supliers = SelectedSuplier;
                ListInputDetail.Add(listinputdetail);
            });
            EditCommand = new RelayCommand<Object>((p) =>
            {
                if (SelectedItem == null || SelectedSuplier == null || SelectedStaff == null || SelectedGood == null) return false;
                var checkinputcode = DataProvider.Ins.DB.Inputs.Where(t => t.InputCode == InputCode);
                if (checkinputcode.Count() != 0 && checkinputcode != null) return false;
                return true;
            }, (p) => {
                var editInputInfoDetail = DataProvider.Ins.DB.InputInfoes.Where(t => t.Id == SelectedItem.InputInfos.Id).SingleOrDefault();
                editInputInfoDetail.NumberInput = NumberInput;
                editInputInfoDetail.Tax = Tax;
                editInputInfoDetail.PricesInput = PriceInput;
                editInputInfoDetail.IdGood = SelectedGood.Id;

                var editInputDetail = DataProvider.Ins.DB.Inputs.Where(t => t.Id == SelectedItem.Inputs.Id && t.InputCode == SelectedItem.Inputs.InputCode).SingleOrDefault();
                editInputDetail.IdStaffs = SelectedStaff.Id;
                editInputDetail.IdSupliers = SelectedSuplier.Id;
                editInputDetail.InputCode = InputCode;
                editInputDetail.DateIn = DateIn;
                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.InputInfos.Id = Id;
                LoadListInputDetail();
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
                    DataProvider.Ins.DB.Sp_Delete_InputInfo(SelectedItem.InputInfos.Id);
                    DataProvider.Ins.DB.Sp_Delete_Input(SelectedItem.Inputs.Id);
                    DataProvider.Ins.DB.SaveChanges();
                    LoadListInputDetail();
                }
            });
            ResetCommand = new RelayCommand<Object>((p) =>
            {
                return true;
            }, (p) =>
            {
                SelectedStaff = null;
                SelectedSuplier = null;
                SelectedGood = null;
                Tax = 0;
                NumberInput = 0;
                InputCode = "";
                PriceInput = 0;
                DateIn = DateTime.Now;
            });
        }
        void LoadListInputDetail()
        {
            ListInput = new ObservableCollection<Input>(DataProvider.Ins.DB.Inputs);
            ListInputInfo = new ObservableCollection<InputInfo>(DataProvider.Ins.DB.InputInfoes);
            ListGood = new ObservableCollection<Good>(DataProvider.Ins.DB.Goods);
            ListStaff = new ObservableCollection<Staff>(DataProvider.Ins.DB.Staffs);
            ListSuplier = new ObservableCollection<Suplier>(DataProvider.Ins.DB.Supliers);
            ListInputDetail = new ObservableCollection<InputDetail>();
            foreach (var temp in ListInputInfo)
            {
                var loadInput = DataProvider.Ins.DB.Inputs.Where(t => t.Id == temp.IdInput).SingleOrDefault();
                var loadGood = DataProvider.Ins.DB.Goods.Where(t => t.Id == temp.IdGood).SingleOrDefault();
                var loadStaff = DataProvider.Ins.DB.Staffs.Where(t => t.Id == loadInput.IdStaffs).SingleOrDefault();
                var loadSuplier = DataProvider.Ins.DB.Supliers.Where(t => t.Id == loadInput.IdSupliers).SingleOrDefault();
                var loadlist = new InputDetail();
                loadlist.InputInfos = temp;
                loadlist.Inputs = loadInput;
                loadlist.Goods = loadGood;
                loadlist.Staffs = loadStaff;
                loadlist.Supliers = loadSuplier;
                ListInputDetail.Add(loadlist);
            }
        }
        #region Command
        public ICommand AddCommand{ get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand ResetCommand { get; set; }


        #endregion
    }
}
