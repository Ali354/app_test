using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AppDbContext.Repos
{
    class OrderRepo : BaseRepo<Order>, IOrderRepo
    {
        public OrderRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
