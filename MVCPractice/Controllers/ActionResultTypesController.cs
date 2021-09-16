using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class ActionResultTypesController : Controller
    {

        // GET: ActionResultTypes three types of Action Result in asp.net MVC
        // Con.
        public ViewResult Index()
        {
            return View();
        }
        public PartialViewResult Testpartialview() 
        {
            return PartialView();
        }
        public ContentResult tetcontent() 
        {
            return Content("This is contentresult from home controller");
        }
        public EmptyResult testemptyresult() 
        {
            return new EmptyResult();
        }
        public FileResult testfileresult() 
        {
            string filepath = @"";
            string contentype = "text";

            return File(filepath,contentype); }

        public JsonResult testJson() 
        {
            var json = new { id = 100, Name = "Anchal",Email="test@gmail.com" };
            var jsonData = new teacher() { Id = 1, Name = "Abc", Email = "abc@mail.com" };
            return Json(jsonData,JsonRequestBehavior.AllowGet); 
        }
        public class teacher 
        {
            public int Id { get; set; }
            public String Name { get; set; }
            public String Email { get; set; }
        }
        public RedirectResult testRedirectresult() 
        {
            return Redirect("http://www.google.com");
        }
        public RedirectToRouteResult testredirecttoroutr() 
        {
            return RedirectToAction("Index");
        }
        public RedirectToRouteResult tesredirectToRoute() 
        {
            return RedirectToRoute(new { Controller = "Home", Action = "Index" });
        }

        //types of Status result 3 types : 

    }
    
}