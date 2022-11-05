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
        protected readonly TestDbContext _db;

        public UnitOfWork(TestDbContext db)
        {
            _db = db;
            StudentRepo = new StudentRepo(db);
        }

        public void RollBack()
        {
            _db.Dispose();
        }

        public void SaveChange()
        {
            _db.SaveChanges();
        }
    }
}
