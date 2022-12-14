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
    public class ValueAttrController : BaseController
    {
        private readonly IMapper _mapper;
        public ValueAttrController(IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var value = _uow.ValueRepo.GetAll().ToList();
            var value_ = _mapper.Map<List<ValueAttrViewModel>>(value);

            //var categs_ = _uow.CategoryRepo.Get(1);
            //var categories_ = _mapper.Map<CategoryViewModel>(categs_);

            return View("ValueAttrReadView", value_);
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Edit(int id)
        {
            var value = _uow.ValueRepo.Get(id);
            var value_ = _mapper.Map<ValueAttrViewModel>(value);
            return View("ValueAttrEditView", value_);
        }
        public IActionResult SaveEdit(ValueAttrViewModel model)
        {
            if (ModelState.IsValid)
            {
                var value = _mapper.Map<AppDbContext.Models.ValueAttr>(model);
                _uow.ValueRepo.Update(value);
                _uow.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create()
        {

            return View("ValueAttrCreateView");
        }
        public IActionResult SaveCreate(ValueAttrViewModel model)
        {
            if (ModelState.IsValid)
            {
                var value = _mapper.Map<AppDbContext.Models.ValueAttr>(model);
                _uow.ValueRepo.Add(value);
                _uow.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var value = _uow.ValueRepo.Get(id);
            var value_ = _mapper.Map<ValueAttrViewModel>(value);
            return View("ValueAttrDeleteView", value_);
        }

        public IActionResult ConfirmDelete(ValueAttrViewModel model)
        {
            var value = _mapper.Map<AppDbContext.Models.ValueAttr>(model);
            _uow.ValueRepo.Delete(value.Id);
            _uow.SaveChanges();
            return RedirectToAction("index");
        }


        // GET: ValueAttrController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: ValueAttrController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ValueAttrController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ValueAttrController/Create
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

        //// GET: ValueAttrController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ValueAttrController/Edit/5
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

        //// GET: ValueAttrController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ValueAttrController/Delete/5
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
