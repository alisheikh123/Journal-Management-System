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
    public class FundAgenciesController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: FundAgencies
        public ActionResult Index()
        {
            return View(db.tblFundAgencies.ToList());
        }

        // GET: FundAgencies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblFundAgency tblFundAgency = db.tblFundAgencies.Find(id);
            if (tblFundAgency == null)
            {
                return HttpNotFound();
            }
            return View(tblFundAgency);
        }

        // GET: FundAgencies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FundAgencies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,fundAgencyType_id,FundAgency,fundAgency_Link,Title,Worth,Date")] tblFundAgency tblFundAgency)
        {
            if (ModelState.IsValid)
            {
                db.tblFundAgencies.Add(tblFundAgency);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblFundAgency);
        }

        // GET: FundAgencies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblFundAgency tblFundAgency = db.tblFundAgencies.Find(id);
            if (tblFundAgency == null)
            {
                return HttpNotFound();
            }
            return View(tblFundAgency);
        }

        // POST: FundAgencies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,fundAgencyType_id,FundAgency,fundAgency_Link,Title,Worth,Date")] tblFundAgency tblFundAgency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblFundAgency).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblFundAgency);
        }

        // GET: FundAgencies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblFundAgency tblFundAgency = db.tblFundAgencies.Find(id);
            if (tblFundAgency == null)
            {
                return HttpNotFound();
            }
            return View(tblFundAgency);
        }

        // POST: FundAgencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblFundAgency tblFundAgency = db.tblFundAgencies.Find(id);
            db.tblFundAgencies.Remove(tblFundAgency);
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
