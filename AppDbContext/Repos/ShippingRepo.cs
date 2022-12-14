using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AppDbContext.Repos
{
    class ShippingRepo : BaseRepo<Shipping>, IShippingRepo
    {
        public ShippingRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
