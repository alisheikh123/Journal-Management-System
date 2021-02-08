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
    public class OricResearchProjectsHeadController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: OricResearchProjectsHead
        public ActionResult Index()
        {
            return View(db.tblOricResearchProjectsHeads.ToList());
        }

        // GET: OricResearchProjectsHead/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricResearchProjectsHead tblOricResearchProjectsHead = db.tblOricResearchProjectsHeads.Find(id);
            if (tblOricResearchProjectsHead == null)
            {
                return HttpNotFound();
            }
            return View(tblOricResearchProjectsHead);
        }

        // GET: OricResearchProjectsHead/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OricResearchProjectsHead/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,projectHeadName")] tblOricResearchProjectsHead tblOricResearchProjectsHead)
        {
            if (ModelState.IsValid)
            {
                db.tblOricResearchProjectsHeads.Add(tblOricResearchProjectsHead);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblOricResearchProjectsHead);
        }

        // GET: OricResearchProjectsHead/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricResearchProjectsHead tblOricResearchProjectsHead = db.tblOricResearchProjectsHeads.Find(id);
            if (tblOricResearchProjectsHead == null)
            {
                return HttpNotFound();
            }
            return View(tblOricResearchProjectsHead);
        }

        // POST: OricResearchProjectsHead/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,projectHeadName")] tblOricResearchProjectsHead tblOricResearchProjectsHead)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblOricResearchProjectsHead).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblOricResearchProjectsHead);
        }

        // GET: OricResearchProjectsHead/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricResearchProjectsHead tblOricResearchProjectsHead = db.tblOricResearchProjectsHeads.Find(id);
            if (tblOricResearchProjectsHead == null)
            {
                return HttpNotFound();
            }
            return View(tblOricResearchProjectsHead);
        }

        // POST: OricResearchProjectsHead/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblOricResearchProjectsHead tblOricResearchProjectsHead = db.tblOricResearchProjectsHeads.Find(id);
            db.tblOricResearchProjectsHeads.Remove(tblOricResearchProjectsHead);
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
