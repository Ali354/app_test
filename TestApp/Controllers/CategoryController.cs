using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDbContext.UOW;
//using Microsoft.AspNetCore.Mvc;
//using System.Linq;
using TestApp.Models;
using AutoMapper;
using AppDbContext.Models;

namespace TestApp.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly IMapper _mapper;
        public CategoryController(IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var categs_ = _uow.CategoryRepo.GetAll().ToList();
            var categories_ = _mapper.Map<List<CategoryViewModel>>(categs_);

            //var categs_ = _uow.CategoryRepo.Get(1);
            //var categories_ = _mapper.Map<CategoryViewModel>(categs_);

            return View("CategoryReadView", categories_);
        }
        public IActionResult Edit(int id)
        {
            var categs_ = _uow.CategoryRepo.Get(id);
            var categories_ = _mapper.Map<CategoryViewModel>(categs_);
            return View("CategoryEditView", categories_);
        }
        public IActionResult SaveEdit(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category_ = _mapper.Map<Category>(model);
                _uow.CategoryRepo.Update(category_);
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

            return View("CategoryCreateView");
        }
        public IActionResult SaveCreate(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category_ = _mapper.Map<Category>(model);
                _uow.CategoryRepo.Add(category_);
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
            var categs_ = _uow.CategoryRepo.Get(id);
            var categories_ = _mapper.Map<CategoryViewModel>(categs_);
            return View("CategoryDeleteView", categories_);
        }
        
        public IActionResult ConfirmDelete(CategoryViewModel model)
        {            
                var category_ = _mapper.Map<Category>(model);
                _uow.CategoryRepo.Delete(category_.Id);
                _uow.SaveChanges();
                return RedirectToAction("index");
        }
    }
}
