using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppDbContext.Repos
{
    class AttributeRepo : BaseRepo<Models.Attribute>, IAttributeRepo
    {
        public AttributeRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
