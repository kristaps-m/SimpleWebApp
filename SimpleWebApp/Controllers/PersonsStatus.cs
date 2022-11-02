using SimpleWebApp.Models;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SimpleWebApp.Controllers
{
    public class PersonsStatus : Controller
    {
        private MvcWebProjectEntities1 db = new MvcWebProjectEntities1();

        // GET: PersonsStatus
        public ActionResult Index()
        {
            return View(db.PersonsStatus.ToList());
        }

        // GET: PersonsStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonsStatu personsStatu = db.PersonsStatus.Find(id);
            if (personsStatu == null)
            {
                return HttpNotFound();
            }
            return View(personsStatu);
        }

        // GET: PersonsStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonsStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StatusName")] PersonsStatu personsStatu)
        {
            if (ModelState.IsValid)
            {
                db.PersonsStatus.Add(personsStatu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personsStatu);
        }

        // GET: PersonsStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonsStatu personsStatu = db.PersonsStatus.Find(id);
            if (personsStatu == null)
            {
                return HttpNotFound();
            }
            return View(personsStatu);
        }

        // POST: PersonsStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StatusName")] PersonsStatu personsStatu)
        {
            if (ModelState.IsValid)
            { //Next row was only = EntityState.Modified. Had to add that all ?
                db.Entry(personsStatu).State = (System.Data.Entity.EntityState)System.Data.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personsStatu);
        }

        // GET: PersonsStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonsStatu personsStatu = db.PersonsStatus.Find(id);
            if (personsStatu == null)
            {
                return HttpNotFound();
            }
            return View(personsStatu);
        }

        // POST: PersonsStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonsStatu personsStatu = db.PersonsStatus.Find(id);
            db.PersonsStatus.Remove(personsStatu);
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
