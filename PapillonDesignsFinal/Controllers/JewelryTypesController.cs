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
    public class JewelryTypesController : Controller
    {
        private DataModel db = new DataModel();

        // GET: JewelryTypes
        public ActionResult Index()
        {
            return View(db.JewelryTypes.ToList());
        }

        // GET: JewelryTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JewelryType jewelryType = db.JewelryTypes.Find(id);
            if (jewelryType == null)
            {
                return HttpNotFound();
            }
            return View(jewelryType);
        }

        // GET: JewelryTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JewelryTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JewelryTypeId,JewelryTypeName")] JewelryType jewelryType)
        {
            if (ModelState.IsValid)
            {
                db.JewelryTypes.Add(jewelryType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jewelryType);
        }

        // GET: JewelryTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JewelryType jewelryType = db.JewelryTypes.Find(id);
            if (jewelryType == null)
            {
                return HttpNotFound();
            }
            return View(jewelryType);
        }

        // POST: JewelryTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JewelryTypeId,JewelryTypeName")] JewelryType jewelryType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jewelryType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jewelryType);
        }

        // GET: JewelryTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JewelryType jewelryType = db.JewelryTypes.Find(id);
            if (jewelryType == null)
            {
                return HttpNotFound();
            }
            return View(jewelryType);
        }

        // POST: JewelryTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JewelryType jewelryType = db.JewelryTypes.Find(id);
            db.JewelryTypes.Remove(jewelryType);
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
