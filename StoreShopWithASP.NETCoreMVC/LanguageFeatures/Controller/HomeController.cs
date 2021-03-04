using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            List<string> output = new List<string>();
            foreach (long? len in await MyAsyncMethods.getPageLength(output,"amazon.com"))
            {
                output.Add($"Page length of : {len}");
            }
            return View(output);

            //long? length = await MyAsyncMethods.GetPageLength();
            //return View(new string[] { $"Length : {length}" });

            //ShoppingCart cart = new ShoppingCart(
            //new Products { Name = "A", Price = 275M },
            //new Products { Name = "B", Price = 48.95M },
            //new Products { Name = "C", Price = 19.50M },
            //new Products { Name = "D", Price = 34.95M }
            //);
            //ShoppingCart cart = new ShoppingCart { products = Products.GetProducts() };
            //bool FilterByPrice(Products p)
            //{
            //    return (p?.Price ?? 0) >= 20;
            //}
            //Func<Products, bool> nameFilter = delegate (Products products)
            //{
            //    return products?.Name?[0] == 'S';
            //};

            //decimal cartTotal = cart.Filter(FilterByPrice).TotalPrices();
            //decimal nameFilterTotal = cart.Filter(nameFilter).TotalPrices();

            //return View(cart.Products.Select(p => p.Name));
            
        }
    }
}
