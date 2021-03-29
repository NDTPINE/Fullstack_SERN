using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Webapp.Validation;
using Microsoft.AspNetCore.Mvc;

namespace Webapp.Models
{
    [PhraseAndPrice(Phrase ="Small",Price ="100")]
    public class Product
    {        
        public long ProductID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        //[DisplayFormat(DataFormatString="{0:c2}",ApplyFormatInEditMode =true)]
        [Required(ErrorMessage ="Please enter a price")]
        [Range(1,999999, ErrorMessage ="Please enter a positive price")]
        public decimal Price { get; set; }
        [PrimaryKey(ContextType = typeof(DataContext), DataType=typeof(Category))]
        [Remote("CategoryKey", "Validation", ErrorMessage ="Enter an existing key")]
        public long CategoryID { get; set; }
        public Category Category { get; set; }
        [Remote("SupplierKey", "Validation", ErrorMessage ="Enter a existing key")]
        public long SupplierID { get; set; }
        public Supplier Supplier { get; set; }
    }
}
