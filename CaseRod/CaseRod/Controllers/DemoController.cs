using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CaseRod.Models;

namespace CaseRod.Controllers
{
    public class DemoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Demo
        public ActionResult Index()
        {
            return View(db.Blades.ToList());
        }

        // GET: Demo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blade blade = db.Blades.Find(id);
            if (blade == null)
            {
                return HttpNotFound();
            }
            return View(blade);
        }

        // GET: Demo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Demo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BladeID,Name,PartNumber,Image,Price,Weight")] Blade blade)
        {
            if (ModelState.IsValid)
            {
                db.Blades.Add(blade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blade);
        }

        // GET: Demo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blade blade = db.Blades.Find(id);
            if (blade == null)
            {
                return HttpNotFound();
            }
            return View(blade);
        }

        // POST: Demo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BladeID,Name,PartNumber,Image,Price,Weight")] Blade blade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blade);
        }

        // GET: Demo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blade blade = db.Blades.Find(id);
            if (blade == null)
            {
                return HttpNotFound();
            }
            return View(blade);
        }

        // POST: Demo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Blade blade = db.Blades.Find(id);
            db.Blades.Remove(blade);
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
