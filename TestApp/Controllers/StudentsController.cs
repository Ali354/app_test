using AppDbContext.UOW;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class StudentsController : BaseController
    {
        public StudentsController(IUnitOfWork uow) : base(uow)
        {
            
        }

        public IActionResult Index()
        {
            //var a = _uow.StudentRepo.GetAll();
            ViewBag.Msg = "Hello from Index";
            // ViewData["Message"] = 

            TempData["Message"] = "Hello from Students Index (TempData)";
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentViewModel svm)
        {
            if (ModelState.IsValid)
            {
                //_uow.StudentRepo.Add(new AppDbContext.Models.Student
                //{
                //    FirstName = "basel",
                //    LastName = "mariam",
                //});
                _uow.SaveChanges();
            }
            else
            {
                return View(svm);
            }
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int? id)
        {
            return View();
        }
    }
}
