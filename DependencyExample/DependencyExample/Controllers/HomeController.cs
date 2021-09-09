using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyExample.Models;

namespace DependencyExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StudentBLL obj = new StudentBLL(new StudentDAL());

            return View(obj.AllStudent());
        }
    }
}