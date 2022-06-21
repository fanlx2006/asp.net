using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo4.Models;

namespace Demo4.Controllers
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

        public ActionResult Contact()
        {
            Math1 math1 = new Math1();
            int ff = ExtensionMath.Add(math1,4, 5);
 
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}