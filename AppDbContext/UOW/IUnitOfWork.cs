using AppDbContext.IRepos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppDbContext.UOW
{
    public interface IUnitOfWork
    {
        //public IStudentRepo StudentRepo { get; set; }
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
        public IUnitRepo UnitRepo { get; set; }
        public IValueAttrRepo ValueRepo { get; set; }

        public void SaveChanges ();

        public void RollBack();
    }
}
