using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AppDbContext.Repos
{
    class ValueIntRepo : BaseRepo<ValueInt>, IValueIntRepo
    {
        public ValueIntRepo(TestDbContext db) : base(db)
        {

        }
    }
}
