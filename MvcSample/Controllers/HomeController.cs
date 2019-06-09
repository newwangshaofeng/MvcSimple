using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSample.EF;
using MvcSample.Models;

namespace MvcSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                Book b1=new Book();
                b1.Id = 1;
                b1.Name="书籍";
                b1.CreateDateTime = DateTime.Now;
                ctx.Books.Add(b1);
                ctx.SaveChanges();



            }


            return View();
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