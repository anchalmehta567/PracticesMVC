using MVCPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCPractice.Controllers
{
    [AllowAnonymous]

    public class SecurityController : Controller
    {
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Registration_tbl user)
        {

            try
            {
                BookDBEntities db = new BookDBEntities();

                if (ModelState.IsValid)
                {
                    
                    if (db.Registration_tbl.Any(x => x.Email == user.Email))
                    {

                        //   ViewBag.DuplicateMessage = "";
                        TempData["Msg"] = "Already used this email";

                        return View("Registration", user);
                    }
                    else
                    {

                        db.Registration_tbl.Add(user);
                        db.SaveChanges();
                        TempData["Msg"] = "Register Sucessfully";
                        return RedirectToAction("Login");
                    }
                }
                else
                {
                    TempData["Msg"] = " you already Register with this email";

                    return View();
                }
            }
            catch (Exception e)
            {
                TempData["Msg"] = " you already Register with this email";
                return RedirectToAction("Index");


            }
        }

            public ActionResult Login()

            {
                return View();
            }
        
            [HttpPost]
        public ActionResult Login(Registration_tbl objuser)
        {
            BookDBEntities db = new BookDBEntities();
            var user = db.Registration_tbl.Where(x => x.Name == objuser.Name && x.password == objuser.password).FirstOrDefault();
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(objuser.Name, false);
                return RedirectToAction("GetAllRecords", "CrudOperations");
            }
            else
            {
                TempData["Msg"] = "UserName or Password is incorrect";
                return View();
            }

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        
    }
}