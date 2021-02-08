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
    public class SliderImgsController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();

        // GET: SliderImgs
        public ActionResult Index()
        {
            return View(db.SliderImgs.ToList());
        }

        // GET: SliderImgs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SliderImg sliderImg = db.SliderImgs.Find(id);
            if (sliderImg == null)
            {
                return HttpNotFound();
            }
            return View(sliderImg);
        }

        // GET: SliderImgs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SliderImgs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Images")] SliderImg sliderImg)
        {
            if (ModelState.IsValid)
            {
                db.SliderImgs.Add(sliderImg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sliderImg);
        }

        // GET: SliderImgs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SliderImg sliderImg = db.SliderImgs.Find(id);
            if (sliderImg == null)
            {
                return HttpNotFound();
            }
            return View(sliderImg);
        }

        // POST: SliderImgs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Images")] SliderImg sliderImg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sliderImg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sliderImg);
        }

        // GET: SliderImgs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SliderImg sliderImg = db.SliderImgs.Find(id);
            if (sliderImg == null)
            {
                return HttpNotFound();
            }
            return View(sliderImg);
        }

        // POST: SliderImgs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SliderImg sliderImg = db.SliderImgs.Find(id);
            db.SliderImgs.Remove(sliderImg);
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
