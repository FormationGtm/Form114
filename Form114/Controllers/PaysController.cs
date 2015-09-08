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
    public class PaysController : Form114Controller
    {
        private Form114Entities db = new Form114Entities();

        // GET: Pays
        public ActionResult Index(string id)
        {
            var produits = db.Produits.Where(p => p.Villes.Pays.CodeIso3 == id).ToList();
            return View("../Search/Result", produits);
        }

        // GET: Pays/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pays pays = db.Pays.Find(id);
            if (pays == null)
            {
                return HttpNotFound();
            }
            return View(pays);
        }

        // GET: Pays/Create
        public ActionResult Create()
        {
            ViewBag.idRegion = new SelectList(db.Regions, "idRegion", "name");
            return View();
        }

        // POST: Pays/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodeIso3,Name,surfacearea,indepyear,population,lifeexpectancy,gnp,gnpold,localName,CodeIso2,idRegion,idgovform,idheadofstate")] Pays pays)
        {
            if (ModelState.IsValid)
            {
                db.Pays.Add(pays);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idRegion = new SelectList(db.Regions, "idRegion", "name", pays.idRegion);
            return View(pays);
        }

        // GET: Pays/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pays pays = db.Pays.Find(id);
            if (pays == null)
            {
                return HttpNotFound();
            }
            ViewBag.idRegion = new SelectList(db.Regions, "idRegion", "name", pays.idRegion);
            return View(pays);
        }

        // POST: Pays/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodeIso3,Name,surfacearea,indepyear,population,lifeexpectancy,gnp,gnpold,localName,CodeIso2,idRegion,idgovform,idheadofstate")] Pays pays)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pays).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idRegion = new SelectList(db.Regions, "idRegion", "name", pays.idRegion);
            return View(pays);
        }

        // GET: Pays/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pays pays = db.Pays.Find(id);
            if (pays == null)
            {
                return HttpNotFound();
            }
            return View(pays);
        }

        // POST: Pays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Pays pays = db.Pays.Find(id);
            db.Pays.Remove(pays);
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
