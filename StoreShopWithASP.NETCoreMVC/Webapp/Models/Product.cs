using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Webapp.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        //[DisplayFormat(DataFormatString="{0:c2}",ApplyFormatInEditMode =true)]
        public decimal Price { get; set; }

        public long CategoryID { get; set; }
        public Category Category { get; set; }

        public long SupplierID { get; set; }
        public Supplier Supplier { get; set; }
    }
}
