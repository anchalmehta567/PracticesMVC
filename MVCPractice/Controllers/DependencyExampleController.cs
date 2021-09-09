using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class DependencyExampleController : Controller
    {
        // GET: DependencyExample
        public ActionResult Index()
        {
            StudentBLL obj = new StudentBLL(new StudentDAL());

           
            return View(obj.AllStudent());
            
        }
    }
}