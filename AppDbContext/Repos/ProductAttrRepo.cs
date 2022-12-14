using AppDbContext.Models;
using AppDbContext.IRepos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppDbContext.Repos
{
    class ProductAttrRepo : BaseRepo<Models.ProductAttr>, IProductAttrRepo
    {
        public ProductAttrRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
