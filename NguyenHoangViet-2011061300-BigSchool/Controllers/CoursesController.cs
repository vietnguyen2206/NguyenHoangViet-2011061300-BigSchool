using Microsoft.AspNet.Identity;
using NguyenHoangViet_2011061300_BigSchool.Models;
using NguyenHoangViet_2011061300_BigSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenHoangViet_2011061300_BigSchool.Controllers
{

    public class CoursesController : Controller
    {
       private readonly ApplicationDbContext _dbcontext;
       public CoursesController()
        {
            _dbcontext = new ApplicationDbContext();
        }
        // GET: Courses
        [Authorize]
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if (!ModelState.IsValid) 
            {
                viewModel.Categories = _dbcontext.Categories.ToList();
                return View("Create",viewModel);
            }
            var course = new Course
            {
                LectureId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place
            };
            _dbcontext.Courses.Add(course);
            _dbcontext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


    }
}