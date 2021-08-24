using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class ValidationsController : Controller
    {
        // GET: Validations
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitData(DataEmployee emp) 
        {
            if (ModelState.IsValid) 
            {
                return View();
            }
            return View("Index");
        }
        public ActionResult CustomValidation() 
        { 
            return View(); 
        }
        [HttpPost]
        public ActionResult CustomValidation(DataEmployee emp)
        {
            if (ModelState.IsValid) 
            {
                ModelState.Clear();
                return View();
            }
            return View();
        }

    }
}