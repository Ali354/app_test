using AppDbContext.Models;
using AppDbContext.IRepos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppDbContext.Repos
{
    class CategoryAttrRepo :BaseRepo<Models.CategoryAttr>, ICategoryAttrRepo
    {
        public CategoryAttrRepo(ECOMMERCEContext db) : base(db)
    {

    }
}
}
