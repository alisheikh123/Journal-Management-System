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
    public class scholarshipController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: scholarship
        public ActionResult Index()
        {
            return View(db.scholarships.ToList());
        }

        // GET: scholarship/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            scholarship scholarship = db.scholarships.Find(id);
            if (scholarship == null)
            {
                return HttpNotFound();
            }
            return View(scholarship);
        }

        // GET: scholarship/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: scholarship/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,title,value,link,category,deadline")] scholarship scholarship)
        {
            if (ModelState.IsValid)
            {
                db.scholarships.Add(scholarship);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(scholarship);
        }

        // GET: scholarship/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            scholarship scholarship = db.scholarships.Find(id);
            if (scholarship == null)
            {
                return HttpNotFound();
            }
            return View(scholarship);
        }

        // POST: scholarship/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,title,value,link,category,deadline")] scholarship scholarship)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scholarship).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(scholarship);
        }

        // GET: scholarship/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            scholarship scholarship = db.scholarships.Find(id);
            if (scholarship == null)
            {
                return HttpNotFound();
            }
            return View(scholarship);
        }

        // POST: scholarship/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            scholarship scholarship = db.scholarships.Find(id);
            db.scholarships.Remove(scholarship);
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
