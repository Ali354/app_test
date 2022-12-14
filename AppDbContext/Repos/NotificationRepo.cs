using AppDbContext.Models;
using AppDbContext.IRepos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppDbContext.Repos
{
    class NotificationRepo : BaseRepo<Models.Notification>, INotificationRepo
    {
        public NotificationRepo(ECOMMERCEContext db) : base(db)
        {

        }
    }
}
