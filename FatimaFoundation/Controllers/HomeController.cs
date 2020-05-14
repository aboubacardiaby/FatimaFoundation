using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FatimaFoundation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult wherewework()
        {
            ViewBag.Message = "where we work";

            return View();
        }
        public ActionResult howcanyouhelp()
        {
            ViewBag.Message = "where we work";

            return View();
        }
        public ActionResult whatwedo()
        {
            ViewBag.Message = "where we work";

            return View();
        }

    }
}