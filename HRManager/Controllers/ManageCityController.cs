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
        public ActionResult Add(AddCityViewModel vm)
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
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View();
            }
            
        }
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var DbContext = new HRManagerDbContext();
            var City = DbContext.City.Where(a => a.ID == id)
                .Select(a => new EditCityViewModel()
            {
                Name=a.Name,
                PostalCode=a.postalCode

            }).FirstOrDefault();
            if(City==null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(City);
            }
        }
        [HttpPost]
        public ActionResult Edit(EditCityViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var DbContext = new HRManagerDbContext();
                var City = DbContext.City.Where(a => a.ID == vm.ID).FirstOrDefault();
                City.ID = vm.ID;
                City.Name = vm.Name;
                City.postalCode = vm.PostalCode;
                DbContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var DbContext = new HRManagerDbContext();
            var City = DbContext.City.Where(a => a.ID == id).SingleOrDefault();
            if (City == null)
            {
                return RedirectToAction("Index", "Home");
            }
            DbContext.City.Remove(City);
            DbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}