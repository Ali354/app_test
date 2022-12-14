using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppDbContext.Repos
{
    class AspNetUserLoginsRepo : BaseRepo<Models.AspNetUserLogins>, IAspNetUserLoginsRepo
    {
        public AspNetUserLoginsRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
