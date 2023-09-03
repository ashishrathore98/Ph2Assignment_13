using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment13.Data;
using Assignment13.Models;

namespace Assignment13.Controllers
{
    public class CricketsController : Controller
    {
        private CricketDbContext db = new CricketDbContext();

        // GET: Crickets
        public ActionResult Index()
        {
            return View(db.Crickets.ToList());
        }

        // GET: Crickets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricket cricket = db.Crickets.Find(id);
            if (cricket == null)
            {
                return HttpNotFound();
            }
            return View(cricket);
        }

        // GET: Crickets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TeamId,TeamName,NoWc")] Cricket cricket)
        {
            if (ModelState.IsValid)
            {
                db.Crickets.Add(cricket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cricket);
        }

        // GET: Crickets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricket cricket = db.Crickets.Find(id);
            if (cricket == null)
            {
                return HttpNotFound();
            }
            return View(cricket);
        }

        // POST: Crickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TeamId,TeamName,NoWc")] Cricket cricket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cricket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cricket);
        }

        // GET: Crickets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricket cricket = db.Crickets.Find(id);
            if (cricket == null)
            {
                return HttpNotFound();
            }
            return View(cricket);
        }

        // POST: Crickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cricket cricket = db.Crickets.Find(id);
            db.Crickets.Remove(cricket);
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
