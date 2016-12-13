using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PapillonDesignsFinal.Models;


namespace PapillonDesignsFinal.Controllers
{
    public class JewelriesController : Controller
    {
        private DataModel db = new DataModel();

        // GET: Jewelries
        public ActionResult Index()
        {
            var jewelries = db.Jewelries.Include(j => j.JewelryType);
            return View(jewelries.ToList());
        }

        public ActionResult Earrings()
        {
            var jewelries = db.Jewelries.Include(j => j.JewelryType);
            return View(jewelries.ToList());

        }

        public ActionResult Bracelets()
        {
            var jewelries = db.Jewelries.Include(j => j.JewelryType);
            return View(jewelries.ToList());

        }

        public ActionResult Necklaces()
        {
            var jewelries = db.Jewelries.Include(j => j.JewelryType);
            return View(jewelries.ToList());

        }

        public ActionResult Sets()
        {
            var jewelries = db.Jewelries.Include(j => j.JewelryType);
            return View(jewelries.ToList());

        }

        //GET: Earring
        //public ActionResult Earrings()
        //{
        //    Repository.EarringRepository JewelryRepo = new Repository.EarringRepository();
        //    ModelState.Clear();//model state will create a dic  object that will contain state of object. Clear because we do not need it in memory
        //    return View(Earrings());
        //}

        // GET: Jewelries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jewelry jewelry = db.Jewelries.Find(id);
            if (jewelry == null)
            {
                return HttpNotFound();
            }
            return View(jewelry);
        }

        // GET: Jewelries/Create
        public ActionResult Create()
        {
            ViewBag.JewelryTypeId = new SelectList(db.JewelryTypes, "JewelryTypeId", "JewelryTypeName");
            return View();
        }

        // POST: Jewelries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JewelryId,Title,Price,Description,Color,ImageURL,JewelryTypeId")] Jewelry jewelry)
        {
            if (ModelState.IsValid)
            {
                db.Jewelries.Add(jewelry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.JewelryTypeId = new SelectList(db.JewelryTypes, "JewelryTypeId", "JewelryTypeName", jewelry.JewelryTypeId);
            return View(jewelry);
        }

        // GET: Jewelries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jewelry jewelry = db.Jewelries.Find(id);
            if (jewelry == null)
            {
                return HttpNotFound();
            }
            ViewBag.JewelryTypeId = new SelectList(db.JewelryTypes, "JewelryTypeId", "JewelryTypeName", jewelry.JewelryTypeId);
            return View(jewelry);
        }

        // POST: Jewelries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JewelryId,Title,Price,Description,Color,ImageURL,JewelryTypeId")] Jewelry jewelry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jewelry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.JewelryTypeId = new SelectList(db.JewelryTypes, "JewelryTypeId", "JewelryTypeName", jewelry.JewelryTypeId);
            return View(jewelry);
        }

        // GET: Jewelries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jewelry jewelry = db.Jewelries.Find(id);
            if (jewelry == null)
            {
                return HttpNotFound();
            }
            return View(jewelry);
        }

        // POST: Jewelries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jewelry jewelry = db.Jewelries.Find(id);
            db.Jewelries.Remove(jewelry);
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
