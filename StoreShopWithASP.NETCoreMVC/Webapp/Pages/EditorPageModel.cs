using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapp.Models;

namespace Webapp.Pages
{
    public class EditorPageModel : PageModel
    {
        public DataContext context { get; set; }
        public EditorPageModel(DataContext ct) => context = ct;
        public IEnumerable<Category> Categories => context.Categories;
        public IEnumerable<Supplier> Suppliers => context.Suppliers;
        public ProductViewModel ViewModel { get; set; }

        protected async Task CheckNewCategory(Product product)
        {
            if (product.CategoryID == -1 && !string.IsNullOrEmpty(product.Category?.Name))
            {
                context.Categories.Add(product.Category);
                await context.SaveChangesAsync();
                product.CategoryID = product.Category.CategoryID;
                ModelState.Clear();
                TryValidateModel(product);
            }
        }
    }
}
