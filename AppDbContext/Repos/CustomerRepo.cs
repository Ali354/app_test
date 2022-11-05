using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AppDbContext.Repos
{
    class CustomerRepo : BaseRepo<Customer>, ICustomerRepo
    {
        public CustomerRepo(TestDbContext db) : base(db)
        {

        }
    }
}
