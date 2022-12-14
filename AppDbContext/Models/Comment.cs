using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AppDbContext.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProdutId { get; set; }
        public string Comment1 { get; set; }

        public virtual Product Produt { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
