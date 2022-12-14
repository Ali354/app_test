using AppDbContext.IRepos;
using AppDbContext.Models;
using AppDbContext.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppDbContext.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAspNetRoleClaimsRepo AspNetRoleClaimsRepo { get; set; }
        public IAspNetRolesRepo AspNetRolesRepo { get; set; }
        public IAspNetUserClaimsRepo AspNetUserClaimsRepo { get; set; }
        public IAspNetUserLoginsRepo AspNetUserLoginsRepo { get; set; }
        public IAspNetUserRolesRepo AspNetUserRolesRepo { get; set; }
        public IAspNetUserTokensRepo AspNetUserTokensRepo { get; set; }
        public IAttributeRepo AttributeRepo { get; set; }
        public ICategoryAttrRepo CategoryAttrRepo { get; set; }
        public ICategoryRepo CategoryRepo { get; set; }
        public ICommentRepo CommentRepo { get; set; }
        public INotificationRepo NotificationRepo { get; set; }
        public IOrderRepo OrderRepo { get; set; }
        public IProductAttrRepo ProductAttrRepo { get; set; }
        public IProductOrderRepo ProductOrderRepo { get; set; }
        public IProductRepo ProductRepo { get; set; }
        public IRatingRepo RatingRepo { get; set; }
        public IShippingRepo ShippingRepo { get; set; }
        public IUserRepo UserRepo { get; set; }
        public IValueAttrRepo ValueRepo { get; set; }
        public IUnitRepo UnitRepo { get; set; }

        protected readonly ECOMMERCEContext _db;

        public UnitOfWork(ECOMMERCEContext db)
        {
            _db = db;
            AspNetRoleClaimsRepo = new AspNetRoleClaimsRepo(db);
            AspNetRolesRepo = new AspNetRolesRepo(db);
            AspNetUserClaimsRepo = new AspNetUserClaimsRepo(db);
            AspNetUserLoginsRepo = new AspNetUserLoginsRepo(db);
            AspNetUserRolesRepo = new AspNetUserRolesRepo(db);
            AspNetUserTokensRepo = new AspNetUserTokensRepo(db);
            AttributeRepo = new AttributeRepo(db);
            CategoryAttrRepo = new CategoryAttrRepo(db);
            CategoryRepo = new CategoryRepo(db);
            CommentRepo = new CommentRepo(db);
            NotificationRepo = new NotificationRepo(db);
            OrderRepo = new OrderRepo(db);
            ProductAttrRepo = new ProductAttrRepo(db);
            ProductOrderRepo = new ProductOrderRepo(db);
            ProductRepo = new ProductRepo(db);
            RatingRepo = new RatingRepo(db);
            ShippingRepo = new ShippingRepo(db);
            UserRepo = new UserRepo(db);
            ValueRepo = new ValueAttrRepo(db);
            UnitRepo = new UnitRepo(db);
        }

        public void RollBack()
        {
            _db.Dispose();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
