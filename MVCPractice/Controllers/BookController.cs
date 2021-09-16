using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;
namespace MVCPractice.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            using (BookDBEntities db = new BookDBEntities()) 
            {
                return View(db.readingbooks.ToList());
            }
              
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            using (BookDBEntities db = new BookDBEntities())
            {
                return View(db.readingbooks.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(readingbook read)
        {
            try
            {
                using (BookDBEntities db = new BookDBEntities())
                {
                    db.readingbooks.Add(read);
                    db.SaveChanges();
                }

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            using (BookDBEntities db = new BookDBEntities())
            {
                return View(db.readingbooks.Where(x => x.id == id).FirstOrDefault());
            }
            return View();
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, readingbook read)
        {
            try
            {
                using (BookDBEntities db = new BookDBEntities())
                {
                    db.Entry(read).State = EntityState.Modified;
                    db.SaveChanges();
                }

                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            using (BookDBEntities db = new BookDBEntities())
            {
                return View(db.readingbooks.Where(x => x.id == id).FirstOrDefault());
            }

            return View();
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, readingbook read)
        {
            try
            {
                // TODO: Add delete logic here
                using (BookDBEntities db = new BookDBEntities())
                {
                    read = db.readingbooks.Where(x => x.id == id).FirstOrDefault();
                    db.readingbooks.Remove(read);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
