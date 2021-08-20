using MVCPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class HelperController : Controller
    {
        // GET: Home
        /*public string Profile(int id ) 
          {
              string profile =string.Empty;
              if (id == 1)
              {
                  profile = "Employee 1 profile";

              }
              else if (id == 1)
              {
                  profile = "Employee 2 profile";

              }
              else {
                  profile = "No record found";
              }
              return  profile; 
          }*/
        public ActionResult Index()
        {
            var data = GetEmployeeDetail();
            return View(data);
        }
        public ActionResult GetEmployee(int id)
        {
            var Obj = GetEmployeeDetail().FirstOrDefault(x => x.Id == id);
            ViewBag.output = "";
            if (Obj == null)
            {
                ViewBag.output = "No employee with this id ";
            }
            return View(Obj);
        }
        private List<Employees> GetEmployeeDetail()
        {
            return new List<Employees>()
            {
                new Employees()
                {
                    Id = 1,
                    Name = "Anchal",
                    Address = "Indore",

                },
                new Employees()
                {
                    Id = 2,
                    Name = "Tarun",
                    Address = "Bhopal "
                },
                new Employees()
                {
                    Id = 3,
                    Name = "Anjali",
                    Address = "Jaipur"
                },
                new Employees()
                {
                    Id = 4,
                    Name = "Saloni",
                    Address = "Ratlam"
                }
            };
        }
    }
}