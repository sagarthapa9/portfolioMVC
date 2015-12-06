using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using PortfolioMVC.Models;

namespace PortfolioMVC.Controllers
{
    public class HomeController : Controller
    {
        private DeveloperBl objsBl;

        public HomeController()
        {
            objsBl = new DeveloperBl();
        }

        public ActionResult Index()
        {
            var developer = objsBl.GetById(1);
            return View(developer);
         
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}