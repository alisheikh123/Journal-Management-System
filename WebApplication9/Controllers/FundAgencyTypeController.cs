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
    public class FundAgencyTypeController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: FundAgencyType
        public ActionResult Index()
        {
            return View(db.tblFundAgencyTypes.ToList());
        }

        // GET: FundAgencyType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblFundAgencyType tblFundAgencyType = db.tblFundAgencyTypes.Find(id);
            if (tblFundAgencyType == null)
            {
                return HttpNotFound();
            }
            return View(tblFundAgencyType);
        }

        // GET: FundAgencyType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FundAgencyType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,FundAgencyType")] tblFundAgencyType tblFundAgencyType)
        {
            if (ModelState.IsValid)
            {
                db.tblFundAgencyTypes.Add(tblFundAgencyType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblFundAgencyType);
        }

        // GET: FundAgencyType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblFundAgencyType tblFundAgencyType = db.tblFundAgencyTypes.Find(id);
            if (tblFundAgencyType == null)
            {
                return HttpNotFound();
            }
            return View(tblFundAgencyType);
        }

        // POST: FundAgencyType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,FundAgencyType")] tblFundAgencyType tblFundAgencyType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblFundAgencyType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblFundAgencyType);
        }

        // GET: FundAgencyType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblFundAgencyType tblFundAgencyType = db.tblFundAgencyTypes.Find(id);
            if (tblFundAgencyType == null)
            {
                return HttpNotFound();
            }
            return View(tblFundAgencyType);
        }

        // POST: FundAgencyType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblFundAgencyType tblFundAgencyType = db.tblFundAgencyTypes.Find(id);
            db.tblFundAgencyTypes.Remove(tblFundAgencyType);
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
