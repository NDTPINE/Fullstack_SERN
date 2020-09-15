using QuanLyCuaHangApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Microsoft.Reporting.WinForms;
using QuanLyCuaHangApp.View;
using System.Windows;
using System.Windows.Forms;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace QuanLyCuaHangApp.ViewModel
{
    public class ReportVM : BaseViewModel
    {
        private ReportViewer _ReportViewerDemo;
        public ReportViewer ReportViewerDemo { get { return _ReportViewerDemo; } set { _ReportViewerDemo = value; } }
        private DateTime dateTo = DateTime.Now;
        public DateTime DateTo { get { return dateTo; } set { dateTo = value; } }
        private DateTime dateFrom = DateTime.Now;
        public DateTime DateFrom { get { return dateFrom; } set { dateFrom = value; } }
        public ICommand ReportCommand { get; set; }
        public ReportVM()
        {
            ReportCommand = new RelayCommand<System.Windows.Controls.Button>((p) => { return true; }, (p) => {
                ReportViewerDemo = new ReportViewer();
                ReportViewerDemo.Reset();
                DataTable dt = GetData(DateFrom,DateTo);

                ReportDataSource ds = new ReportDataSource("DataSet1", dt);
                ReportViewerDemo.LocalReport.DataSources.Add(ds);

                ReportViewerDemo.LocalReport.ReportEmbeddedResource = "Report1.rdlc";
                ReportViewerDemo.RefreshReport();
            });
        }

        private DataTable GetData(DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();
            var temp = DataProvider.Ins.DB.v_ListInput.ToList();
            dt.Columns.Add("MaPhieunhap");
            dt.Columns.Add("Ngaynhap");
            dt.Columns.Add("Mahang");
            dt.Columns.Add("Tenhang");
            dt.Columns.Add("Soluong");
            dt.Columns.Add("Dongia");
            dt.Columns.Add("Thue");
            dt.Columns.Add("Thanhtien");
            foreach (var row in temp)
            {
                DataRow rows = dt.NewRow();
                rows["MaPhieunhap"] = row.Maphieunhap;
                rows["Ngaynhap"] = row.Ngaynhap;
                rows["Mahang"] = row.Mahang;
                rows["Tenhang"] = row.Tenhang;
                rows["Soluong"] = row.Soluongnhap;
                rows["Dongia"] = row.Dongianhap;
                rows["Thue"] = row.Thue;
                rows["Thanhtien"] = row.Thanhtien;
                dt.Rows.Add(rows);
            }
            return dt;
        }
    }
}
