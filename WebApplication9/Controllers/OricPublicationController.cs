using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Data;
using WebApplication9.Models.Class.AdmissionContext;

namespace WebApplication9.Controllers
{
    public class OricPublicationController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: OricPublication
        public ActionResult Index()
        {
            return View(db.tblOricPublications.ToList());
        }

        // GET: OricPublication/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricPublication tblOricPublication = db.tblOricPublications.Find(id);
            if (tblOricPublication == null)
            {
                return HttpNotFound();
            }
            return View(tblOricPublication);
        }

        // GET: OricPublication/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OricPublication/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,author,title,journal,year,reference,dept_id")] tblOricPublication tblOricPublication)
        {
            if (ModelState.IsValid)
            {
                db.tblOricPublications.Add(tblOricPublication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblOricPublication);
        }

        // GET: OricPublication/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricPublication tblOricPublication = db.tblOricPublications.Find(id);
            if (tblOricPublication == null)
            {
                return HttpNotFound();
            }
            return View(tblOricPublication);
        }

        // POST: OricPublication/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,author,title,journal,year,reference,dept_id")] tblOricPublication tblOricPublication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblOricPublication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblOricPublication);
        }

        // GET: OricPublication/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricPublication tblOricPublication = db.tblOricPublications.Find(id);
            if (tblOricPublication == null)
            {
                return HttpNotFound();
            }
            return View(tblOricPublication);
        }

        // POST: OricPublication/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblOricPublication tblOricPublication = db.tblOricPublications.Find(id);
            db.tblOricPublications.Remove(tblOricPublication);
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
