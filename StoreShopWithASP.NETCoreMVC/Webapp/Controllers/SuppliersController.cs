using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.JsonPatch;


namespace Webapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuppliersController : ControllerBase
    {
        private DataContext context;
        public SuppliersController(DataContext ctx)
        {
            context = ctx;
        }
        [HttpGet("{id}")]
        public async Task<Supplier> GetSupplier(long id)
        {
            Supplier supplier =  await context.Suppliers.Include(s => s.Products).FirstAsync(s => s.SupplierID == id);
            foreach (Product pro in supplier.Products)
            {
                pro.Supplier = null;
            }
            return supplier;
        }
        [HttpPatch("{id}")]
        public async Task<Supplier> PatchSupplier(long id, JsonPatchDocument<Supplier> patchDocument)
        {
            Supplier supplier = await context.Suppliers.FindAsync(id);
            if (supplier != null)
            {
                patchDocument.ApplyTo(supplier);
                await context.SaveChangesAsync();
            }
            return supplier;
        }

    }
}
