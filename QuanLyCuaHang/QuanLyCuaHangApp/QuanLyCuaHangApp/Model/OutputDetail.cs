using QuanLyCuaHangApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangApp.Model
{
    public class OutputDetail : BaseViewModel
    {
        private Output _Outputs;
        public Output Outputs { get { return _Outputs; } set { _Outputs = value; OnPropertyChanged(); } }
        private OutputInfo _OutputInfos;
        public OutputInfo OutputInfos { get { return _OutputInfos; } set { _OutputInfos = value; OnPropertyChanged(); } }
        private Good _Goods;
        public Good Goods { get { return _Goods; } set { _Goods = value; OnPropertyChanged(); } }
        private Staff _Staffs;
        public Staff Staffs { get { return _Staffs; } set { _Staffs = value; OnPropertyChanged(); } }
        private Customer _Customers;
        public Customer Customers { get { return _Customers; } set { _Customers = value; OnPropertyChanged(); } }
    }
}
