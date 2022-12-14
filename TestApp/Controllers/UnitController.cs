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
    public class UnitController : BaseController
    {
        private readonly IMapper _mapper;
        public UnitController(IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var unit = _uow.UnitRepo.GetAll().ToList();
            var unit_ = _mapper.Map<List<UnitViewModel>>(unit);

            //var categs_ = _uow.CategoryRepo.Get(1);
            //var categories_ = _mapper.Map<CategoryViewModel>(categs_);

            return View("UnitReadView", unit_);
        }
        public IActionResult Edit(int id)
        {
            var unit = _uow.UnitRepo.Get(id);
            var unit_ = _mapper.Map<UnitViewModel>(unit);
            return View("UnitEditView", unit_);
        }
        public IActionResult SaveEdit(UnitViewModel model)
        {
            if (ModelState.IsValid)
            {
                var unit = _mapper.Map<AppDbContext.Models.Unit>(model);
                _uow.UnitRepo.Update(unit);
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

            return View("UnitCreateView");
        }
        public IActionResult SaveCreate(UnitViewModel model)
        {
            if (ModelState.IsValid)
            {
                var unit = _mapper.Map<AppDbContext.Models.Unit>(model);
                _uow.UnitRepo.Add(unit);
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
            var unit = _uow.UnitRepo.Get(id);
            var unit_ = _mapper.Map<UnitViewModel>(unit);
            return View("UnitDeleteView", unit_);
        }

        public IActionResult ConfirmDelete(UnitViewModel model)
        {
            var unit = _mapper.Map<AppDbContext.Models.Unit>(model);
            _uow.UnitRepo.Delete(unit.Id);
            _uow.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
