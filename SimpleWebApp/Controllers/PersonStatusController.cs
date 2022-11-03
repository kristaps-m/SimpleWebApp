using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SimpleWebApp.Models;

namespace SimpleWebApp.Controllers
{
    public class PersonStatusController : Controller
    {
        private MvcWebProjectEntities2 db = new MvcWebProjectEntities2();

        // GET: PersonStatus
        public ActionResult Index()
        {
            return View(db.PersonStatus.ToList());
        }

        // GET: PersonStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonStatu personStatu = db.PersonStatus.Find(id);
            if (personStatu == null)
            {
                return HttpNotFound();
            }
            return View(personStatu);
        }

        // GET: PersonStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StatusName")] PersonStatu personStatu)
        {
            if (ModelState.IsValid)
            {
                db.PersonStatus.Add(personStatu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personStatu);
        }

        // GET: PersonStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonStatu personStatu = db.PersonStatus.Find(id);
            if (personStatu == null)
            {
                return HttpNotFound();
            }
            return View(personStatu);
        }

        // POST: PersonStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StatusName")] PersonStatu personStatu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personStatu).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personStatu);
        }

        // GET: PersonStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonStatu personStatu = db.PersonStatus.Find(id);
            if (personStatu == null)
            {
                return HttpNotFound();
            }
            return View(personStatu);
        }

        // POST: PersonStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonStatu personStatu = db.PersonStatus.Find(id);
            db.PersonStatus.Remove(personStatu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
