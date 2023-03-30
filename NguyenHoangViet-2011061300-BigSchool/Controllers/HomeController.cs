using NguyenHoangViet_2011061300_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenHoangViet_2011061300_BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db_context;

        public HomeController() 
        {
            db_context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcomingCourses = db_context.Courses
                .Include(c => c.Lecture)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);
            
            return View(upcomingCourses);
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