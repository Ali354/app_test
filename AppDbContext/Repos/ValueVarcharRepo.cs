using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AppDbContext.Repos
{
    class ValueVarcharRepo : BaseRepo<ValueVarchar>, IValueVarcharRepo
    {
        public ValueVarcharRepo(TestDbContext db) : base(db)
        {

        }
    }
}
