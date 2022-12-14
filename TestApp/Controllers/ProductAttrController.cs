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
    public class ProductAttrController : BaseController
    {
        private readonly IMapper _mapper;
        public ProductAttrController(IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var productAttr = _uow.ProductAttrRepo.GetAll().ToList();
            var productAttr_ = _mapper.Map<List<ProductAttrViewModel>>(productAttr);


            //var categAttrs = _uow.CategoryRepo.Get(1);
            //var categAttrs_ = _mapper.Map<CategoryViewModel>(categs_);

            return View("ProductAttrReadView", productAttr_);
        }
        public IActionResult Edit(int id)
        {
            var productAttr = _uow.ProductAttrRepo.Get(id);
            var productAttr_ = _mapper.Map<ProductAttrViewModel>(productAttr);
            ViewBag.Products = _uow.ProductRepo.GetAll().ToList();
            ViewBag.Attributes = _uow.AttributeRepo.GetAll().ToList();
            ViewBag.Units = _uow.UnitRepo.GetAll().ToList();
            ViewBag.Values = _uow.ValueRepo.GetAll().ToList();
            return View("ProductAttrEditView", productAttr_);
        }
        public IActionResult SaveEdit(ProductAttrViewModel model)
        {
            if (ModelState.IsValid)
            {
                var productAttr = _mapper.Map<ProductAttr>(model);
                _uow.ProductAttrRepo.Update(productAttr);
                _uow.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Create()
        {
            ViewBag.Products = _uow.ProductRepo.GetAll().ToList();
            ViewBag.Attributes = _uow.AttributeRepo.GetAll().ToList();
            ViewBag.Units = _uow.UnitRepo.GetAll().ToList();
            ViewBag.Values = _uow.ValueRepo.GetAll().ToList();

            return View("ProductAttrCreateView");
        }
        public IActionResult SaveCreate(ProductAttrViewModel model)
        {
            if (ModelState.IsValid)
            {
                var productAttr = _mapper.Map<ProductAttr>(model);
                _uow.ProductAttrRepo.Add(productAttr);
                _uow.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Delete(int id)
        {
            var productAttr = _uow.ProductAttrRepo.Get(id);
            var productAttr_ = _mapper.Map<ProductAttrViewModel>(productAttr);
            return View("ProductAttrDeleteView", productAttr_);
        }

        public IActionResult ConfirmDelete(ProductAttrViewModel model)
        {
            var productAttr = _mapper.Map<ProductAttr>(model);
            _uow.ProductAttrRepo.Delete(productAttr.Id);
            _uow.SaveChanges();
            return RedirectToAction("index");
        }


        //// GET: ProductAttrController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: ProductAttrController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ProductAttrController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ProductAttrController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ProductAttrController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ProductAttrController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ProductAttrController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ProductAttrController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
