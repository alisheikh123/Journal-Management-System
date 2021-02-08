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
    public class OricEventsController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: OricEvents
        public ActionResult Index()
        {
            return View(db.tblOricEvents.ToList());
        }

        // GET: OricEvents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricEvent tblOricEvent = db.tblOricEvents.Find(id);
            if (tblOricEvent == null)
            {
                return HttpNotFound();
            }
            return View(tblOricEvent);
        }

        // GET: OricEvents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OricEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,eventDate,eventDetail")] tblOricEvent tblOricEvent)
        {
            if (ModelState.IsValid)
            {
                db.tblOricEvents.Add(tblOricEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblOricEvent);
        }

        // GET: OricEvents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricEvent tblOricEvent = db.tblOricEvents.Find(id);
            if (tblOricEvent == null)
            {
                return HttpNotFound();
            }
            return View(tblOricEvent);
        }

        // POST: OricEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,eventDate,eventDetail")] tblOricEvent tblOricEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblOricEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblOricEvent);
        }

        // GET: OricEvents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricEvent tblOricEvent = db.tblOricEvents.Find(id);
            if (tblOricEvent == null)
            {
                return HttpNotFound();
            }
            return View(tblOricEvent);
        }

        // POST: OricEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblOricEvent tblOricEvent = db.tblOricEvents.Find(id);
            db.tblOricEvents.Remove(tblOricEvent);
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
