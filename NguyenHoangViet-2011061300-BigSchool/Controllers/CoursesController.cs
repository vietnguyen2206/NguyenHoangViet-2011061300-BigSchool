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
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbcontext.Categories.ToList()
            };
            return View(viewModel);
        }


    }
}