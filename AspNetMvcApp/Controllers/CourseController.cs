using AspNetMvcApp.Models;
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
            var liste=Repository.Students.Where(i => i.WillAttend == true);
            
            return View(liste);
        }
        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Apply(Student student)
        {
            //Studen bilgisini veritabanına kayıt et.
            //Model binding
            //Sanal veritabanı oluştur ve kayıt et. 

            Repository.AddStudent(student);

            return View("Thanks",student);
        }


    }
}