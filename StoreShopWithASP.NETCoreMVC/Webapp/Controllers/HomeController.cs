using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapp.Filters;
using Microsoft.AspNetCore.Mvc.Filters;
using Webapp.Models;
using Microsoft.EntityFrameworkCore;

namespace Webapp.Controllers
{
   [AutoValidateAntiforgeryToken]
   public class HomeController : Controller
    {
        private DataContext context;
        public HomeController(DataContext ct) => context = ct;
        private IEnumerable<Category> Categories => context.Categories;
        private IEnumerable<Supplier> Suppliers => context.Suppliers;
        public IActionResult Index()
        {
            return View(context.Products.Include(pr => pr.Category).Include(p => p.Supplier));
        }
        public async Task<IActionResult> Details(long id)
        {
            Product p = await context.Products.Include(p => p.Category).Include(p => p.Supplier).FirstOrDefaultAsync(p => p.ProductID == id);
            ProductViewModel model = ViewModelFactory.Details(p);
            return View("ProductEditor", model);
        }
        public IActionResult Create()
        {
            return View("ProductEditor", ViewModelFactory.Create(new Product(), Categories, Suppliers));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] Product product)
        {
            if (ModelState.IsValid)
            {
                product.ProductID = default;
                product.Category = default;
                product.Supplier = default;
                context.Products.Add(product);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("ProductEditor", ViewModelFactory.Create(product, Categories, Suppliers));
        }
        public async Task<IActionResult> Edit(long id)
        {
            Product p = await context.Products.FindAsync(id);
            ProductViewModel model = ViewModelFactory.Edit(p, Categories, Suppliers);
            return View("ProductEditor", model) ;
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromForm] Product product)
        {
            if (ModelState.IsValid)
            {
                
                product.Category = default;
                product.Supplier = default;
                context.Products.Update(product);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("ProductEditor", ViewModelFactory.Edit(product, Categories, Suppliers));
        }
        public async Task<IActionResult> Delete(long id)
        {
            Product p = await context.Products.FindAsync(id);
            ProductViewModel model = ViewModelFactory.Delete(p, Categories, Suppliers);
            return View("ProductEditor", model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Product product)
        {
            context.Products.Remove(product);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
