using HRManager.ViewModels;
using System.Web.Mvc;
using HRManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRManager.Controllers
{
    public class ManageCityController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(AddManageCityViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var City = new City()
                {
                    Name = vm.Name,
                    postalCode = vm.PostalCode
                };
                var DbContext = new HRManagerDbContext();
                DbContext.City.Add(City);
                DbContext.Entry(City).State = System.Data.Entity.EntityState.Added;
                DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}