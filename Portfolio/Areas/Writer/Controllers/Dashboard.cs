﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.Entity.Concrete;
using Potfolio.DataAccess.Concrete;
using System.Xml.Linq;

namespace Portfolio.UI.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class Dashboard : Controller
    {
        private readonly UserManager<WriterUser> _userMenager;

        public Dashboard(UserManager<WriterUser> userMenager)
        {
            _userMenager = userMenager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userMenager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;

            string api = "1746bc23a2eb8dfe7917ee89fe097951";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=mersin&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.j = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            Context c = new Context();
            ViewBag.a = 0;
            ViewBag.b = c.Announcements.Count();
            ViewBag.e= 0;
            ViewBag.d=c.Skills.Count(); 
            return View();
        }
    }
}
