using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Data;
using WebApplication9.Models;
using WebApplication9.Models.Class;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        private WebApplication9Context db = new WebApplication9Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            List<string> countrylist = new List<string>();
            CultureInfo[] CInfoList = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo CInfo in CInfoList)
            {
                RegionInfo R = new RegionInfo(CInfo.LCID);
                if (!(countrylist.Contains(R.EnglishName)))
                {
                    countrylist.Add(R.EnglishName);
                }
            }
            countrylist.Sort();
            ViewData["CountryList"] = new SelectList(countrylist);

            return View(db.tblJournals.ToList());
        }


        [HttpPost]
        public JsonResult Create(JournalModel obj)
        {


            tblJournal model = new tblJournal();
            if (obj != null)
            {
                obj.TPage = obj.EPage - obj.SPage;
                model.Id = obj.id;
                model.Category = obj.category;
                model.title = obj.title;
                model.Noofauthor = obj.Noofauthor;
                model.author1 = obj.author1;
                model.author2 = obj.author2;
                model.author3 = obj.author3;
                model.author4 = obj.author4;
                model.author5 = obj.author6;
                model.author6 = obj.author6;
                model.journalName = obj.JournalNm;
                model.issueno = obj.issueno;
                model.volumeno = obj.volumeno;
                model.SPage = obj.SPage;
                model.EPage = obj.EPage;
                model.totalPage = obj.TPage;
                model.pubName = obj.pubName;
                model.Impact_Factor = obj.impactFactor;
                model.Country = obj.Country;
                model.pubDate = obj.PubDate;
                db.tblJournals.Add(model);
                db.SaveChanges();

                return Json(obj);
            }
            return Json("error", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            if (id == null)
            {
                return Json("id is Null");
            }
            tblJournal tblJournal = db.tblJournals.Find(id);
            if (tblJournal == null)
            {
                return Json("Id is not available");
            }

            db.tblJournals.Remove(tblJournal);
            db.SaveChanges();
            return Json(tblJournal);
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            List<string> countrylist = new List<string>();
            CultureInfo[] CInfoList = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo CInfo in CInfoList)
            {
                RegionInfo R = new RegionInfo(CInfo.LCID);
                if (!(countrylist.Contains(R.EnglishName)))
                {
                    countrylist.Add(R.EnglishName);
                }
            }
            countrylist.Sort();
            ViewData["CountryList"] = new SelectList(countrylist);
            if (id == null)
            {
                return HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblJournal JObj = db.tblJournals.Find(id);
            if (JObj == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            ViewData["Category"] = JObj.Category;
            ViewData["title"] = JObj.title;
            ViewData["ImpactFactor"] = JObj.Impact_Factor;
            ViewData["Noofauthor"] = JObj.Noofauthor;
            ViewData["author1"] = JObj.author1;
            ViewData["author2"] = JObj.author2;
            ViewData["author3"] = JObj.author3;
            ViewData["author4"] = JObj.author4;
            ViewData["author5"] = JObj.author5;
            ViewData["author6"] = JObj.author6;
            ViewData["volumeno"] = JObj.volumeno;
            ViewData["journalName"] = JObj.journalName;
            ViewData["issueno"] = JObj.issueno;
            ViewData["pubName"] = JObj.pubName;
            ViewData["pubDate"] = JObj.pubDate;
            ViewData["SPage"] = JObj.SPage;
            ViewData["EPage"] = JObj.EPage;
            ViewData["totalPage"] = JObj.totalPage;
            ViewData["Country"] = JObj.Country.ToString();
            ViewData["Id"] = JObj.Id;



            return View(JObj);
        }
        //[Bind(Include = "Id,Category,title,Noofauthor,author1,author2,author3,author4,author5,author6,issueno,journalName,volumeno,SPage,EPage,totalPage,pubName,Impact_Factor,Country,pubDate")]
        //tblJournal obj
        [HttpPost]
        public JsonResult Edit(JournalModel form)
        {

            if (ModelState.IsValid)
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                
            }

            return Json("Result",JsonRequestBehavior.AllowGet);
        }

        private ActionResult HttpStatusCodeResult(HttpStatusCode badRequest)
        {
            throw new NotImplementedException();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



    }
}