using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioMVC.Models;

namespace PortfolioMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          var devInfo= new HomeModel();
            devInfo.Title = "WEB APPLICATION & SOFTWARE DEVELOPER";
  
            devInfo.TagLine = "I am passionate about taking and idea & making it into a Digitized Reality";
            return View(devInfo);
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