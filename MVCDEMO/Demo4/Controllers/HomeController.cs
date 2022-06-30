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
        worksEntities db = new worksEntities();
        public ActionResult Index()
        {
            User u = new User() { Id=1,Name = "tom",Age=23,Photo="1.png" };
            ViewData["data"] = u;
            ViewBag.data = u;

            List<Book> list = db.Book.ToList();

            //强类型的使用
            //方式一
            //ViewData.Model = u;

            //方式二
            //return View("Index",u);

            ViewData.Model = list;

            return View("Index", list);

        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Math1 math22 = new Math1();
            int ff = ExtensionMath.Add(math22,4, 5);
            int yy = math22.Add(4, 5);

            SelectListItem s1 = new SelectListItem();

            
 
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(int id,string title,decimal price,HttpPostedFileBase myfile)
        {
            if(myfile != null)
            {
                myfile.SaveAs(Server.MapPath("~/images/" + myfile.FileName));
            }
            Book book = new Book();
            book.ID = id;
            book.Title = title;
            book.Author = myfile.FileName;
            book.Price = price;
            db.Entry(book).State = System.Data.Entity.EntityState.Added;
            db.Book.Add(book);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            int id = Convert.ToInt32(Request["uid"]);
            Book book = db.Book.SingleOrDefault(t => t.ID == id);
            return View("Edit",book);
        }

        [HttpPost]
        public ActionResult Edit(FormCollection formCollection, HttpPostedFileBase myfile)
        {
            int id = Convert.ToInt32(formCollection["ID"]);
            string title = formCollection["Title"];
            decimal price = Convert.ToDecimal(formCollection["Price"]);

            Book book = new Book();
            book.ID = id;
            book.Title = title;

            if(myfile!=null)
            {
                book.Author = myfile.FileName;
                myfile.SaveAs(Server.MapPath("~/images/" + myfile.FileName));
            }

            book.Price = price;
            db.Entry(book).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Del(string uid)
        {
            int id = Convert.ToInt32(uid);
            Book book = db.Book.FirstOrDefault(t => t.ID == id);
            

             
            db.Entry(book).State = System.Data.Entity.EntityState.Deleted;
            db.Book.Remove(book);
            db.SaveChanges();

            return Content("<script>alert('确定删除？');window.location.href='/home/index';</script>");
            //return RedirectToAction("Index");
        }

        public ActionResult Select(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return RedirectToAction("Index");
            }
            else
            { 
                List<Book> book = db.Book.Where(t => t.Title == name).ToList();

                return View("Index", book);
            }
        }
    }
}