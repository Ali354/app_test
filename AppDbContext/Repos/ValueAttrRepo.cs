using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AppDbContext.Repos
{
    class ValueAttrRepo : BaseRepo<ValueAttr>, IValueAttrRepo
    {
        public ValueAttrRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
