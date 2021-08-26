using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class CrudOperationsController : Controller
    {
        EmployeeRepositoryDBOperations repository = null;
        public CrudOperationsController()
        {
            repository = new EmployeeRepositoryDBOperations();
        }
        // GET: CrudOperations
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
            if (ModelState.IsValid) 
            {
               int id= repository.AddEmployee(model);
                if (id > 0) 
                {
                    ModelState.Clear();
                    ViewBag.IsSucess = "Data Add";
                }
            }
            return View();
        }
        public ActionResult GetAllRecords() 
        {
            var result = repository.GetAllEmployees();
            
            return View(result);
        }
        public ActionResult Details(int id ) 
        {
            var employee = repository.GetEmployees(id);
            return View(employee);
        }
        public ActionResult Edit(int id ) 
        {

            var employee = repository.GetEmployees(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel model)
        {
            if (ModelState.IsValid) 
            {
                repository.UpdateEmployee(model.id, model);
                return RedirectToAction("GetAllRecords");
            }
         return View();
        }
        
        public ActionResult Delete(int id) 
        {
            repository.DeleteEmployee(id);
           
            return RedirectToAction("GetAllRecords"); 
        }

    }
}