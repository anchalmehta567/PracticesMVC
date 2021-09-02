using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Areas.Sales
{
    public class HomeController : Controller
    {
        // GET: Sales/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}