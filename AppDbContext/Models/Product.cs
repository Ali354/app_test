using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AppDbContext.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductOrder = new HashSet<ProductOrder>();
            ValueDate = new HashSet<ValueDate>();
            ValueInt = new HashSet<ValueInt>();
            ValueVarchar = new HashSet<ValueVarchar>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<ProductOrder> ProductOrder { get; set; }
        public virtual ICollection<ValueDate> ValueDate { get; set; }
        public virtual ICollection<ValueInt> ValueInt { get; set; }
        public virtual ICollection<ValueVarchar> ValueVarchar { get; set; }
    }
}
