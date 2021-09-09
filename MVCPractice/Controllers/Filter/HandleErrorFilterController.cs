using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHandsOnPractice.Controllers.Filter
{
    [HandleError]
    public class HandleErrorFilterController : Controller
    {
        // GET: HandleErrorFilter
     //   [HandleError]
        public ActionResult Index()
        {
            throw new Exception("This is a  exception");
            /*  try
              {
                  throw new Exception("This is a  exception");
              }
              catch(Exception e) 
              {
                  return RedirectToAction("Index","Error");
              }*/
        }
        public ActionResult About()
        {
            throw new Exception("This is a  exception");
        }
    }
}