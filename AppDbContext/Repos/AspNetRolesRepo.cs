using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppDbContext.Repos
{
    class AspNetRolesRepo : BaseRepo<Models.AspNetRoles>, IAspNetRolesRepo
    {
        public AspNetRolesRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
