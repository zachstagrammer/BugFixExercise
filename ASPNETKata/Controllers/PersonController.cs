using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNETKata.Models;

namespace ASPNETKata.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            var list = new List<Person>();

            list.Add(new Person { Age = 21, IsOwner = true, Name = "Michael" });
            list.Add(new Person { Age = 17, IsOwner = false, Name = "Britney" });
            list.Add(new Person { Age = 76, IsOwner = true, Name = "Luther" });
            list.Add(new Person { Age = 13, IsOwner = false, Name = "Gerald" });
            list.Add(new Person { Age = 28, IsOwner = true, Name = "LisaRaye" });
            list.Add(new Person { Age = 8, IsOwner = false, Name = "Aaliyah" });
            list.Add(new Person { Age = 91, IsOwner = true, Name = "Abraham" });

            return View(list);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
