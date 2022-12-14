using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppDbContext.Repos
{
    class AspNetUserTokensRepo : BaseRepo<Models.AspNetUserTokens>, IAspNetUserTokensRepo
    {
        public AspNetUserTokensRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
