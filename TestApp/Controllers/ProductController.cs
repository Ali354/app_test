using AppDbContext.Models;
using AppDbContext.UOW;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IMapper _mapper;
        public ProductController(IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _mapper = mapper;
        }

        // GET: ProductController
        public ActionResult Index()
        {
            var products = _uow.ProductRepo.GetAll().ToList();
            var products_ = _mapper.Map<List<ProductViewModel>>(products);

            //var products = _uow.ProductRepo.Get(1);
            //var products_ = _mapper.Map<ProductViewModel>(products);

            return View("ProductReadView", products_);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            //ViewBag.CategoryId
            ViewBag.Categories = _uow.CategoryRepo.GetAll().ToList();
            
            return View("ProductCreateView");
        }
        public ActionResult SaveCreate(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product_ = _mapper.Map<Product>(model);
                _uow.ProductRepo.Add(product_);
                _uow.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
        
        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public IActionResult Edit(int id)
        {
            var product = _uow.ProductRepo.Get(id);
            var product_ = _mapper.Map<ProductViewModel>(product);
            ViewBag.Categories = _uow.CategoryRepo.GetAll().ToList();
            return View("ProductEditView", product_);
        }
        public IActionResult SaveEdit(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product_ = _mapper.Map<Product>(model);
                _uow.ProductRepo.Update(product_);
                _uow.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = _uow.ProductRepo.Get(id);
            var product_ = _mapper.Map<ProductViewModel>(product);
            return View("ProductDeleteView", product_);
        }
        public IActionResult ConfirmDelete(ProductViewModel model)
        {
            var product_ = _mapper.Map<Product>(model);
            _uow.ProductRepo.Delete(product_.Id);
            _uow.SaveChanges();
            return RedirectToAction("index");
        }
        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
