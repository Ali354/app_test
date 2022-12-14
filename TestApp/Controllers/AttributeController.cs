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
    public class AttributeController : BaseController
    {
        private readonly IMapper _mapper;
        public AttributeController(IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var attributes = _uow.AttributeRepo.GetAll().ToList();
            var attributes_ = _mapper.Map<List<AttributeViewModel>>(attributes);

            //var categs_ = _uow.CategoryRepo.Get(1);
            //var categories_ = _mapper.Map<CategoryViewModel>(categs_);

            return View("AttributeReadView", attributes_);
        }
        public IActionResult Edit(int id)
        {
            var attribute = _uow.AttributeRepo.Get(id);
            var attribute_ = _mapper.Map<AttributeViewModel>(attribute);
            return View("AttributeEditView", attribute_);
        }
        public IActionResult SaveEdit(AttributeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var attribute = _mapper.Map<AppDbContext.Models.Attribute>(model);
                _uow.AttributeRepo.Update(attribute);
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

            return View("AttributeCreateView");
        }
        public IActionResult SaveCreate(AttributeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var attribute = _mapper.Map<AppDbContext.Models.Attribute>(model);
                _uow.AttributeRepo.Add(attribute);
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
            var attribute = _uow.AttributeRepo.Get(id);
            var attribute_ = _mapper.Map<AttributeViewModel>(attribute);
            return View("AttributeDeleteView", attribute_);
        }

        public IActionResult ConfirmDelete(AttributeViewModel model)
        {
            var attribute = _mapper.Map<AppDbContext.Models.Attribute>(model);
            _uow.AttributeRepo.Delete(attribute.Id);
            _uow.SaveChanges();
            return RedirectToAction("index");
        }

    }
}
