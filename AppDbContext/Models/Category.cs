using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AppDbContext.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryAttr = new HashSet<CategoryAttr>();
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CategoryAttr> CategoryAttr { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
