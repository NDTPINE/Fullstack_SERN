using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapp.Models;

namespace Webapp.Components
{
    public class CitySummary : ViewComponent
    {
        private CitiesData data;
        public CitySummary(CitiesData ct) => data = ct;

        public IViewComponentResult Invoke()
        {
            return View(new CityViewModel
            {
                Cities = data.Cities.Count(),
                Population = data.Cities.Sum(c => c.Population)
            });
        }
    }
}
