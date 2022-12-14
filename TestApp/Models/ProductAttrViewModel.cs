using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class ProductAttrViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AttrId { get; set; }
        public int ValueId { get; set; }
        public int UnitId { get; set; }

        public virtual AppDbContext.Models.Attribute Attr { get; set; }
        public virtual Product Product { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ValueAttr Value { get; set; }
    }
}
