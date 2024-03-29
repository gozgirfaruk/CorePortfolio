﻿using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.EntityFramework;

namespace Portfolio.UI.Controllers
{
    public class FeatureController : Controller
    {
        FeatureMenager featureMenager = new FeatureMenager(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = featureMenager.GetById(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureMenager.TUpdate(feature);
            return RedirectToAction("Index","Default");
        }
    }
}
