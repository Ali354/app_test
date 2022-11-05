using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AppDbContext.Models
{
    public partial class Shipping
    {
        public Shipping()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
