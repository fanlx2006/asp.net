using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo2.Models;

namespace Demo2.Controllers
{
    public class JOBController : Controller
    {
        JobDBEntities db = new JobDBEntities();

        // GET: JOB
        public ActionResult Index()
        {
            List < JobSeeker > list = db.JobSeekers.ToList();
            //将数据传递到前端
            ViewBag.data = list;
            return View();
        }

        // GET: JOB
        public ActionResult Add()
        {
            return View("AddView");
        }

        //SAVE（）方法用于处理表单传过来的数据
        public ActionResult Save()
        {

            //将数据添加到数据库中:创建jobSeeker的对象，然后将获取的值封装到此对象中，再将
            //对象交给数据库上下文对象调用add()方法进行数据添加
            JobSeeker j = new JobSeeker();
            j.Id = Convert.ToInt32(Request.Form["id"]);
            j.Career = Request.Form["Career"];
            j.Name = Request.Form["Name"];
            j.Sex = Request.Form["Sex"];
            j.Age = Convert.ToInt32(Request.Form["Age"]);
            j.Experience = Request.Form["Experience"];
            j.Education = Request.Form["Education"];
            j.Photo = Request.Form["Photo"];
            //db.Entry(j).State = System.Data.Entity.EntityState.Added;
            db.JobSeekers.Add(j);
            db.SaveChanges();
            //跳转到另外一个方法
            return Redirect("Index");
        }
    }
}