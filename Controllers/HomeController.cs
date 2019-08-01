using GarageProject.Models;
using GarageProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarageProject.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        ApplicationDbContext db;

        public HomeController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
        public ActionResult Index()
        {

          return View();
        }

        public ActionResult About()
        {
            var viewModel = new AdminAddViewModel()
            {
                AddCarBrand=db.CarBrandDbs.ToList(),
                AddCarStyle=db.CarStyleDbs.ToList(),
                AddServiceTypes=db.CarServicesDbs.ToList()
            };

            return View(viewModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}