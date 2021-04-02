using Advanced.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advanced.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;
        public HomeController(DataContext ct) => context = ct;
        public IActionResult Index([FromQuery] string selectedCity)
        {
            return View(new PeopleListViewModel
            {
                People = context.People.Include(p => p.Department).Include(p => p.Location),
                Cities = context.Locations.Select(l => l.City).Distinct(),
                SelectedCity = selectedCity
            }) ;
        }
    }
    public class PeopleListViewModel
    {
        public IEnumerable<Person> People { get; set; }
        public IEnumerable<string> Cities { get; set; }
        public string SelectedCity { get; set; }
        public string GetClass(string city) => SelectedCity == city ? "bg-info text-white" : "";
    }
}
