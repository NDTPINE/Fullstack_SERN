using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace MakeWebByASP.Net.Controllers
{
    public class HelloController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        public string ChaoMung(string ten, int tuoi = 1)
        {
            return HttpUtility.HtmlEncode("Xin chào " + ten + ". Tuổi của bạn là: " + tuoi);
        }
    }
}