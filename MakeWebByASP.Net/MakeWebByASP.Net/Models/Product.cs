//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MakeWebByASP.Net.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public Nullable<double> Price { get; set; }
        public string Image { get; set; }
        public Nullable<double> PriceNew { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Orders { get; set; }
        public Nullable<int> Statuss { get; set; }
        public Nullable<int> GroupProductID { get; set; }
    
        public virtual GroupProduct GroupProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
