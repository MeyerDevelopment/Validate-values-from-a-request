using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var studentList = new List<StudentViewModel>{
                            new StudentViewModel() { FirstName = "Bob", LastName = "Smith", Grade = "94" } ,
                            new StudentViewModel() { FirstName = "Jack", LastName = "Higgins", Grade = "56" } ,
                            new StudentViewModel() { FirstName = "Thomas", LastName = "Unitas", Grade = "74" } ,
                            new StudentViewModel() { FirstName = "Fred", LastName = "Flintstone", Grade = "99" } ,
                            new StudentViewModel() { FirstName = "Barney", LastName = "Rubble", Grade = "83" }
                        };
            return View(studentList);
        }

        public ActionResult ShowPartial()
        {
            return PartialView("_PartialView");
        }
    }
}