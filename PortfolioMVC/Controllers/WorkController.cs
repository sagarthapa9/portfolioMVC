using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioMVC.Controllers
{
    public class WorkController : Controller
    {
        // GET: Work
        public ActionResult Search()
        {
            return Content("I am in Work Controller");
        }
    }
}