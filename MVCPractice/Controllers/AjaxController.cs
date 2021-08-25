using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;
using Newtonsoft.Json;
namespace MVCPractice.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetStudent()
        {
            StudentData std = new StudentData()
            {
                id = 2,
                Email = "aanchalmehta@gmail.com",
                name = "Anchal"
            };
            var json = JsonConvert.SerializeObject(std);

            return Json(json,JsonRequestBehavior.AllowGet); 
        }
        [HttpPost]
        public JsonResult AddStudent(StudentData student) 
        {
            return Json("true", JsonRequestBehavior.AllowGet);
        }
    }
}