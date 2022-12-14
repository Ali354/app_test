using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AppDbContext.Repos
{
    class UnitRepo : BaseRepo<Unit>, IUnitRepo
    {
        public UnitRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
