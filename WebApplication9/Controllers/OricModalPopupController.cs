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
    public class OricModalPopupController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: OricModalPopup
        public ActionResult Index()
        {
            return View(db.tblOricModalPopups.ToList());
        }

        // GET: OricModalPopup/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricModalPopup tblOricModalPopup = db.tblOricModalPopups.Find(id);
            if (tblOricModalPopup == null)
            {
                return HttpNotFound();
            }
            return View(tblOricModalPopup);
        }

        // GET: OricModalPopup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OricModalPopup/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,modalHeader,modalDetail,modalImagePath")] tblOricModalPopup tblOricModalPopup)
        {
            if (ModelState.IsValid)
            {
                db.tblOricModalPopups.Add(tblOricModalPopup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblOricModalPopup);
        }

        // GET: OricModalPopup/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricModalPopup tblOricModalPopup = db.tblOricModalPopups.Find(id);
            if (tblOricModalPopup == null)
            {
                return HttpNotFound();
            }
            return View(tblOricModalPopup);
        }

        // POST: OricModalPopup/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,modalHeader,modalDetail,modalImagePath")] tblOricModalPopup tblOricModalPopup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblOricModalPopup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblOricModalPopup);
        }

        // GET: OricModalPopup/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricModalPopup tblOricModalPopup = db.tblOricModalPopups.Find(id);
            if (tblOricModalPopup == null)
            {
                return HttpNotFound();
            }
            return View(tblOricModalPopup);
        }

        // POST: OricModalPopup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblOricModalPopup tblOricModalPopup = db.tblOricModalPopups.Find(id);
            db.tblOricModalPopups.Remove(tblOricModalPopup);
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
