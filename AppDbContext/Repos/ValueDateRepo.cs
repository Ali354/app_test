using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AppDbContext.Repos
{
    class ValueDateRepo : BaseRepo<ValueDate>, IValueDateRepo
    {
        public ValueDateRepo(TestDbContext db) : base(db)
        {

        }
    }
}
