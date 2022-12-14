using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class CategoryAttrViewModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AttrId { get; set; }
        public int ValueId { get; set; }
        public int UnitId { get; set; }

        public virtual AppDbContext.Models.Attribute Attr { get; set; }
        public virtual CategoryViewModel Category { get; set; }
        public virtual UnitViewModel Unit { get; set; }
        public virtual ValueAttrViewModel Value { get; set; }
    }
}
