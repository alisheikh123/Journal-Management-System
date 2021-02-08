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
    public class OricResearchProjectsController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: OricResearchProjects
        public ActionResult Index()
        {
            return View(db.tblOricResearchProjects.ToList());
        }

        // GET: OricResearchProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricResearchProject tblOricResearchProject = db.tblOricResearchProjects.Find(id);
            if (tblOricResearchProject == null)
            {
                return HttpNotFound();
            }
            return View(tblOricResearchProject);
        }

        // GET: OricResearchProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OricResearchProjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,projectName,projectHeadId")] tblOricResearchProject tblOricResearchProject)
        {
            if (ModelState.IsValid)
            {
                db.tblOricResearchProjects.Add(tblOricResearchProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblOricResearchProject);
        }

        // GET: OricResearchProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricResearchProject tblOricResearchProject = db.tblOricResearchProjects.Find(id);
            if (tblOricResearchProject == null)
            {
                return HttpNotFound();
            }
            return View(tblOricResearchProject);
        }

        // POST: OricResearchProjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,projectName,projectHeadId")] tblOricResearchProject tblOricResearchProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblOricResearchProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblOricResearchProject);
        }

        // GET: OricResearchProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricResearchProject tblOricResearchProject = db.tblOricResearchProjects.Find(id);
            if (tblOricResearchProject == null)
            {
                return HttpNotFound();
            }
            return View(tblOricResearchProject);
        }

        // POST: OricResearchProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblOricResearchProject tblOricResearchProject = db.tblOricResearchProjects.Find(id);
            db.tblOricResearchProjects.Remove(tblOricResearchProject);
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
