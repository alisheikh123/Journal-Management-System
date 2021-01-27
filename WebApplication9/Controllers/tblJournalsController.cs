using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Data;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class tblJournalsController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: tblJournals
        public ActionResult Index()
        {
            return View(db.tblJournals.ToList());
        }

        // GET: tblJournals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblJournal tblJournal = db.tblJournals.Find(id);
            if (tblJournal == null)
            {
                return HttpNotFound();
            }
            return View(tblJournal);
        }

        // GET: tblJournals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblJournals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Category,title,Noofauthor,author1,author2,author3,author4,author5,author6,issueno,journalName,volumeno,SPage,EPage,totalPage,pubName,Impact_Factor,Country,pubDate")] tblJournal tblJournal)
        {
            if (ModelState.IsValid)
            {
                db.tblJournals.Add(tblJournal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblJournal);
        }

        // GET: tblJournals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblJournal tblJournal = db.tblJournals.Find(id);
            if (tblJournal == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            return View(tblJournal);
        }

        // POST: tblJournals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Category,title,Noofauthor,author1,author2,author3,author4,author5,author6,issueno,journalName,volumeno,SPage,EPage,totalPage,pubName,Impact_Factor,Country,pubDate")] tblJournal tblJournal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblJournal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblJournal);
        }

        // GET: tblJournals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblJournal tblJournal = db.tblJournals.Find(id);
            if (tblJournal == null)
            {
                return HttpNotFound();
            }
            return View(tblJournal);
        }

        // POST: tblJournals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblJournal tblJournal = db.tblJournals.Find(id);
            db.tblJournals.Remove(tblJournal);
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
