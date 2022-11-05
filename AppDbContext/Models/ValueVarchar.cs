﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AppDbContext.Models
{
    public partial class ValueVarchar
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int AttributeId { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
