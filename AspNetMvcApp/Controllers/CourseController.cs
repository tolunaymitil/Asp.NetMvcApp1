using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcApp.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "Good Afternoon " : "Good Morning";
            return View("MyView");
        }
        public ViewResult List()
        {
            return View();
        }


    }
}