using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hackaton.Models;

namespace Hackaton.Controllers
{
    public class FNOLDataController : Controller
    {
        private HackatonContext db = new HackatonContext();

        // GET: FNOLData
        public ActionResult Index()
        {
            return View(db.FNOLDatas.ToList());
        }

        // GET: FNOLData/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FNOLData fNOLData = db.FNOLDatas.Find(id);
            if (fNOLData == null)
            {
                return HttpNotFound();
            }
            return View(fNOLData);
        }

        // GET: FNOLData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FNOLData/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DeviceId,PolicyId,OracleId,TriggerDate,TriggerLevel,TriggerLeverDescription,TriggerType")] FNOLData fNOLData)
        {
            if (ModelState.IsValid)
            {
                db.FNOLDatas.Add(fNOLData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fNOLData);
        }

        // GET: FNOLData/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FNOLData fNOLData = db.FNOLDatas.Find(id);
            if (fNOLData == null)
            {
                return HttpNotFound();
            }
            return View(fNOLData);
        }

        // POST: FNOLData/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DeviceId,PolicyId,OracleId,TriggerDate,TriggerLevel,TriggerLeverDescription,TriggerType")] FNOLData fNOLData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fNOLData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fNOLData);
        }

        // GET: FNOLData/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FNOLData fNOLData = db.FNOLDatas.Find(id);
            if (fNOLData == null)
            {
                return HttpNotFound();
            }
            return View(fNOLData);
        }

        // POST: FNOLData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FNOLData fNOLData = db.FNOLDatas.Find(id);
            db.FNOLDatas.Remove(fNOLData);
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
