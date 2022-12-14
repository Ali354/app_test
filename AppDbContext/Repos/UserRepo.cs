using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AppDbContext.Repos
{
    class UserRepo : BaseRepo<AspNetUsers>, IUserRepo
    {
        public UserRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
