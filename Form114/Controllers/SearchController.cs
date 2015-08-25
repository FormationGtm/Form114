﻿using DataLayer.Models;
using Form114.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Form114.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View(new SearchViewModel());
        }

        public ActionResult Result(SearchViewModel svm)
        {
            var db = new Form114Entities();
            var liste = db.Produits;
            return View(liste.ToList());
        }
    }
}