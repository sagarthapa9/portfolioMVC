using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime.Misc;
using BLL;
using BOL;

namespace PortfolioMVC.Areas.Admin.Controllers
{
    public class AddEditDeveloperController : Controller
    {
        private AdminBs objbs;

        public AddEditDeveloperController()
        {
            objbs = new AdminBs();
        }
       
        // GET: Admin/AddEditDeveloper
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddEditDeveloper dev)
        {
            if (ModelState.IsValid)
            {
                objbs.AddDeveloperDetails(dev);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
           
        }
    }
}