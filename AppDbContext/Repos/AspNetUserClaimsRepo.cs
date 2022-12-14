using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppDbContext.Repos
{
    class AspNetUserClaimsRepo : BaseRepo<Models.AspNetUserClaims>, IAspNetUserClaimsRepo
    {
        public AspNetUserClaimsRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
