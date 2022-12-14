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
            Comment = new HashSet<Comment>();
            ProductAttr = new HashSet<ProductAttr>();
            ProductOrder = new HashSet<ProductOrder>();
            Rating = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }
        public int? Dicount { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<ProductAttr> ProductAttr { get; set; }
        public virtual ICollection<ProductOrder> ProductOrder { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
    }
}
