using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor_Demo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            //1,ViewData,需要类型转换,单个页面传值
            //2,ViewBag ,不需要类型转换，单个页面传值
            //3,TempData,和ViewData类似，单个页面传值也可以跨页面

            List<string> list1 = new List<string>() { "yuwen","shuxue","yinyu" };
            ViewData["myage"] = 23;
            ViewData["myname"] = "tom";
            ViewData["mylist"] = list1;

            ViewBag.name = "jeny";
            ViewBag.age = 23;
            ViewBag.list = list1;

            TempData["yourname"] = "hello,this`s new page";

            return View();
        }

        public ActionResult SecondPage()
        {
            return View();
        }

    }
}