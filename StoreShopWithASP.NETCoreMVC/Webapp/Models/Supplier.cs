using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp.Models
{
    public class Supplier
    {
        public long SupplierID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
