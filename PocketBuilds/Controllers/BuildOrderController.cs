using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PocketBuilds.Models;
using PocketBuilds.Data_Access_Layer;

namespace PocketBuilds.Controllers
{
    public class BuildOrderController : Controller
    {
        private BuildOrderContext db = new BuildOrderContext();

        // GET: /BuildOrder/
        public ActionResult Index()
        {
            return View(db.BuildOrders.ToList());
        }

        // GET: /BuildOrder/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuildOrder buildorder = db.BuildOrders.Find(id);
            if (buildorder == null)
            {
                return HttpNotFound();
            }
            return View(buildorder);
        }

        // GET: /BuildOrder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /BuildOrder/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Title,Content")] BuildOrder buildorder)
        {
            if (ModelState.IsValid)
            {
                //buildorder.DateAdded = DateTime.Today;
                db.BuildOrders.Add(buildorder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(buildorder);
        }

        // GET: /BuildOrder/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuildOrder buildorder = db.BuildOrders.Find(id);
            if (buildorder == null)
            {
                return HttpNotFound();
            }
            return View(buildorder);
        }

        // POST: /BuildOrder/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Title,Content")] BuildOrder buildorder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(buildorder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(buildorder);
        }

        // GET: /BuildOrder/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BuildOrder buildorder = db.BuildOrders.Find(id);
            if (buildorder == null)
            {
                return HttpNotFound();
            }
            return View(buildorder);
        }

        // POST: /BuildOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BuildOrder buildorder = db.BuildOrders.Find(id);
            db.BuildOrders.Remove(buildorder);
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
