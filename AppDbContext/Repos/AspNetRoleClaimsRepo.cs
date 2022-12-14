using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppDbContext.Repos
{
    class AspNetRoleClaimsRepo : BaseRepo<Models.AspNetRoleClaims>, IAspNetRoleClaimsRepo
    {
        public AspNetRoleClaimsRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
