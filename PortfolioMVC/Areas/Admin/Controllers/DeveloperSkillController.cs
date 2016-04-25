using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;

namespace PortfolioMVC.Areas.Admin.Controllers
{
    public class DeveloperSkillController : Controller
    {
        // GET: Admin/DeveloperSkill
        public ActionResult Index()
        {
            PortfolioDbEntities db = new PortfolioDbEntities();
            ViewBag.SkillId = new SelectList(db.Skills, "Id", "DeveloperSkill");
            return View();
        }
    }
}