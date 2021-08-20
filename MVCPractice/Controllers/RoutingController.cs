using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class RoutingController : Controller
    {

        /*https://localhost:44305/students*/

        public ActionResult GetAllStudent() {
            var students = Students();

            return View(students);
        }

        // Apply Concept of Attribute Routing 
        
        [Route("students/{id}")]
        public ActionResult GetStudent(int id)
        {
            var students = Students().FirstOrDefault(x=>x.id==id);

            return View(students);
        }
        
        [Route("students/{id}/address")]
        public ActionResult GetStudentAdress(int id) 
        {
            var studentAddres = Students().Where(x => x.id ==id).Select(x => x.Address).FirstOrDefault();
            return View(studentAddres); 
        }
        private List<Student> Students() 
        {
            return new List<Student>()
        {
            new Student()
            {
                id=1,
                name="Anchal",
                Class="It-A",
                Address= new Address() 
                {
                    Address1="this is studnt1 address",
                    City="Student1 city",
                    HomeNumber="Student 1 home"
                }
            },
             new Student()
            {
                id=2,
                name="Chinu",
                Class="It-A",
                Address= new Address()
                {
                    Address1="this is studnet2 address",
                    City="Student2 city",
                    HomeNumber="Student 2 home"
                }
            },
             new Student()
            {
                id=3,
                name="abc",
                Class="It-A",
                Address= new Address()
                {
                    Address1="this is studnet2 address",
                    City="Student2 city",
                    HomeNumber="Student 2 home"
                }
            }
        };
        }


    }
}