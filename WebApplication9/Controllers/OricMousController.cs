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
    public class OricMousController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: OricMous
        public ActionResult Index()
        {
            return View(db.tblOricMous.ToList());
        }

        // GET: OricMous/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricMou tblOricMou = db.tblOricMous.Find(id);
            if (tblOricMou == null)
            {
                return HttpNotFound();
            }
            return View(tblOricMou);
        }

        // GET: OricMous/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OricMous/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,MouDate,MouDetail")] tblOricMou tblOricMou)
        {
            if (ModelState.IsValid)
            {
                db.tblOricMous.Add(tblOricMou);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblOricMou);
        }

        // GET: OricMous/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricMou tblOricMou = db.tblOricMous.Find(id);
            if (tblOricMou == null)
            {
                return HttpNotFound();
            }
            return View(tblOricMou);
        }

        // POST: OricMous/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,MouDate,MouDetail")] tblOricMou tblOricMou)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblOricMou).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblOricMou);
        }

        // GET: OricMous/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblOricMou tblOricMou = db.tblOricMous.Find(id);
            if (tblOricMou == null)
            {
                return HttpNotFound();
            }
            return View(tblOricMou);
        }

        // POST: OricMous/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblOricMou tblOricMou = db.tblOricMous.Find(id);
            db.tblOricMous.Remove(tblOricMou);
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
