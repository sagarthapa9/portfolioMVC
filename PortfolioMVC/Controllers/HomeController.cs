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
        PortfolioDb Db = new PortfolioDb();

        public ActionResult Index()
        {
            var developers = Db.Developers.ToList();
            return View(developers);
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

        protected override void Dispose(bool disposing)
        {
            if (Db != null)
            {
                Db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}