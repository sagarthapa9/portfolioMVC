using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;

namespace PortfolioMVC.Areas.Admin.Controllers
{
    public class DeveloperController : Controller
    {
        private DeveloperBl objsBl;

        public DeveloperController()
        {
            objsBl = new DeveloperBl();
        }
        // GET: Admin/Developer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Developer
        [HttpPost]
        public ActionResult Create( Developer obj)
        {
           objsBl.Insert(obj);
            return View();
        }
    }
}