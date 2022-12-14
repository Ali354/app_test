using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppDbContext.Repos
{
    class AspNetUserRolesRepo : BaseRepo<Models.AspNetUserRoles>, IAspNetUserRolesRepo
    {
        public AspNetUserRolesRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
