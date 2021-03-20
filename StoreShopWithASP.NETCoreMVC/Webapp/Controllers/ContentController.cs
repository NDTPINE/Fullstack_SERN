using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webapp.Models;

namespace Webapp.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class ContentController : ControllerBase
    {
        private DataContext context;
        public ContentController( DataContext ctx)
        {
            context = ctx;
        }
        [HttpGet("string")]
        public string GetString() => "This is a string Response";
        [HttpGet("object/{format?}")]
        [FormatFilter]
        [Produces("application/json","application/xml")]

        public async Task<ProductBindingTarget> GetObject()
        {
            Product pro = await context.Products.FirstAsync();
            return new ProductBindingTarget()
            {
                Name = pro.Name,
                Price = pro.Price,
                CategoryID = pro.CategoryID,
                SupplierID = pro.SupplierID
            };
        }
        [HttpPost]
        [Consumes("application/json")]
        public string SaveProductJson(ProductBindingTarget product)
        {
            return $"JSON: {product.Name}";
        }
        //[HttpPost]
        //[Consumes("application/xml")]
        //public string SaveProductXml(ProductBindingTarget product)
        //{
        //    return $"XML: {product.Name}";
        //}
    }
}
