using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DFWFreeways.Models;

namespace DFWFreeways.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomePage homePage = new HomePage();
            return View(homePage);
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