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
    public class StaffVM : BaseViewModel
    {
        private ObservableCollection<Staff> _ListStaff;
        public ObservableCollection<Staff> ListStaff { get { return _ListStaff; } set { _ListStaff = value; OnPropertyChanged(); } }
        private Staff _SelectedItemSta;
        public Staff SelectedItemSta
        {
            get { return _SelectedItemSta; }
            set
            {
                _SelectedItemSta = value;
                OnPropertyChanged();
                if (SelectedItemSta != null)
                {
                    ID = SelectedItemSta.Id;
                    Staff1 = SelectedItemSta.Staff1;
                    NameSta = SelectedItemSta.NameSta;
                    YearBirth = SelectedItemSta.YearBirth;
                    Sex = SelectedItemSta.Sex;
                    AddressSta = SelectedItemSta.AddressSta;
                    Phone = SelectedItemSta.Phone;
                    Position = SelectedItemSta.Position;
                    Salary = SelectedItemSta.Salary;
                }
            }
        }

        private int _id;
        public int ID { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private int _yearBirth;
        public int YearBirth { get { return _yearBirth; } set { _yearBirth = value; OnPropertyChanged(); } }
        private string _Staff1;
        public string Staff1 { get { return _Staff1; } set { _Staff1 = value; OnPropertyChanged(); } }
        private string _NameSta;
        public string NameSta { get { return _NameSta; } set { _NameSta = value; OnPropertyChanged(); } }
        private string _sex;
        public string Sex { get { return _sex; } set { _sex = value; OnPropertyChanged(); } }
        private string _AddressSta;
        public string AddressSta { get { return _AddressSta; } set { _AddressSta = value; OnPropertyChanged(); } }
        private string _Phone;
        public string Phone { get { return _Phone; } set { _Phone = value; OnPropertyChanged(); } }
        private string _Position;
        public string Position { get { return _Position; } set { _Position = value; OnPropertyChanged(); } }
        private string _Email;
        public string Email { get { return _Email; } set { _Email = value; OnPropertyChanged(); } }
        private int? _salary;
        public int? Salary { get { return _salary; } set { _salary = value; OnPropertyChanged(); } }
        public StaffVM()
        {
            ListStaff = new ObservableCollection<Staff>(DataProvider.Ins.DB.Staffs);

            AddCommand = new RelayCommand<Object>((p) =>
            {
                if (string.IsNullOrEmpty(Staff1) || string.IsNullOrEmpty(NameSta) || YearBirth < 0 || string.IsNullOrEmpty(Sex) || string.IsNullOrEmpty(Position) || Salary < 0 ) return false;
                var staffList = DataProvider.Ins.DB.Staffs.Where(x => x.Staff1 == Staff1);
                if (staffList == null || staffList.Count() != 0) return false;
                return true;
            }, (p) => {
                var staff = new Staff() { Staff1 = Staff1, NameSta = NameSta, YearBirth = YearBirth, Sex = Sex, AddressSta = AddressSta, Phone = Phone, Position = Position, Email = Email, Salary = Salary};
                DataProvider.Ins.DB.Staffs.Add(staff);
                DataProvider.Ins.DB.SaveChanges();
                ListStaff.Add(staff);
            });
            EditCommand = new RelayCommand<Object>((p) =>
            {
                if (SelectedItemSta == null) return false;
                return true;
            }, (p) => {
                DataProvider.Ins.DB.Sp_Update_Staff(ID, Staff1, NameSta, YearBirth, Sex, AddressSta, Phone, Position,Email, Salary);
                DataProvider.Ins.DB.SaveChanges();
                SelectedItemSta.Id = ID;
            });
            //Command Detele IS OK
            DeleteCommand = new RelayCommand<Object>((p) =>
            {
                if (SelectedItemSta == null) return false;
                return true;
            }, (p) =>
            {
                var checkOK = MessageBox.Show("Bạn có chắc muốn xoá", "Thông báo", MessageBoxButton.OKCancel,MessageBoxImage.Warning,MessageBoxResult.OK);
                if ((int)checkOK == 1)
                {
                    DataProvider.Ins.DB.Sp_Delete_Staff(SelectedItemSta.Id);
                    DataProvider.Ins.DB.SaveChanges();
                    ListStaff.Remove(SelectedItemSta);
                }
            });
            ResetCommand = new RelayCommand<Object>((p) =>
            {
                return true;
            }, (p) =>
            {
                Staff1 = "";
                NameSta = "";
                YearBirth = 0;
                Sex = "";
                AddressSta = "";
                Phone = "";
                Position = "";
                Salary = 0;
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
