using QuanLyCuaHangApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangApp.Model
{
    public class InputDetail: BaseViewModel
    {
        private Input _Inputs;
        public Input Inputs { get { return _Inputs; } set { _Inputs = value; OnPropertyChanged(); } }
        private InputInfo _InputInfos;
        public InputInfo InputInfos { get { return _InputInfos; } set { _InputInfos = value; OnPropertyChanged(); } }
        private Good _Goods;
        public Good Goods { get { return _Goods; } set { _Goods = value; OnPropertyChanged(); } }
        private Staff _Staffs;
        public Staff Staffs { get { return _Staffs; } set { _Staffs = value; OnPropertyChanged(); } }
        private Suplier _Supliers;
        public Suplier Supliers { get { return _Supliers; } set { _Supliers = value; OnPropertyChanged(); }}

    }
}
