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
        public ActionResult Ajaxform() 
        {
            return View(); }

        [HttpPost]
        public JsonResult Ajaxform(StudentData student) { return Json("true",JsonRequestBehavior.AllowGet); }
        public ActionResult ListofStudent() 
        { 
            return View(); 
        }
        public JsonResult Country()
        {
            List<string> Country = new List<string>()
            {
               " Afghanistan ",
                "Albania ",
                "Algeria",
                "Andorra",
                "Angola ",
                "Antigua and barbuda",
                "Argentina",
                "Armenia",
                "Australia",
                "Austria",
                "Azerbaijan",
                "Bahamas",
                "Bahrain",
                "Bangladesh",
                "Barbados",
                /*"Belarus",
                "Belgium ",
                "Belize  ",
                "Benin  ",
                "Bhutan  ",
                "Bolivia ",
                "Bosnia and Herzegovina ",
                "Botswana    ",

                "Brazil  ",
                "Brunei ",
                "Bulgaria ",
                "Burkina Faso",
                "Burundi ",
                "Côte d'Ivoire",
                "Cabo Verde  ",
                "Cambodia    ",
                "Cameroon   ",
                "Canada  ",
                "Central African Republic  ",
                "Chad ",
                "Chile  ",
                "China ",
                "Comoros ",
                "Congo (Congo-Brazzaville)",
                 "Costa Rica"            
*/
                };

            var json = JsonConvert.SerializeObject(Country);
            return Json(json, JsonRequestBehavior.AllowGet);
        }



        public JsonResult State()
        {
            List<string> State = new List<string>()
            {
               "state- Afghanistan ",
                "state-Albania ",
                "state-Algeria",
                "state-Andorra ",
                "state-Angola  ",
                "state-Antigua and Barbuda",
                "state-Argentina   "       };
            var json = JsonConvert.SerializeObject(State);
            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public JsonResult City()
        {
            List<string> City = new List<string>()
            {
               "City-- Afghanistan ",
                "City--Albania ",
                "City--Algeria",
                "City--Andorra ",
                "City-Angola  ",
                "City--Antigua and Barbuda",
                "City--Argentina   "
            };
            var json = JsonConvert.SerializeObject(City);
            return Json(json, JsonRequestBehavior.AllowGet);
        }


    }
}