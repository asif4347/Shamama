using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebPhase2.Models;

namespace WebPhase2.Controllers
{
    public class HRsController : Controller
    {
        private DataBaseConnetion db = new DataBaseConnetion();

        // GET: HRs
        public ActionResult Index()
        {
            return View(db.hr.ToList());
        }

        // GET: HRs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HR hR = db.hr.Find(id);
            if (hR == null)
            {
                return HttpNotFound();
            }
            return View(hR);
        }

        // GET: HRs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HRs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,JobTitle,shortDes,Department,Position,RequiredSkills,ApplyTill,LongDes")] HR hR)
        {
            if (ModelState.IsValid)
            {
                db.hr.Add(hR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hR);
        }

        // GET: HRs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HR hR = db.hr.Find(id);
            if (hR == null)
            {
                return HttpNotFound();
            }
            return View(hR);
        }

        // POST: HRs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,JobTitle,shortDes,Department,Position,RequiredSkills,ApplyTill,LongDes")] HR hR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hR);
        }

        // GET: HRs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HR hR = db.hr.Find(id);
            if (hR == null)
            {
                return HttpNotFound();
            }
            return View(hR);
        }

        // POST: HRs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HR hR = db.hr.Find(id);
            db.hr.Remove(hR);
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
