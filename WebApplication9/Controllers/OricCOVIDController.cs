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
    public class OricCOVIDController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        public ActionResult Home()
        {
            return View(db.tblOricCOVIDs.ToList());
        }
        // GET: OricCOVID
        public ActionResult Index()
        {
            return View(db.tblOricCOVIDs.ToList());
        }

        // GET: OricCOVID/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricCOVID tblOricCOVID = db.tblOricCOVIDs.Find(id);
            if (tblOricCOVID == null)
            {
                return HttpNotFound();
            }
            return View(tblOricCOVID);
        }

        // GET: OricCOVID/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OricCOVID/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,covidHeader,covidDetail,covidImagePath")] tblOricCOVID tblOricCOVID)
        {
            if (ModelState.IsValid)
            {
                db.tblOricCOVIDs.Add(tblOricCOVID);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblOricCOVID);
        }

        // GET: OricCOVID/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricCOVID tblOricCOVID = db.tblOricCOVIDs.Find(id);
            if (tblOricCOVID == null)
            {
                return HttpNotFound();
            }
            return View(tblOricCOVID);
        }

        // POST: OricCOVID/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,covidHeader,covidDetail,covidImagePath")] tblOricCOVID tblOricCOVID)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblOricCOVID).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblOricCOVID);
        }

        // GET: OricCOVID/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricCOVID tblOricCOVID = db.tblOricCOVIDs.Find(id);
            if (tblOricCOVID == null)
            {
                return HttpNotFound();
            }
            return View(tblOricCOVID);
        }

        // POST: OricCOVID/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblOricCOVID tblOricCOVID = db.tblOricCOVIDs.Find(id);
            db.tblOricCOVIDs.Remove(tblOricCOVID);
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
