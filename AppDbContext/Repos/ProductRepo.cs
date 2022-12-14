using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AppDbContext.Repos
{
    class ProductRepo : BaseRepo<Product>, IProductRepo
    {
        public ProductRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
