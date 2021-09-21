using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;

namespace MVCPractice.Controllers
{
    public class DependencyExampleController : Controller
    {
        private EmployeeData _employee = null;
        public DependencyExampleController() 
        {
           EmployeeData data = new EmployeeData();

        }
        /*public DependencyExampleController(IEmployeeData _employee)
        {
            this._employee = _employee;

        }*/
        // GET: DependencyExample
        public ActionResult Index()
        {
            int count = _employee.GetallStudents();
            return View();
        }
    }
}