using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataLayer.Models;

namespace Form114.Controllers
{
    public class RegionsController : Form114Controller
    {
        private Form114Entities db = new Form114Entities();

        // GET: Regions
        public ActionResult Index(string id)
        {
            var numId = int.Parse(id);
            var produits = db.Produits.Where(p => p.Villes.Pays.Regions.idRegion == numId).ToList();
            return View("../Search/Result",produits);
        }

        // GET: Regions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regions regions = db.Regions.Find(id);
            if (regions == null)
            {
                return HttpNotFound();
            }
            return View(regions);
        }

        // GET: Regions/Create
        public ActionResult Create()
        {
            ViewBag.idContinent = new SelectList(db.Continents, "idContinent", "name");
            return View();
        }

        // POST: Regions/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idRegion,name,idContinent")] Regions regions)
        {
            if (ModelState.IsValid)
            {
                db.Regions.Add(regions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idContinent = new SelectList(db.Continents, "idContinent", "name", regions.idContinent);
            return View(regions);
        }

        // GET: Regions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regions regions = db.Regions.Find(id);
            if (regions == null)
            {
                return HttpNotFound();
            }
            ViewBag.idContinent = new SelectList(db.Continents, "idContinent", "name", regions.idContinent);
            return View(regions);
        }

        // POST: Regions/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idRegion,name,idContinent")] Regions regions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idContinent = new SelectList(db.Continents, "idContinent", "name", regions.idContinent);
            return View(regions);
        }

        // GET: Regions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regions regions = db.Regions.Find(id);
            if (regions == null)
            {
                return HttpNotFound();
            }
            return View(regions);
        }

        // POST: Regions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Regions regions = db.Regions.Find(id);
            db.Regions.Remove(regions);
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
