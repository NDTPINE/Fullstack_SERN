using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp.Controllers
{
    public class CubedController : Controller
    {
        public IActionResult Index()
        {
            return View("Cubed");
        }
        public IActionResult Cube(double number)
        {
            Value = number.ToString();
            Result = Math.Pow(number, 3).ToString();
            return RedirectToAction(nameof(Index));
        }
        [TempData]
        public string Value { get; set; }
        [TempData]
        public string Result { get; set; }
    }
}
