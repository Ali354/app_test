using AppDbContext.IRepos;
using AppDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AppDbContext.Repos
{
    class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
