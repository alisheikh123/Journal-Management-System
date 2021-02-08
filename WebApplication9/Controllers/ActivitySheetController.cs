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
    public class ActivitySheetController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: ActivitySheet
        public ActionResult Index()
        {
            return View(db.tblActivitySheets.ToList());
        }

        // GET: ActivitySheet/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblActivitySheet tblActivitySheet = db.tblActivitySheets.Find(id);
            if (tblActivitySheet == null)
            {
                return HttpNotFound();
            }
            return View(tblActivitySheet);
        }

        // GET: ActivitySheet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActivitySheet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,activityDate,activityHead,activitySubHead,activityDetail")] tblActivitySheet tblActivitySheet)
        {
            if (ModelState.IsValid)
            {
                db.tblActivitySheets.Add(tblActivitySheet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblActivitySheet);
        }

        // GET: ActivitySheet/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblActivitySheet tblActivitySheet = db.tblActivitySheets.Find(id);
            if (tblActivitySheet == null)
            {
                return HttpNotFound();
            }
            return View(tblActivitySheet);
        }

        // POST: ActivitySheet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,activityDate,activityHead,activitySubHead,activityDetail")] tblActivitySheet tblActivitySheet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblActivitySheet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblActivitySheet);
        }

        // GET: ActivitySheet/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblActivitySheet tblActivitySheet = db.tblActivitySheets.Find(id);
            if (tblActivitySheet == null)
            {
                return HttpNotFound();
            }
            return View(tblActivitySheet);
        }

        // POST: ActivitySheet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblActivitySheet tblActivitySheet = db.tblActivitySheets.Find(id);
            db.tblActivitySheets.Remove(tblActivitySheet);
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
