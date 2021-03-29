using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View("Message", "This is the Index action on the Home Controller");
        }
        public IActionResult Secure()
        {
            return View("Message", "This is  the Secure action on the Home Controller");
        }
    }
}
