using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AppDbContext.Models
{
    public partial class Order
    {
        public Order()
        {
            ProductOrder = new HashSet<ProductOrder>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public byte IsPaid { get; set; }
        public int ShippingId { get; set; }
        public int Price { get; set; }
        public string State { get; set; }

        public virtual Shipping Shipping { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<ProductOrder> ProductOrder { get; set; }
    }
}
