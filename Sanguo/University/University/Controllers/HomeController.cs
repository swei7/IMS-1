using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace University.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SchoolContext schoolContext = new SchoolContext();

            Student zhangSan = new Student { FirstMidName = "San", LastName = "Zhang", EnrollmentDate = DateTime.Now.Date };

            schoolContext.Students.Add(zhangSan);
            schoolContext.SaveChanges();

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page (xhbdsn).";

            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}