using AppDbContext.Models;
using AppDbContext.IRepos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppDbContext.Repos
{
    class RatingRepo : BaseRepo<Models.Rating>, IRatingRepo
    {
        public RatingRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
