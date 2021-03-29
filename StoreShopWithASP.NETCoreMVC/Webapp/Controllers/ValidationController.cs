using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapp.Models;

namespace Webapp.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ValidationController : ControllerBase
    {
        private DataContext context;
        public ValidationController(DataContext ct) => context = ct;
        [HttpGet]
        public bool CategoryKey(string categoryID, [FromQuery] KeyTarget target)
        {
            long keyVal;
            return long.TryParse(categoryID ?? target.CategoryID, out keyVal) && context.Categories.Find(keyVal) != null;
        }
        [HttpGet]
        public bool SupplierKey(string supplierID, [FromQuery] KeyTarget target)
        {
            long keyVal;
            return long.TryParse(supplierID ?? target.SupplierID, out keyVal) && context.Suppliers.Find(keyVal) != null;
        }
    }
    [Bind(Prefix = "Product")]
    public class KeyTarget
    {
        public string CategoryID { get; set; }
        public string SupplierID { get; set; }
    }
}
