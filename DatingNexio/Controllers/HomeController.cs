using DatingNexio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatingNexio.Controllers
{
    public class HomeController : Controller
    {
        private static Pair Pair = new Pair();

        public ActionResult Index()
        {
            Pair = new Pair();
            return RedirectToAction("WomanForm");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Portal randkowy, etap rekrutacji Nexio - Developer .NET";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult WomanForm()
        {
            ViewBag.Title = "Kobieta";
            return View("Person", new Person());
        }

        [HttpPost]
        public ActionResult WomanForm(Person woman) {
            ViewBag.Title = "Kobieta";
            if (ModelState.IsValid)
            {
                Pair.Woman = woman;
                return RedirectToAction("ManForm");
            }
            return View("Person", woman);
        }

        [HttpGet]
        public ActionResult ManForm()
        {
            ViewBag.Title = "Meżczyna";
            return View("Person", new Person());
        }

        [HttpPost]
        public ActionResult ManForm(Person man)
        {
            ViewBag.Title = "Meżczyna";
            if (ModelState.IsValid)
            {
                Pair = new Pair(man, Pair.Woman);
                return RedirectToAction("Summary");
            }
            return View("Person", man);
        }

        [HttpGet]
        public ActionResult Summary()
        {
            if (null == Pair.Woman || null == Pair.Man)
                return RedirectToAction("WomanForm");
            return View(Pair);
        }
    }
}