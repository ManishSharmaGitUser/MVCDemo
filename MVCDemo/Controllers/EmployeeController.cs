using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var data = AllEmployees();
            return View(data);


            //below if viewname is deiffrenet from action name
            //return View("Viewname",data);
        }

        private Employee AllEmployees()
        {
            return new Employee { Id = 1, Name = "Manish", Address = "Kanpur" };
        }
    }
}