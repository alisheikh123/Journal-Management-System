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
    public class DetailController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: Detail
        public ActionResult Index()
        {
            return View(db.tblDetails.ToList());
        }

        // GET: Detail/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblDetail tblDetail = db.tblDetails.Find(id);
            if (tblDetail == null)
            {
                return HttpNotFound();
            }
            return View(tblDetail);
        }

        // GET: Detail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Detail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,title,uploadImage,heading,description")] tblDetail tblDetail)
        {
            if (ModelState.IsValid)
            {
                db.tblDetails.Add(tblDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblDetail);
        }

        // GET: Detail/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblDetail tblDetail = db.tblDetails.Find(id);
            if (tblDetail == null)
            {
                return HttpNotFound();
            }
            return View(tblDetail);
        }

        // POST: Detail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,title,uploadImage,heading,description")] tblDetail tblDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblDetail);
        }

        // GET: Detail/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblDetail tblDetail = db.tblDetails.Find(id);
            if (tblDetail == null)
            {
                return HttpNotFound();
            }
            return View(tblDetail);
        }

        // POST: Detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblDetail tblDetail = db.tblDetails.Find(id);
            db.tblDetails.Remove(tblDetail);
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
