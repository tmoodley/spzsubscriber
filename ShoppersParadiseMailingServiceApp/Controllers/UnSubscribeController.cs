using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShoppersParadiseMailingServiceApp.Models;

namespace ShoppersParadiseMailingServiceApp.Controllers
{
    public class UnSubscribeController : Controller
    {
        private ShoppersParadiseMailingServiceAppEntities db = new ShoppersParadiseMailingServiceAppEntities();

        // GET: /UnSubscribe/
        public ActionResult Index()
        {
            return View(db.UnSubscribes.ToList());
        }

        // GET: /UnSubscribe/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnSubscribe unsubscribe = db.UnSubscribes.Find(id);
            if (unsubscribe == null)
            {
                return HttpNotFound();
            }
            return View(unsubscribe);
        }

        // GET: /UnSubscribe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /UnSubscribe/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="EmailID,Email")] UnSubscribe unsubscribe)
        {
            if (ModelState.IsValid)
            {
                db.UnSubscribes.Add(unsubscribe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(unsubscribe);
        }

        // GET: /UnSubscribe/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnSubscribe unsubscribe = db.UnSubscribes.Find(id);
            if (unsubscribe == null)
            {
                return HttpNotFound();
            }
            return View(unsubscribe);
        }

        // POST: /UnSubscribe/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="EmailID,Email")] UnSubscribe unsubscribe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unsubscribe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unsubscribe);
        }

        // GET: /UnSubscribe/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnSubscribe unsubscribe = db.UnSubscribes.Find(id);
            if (unsubscribe == null)
            {
                return HttpNotFound();
            }
            return View(unsubscribe);
        }

        // POST: /UnSubscribe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UnSubscribe unsubscribe = db.UnSubscribes.Find(id);
            db.UnSubscribes.Remove(unsubscribe);
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
