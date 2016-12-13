using HRManager.Models;
using System.Web.Mvc;
using System.Linq;
using HRManager.ViewModels;

namespace HRManager.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var DBcontext = new HRManagerDbContext();
            var City = DBcontext.City.Select(a => new ShowCityViewModel
            {
                ID = a.ID,
                Name = a.Name,
                PostalCode = a.postalCode
            }
                ).ToList();
            return View(City);
            
        }
    }
}