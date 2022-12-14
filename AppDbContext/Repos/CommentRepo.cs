using AppDbContext.Models;
using AppDbContext.IRepos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppDbContext.Repos
{
    class CommentRepo : BaseRepo<Models.Comment>, ICommentRepo
    {
        public CommentRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}