using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapp.Models;

namespace Webapp.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class FormController : Controller
    {
        private DataContext context;
        public FormController(DataContext datacontext) => context = datacontext;
        public async Task<IActionResult> Index(long? id = 1)
        {
            ViewBag.Categories = new SelectList(context.Categories, "CategoryID", "Name");
            return View("Form", await context.Products.Include(p => p.Category)
                .Include(p => p.Supplier).FirstOrDefaultAsync(o => o.ProductID == id || id == null));
        }
        [HttpPost]
        public IActionResult SubmitForm([Bind("Name", "Category")] Product product)
        {
            TempData["name"] = product.Name;
            TempData["price"] = product.Price.ToString();
            TempData["category name"] = product.Category.Name;
            return RedirectToAction(nameof(Results));
        }
        public IActionResult Results()
        {
            return View(TempData);
        }
    }
}
