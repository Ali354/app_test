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
    public class CategoryAttrController : BaseController
    {
        private readonly IMapper _mapper;
        public CategoryAttrController(IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var categAttrs = _uow.CategoryAttrRepo.GetAll().ToList();
            var categAttrs_ = _mapper.Map<List<CategoryAttrViewModel>>(categAttrs);


            //var categAttrs = _uow.CategoryRepo.Get(1);
            //var categAttrs_ = _mapper.Map<CategoryViewModel>(categs_);

            return View("CategoryAttrReadView", categAttrs_);
        }
        public IActionResult Edit(int id)
        {
            var categAttrs = _uow.CategoryAttrRepo.Get(id);
            var categAttrs_ = _mapper.Map<CategoryAttrViewModel>(categAttrs);
            ViewBag.Categories = _uow.CategoryRepo.GetAll().ToList();
            ViewBag.Attributes = _uow.AttributeRepo.GetAll().ToList();
            ViewBag.Units = _uow.UnitRepo.GetAll().ToList();
            ViewBag.Values = _uow.ValueRepo.GetAll().ToList();
            return View("CategoryAttrEditView", categAttrs_);
        }
        public IActionResult SaveEdit(CategoryAttrViewModel model)
        {
            if (ModelState.IsValid)
            {
                var categAttrs = _mapper.Map<CategoryAttr>(model);
                _uow.CategoryAttrRepo.Update(categAttrs);
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
            ViewBag.Categories = _uow.CategoryRepo.GetAll().ToList();
            ViewBag.Attributes = _uow.AttributeRepo.GetAll().ToList();
            ViewBag.Units = _uow.UnitRepo.GetAll().ToList();
            ViewBag.Values = _uow.ValueRepo.GetAll().ToList();

            return View("CategoryAttrCreateView");
        }
        public IActionResult SaveCreate(CategoryAttrViewModel model)
        {
            if (ModelState.IsValid)
            {
                var categAttrs = _mapper.Map<CategoryAttr>(model);
                _uow.CategoryAttrRepo.Add(categAttrs);
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
            var categAttrs = _uow.CategoryAttrRepo.Get(id);
            var categAttrs_ = _mapper.Map<CategoryAttrViewModel>(categAttrs);
            return View("CategoryAttrDeleteView", categAttrs_);
        }

        public IActionResult ConfirmDelete(CategoryAttrViewModel model)
        {
            var categAttrs = _mapper.Map<CategoryAttr>(model);
            _uow.CategoryAttrRepo.Delete(categAttrs.Id);
            _uow.SaveChanges();
            return RedirectToAction("index");
        }


        //// GET: CategoryAttrController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: CategoryAttrController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: CategoryAttrController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: CategoryAttrController/Create
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

        //// GET: CategoryAttrController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: CategoryAttrController/Edit/5
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

        //// GET: CategoryAttrController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: CategoryAttrController/Delete/5
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
