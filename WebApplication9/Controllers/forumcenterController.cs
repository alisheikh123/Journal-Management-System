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
    public class forumcenterController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: forumcenter
        public ActionResult Index()
        {
            return View(db.tblforumcenters.ToList());
        }

        // GET: forumcenter/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblforumcenter tblforumcenter = db.tblforumcenters.Find(id);
            if (tblforumcenter == null)
            {
                return HttpNotFound();
            }
            return View(tblforumcenter);
        }

        // GET: forumcenter/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: forumcenter/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Title,upload_Image,heading,Description")] tblforumcenter tblforumcenter)
        {
            if (ModelState.IsValid)
            {
                db.tblforumcenters.Add(tblforumcenter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblforumcenter);
        }

        // GET: forumcenter/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblforumcenter tblforumcenter = db.tblforumcenters.Find(id);
            if (tblforumcenter == null)
            {
                return HttpNotFound();
            }
            return View(tblforumcenter);
        }

        // POST: forumcenter/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Title,upload_Image,heading,Description")] tblforumcenter tblforumcenter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblforumcenter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblforumcenter);
        }

        // GET: forumcenter/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblforumcenter tblforumcenter = db.tblforumcenters.Find(id);
            if (tblforumcenter == null)
            {
                return HttpNotFound();
            }
            return View(tblforumcenter);
        }

        // POST: forumcenter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblforumcenter tblforumcenter = db.tblforumcenters.Find(id);
            db.tblforumcenters.Remove(tblforumcenter);
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
