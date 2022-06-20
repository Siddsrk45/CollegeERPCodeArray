using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CollegeERP.Models;

namespace CollegeERP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var students = new List<Student>(){
              new Student()
            {
                Id = 1,
                Name = "Siddhesh",
                Middlename = "Ram",
                LastName = "Kumbhar"
            },
           new Student()
            {
                Id = 2,
                Name = "Shubham",
                Middlename = "xyz",
                LastName = "Jadhav"
            }
           };
            ViewBag.datas = students;
            return View();
        }
    }
}