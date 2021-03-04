using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VideoOnDemand.UI.Models;
using VideoOnDemand.Data.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace VideoOnDemand.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //if (!_signInManager.IsSignedIn(User))
            //   return RedirectToAction("Login", "Account");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //private SignInManager<User> _signInManager;

        //public HomeController(SignInManager<User> signInMgr)
        //{
        //    _signInManager = signInMgr;
        //}

    }
}
