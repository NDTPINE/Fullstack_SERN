using QuanLyCuaHangApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyCuaHangApp.Model
{
    public class ListMain : BaseViewModel
    {
        public string Maphieu { get; set; }
        public string Tenhang { get; set; }
        public int Soluong { get; set; }
        public float Gia { get; set; }
        public float? Thue { get; set; }
        public float? Thanhtien { get; set; }
    }
}
