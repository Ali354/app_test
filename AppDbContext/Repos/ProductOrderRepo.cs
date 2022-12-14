using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AppDbContext.Repos
{
    class ProductOrderRepo : BaseRepo<ProductOrder>, IProductOrderRepo
    {
        public ProductOrderRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
