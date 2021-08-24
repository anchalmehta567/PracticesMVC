using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string PostingUsingParameter(string firtsName, string lastName)
        { 
            return "form parameter   first name is :"+firtsName+" , last name is "+lastName; 
        }
        [HttpPost]

        public string PostingUsingRequest()
        {
            string firtsName = Request["firtsName"];
            string lastName = Request["lastName"];
            return "form request   first name is :" + firtsName + " , last name is " + lastName;
        }
        [HttpPost]

        public string PostingUsingFormCollection(FormCollection form)
        {
            string firtsName = form["firtsName"];
            string lastName = form["lastName"];
            return "form Form collection   first name is :" + firtsName + " , last name is " + lastName;
        }
        [HttpPost]
        public string PostingUsingStronglyBinding(Employee emp)
        {
           
            return "form Form collection   first name is :" +emp.firstName + " , last name is " + emp.lastName;
        }

    }
}