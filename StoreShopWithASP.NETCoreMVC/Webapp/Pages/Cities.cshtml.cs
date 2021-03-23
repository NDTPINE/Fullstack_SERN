using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Webapp.Models;

namespace Webapp.Pages
{
    [ViewComponent(Name ="CitiesPageHybrid")]
    public class CitiesModel : PageModel
    {
        public CitiesData Data { get; set; }
        public CitiesModel(CitiesData data) => Data = data;
        [ViewComponentContext]
        public ViewComponentContext Context { get; set; }

        public IViewComponentResult Invoke()
        {
            return new ViewViewComponentResult()
            {
                ViewData = new ViewDataDictionary<CityViewModel>(
                    Context.ViewData, new CityViewModel
                    {
                        Cities = Data.Cities.Count(),
                        Population = Data.Cities.Sum(c => c.Population)
                    })
            };
        }
    }
}
