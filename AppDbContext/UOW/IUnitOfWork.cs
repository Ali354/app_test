using AppDbContext.IRepos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppDbContext.UOW
{
    public interface IUnitOfWork
    {
        public IAttributeRepo AttributeRepo { get; set; }
        public ICategoryRepo CategoryRepo { get; set; }
        public IProductRepo ProductRepo { get; set; }
        public ICustomerRepo CustomerRepo { get; set; }
        public IOrderRepo OrderRepo { get; set; }
        public IProductOrderRepo ProductOrderRepo { get; set; }
        public IShippingRepo ShippingRepo { get; set; }
        public IValueDateRepo ValueDateRepo { get; set; }
        public IValueIntRepo ValueIntRepo { get; set; }
        public IValueVarcharRepo ValueVarcharRepo { get; set; }

        public IStudentRepo StudentRepo { get; set; }
        public void SaveChanges ();

        public void RollBack();
    }
}