using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AppDbContext.Models
{
    public partial class ProductAttr
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AttrId { get; set; }
        public int ValueId { get; set; }
        public int UnitId { get; set; }

        public virtual Attribute Attr { get; set; }
        public virtual Product Product { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ValueAttr Value { get; set; }
    }
}
