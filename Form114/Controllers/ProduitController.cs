﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Form114.Controllers
{
    public class ProduitController : Controller
    {
        private Form114Entities _db = new Form114Entities();
        // GET: Produit
        public ActionResult Index()
        {
            return View();
        }

        // GET: Produit
        /// <summary>
        /// Affiche les details d'un produit
        /// </summary>
        /// <param name="id">idProduit du produit à afficher</param>
        /// <returns>Vue partielle</returns>
        [ChildActionOnly]
        public PartialViewResult Miniature(int id)
        {
            var produit = _db.Produits.Find(id);
            return PartialView("_ProduitMini", produit);
        }
    }
}